using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{

    public interface IGradeTracker : IEnumerable{

        void AddGrade(float grade);
        GradeStatistics ComputeStatistics();
        void WriteGrade(TextWriter textWriter); 
        string Name { get; set; }
        event NameChangedDelegate NameChanged;
        void DoSomething();
    }



    public abstract class GradeTracker : IGradeTracker
    {
        public abstract void AddGrade(float grade);
        public abstract GradeStatistics ComputeStatistics();
        public abstract void WriteGrade(TextWriter textWriter);
        public abstract IEnumerator GetEnumerator();

        public abstract void DoSomething();
       

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {


                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Hata alla f;r du kan inte skriva");
                }
                if (_name != value)
                {
                    var oldValue = _name;
                    _name = value;
                    if (NameChanged != null)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.OldValue = oldValue;
                        args.NewValue = value;
                        NameChanged(this, args);
                    }
                }
            }
        }
        public event NameChangedDelegate NameChanged;
        private string _name;
    }
}
