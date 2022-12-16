using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppUrupaBohdan
{
    public class TeacherList
    {
        private List<Teacher> _tList;
        public TeacherList()
        {
            _tList = new List<Teacher>();
        }

        public void add(Teacher t)
        {
            _tList.Add(t);
        }
        public void RemoveTeacher(Teacher t)
        {
            if (_tList.Contains(t))
            {
                _tList.Remove(t);
            }
        }
        public void show()
        {
            int i = 0;
            for (i = 0; i < _tList.Count(); i++)
            { _tList[i].printInfo(); }
        }
        public List<Teacher> TList
        {
            get { return _tList; }
            set { this._tList = value; }
        }
    }
}
