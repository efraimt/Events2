using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events2
{
    public delegate void LongNameDelegate(string name);
    public delegate void LongNameDelegate2(Person client);

    public class Person
    {
        public int Age { get; set; } = 29;

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                //if(value.Length>10)
                //    throw new ArgumentException("Name longer than 10 could not be accepted!");

                //name = value.Length <= 10 ? value : value.Substring(0, 10);
                name = value;
                OnLongNameEntered();
            }
        }

        protected virtual void OnLongNameEntered()
        {
            if (name.Length > 10)
                if (LongNameEntered != null)
                {
                    LongNameEntered(name);
                    LongNameEntered2(this);
                    LongNameEntered3(this,EventArgs.Empty);
                }
        }

        public event LongNameDelegate LongNameEntered;
        public event LongNameDelegate2 LongNameEntered2;

        public event EventHandler LongNameEntered3;
        //public event LongNameDelegate LongNameEntered
        //{
        //    add { LongNameEntered += value; }
        //    remove { LongNameEntered -= value; }
        //}

        public override string ToString()
        {
            return string.Format(Name);
        }
    }


    public class Client : Person
    {

    }
}
