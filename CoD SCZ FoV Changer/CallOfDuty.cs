namespace CoD_SCZ_FoV_Changer
{
    public class CallOfDuty
    {
        public CallOfDuty(string name, string processName, int steamAppId)
        {
            Name = name;
            ProcessName = processName;
            SteamAppId = steamAppId;
        }

        public string Name { get; }
        public string ProcessName { get; set; }
        public int SteamAppId { get; set; }
        public Memory.Pointer FovPointer { get; set; }
        public Memory.Pointer FovScalePointer { get; set; }

        public override string ToString()
        {
            return $"{Name} ({ProcessName}.exe)";
        }
    }
}