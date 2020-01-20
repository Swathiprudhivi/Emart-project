using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class SallerBO
    {
        static List<Seller> slist = new List<Seller>();
        public void Singup(int sellerid, string sname, string spassword, string companyname, int gstin, int phnum, string email, string postal_address)
        {
            slist.Add(new Seller(sellerid,sname, spassword, companyname, gstin, phnum, email, postal_address));
            Console.WriteLine("Sing in successfully");
        }
        public bool Login(string username,string password)
        {
            Seller sobj = slist.Find(e => e.sname == username && e.spassword == password);
            if (sobj != null)
                return true;
            else
                return false;


        }
        public void display()
        {
            foreach(Seller s in slist)
            {
                Console.WriteLine("Seller id:" + s.sellerid);
                Console.WriteLine("Seller Name:" + s.sname);
                Console.WriteLine("Seller Email id:" + s.email);
                Console.WriteLine("Seller Address:" + s.postal_address);
                Console.WriteLine("GstIN:" + s.gstin);
            }
        }
        public void Displayseleritem()
        {
            ProductBO ibo = new ProductBO();
            Console.WriteLine("Enter seller id");
            int ch = int.Parse(Console.ReadLine());
            List<Product> lp = ibo.display(ch);
            foreach(Product p in lp)
            {
                Console.WriteLine("Item id \t Item name \t price");
                Console.WriteLine(p.id + " " + p.name + " " + p.price);
            }
        }
    }
}
