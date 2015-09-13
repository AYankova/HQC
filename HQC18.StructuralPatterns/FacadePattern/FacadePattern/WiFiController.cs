namespace FacadePattern
{
    using System;

    internal class WiFiController
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
            Console.WriteLine("WiFi Switched {0}", status);
        }
    }
}
