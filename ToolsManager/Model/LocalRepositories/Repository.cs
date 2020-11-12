using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.LocalRepositories
{
    public interface Repository <T>
    {
        public void AddObject(T instance);
        public void RemoveObject(T instance);
        public List<T> GetRepo();
        public void PrintRepo();
    }
}
