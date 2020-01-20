using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Subcategory:Category
    {
        public int subcatid { get; set; }
        public string subcatname { get; set; }
        public int gst { get; set; }
        public Subcategory(int cid,string cname,int subcatid,string subcatname,int gst):base(cid,cname)
        {
            this.subcatid = subcatid;
            this.subcatname = subcatname;
            this.gst = gst;
            this.cid = cid;
            this.cname = cname;
        }
    }
}
