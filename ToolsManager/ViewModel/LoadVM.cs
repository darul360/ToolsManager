using Model.Databases;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    public class LoadVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private DBAccess _dbAccess;
        private ObservableCollection<Tools> _toolsOB;
        public ObservableCollection<Tools> ToolsOB
        {
            get { return _toolsOB; }
            set
            {
                if (_toolsOB != value)
                {
                    _toolsOB = value;

                    if (this.PropertyChanged != null)
                    {
                        this.PropertyChanged(this, new PropertyChangedEventArgs("ToolsOB"));
                    }
                }
            }
        }
        public ICommand LoadButton { get; set; }
        public IList<Tools> SelectedTools { get; set; }


        public LoadVM()
        {
            _dbAccess = new DBAccess();
            ToolsOB = new ObservableCollection<Tools>();
            LoadButton = new RelayCommand(p => LoadRecords());
           // SelectedTools = RemoveRecord();
        }

        private void LoadRecords()
        {
            ToolsOB = _dbAccess.GetRecords();
        }
        private void RemoveRecord()
        {
            Debug.WriteLine(SelectedTools[0].ID);
        }

    }
}
