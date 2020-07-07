﻿using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace AppointmentCustomization
{
    /// <summary>   
    /// Represents custom data properties.   
    /// </summary> 
    public class Events : NotificationObject
    {
        private string eventName;
        private DateTime from;
        private DateTime to;
        private Brush background;
        private bool isAllDay;

        public string EventName
        {
            get { return eventName; }
            set
            {
                eventName = value;
                this.RaisePropertyChanged("EventName");
            }
        }

        public DateTime From
        {
            get { return from; }
            set
            {
                from = value;
                this.RaisePropertyChanged("From");
            }
        }

        public DateTime To
        {
            get { return to; }
            set
            {
                to = value;
                this.RaisePropertyChanged("To");
            }
        }

        public Brush Background
        {
            get { return background; }
            set
            {
                background = value;
                this.RaisePropertyChanged("Background");
            }
        }

        public bool IsAllDay
        {
            get { return isAllDay; }
            set
            {
                isAllDay = value;
                this.RaisePropertyChanged("IsAllDay");
            }
        }
    }
}
