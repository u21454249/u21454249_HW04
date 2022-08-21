using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21454249_HW04.Models
{
    public class Maternal : Booking
    {
        private string mCondition;
        
        public Maternal()
        {
        }
        public Maternal(string _name, string _surname, string _location, string _time, int _date, string _condition) :
       base(_name, _surname, _location, _time, _date)
        {
        }
        public override string getConfirmation()
        {
            return  "Your booking has been made!";
        }
        public override string getDetails()
        {
            return base.Name + " " + base.Surname +  " your appointment is at " +base.Location + " at  " + base.Time+ "  For " +Condition;
        }
        public string Condition
        {
            get { return mCondition; }
            set { mCondition = value; }
        }
       
    }
}