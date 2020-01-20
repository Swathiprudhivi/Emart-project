using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Admin\n2.Buyer\n3.seller");
            int n = int.Parse(Console.ReadLine());
            for(; ; )
            {
                switch(n)
                {
                    case 1:
                        

                        break;
                    case 2:
                        Console.WriteLine("1.New User For SingUp\n2.Already have an account");
                        int c = int.Parse(Console.ReadLine());
                        SallerBO sb = new SallerBO();
                        if (c == 1)
                        {
                            Console.WriteLine("Enter detalis for singup");
                            Console.WriteLine("Enter seller id");
                            int sellerid = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter seller name");
                            string sname = Console.ReadLine();
                            Console.WriteLine("Enter password");
                            string spassword = Console.ReadLine();
                            Console.WriteLine("Enter email id");
                            string email = Console.ReadLine();
                            Console.WriteLine("Enter phone number");
                            int phnum = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter company name");
                            string companyname = Console.ReadLine();
                            Console.WriteLine("Enter postal address");
                            string postal_address = Console.ReadLine();
                            Console.WriteLine("Enter gst");
                            int gstin = int.Parse(Console.ReadLine());
                            sb.Singup(sellerid,sname, spassword, companyname, gstin, phnum, email, postal_address);
                            Console.WriteLine("Sign up successfully");

                        }
                        else
                        {
                            Console.WriteLine("Enter u r username and password to Login");
                            Console.WriteLine("Enter username");
                            string username = Console.ReadLine();
                            Console.WriteLine("Enter password");
                            string password = Console.ReadLine();
                            bool x = sb.Login(username, password);
                            if (x != true)
                                Console.WriteLine("Invalid Credientials");
                            else
                            {
                                Console.WriteLine("Login successfull");
                                for(; ; )
                                {
                                    Console.WriteLine("1.Display seeler details\n 2.Add item\n3.Display seller item\n 4.Dispaly list of remaining items");
                                    int ch2 = int.Parse(Console.ReadLine());
                                    ProductBO pb = new ProductBO();
                                    SallerBO sbo = new SallerBO();
                                    switch(ch2)
                                    {
                                        case 1:
                                            Console.WriteLine("Seller detalis are");
                                            sbo.display();
                                            break;
                                        case 2:
                                            Console.WriteLine("Enter how many items u want to add");
                                            int num = int.Parse(Console.ReadLine());
                                            for (int i = 0; i < num; i++)
                                            {
                                                Console.WriteLine("Enter Category id");
                                                int cid = int.Parse(Console.ReadLine());
                                                Console.WriteLine("Enter category name");
                                                string cname = Console.ReadLine();
                                                Console.WriteLine("Enter subcategory id");
                                                int subcatid = int.Parse(Console.ReadLine());
                                                Console.WriteLine("Enter subcategory name");
                                                string subcatname = Console.ReadLine();
                                                Console.WriteLine("Enter the gst");
                                                int gst = int.Parse(Console.ReadLine());
                                                Console.WriteLine("Enter item id");
                                                int id = int.Parse(Console.ReadLine());
                                                Console.WriteLine("Enter item name");
                                                string name = Console.ReadLine();
                                                Console.WriteLine("Enter price");
                                                int price = int.Parse(Console.ReadLine());
                                                Console.WriteLine("Enter stock num");
                                                int stocknum = int.Parse(Console.ReadLine());
                                                Console.WriteLine("Enter seller id");
                                                int sellerid = int.Parse(Console.ReadLine());
                                                pb.Additems(id,price,stocknum,name,subcatid,subcatname,gst,cid,cname,sellerid);
                                            }
                                            break;
                                        case 3:
                                            sbo.Displayseleritem();
                                            break;
                                    }
                                }
                            }
                            
                        }
                        break;
                    case 3:
                        Console.WriteLine("1.New User For SingUp\n2.Already have an account");
                        int ch = int.Parse(Console.ReadLine());
                        BuyerBO bb = new BuyerBO();
                        if (ch == 1)
                        {
                            Console.WriteLine("Enter detalis for singup");
                            Console.WriteLine("Enter name,id,pwd,email,phn");
                            int id = int.Parse(Console.ReadLine());
                            string bname = Console.ReadLine();
                            string bpassword = Console.ReadLine();
                            string bemail = Console.ReadLine();
                            int bphnum = int.Parse(Console.ReadLine());
                            int createddatetime = int.Parse(Console.ReadLine());
                            bb.Singup(id, bname, bpassword, bemail, bphnum, createddatetime);
                            Console.WriteLine("Sign up successfully");
                        }
                        else
                        {
                            Console.WriteLine("Enter u r username and password to Login");
                            Console.WriteLine("Enter username");
                            string username = Console.ReadLine();
                            Console.WriteLine("Enter password");
                            string password = Console.ReadLine();
                            bool y = bb.Login(username, password);
                            if (y != true)
                                Console.WriteLine("Invalid Credientials");
                            else
                            {
                                Console.WriteLine("Login successfull");
                                while(true)
                                {
                                    Console.WriteLine("1.Display \n2.Search \n3.Display Details");
                                    int c1 = int.Parse(Console.ReadLine());
                                    if (c1 == 1)
                                        bb.dispaly();
                                    else if (c1 == 2)
                                        bb.search();
                                    else if (c1 == 3)
                                        bb.displaydetails();
                                    else
                                        break;
                                }
                            }
                            
                        }
                        break;
                    
                }

            }
           


        }
    }
}
