using System;
using System.Timers;

namespace ContactsAppUI
{
    public class Clock
    {
        private readonly Timer _timer = new Timer(10000);
        private DateTime _yesturday = DateTime.Today;

        public event EventHandler NewDay;

        public Clock()
        {
            _timer.Elapsed += Timer_Elapsed;
            _timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (_yesturday != DateTime.Today)
            {
                NewDay?.Invoke(this, EventArgs.Empty);
                _yesturday = DateTime.Today;
            }
        }
    }
}