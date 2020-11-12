using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Databases
{
    public class DBAccess
    {
        private ToolsEntities _toolsContext;
        public ToolsEntities ToolsEntites { get => _toolsContext; }
        public DBAccess()
        {
            _toolsContext = new ToolsEntities();
        }

        public void AddToDb(Tools _tools)
        {
            int _lastIndex = _toolsContext.Tools.OrderByDescending(p => p.ID).First().ID;
            _tools.ID = _lastIndex;
            _toolsContext.Tools.Add(_tools);
            _toolsContext.SaveChanges();
        }

        public void RemoveFromDb(Tools _tools)
        {
            _toolsContext.Tools.Remove(_tools);
            _toolsContext.SaveChanges();
        }
 
        public ObservableCollection<Tools> GetRecords()
        {
            return new ObservableCollection<Tools>(_toolsContext.Tools.AsEnumerable<Tools>());
        }
    }
}