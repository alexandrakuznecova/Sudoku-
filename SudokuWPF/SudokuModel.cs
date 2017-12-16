using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SudokuRep;

namespace SudokuWPF
{
    public class SudokuModel
    {
        public SudokuModel()
        {
            Users=new ObservableCollection<User>();
        } 
        public ObservableCollection<User> Users { get; set; }
    }
}
