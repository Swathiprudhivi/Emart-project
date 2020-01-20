using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
   abstract class Category
    {
        public int cid { get; set; }
        public string cname { get; set; }
        List<Category> ic = new List<Category>();
       
        public Category(int cid,string cname)
        {
            this.cid = cid;
            this.cname = cname;
          

        }
    }
}
