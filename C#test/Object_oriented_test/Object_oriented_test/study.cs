using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_test
{
    class study
    {
        public string _subject;
        private int _marks;
        public string _masterTeacher;

        public int marks
        {
            set 
            {
                if (value > 100 || value < 0)
                {
                    value = 60;
                }
                _marks=value;
            }
            get 
            {
                return _marks;
            }
        }

        public void lesson()
        {
            Console.WriteLine("{0}的任课老师是{1}，我得到的分数是{2}",this._subject,this._masterTeacher,this._marks);
        }
    }
}
