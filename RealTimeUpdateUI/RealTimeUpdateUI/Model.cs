using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Timers;

namespace RealTimeUpdateUI
{
    public class Model : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public int Content { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
        private static Timer aTimer;
        public Model()
        {
            Content = 0;
            Second = 0;
            Minute = 0;
            Hour = 0;
            setTimer();
        }

        public void setTimer()
        {
            aTimer = new Timer(1);
            aTimer.Elapsed += ATimer_Elapsed;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private void ATimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Content ++;
            Second = Second + Content / 100;
            Minute = Minute + Second / 60;
            Hour = Hour + Hour / 60;
            if (Content == 100) Content = 0;
            if (Second == 60) Second = 0;
            if (Minute == 60) Minute = 0;
            if (Hour == 24) Hour = 0;
            OnPropertyChanged("Content");
            OnPropertyChanged("Second");
            OnPropertyChanged("Minute");
            OnPropertyChanged("Hour");
        }
    }
}
