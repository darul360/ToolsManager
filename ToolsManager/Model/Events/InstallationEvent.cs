using Model.Databases;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class InstallationEvent : Event
    {
        private Tools _tool;
        private DateTime _date;
        private String _description;
        public override Tools ToolInstance { get => _tool; set => _tool = value; }
        public override DateTime Date { get => _date; set => _date = value; }
        public override string Description { get => _description; set => _description = value; }

        public InstallationEvent(Tools _tool, DateTime _date, String _description)
        {
            this.ToolInstance = _tool;
            this.Date = _date;
            this.Description = _description;
        }

        public override void printEvent()
        {
            Debug.WriteLine(ToolInstance.ID + "\n" + ToolInstance.Manufacturer + "\n" + ToolInstance.Model
                + "\n" + Date + "\n" + Description);
        }
    }
}
