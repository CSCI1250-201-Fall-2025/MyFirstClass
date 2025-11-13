using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstClass
{
    internal class Car
    {
        public string brand;
        public string name;
        public bool on;

        public static int carCounter = 0;

        public static int speed;


        public string PrintSymbol()
        {
            if(brand == "Chevy")
            {
                return "THE CHEVY SYMBOL!";
            }
            else if(brand == "Nissan")
            {
                return "THE NISSAN LOGO!";
            }
            else 
            {
                return "THE SYMBOL HAS NOT BEEN REGISTERED!";
            }
        }


        public void PushButtonIgnition()
        {
            if (on)
            {
                on = false;
            }
            else
            {
                on = true;
            }

            carCounter++;
        }

        public void Acclerate()
        {
            while(true)
            {
                speed++;
            }
        }


    }
}
