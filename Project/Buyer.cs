using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Buyer
    {
        public int id { get; set; }
        public string bname { get; set; }
        public string bpassword { get; set; }
        public string bemail { get; set; }
        public int bphnum { get; set; }
        public  int createddatetime { get; set; }
        public Buyer(int id, string bname,string bpassword,string bemail,int bphnum,int createddatetime)
        {
            this.id = id;
            this.bname = bname;
            this.bpassword = bpassword;
            this.bemail = bemail;
            this.bphnum = bphnum;
            this.createddatetime = createddatetime;
        }
      
    }
}
