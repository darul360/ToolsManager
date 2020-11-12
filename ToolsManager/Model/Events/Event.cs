using Model.Databases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Event
    {
        private Tools _toolInstance;
        private DateTime _date;
        private String _description;
        public abstract void printEvent();
        public abstract Tools ToolInstance { get; set; }
        public abstract DateTime Date { get; set; }
        public abstract String Description { get; set; }
    }
}
