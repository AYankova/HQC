namespace FacadePattern
{
    using System;

    internal class MusicController
    {
       private bool isSwitchedOn = false;

        public bool IsSwitchedOn
        {
            get
            {
                return this.isSwitchedOn;
            }

            set
            {
                this.isSwitchedOn = value;
                this.DisplayStatus();
            }
        }

        private void DisplayStatus()
        {
            string status = (this.isSwitchedOn == true) ? "ON" : "OFF";
            Console.WriteLine("Music Switched {0}", status);
        }
    }
}
