using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21454249_HW04.Models
{
    public class PlanB : Booking
    {
        private string mFarlong;

        public PlanB()
        {
        }
        public PlanB(string _name, string _surname, string _location, string _time, int _date, string _farlong) :
       base(_name, _surname, _location, _time,_date)
        {
        }
        public override string getConfirmation()
        {

            return base.Name + "Your booking has been made!";
        }
        public override string getDetails()
        {
            return "The details for your appointment are as follows" + "Name:" + base.Name + " " + base.Surname + "At " + base.Location + " At " + base.Time +  " for a pregrancy of " + Farlong + " weeks.";
        }
        public string Farlong
        {
            get { return mFarlong; }
            set { mFarlong = value; }
        }

    }
}
