using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Seller
    {
       public int sellerid { get; set; }
       public  string sname { get; set; }
       public  string spassword { get; set; }
       public  string companyname { get; set; }
       public int gstin { get; set; }
       public  int phnum { get; set; }
        public string email { get; set; }
       public string postal_address { get; set; }
        public Seller(int sellerid, string sname, string spassword, string companyname, int gstin, int phnum, string email, string postal_address)
        {
            this.sellerid = sellerid;
            this.sname = sname;
            this.spassword = spassword;
            this.companyname = companyname;
            this.gstin = gstin;
            this.phnum = phnum;
            this.email = email;
            this.postal_address = postal_address;
        }

    }
}
