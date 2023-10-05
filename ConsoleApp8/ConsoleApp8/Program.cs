// See https://aka.ms/new-console-template for more information
using System.IO;
using System.Reflection.Metadata;

namespace employee
{
    class emp
    {
        public int id, salary;
        public String fname;
        public String lname;
        public int Id
        {
            get { return id; }
        }
        public String Fname
        {
            get { return fname; }

        }
        public String Lname
        {
            get { return lname; }

        }
        public String Name
        {
            get { return fname; }
        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        emp(int id,String fname,String lname,int salary)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;
            this.salary = salary;
        }
        public int annualsalary()
        {
            return salary * 12;
        }
        public int raisesalary(int p)
        {
            int per = (salary * p) / 100;
            return per + salary;
        }
        public static void Main(String []args)
        {
            emp obj = new emp(12,"di","abc",2345);
            Console.WriteLine("id", ${ obj.Id});
            Console.WriteLine("fname",obj.Fname); 
            Console.WriteLine("name",obj.Lname);
            obj.Salary = 7000;
            Console.WriteLine(obj.Salary);
            int s = obj.annualsalary();
            int r = obj.raisesalary(3);
            Console.WriteLine("annual salary is", s);
            Console.WriteLine("raise salary is",r); 
        }
    }
}
