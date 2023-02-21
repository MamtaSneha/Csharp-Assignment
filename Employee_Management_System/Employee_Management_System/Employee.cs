using System;


namespace Employee_Management_System
{
    
        public class Employee

        {

            int EmpNo;

            string EmpName;

            double Salary;

            double HRA;

            double TA;

            double DA;

            double PF;

            double TDS;

            double NetSalary;

            double GrossSalary;

            //method

            public void set_EmpNo_Name_Salary()

            {

                //taking input of emp no,emp name and for  salary

                Console.WriteLine("Enter Emp No, Emp Name,Salary of an an employee");

                EmpNo = Convert.ToInt32(Console.ReadLine());

                EmpName = Console.ReadLine();

                Salary = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Emp No =  {0}\nEmpName = {1}\nSalary = {2} ", EmpNo, EmpName, Salary);

            }

            public double GroSal()

            {

                GrossSalary = 0;

                if (Salary < 5000)

                {

                    HRA = 10 * Salary / 100;

                    TA = 5 * Salary / 100;

                    DA = 15 * Salary / 100;

                    GrossSalary = Salary + HRA + TA + DA;

                }

                else if (Salary < 10000)

                {

                    HRA = 15 * Salary / 100;

                    TA = 10 * Salary / 100;

                    DA = 20 * Salary / 100;

                    GrossSalary = Salary + HRA + TA + DA;

                }

                else if (Salary < 150000)

                {

                    HRA = 20 * Salary / 100;

                    TA = 15 * Salary / 100;

                    DA = 25 * Salary / 100;

                    GrossSalary = Salary + HRA + TA + DA;

                }

                else if (Salary < 200000)

                {

                    HRA = 25 * Salary / 100;

                    TA = 20 * Salary / 100;

                    DA = 30 * Salary / 100;

                    GrossSalary = Salary + HRA + TA + DA;

                }

                else if (Salary >= 20000)

                {

                    HRA = 10 * Salary / 100;

                    TA = 5 * Salary / 100;

                    DA = 15 * Salary / 100;

                    GrossSalary = Salary + HRA + TA + DA;

                }

                return GrossSalary;

            }

            public void CalCulateSalary()

            {

                Console.WriteLine("HERE PF , TDS AND NET SALARY OF AN EMPLOYEE");

                Double GrosSal = GroSal();

                PF = 10 * GrosSal / 100;

                TDS = 18 * GrosSal / 100;

                NetSalary = GrosSal - (PF + TDS);

                Console.WriteLine(" PF = {0} \nTDS = {1}\nNetSalary = {2}", PF, TDS, NetSalary);

            }

            static void Main()

            {

                Employee emp = new Employee();

                emp.set_EmpNo_Name_Salary();

                Double Gs = emp.GroSal();

                Console.WriteLine(" Gross SALARY {0}  ", Gs);

                emp.CalCulateSalary();

                Console.ReadLine();

            }

        }
    }

