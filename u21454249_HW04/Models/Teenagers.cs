using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21454249_HW04.Models
{
    public class Teenagers : Booking
    {
        
            private int mAge;
            private int mGrade;
            public Teenagers()
            {
            }
            public Teenagers(string _name, string _surname, string _location,string _time, int _date,int _Age, int _Grade) :base(_name, _surname, _location, _time, _date)
            {
            }
            public override string getConfirmation()
            {
               
                return  base.Name+ "Your booking has been made!" ;
            }
            public override string getDetails()
            {
                return "The details for your appointment for "+ base.Name + " "+ base.Surname + " Age and grade: " + Age + "  " + Grade + "At " + base.Location+ " At "+ base.Time ;
            }
            public int Age
            {
                get { return mAge; }
                set { mAge = value; }
            }
            public int Grade
            {
                get { return mGrade; }
                set { mGrade = value; }
            }
        }
}