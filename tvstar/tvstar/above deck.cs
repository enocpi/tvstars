using System;
using System.Collections.Generic;
using System.Text;

namespace tvstar
{
    class above_deck: application
    {
        public int xp;
        public string nationality;

        public above_deck (string firstname, string lastname, int DOB, string address, string city, string state, int zipcode, int phoneNumber, string email,
            int xp, string nationality)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.DOB = DOB;
            this.address = address;
            this.city = city;
            this.zipcode = zipcode;
            this.phoneNumber = phoneNumber;
            this.email = email;

            this.xp = xp;
            this.nationality = nationality;

        }

        public override void submit()
        {
            base.submit();
            Console.WriteLine("app submit");
        }

        public override void accept()
        {
            base.accept();
            Console.WriteLine("you have been accepted to above deck");
        }



    }
}
