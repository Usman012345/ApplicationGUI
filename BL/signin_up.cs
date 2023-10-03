using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Threading.Tasks;
using task6.DL;

namespace task6.BL
{
    class signin_up
    {
        /*public static string sign_in_up()
        {
            int count = 0;
            string role__ = "";
            signdata.read_count(ref count);
            int option = 0;
            if (option == 1)
            {
                signup(ref count);
            }
            else if (option == 2)
            {
                role__ = signin(ref count);
                return role__;
            }
            else
            {
                Environment.Exit(0);
            }
            return role__;
        }*/
        public static string signin(ref int count,string name,string password,string role)
        {
          //  string Username_ = "", password_ = "", role_ = "";
           // signin_up_.username_password(ref Username_, ref password_, ref role, "signin");
            bool exists = signdata.readfile(name, password, ref role, count);
            if (exists == true)
            {
                return role;
            }
            else
              //  signin_up_.valid_invalid("invalid");

            return null;
        }
       public static void signup(ref int count, string name, string password, string role)
        {
            //string Username = "", password = "", role = "";
          //  signin_up_.username_password(ref Username, ref password, ref role, "signup");
            count++;
            signdata.storedata(name, password, role, count);
        }

    }
}
