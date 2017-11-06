using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class Metronome
    {
        public delegate void TickHandler(Metronome m, EventArgs e);
        public event TickHandler Tick;
        public EventArgs e = null;
        public void Start()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(3000);
                if (Tick != null)
                {
                    Tick(this, e);
                }
            }
        }
    }
}
