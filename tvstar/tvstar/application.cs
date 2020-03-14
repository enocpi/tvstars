using System;
using System.Collections.Generic;
using System.Text;

namespace tvstar
{
    class application
    { protected string firstname;
        protected string lastname;
        protected int DOB;
        protected string address;
        protected string city;
        protected string state;
        protected int zipcode;
        protected int phoneNumber;
        protected string email;
        protected bool appsubmit;
        protected bool appApproved;

        public virtual void submit() 
        {
            if (appsubmit == true)
            {
                Console.WriteLine("application has been submitted");
            }


 }

        public virtual void accept()
        {
            if (appsubmit == true)
            {
                Console.WriteLine("Congrats you have been accepted");
            }
           
        }




    }

}

