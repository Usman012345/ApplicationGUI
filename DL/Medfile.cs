using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_task2.medicine;
using Project_task2.Class;
using System.IO;
namespace Project_task1.DL
{
    class Medfile:medicine__info
    {
        public static List<medicine__info> med = new List<medicine__info>();
        /*public static bool checkexpiry()
        {
            bool expired;
            return false;
        }*/
        public static void readfile(List<medicine__info> med)
        {
            string medicine;
            int price;
            DateTime expiry = new DateTime();
            if (File.Exists("medicine_data.txt"))
            {
                string line = "";
                StreamReader data = new StreamReader("medicine_data.txt", true);
                while ((line = data.ReadLine()) != null)
                {
                    // v.line = data.ReadLine();
                    string[] line1 = line.Split(',');
                    medicine = line1[0];
                    price = int.Parse(line1[1]);
                    string[] line2 = line1[2].Split('/');
                    
                    string[] line3 = line2[2].Split(' ');
                    expiry = new DateTime(int.Parse(line3[0]), int.Parse(line2[1]), int.Parse(line2[0]));
                    medicine__info m = new medicine__info(price, medicine, expiry);
                    med.Add(m);
                }
                data.Close();
            }
        }
        public static void storedata()
        {
            if (File.Exists("medicine_data.txt"))
            {
                StreamWriter data = new StreamWriter("medicine_data.txt", false);
                for (int x = 0; x < med.Count; x++)
                    data.WriteLine("{0},{1},{2}", med[x].Medicine, med[x].Price, med[x].Expiry);
                data.Flush();
                data.Close();
            }
        }
    }
}
