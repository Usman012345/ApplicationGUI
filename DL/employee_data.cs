using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Project_task1.Employee;

namespace Project_task1.DL
{
    class employee_data : Employee_info
    {
        public static List<Employee_info> employees = new List<Employee_info>();
        public static void storedata()
        {
            if (File.Exists("employee_data.txt"))
            {
                StreamWriter data = new StreamWriter("employee_data.txt", false);
                for (int x = 0; x < employees.Count; x++)
                    data.WriteLine("{0},{1},{2},{3}", employees[x].Employee_name, employees[x].Role, employees[x].Pay, employees[x].Attendace);
                data.Flush();
                data.Close();
            }
        }
        public static void readfile()
        {
            if (File.Exists("employee_data.txt"))
            {
                string line = "", name, role;
                int pay;
                float attendace = 0;
                StreamReader data = new StreamReader("employee_data.txt", true);
                while ((line = data.ReadLine()) != null)
                {
                    string[] line1 = line.Split(',');
                    name = line1[0];
                    role = line1[1];
                    pay = int.Parse(line1[2]);
                    attendace = float.Parse(line1[3]);
                    Employee_info e = new Employee_info(name, role, pay, attendace);
                    employees.Add(e);
                }
                data.Close();
            }
        }
    }
}
