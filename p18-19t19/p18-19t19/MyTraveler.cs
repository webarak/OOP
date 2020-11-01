using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p18_19t19
{
    class MyTraveler
    {
        private MyPassport passPassanger;
        private bool didPayed;

        public MyTraveler()
        {
            this.passPassanger = new MyPassport();
            this.didPayed = false;
        }

        public MyTraveler(MyPassport Pass, bool isPayed)
        {
            this.passPassanger = Pass;
            this.didPayed = isPayed;
        }

        public MyTraveler(MyTraveler t)
        {
            this.passPassanger = t.getpass();
            this.didPayed = t.getIsPayed();
        }

        public MyPassport getpass()
        {
            return this.passPassanger;
        }

        public bool getIsPayed()
        {
            return this.didPayed;
        }

        public void setispayed()
        {
            this.didPayed = true;
        }

        public override string ToString()
        {
            return this.passPassanger.ToString() + "\nIs payed?" + this.didPayed;
        }

        public bool CheckTravel(MyDate TravelDate)
        {
            if (getIsPayed() == true && this.passPassanger.isValid(TravelDate) == false)
                return true;
            else
                return false;
        }

    }
}
