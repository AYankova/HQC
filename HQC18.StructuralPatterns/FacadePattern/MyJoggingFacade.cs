namespace FacadePattern
{
    public class MyJoggingFacade
    {
        // These handles will be passed to this facade in a real application
        // also on actual device these controllers will be singletons too.
        private readonly GPSController gps = new GPSController();
        private readonly MobileDataController data = new MobileDataController();
        private readonly MusicController music = new MusicController();
        private readonly WiFiController wifi = new WiFiController();

        private SportsTrackerApp app = null;

        public void StartJogging()
        {
            // 1. Turn off the wifi
            this.wifi.IsSwitchedOn = false;

            // 2. Switch on the Mobile Data
            this.data.IsSwitchedOn = true;

            // 3. Turn on the GPS
            this.gps.IsSwitchedOn = true;

            // 4. Turn on the Music
            this.music.IsSwitchedOn = true;

            // 5. Start the Sports-Tracker
            this.app = new SportsTrackerApp();
            this.app.Start();
        }

        public void StopJogging()
        {
            // 0. Share Sports tracker stats on twitter and facebook
            this.app.Share();

            // 1. Stop the Sports Tracker
            this.app.Stop();

            // 2. Turn off the Music
            this.music.IsSwitchedOn = false;

            // 3. Turn off the GPS
            this.gps.IsSwitchedOn = false;

            // 4. Turn off the Mobile Data
            this.data.IsSwitchedOn = false;

            // 5. Turn on the wifi
            this.wifi.IsSwitchedOn = true;
        }
    }
}
