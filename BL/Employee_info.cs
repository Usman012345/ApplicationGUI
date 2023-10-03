using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project_task1.DL;
using Project_task2.Class;
using System.Threading.Tasks;
using Project_task2.medicine;

namespace Project_task1.Employee
{

    class Employee_info
    {
        public static List<medicine__info> bought_medicine = new List<medicine__info>();
        public static List<string> medicine_new = new List<string>();
        protected string employee_name, role;
        protected int pay;
        protected float attendace = 0;

        public Employee_info()
        {

        }
        public string Employee_name { get => employee_name; set => employee_name = value; }
        public string Role { get => role; set => role = value; }
        public int Pay { get => pay; set => pay = value; }
        public float Attendace { get => attendace; set => attendace = value; }

        public Employee_info(string employee_name, string role, int pay, float attendace)
        {
            this.employee_name = employee_name;
            this.role = role;
            this.pay = pay;
            this.attendace = attendace;
        }
       /* public int emplyee_menu_()
        {
            while (true)
            {
                int option = Emplinfo.employee_menu();
                *//*if (option == 1)
                {
                    string name = Emplinfo.mark_attendance();
                    Employee_info name_ = employee_data.employees.Find(i => i.employee_name == name);
                    if (name_.employee_name == name)
                    {
                        name_.Attendace++;
                    }
                    else
                        wrong_input.wrong_input_();*//*
                }
                if (option == 2)
                {
                    float bill = Emplinfo.prepare_bill();
                    Emplinfo.write_bill(bill);
                }
                if (option == 3)
                {
                    medinfo.Print_medicine_record(Medfile.med);
                }
                if (option == 4)
                {
                    medicine_new.Add(Emplinfo.new_medicine());
                }
                if (option == 5)
                {
                    Emplinfo.edit_price();
                }
                if (option == 0)
                {
                    return 0;
                }
                else if (new[] { 1, 2, 3, 4, 5, 0 }.All(x => x != variables.option))
                {
                    wrong_input.wrong_input_();
                }
                readkey.readkey_();
            }
        }*/
        /*public static Employee_info Add_employee()
        {
            string name = "", role = "";
            int pay = 0;
            float attendace = 0F;
          //  Emplinfo.Emplinfo_(ref name, ref role, ref pay, ref attendace);
            Employee_info e = new Employee_info(name, role, pay, attendace);
            return e;
        }*/

        public static void remove_employee(string name)
        {
            //string name;
          //  name = Emplinfo.enter_employee(true);
            for (int x = 0; x < employee_data.employees.Count; x++)
            {
                if (name == employee_data.employees[x].Employee_name)
                {
                    employee_data.employees.RemoveAt(x);
                    employee_data.storedata();
                }
            }
        }
        public static void add(string name, string role,int pay, float attendance)
        {
            Employee_info e = new Employee_info(name, role, pay, attendance);
            employee_data.employees.Add(e);
            employee_data.storedata();
        }
        public static bool mark_attendance(string name)
        {
            Employee_info name_ = employee_data.employees.Find(i => i.Employee_name == name);
            if (name_.Employee_name == name)
            {
                name_.Attendace++;
                employee_data.storedata();
                return true;
            }
            else
                return false;
        }
        public static void edit_prices(string name,int price)
        {
            foreach (medicine__info data in Medfile.med)
            {
                if (name == data.Medicine)
                {
                    data.Price = price;
                }
            }
            Medfile.storedata();
        }
    }
}
