using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class ProductBO
    {
        static List<Product> plist = new List<Product>();
        static List<Subcategory> slist = new List<Subcategory>();
        public void Additems(int id, double price, int stocknum, string name, int subcatid, string subcatname, int gst, int cid, string cname,int sellerid)
        {
            Subcategory sobj = new Subcategory(cid, cname, subcatid, subcatname, gst);
            Product pobj = new Product(id, price,stocknum, name,subcatid);
            plist.Add(pobj);
            slist.Add(sobj);
            Console.WriteLine("items added successfully");
        }
        public List<Product>display(int sellerid)
        {
            List<Product> iplist = plist.FindAll(e => e.sellerid == sellerid);
            return iplist;
        }
        public void display()
        {
            foreach(Category c in slist)
            {
                Console.WriteLine(" Category id \n Category name");
                Console.WriteLine(+c.cid + "\t" + c.cname);

            }
            Console.WriteLine("Enter category id  for visit subcategories");
            int ch = int.Parse(Console.ReadLine());
            foreach(Subcategory s in slist)
            {
                if(s.cid==ch)
                {
                    Console.WriteLine(" SubCategory id \n SubCategory name \n gst");
                    Console.WriteLine(+s.subcatid + "\t" + s.subcatname+"\t"+s.gst);
                }
            }
            Console.WriteLine("Enter subcategory id for visit items ");
            int ch1 = int.Parse(Console.ReadLine());
            foreach(Product p in plist)
            {
                if(p.subcatid==ch1)
                {
                    Console.WriteLine("Item id \t Item name \t Price");
                    Console.WriteLine(+p.id + "\t" + p.name + "\t" + p.price);
                }
            }
        }

        public void search()
        {
            Console.WriteLine("1.Search an item using item id \n 2.Search an item using item name");
            Console.WriteLine("Enter u r choice");
            int ch = int.Parse(Console.ReadLine());
            int flag = 0;
            if(ch==1)
            {
                Console.WriteLine("Enter item id");
                int i = int.Parse(Console.ReadLine());
                foreach(Product pi in plist)
                {
                    if(pi.id==1)
                    {
                        Console.WriteLine("Item id \t Item name \t Price");
                        Console.WriteLine(+pi.id + "\t" + pi.name + "\t" + pi.price);
                        flag = 1;
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Enter item name");
                string name = Console.ReadLine();
                foreach(Product ip in plist)
                {
                    if(ip.name==name)
                    {
                        Console.WriteLine("Item id \t Item name \t Price");
                        Console.WriteLine(+ip.id + "\t" + ip.name + "\t" + ip.price);
                        flag = 1;
                        break;
                    }
                }
            }
            if (flag == 1)
                Console.WriteLine("Item not found");
        }
    }
}
