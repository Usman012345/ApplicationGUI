using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task6.DL
{
    class signdata
    {
        public static void storedata(string Username, string password, string role, int count)
        {
            File.Exists("userdata.txt");
            StreamWriter data = new StreamWriter("userdata.txt", true);
            data.WriteLine("{0},{1},{2}", Username, password, role);
            data.Flush();
            data.Close();
            File.Exists("count.txt");
            StreamWriter data_ = new StreamWriter("count.txt", false);
            data_.Write(count);
            data_.Flush();
            data_.Close();

        }
        public static void read_count(ref int count)
        {
            if (File.Exists("count.txt"))
            {
                StreamReader data = new StreamReader("count.txt", true);
                count = int.Parse(data.ReadLine());
                data.Close();
            }
        }
        public static bool readfile(string username_, string password_, ref string role, int count)
        {
            string username = "", password = "";
            bool run = false, comma = false;

            string line;
            int x = 0;
            char comma_ = ',';
            if (File.Exists("userdata.txt"))
            {
                StreamReader data = new StreamReader("userdata.txt", true);
                for (int y = 0; y < count; y++)
                {
                    comma = false;
                    x = 0;
                    run = false;
                    username = null;
                    password = null;
                    line = data.ReadLine();
                    string[] line1 = line.Split(comma_);
                    username = line1[0];
                    password = line1[1];


                    if (username_ == username && password_ == password)
                    {
                        role = line1[2];
                        return true;
                    }

                }
                data.Close();
            }

            return false;
        }
    }
}

