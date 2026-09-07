using System;
using System.Diagnostics;
using System.Linq;

namespace CoD_SCZ_FoV_Changer
{
    public class Memory
    {
        private readonly string _processName;

        private Process _targetProcess;

        public Memory(string processName)
        {
            _processName = processName;
        }

        public Process TargetProcess
        {
            get
            {
                if (_targetProcess != null) return _targetProcess;
                var processes = Process.GetProcessesByName(_processName);
                _targetProcess = processes.Length == 0 ? null : processes[0];
                return _targetProcess;
            }
            set { _targetProcess = value; }
        }

        public bool IsRunning()
        {
            return Process.GetProcessesByName(_processName).Length >= 1;
        }


        public bool Write(IntPtr lpBaseAddress, byte[] lpBuffer)
        {
            var processHandle = NativeMethods.OpenProcess(NativeMethods.ProcessAccessFlags.VirtualMemoryWrite | NativeMethods.ProcessAccessFlags.VirtualMemoryOperation, false, TargetProcess.Id);
            if (processHandle != IntPtr.Zero)
            {
                UIntPtr bytesRead;
                var result = NativeMethods.WriteProcessMemory(processHandle, lpBaseAddress, lpBuffer, (UIntPtr)lpBuffer.Length, out bytesRead);
                NativeMethods.CloseHandle(processHandle);
                return result;
            }
            return false;
        }

        public bool WriteInt(IntPtr address, int value)
        {
            return Write(address, BitConverter.GetBytes(value));
        }

        public bool WriteFloat(IntPtr address, float value)
        {
            return Write(address, BitConverter.GetBytes(value));
        }


        public byte[] Read(IntPtr lpBaseAddress, int length)
        {
            var processHandle = NativeMethods.OpenProcess(NativeMethods.ProcessAccessFlags.VirtualMemoryRead, false, TargetProcess.Id);
            if (processHandle != IntPtr.Zero)
            {
                var buffer = new byte[length];
                UIntPtr bytesRead;
                var result = NativeMethods.ReadProcessMemory(processHandle, lpBaseAddress, buffer, (UIntPtr)buffer.Length, out bytesRead);
                NativeMethods.CloseHandle(processHandle);
                if (result) return buffer;
            }
            return null;
        }

        public int ReadInt(IntPtr address)
        {
            return BitConverter.ToInt32(Read(address, sizeof(int)), 0);
        }

        public long ReadLong(IntPtr address)
        {
            return BitConverter.ToInt64(Read(address, sizeof(long)), 0);
        }

        public float ReadFloat(IntPtr address)
        {
            return BitConverter.ToSingle(Read(address, sizeof(float)), 0);
        }

        public IntPtr ReadAddress(IntPtr address)
        {
            return (IntPtr)ReadLong(address);
        }


        public IntPtr ReadPointerAddress(MultiLevelPointer pointer, bool addBaseAddress)
        {
            var address = pointer.Address;
            var baseAddress = GetBaseAddress();

            if (addBaseAddress)
                address = new IntPtr(baseAddress.ToInt64() + address.ToInt64());

            foreach (var offset in pointer.Offsets)
                address = IntPtr.Add(ReadAddress(address), offset);
            return address;
        }

        public IntPtr GetBaseAddress()
        {
            return TargetProcess?.MainModule.BaseAddress ?? IntPtr.Zero;
        }

        public class MultiLevelPointer
        {
            public MultiLevelPointer(IntPtr address, short[] offsets)
            {
                Address = address;
                Offsets = offsets;
            }

            public IntPtr Address { get; set; }
            public short[] Offsets { get; set; }

            public bool IsPointingCorrectly(IntPtr address)
            {
                return address != IntPtr.Zero && address != (IntPtr)Offsets.Last();
            }
        }
    }
}