using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class BuyerBO
    {
        static List<Buyer> blist = new List<Buyer>();
        ProductBO pbo = new ProductBO();
        public void Singup(int id, string bname, string bpassword, string bemail, int bphnum, int createddatetime)
        {
            blist.Add(new Buyer(id, bname, bpassword, bemail,bphnum, createddatetime));
            Console.WriteLine("Sing in successfully");
        }
        public bool Login(string username, string password)
        {
            Buyer bobj = blist.Find(e => e.bname == username && e.bpassword == password);
            if (bobj != null)
                return true;
            else
                return false;


        }
        public void search()
        {
            pbo.search();
        }
        public void dispaly()
        {
            pbo.display();
        }
        public void displaydetails()
        {
            foreach (Buyer b in blist)
            {
                Console.WriteLine("Buyer id:" + b.id);
                Console.WriteLine("Buyer Name:" + b.bname);
                Console.WriteLine("Buyer Email id:" + b.bemail);
                Console.WriteLine("Buyer phnum:" + b.bphnum);
            }
        }
    }
}
