using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Product 
    {
        internal int id { get; set; }
        public double price { get; set; }
        public int stocknum { get; set; }
        public string name { get; set; }
        public int subcatid { get; set; }
        internal int sellerid;
       
        public Product(int id,double price,int stocknum,string name,int subcatid)
        {
            this.id = id;
            this.price = price;
            this.stocknum = stocknum;
            this.name = name;

            this.subcatid = subcatid;
            
            
           
        }
    }
}
