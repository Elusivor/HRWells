using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc.Html;

namespace HRWells.ViewModels
{
    public class CalanderInput
    {
        public CalanderInput()
        {
            Overlay = new Dictionary<DateTime, string>();
        }

        public DateTime Date { get; set; }
        public Dictionary<DateTime, string> Overlay { get; set; }
        private int back;
        private int forward;
        public int Back
        {
            get
            {
                return back;
            }
        }
        public int Forward
        {
            get
            {
                return forward;
            }
            set
            {
                if (Overlay.Count() >= value)
                {
                    forward = value;
                }
                else
                {
                    forward = -1;
                }
            }
        }

        public int Current
        {
            get
            {
                return (back + 1);
            }
            set
            {
                back = (value - 1);
                Forward = (value + 1);
            }
        }
    }
}