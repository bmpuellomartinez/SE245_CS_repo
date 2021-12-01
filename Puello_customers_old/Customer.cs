using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puello_WindowsAssigment
{
    class Customer : PersonV2
    {
        private DateTime customersince;
        private double totalpurshes;
        private bool discountMenber;
        private int rewardsearned;

        public DateTime CustomerSince
        {
            get
            {
                return customersince;
            }
            set
            {
                //This will check for the rental date. It had to be only 14 day+.
                if (ValidationLibrary.IsAFutureDate(value))
                {
                    customersince = value;
                }
                else
                {
                    feedback += "ERROR: Enter a future day for membership.\n";
                }
            }

        }
        public double TotalPursh //New Variable Name
        {
            get
            {
                return totalpurshes;
            }
            set
            {
                if (ValidationLibrary.IsMinimunAmount(value, 1))
                {
                    totalpurshes = value;
                }
                else
                {
                    feedback += "Enter the amount of you Purchased\n";
                }
            }
                
            
        }

        public bool Discount
        {
            get
            {
                return discountMenber;
            }
            set
            {
                discountMenber = value;
            }

        }
        public int Rewards
        {
            get
            {
                return rewardsearned;
            }
            set
            {
                if(ValidationLibrary.IsMinimunAmount(value,0))
                rewardsearned = value;
            }
               
        }
        public Customer() : base()
        {
            customersince = DateTime.Now.AddDays(1);
            totalpurshes = 0.0;
            discountMenber = false;
            rewardsearned = 0;


        }

    }
}
