using System.Media;
using CoD_SCZ_FoV_Changer.Properties;

namespace CoD_SCZ_FoV_Changer
{
    internal class Beeper
    {
        // Credits to AgentRev ( https://github.com/AgentRev ) for the beep sounds!
        private static readonly SoundPlayer SndActivated = new SoundPlayer(Resources.activated);
        private static readonly SoundPlayer SndDectivated = new SoundPlayer(Resources.deactivated);
        private static bool _sndPlayedActivated;
        private static bool _sndPlayedDectivated = true;

        public static bool Enabled { get; set; }


        public static void BeepActivated()
        {
            if (!_sndPlayedActivated && Enabled)
            {
                SndActivated.PlaySync();
                _sndPlayedActivated = true;
            }
            _sndPlayedDectivated = false;
        }

        public static void BeepDeactivated()
        {
            if (!_sndPlayedDectivated && Enabled)
            {
                SndDectivated.PlaySync();
                _sndPlayedDectivated = true;
            }
            _sndPlayedActivated = false;
        }
    }
}