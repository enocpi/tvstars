using System;
using System.Collections.Generic;
using System.Text;

namespace tvstar
{
    class paradise_island : application
    {
        public string gender;
        public string soname;
        public int yearsDating;


        public paradise_island(string firstname, string lastname, int DOB, string address, string city, string state, int zipcode, int phoneNumber, string email,
            string gender, string soname, int yearsDating
            )
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.DOB = DOB;
            this.address = address;
            this.city = city;
            this.zipcode = zipcode;
            this.phoneNumber = phoneNumber;
            this.email = email;

            this.gender = gender;
            this.soname = soname;
            this.yearsDating = yearsDating;
        }


        public override void submit()
        {
            base.submit();
            Console.WriteLine("app sumbit");
        }


        public override void accept()
        {
            base.accept();
            Console.WriteLine("You have been accepted to paradise island");
        }




    }
}
