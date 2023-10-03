using System;
using Project_task2.Class;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project_task1.DL;
using System.Threading.Tasks;

namespace Project_task2.medicine
{
    class medicine__info
    {
        private int quantity;

        public medicine__info(int quantity,string medicine)
        {
            this.Quantity = quantity;
            this.Medicine = medicine;
        }
        public medicine__info()
        {

        }
        private int price;
        private string medicine;
        private DateTime expiry;
        public medicine__info(int price, string medicine, DateTime expiry)
        {
            this.expiry = expiry;
            this.price = price;
            this.medicine = medicine;
        }

        public int Price { get => price; set => price = value; }
        public string Medicine { get => medicine; set => medicine = value; }
        public DateTime Expiry { get => expiry; set => expiry = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public static void add(string name,int price, DateTime expiry)
        {
            medicine__info med = new medicine__info(price, name, expiry);
            Medfile.med.Add(med);
            Medfile.storedata();
        }
        public static List<string> checkexpiry()
        {
            List<string> expired_ = new List<string>();
            bool expired = false;
            DateTime date = DateTime.Now;
            for (int x = 0; x < Medfile.med.Count; x++)
            {
                if (Medfile.med[x].expiry <= date)
                {
                    expired = true;
                    expired_.Add(Medfile.med[x].medicine);
                   // medinfo.write_expired(Medfile.med[x], 1);
                    Medfile.med.Remove(Medfile.med[x]);
                    Medfile.storedata();
                }
            }
            if (expired == false)
            {
                return null;
             //   medinfo.write_expired(Medfile.med[0], 2);
            }
            return expired_;
        }
        public static medicine__info medicine_info_(variables v)
        {
            string medicine = "";
            int price = 0;
            DateTime expiry = new DateTime();
            //medinfo.medinfo_(ref medicine, ref price, ref expiry);
            medicine__info m = new medicine__info(price, medicine, expiry);
            return m;
        }
        public static bool Remove_medicine(List<medicine__info> med,string name)
        {
            //string name;
        //    name = medinfo.enter_medicine(true);
            medicine__info m = Medfile.med.Find(i => i.Medicine == name);
            if (m.Medicine == name)
            {
                Medfile.med.Remove(m);
                Medfile.storedata();
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
