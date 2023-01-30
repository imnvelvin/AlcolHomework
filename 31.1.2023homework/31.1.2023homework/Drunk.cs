using System;
using System.Collections.Generic;
using System.Text;

namespace _31._1._2023homework
{
    internal class Drink:Product
    {
        private double _alcoholpercent;
        public  double Alcoholpercent
        {
            set
            {
                if (value >= 0 && value<= 100)
                {
                    _alcoholpercent= value;


                }




            }






            get
            {
                return _alcoholpercent;



            }







        }











    }
       
    









    
}
