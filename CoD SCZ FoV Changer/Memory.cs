using System;
using System.Diagnostics;
using System.Linq;

namespace CoD_SCZ_FoV_Changer
{
    public class Memory
    {
        private readonly string _processName;

        public Memory(string processName)
        {
            _processName = processName;
        }

        public int ProcessId { get; set; }

        private int GetProcessId()
        {
            if (ProcessId == 0)
            {
                var window = Process.GetProcessesByName(_processName);
                ProcessId = window.Length == 0 ? 0 : window[0].Id;
            }
            return ProcessId;
        }

        public bool IsRunning()
        {
            return Process.GetProcessesByName(_processName).Length >= 1;
        }


        public bool Write(IntPtr lpBaseAddress, byte[] lpBuffer)
        {
            var processHandle = NativeMethods.OpenProcess(NativeMethods.ProcessAccessFlags.VirtualMemoryWrite | NativeMethods.ProcessAccessFlags.VirtualMemoryOperation, false, GetProcessId());
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
            var processHandle = NativeMethods.OpenProcess(NativeMethods.ProcessAccessFlags.VirtualMemoryRead, false, GetProcessId());
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
            return BitConverter.ToInt32(Read(address, 4), 0);
        }

        public float ReadFloat(IntPtr address)
        {
            return BitConverter.ToSingle(Read(address, 4), 0);
        }


        public IntPtr ReadPointerAddress(Pointer pointer, int baseAddress = 0x400000)
        {
            var address = IntPtr.Add(pointer.Address, baseAddress);
            foreach (var offset in pointer.Offsets)
            {
                address = IntPtr.Add((IntPtr)ReadInt(address), offset);
            }
            return address;
        }

        public IntPtr GetMainModuleBaseAddress(string prog)
        {
            var p = Process.GetProcessesByName(prog);
            var baseAddress = p[0].MainModule.BaseAddress;
            return baseAddress;
        }

        public class Pointer
        {
            public Pointer(IntPtr address, short[] offsets)
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