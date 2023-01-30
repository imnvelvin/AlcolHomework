using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _31._1._2023homework
{
    internal class Product
    {
        
        string _name;


          double _price;
        public double Price
        {

            set
            {

                if (value >= 0)
                {
                    _price = value;
                }



            }
            get
            {
                return _price;
            } 
            

          

        }

        public string Name
        {
            set
            {
                if(value.Length>1 && value.Length < 21)
                {
                    _name= value;   
                }
            }


            get
            {
                return _name;
            }
        }










     
        

        
            
        
           






    }
}
