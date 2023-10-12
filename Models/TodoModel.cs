using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Models
{
    internal class TodoModel
    {

        //это пример использования полных свойств
        //набираем propfull и выпадающем списке дважды Tab
        private bool _isDone;
        
        private string _text;

        //присваиваем текущую дату, тип данных DateTime
        //это пример использования автосвойств
        public DateTime CreationDate { get; set; } = DateTime.Now;

        public bool IsDone
        {
            get { return _isDone; }
            set { _isDone = value; }
        }


        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }


    }
}
