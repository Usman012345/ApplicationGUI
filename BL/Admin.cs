using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_task2.Class;
using Project_task2.medicine;
using task6.BL;
using task6.DL;
using Project_task1.Employee;
using Project_task1.DL;

namespace Project_task1.BL
{
    class Admin
    {

       /* public static int admin_menu()
        {
            *//*medicine__info m = new medicine__info();*//*
            variables v = new variables();
            while (true)
            {
                //Main_menu.main_menu_();

                if (variables.option == 1)
                {
                    Medfile.med.Add(medicine__info.medicine_info_(v));
                    Medfile.storedata();

                }
                if (variables.option == 2)
                {
                    //medinfo.Print_medicine_record(Medfile.med);

                }
                if (variables.option == 3)
                {
                    medicine__info.checkexpiry();
                }
                if (variables.option == 4)
                {
                    medicine__info.Remove_medicine(v, Medfile.med);

                }
                if (variables.option == 5)
                {
                    employee_data.employees.Add(Employee_info.Add_employee());
                    employee_data.storedata();
                }
                if (variables.option == 6)
                {
                    //Emplinfo.employee_record();
                }
                if (variables.option == 7)
                {
                    //Main_menu.print_emed();
                }
                if (variables.option == 8)
                {
                    Employee_info.remove_employee();
                }
                if (variables.option == 0)
                {
                    return 0;
                }
                else if (new[] { 1, 2, 3, 4, 5, 6, 7, 0 }.All(x => x != variables.option))
                {
                    //wrong_input.wrong_input_();
                }
             //   readkey.readkey_();
            }
        }*/



    }
}
