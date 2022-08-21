using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21454249_HW04.Models
{
    public abstract class  Booking
    {
            private string mName;
            private string mSurname;
            private string mLocation;
            private string mTime;
        private int mDate;

        public Booking()
            {
            }
            public Booking(string _name, string _surname, string _location, string _time,int _date)
            {
                mName = _name;
                mSurname = _surname;
                mLocation = _location;
                mTime = _time;
                ////mDate = _date;
            }
            public virtual string getConfirmation()
        {
            return  "Your booking has been made!";
        }
            public abstract string getDetails();
            public string Name
            {
                get { return mName; }
                set { mName = value; }
            }
            public string Surname
            {
                get { return mSurname; }
                set { mSurname = value; }
            }
            public string Location
            {
                get { return mLocation; }
                set { mLocation = value; }
            }
            public string Time
            {
                get { return mTime; }
                set { mTime = value; }
            }
        public int Date
        {
            get { return mDate; }
            set { mDate = value; }
    }


}
}