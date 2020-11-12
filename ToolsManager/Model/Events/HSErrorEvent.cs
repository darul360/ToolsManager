using Model.Databases;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class HSErrorEvent : Event
    {
        private Tools _tool;
        private DateTime _date;
        private String _description;
        private Boolean _hardwareError;
        private Boolean _softwareError;
        public override Tools ToolInstance { get => _tool; set => _tool = value; }
        public override DateTime Date { get => _date; set => _date = value; }
        public override string Description { get => _description; set => _description = value; }
        public Boolean HardwareError { get => _hardwareError; set => _hardwareError = value; }
        public Boolean SoftwareError { get => _softwareError; set => _softwareError = value; }

        public HSErrorEvent(Tools _tool, DateTime _date, String _description, Boolean _hardwareError, Boolean _softwareError)
        {
            this.ToolInstance = _tool;
            this.Date = _date;
            this.Description = _description;
            this.HardwareError = _hardwareError;
            this.SoftwareError = _softwareError; 
        }

        public override void printEvent()
        {
            if(HardwareError)
                Debug.WriteLine(ToolInstance.ID + "\n" + ToolInstance.Manufacturer + "\n" + ToolInstance.Model
                    + "\n" + Date + "\n" + Description + "\n" + "HARDWARE_ERROR");
            if (SoftwareError)
                Debug.WriteLine(ToolInstance.ID + "\n" + ToolInstance.Manufacturer + "\n" + ToolInstance.Model
                    + "\n" + Date + "\n" + Description + "\n" + "SOFTWARE_ERROR");
        }
    }
}
