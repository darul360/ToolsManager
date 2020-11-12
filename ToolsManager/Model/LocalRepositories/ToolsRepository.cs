using Model.Databases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Model.LocalRepositories
{
    public class ToolsRepository : Repository<Tools>
    {
        private List<Tools> _toolsList = new List<Tools>();
        public List<Tools> ToolsList => _toolsList;
        public void AddObject(Tools instance)
        {
            ToolsList.Add(instance);
        }

        public List<Tools> GetRepo()
        {
            return ToolsList;
        }

        public void PrintRepo()
        {
            foreach(Tools instance in ToolsList)
            {
                Debug.WriteLine(instance.ID + "\n" + instance.IpAdress + "\n" + instance.Mac
                    + "\n" + instance.Manufacturer + "\n" + instance.Model + "\n" + instance.SerialNumber);
            }
        }

        public void RemoveObject(Tools instance)
        {
            ToolsList.Remove(instance);
        }
    }
}
