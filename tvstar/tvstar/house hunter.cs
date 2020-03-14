using System;
using System.Collections.Generic;
using System.Text;

namespace tvstar
{
    class house_hunter : application

    {
        public string jobtitle;
        public int annualIncome;
        public string location;
        public int bedrooms;
        public int bathrooms;
        
        public house_hunter
            (string firstname, string lastname, int DOB, string address, string city, string state, int zipcode, int phoneNumber, string email,
            string jobtitle, int annualIncome, string location, int bedrooms, int bathrooms) 
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.DOB = DOB;
            this.address = address;
            this.city = city;
            this.zipcode = zipcode;
            this.phoneNumber = phoneNumber;
            this.email = email;

             
            this.jobtitle = jobtitle;
            this.annualIncome = annualIncome;
            this.location = location;
            this.bedrooms = bedrooms;
            this.bathrooms = bathrooms;
           


            

            
        }


        public override void submit()
        {
            base.submit();
            Console.WriteLine("app submit complete");   
        }


        public override void accept()
        {
            base.accept();
            Console.WriteLine("You have been accepted to dream house hunters");
        }



    }
}
