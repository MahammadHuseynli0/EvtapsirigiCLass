namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string surname;
            byte age;
            string departmentname;
            int salary;
            byte Choose = 0;
            int minSalary;
            int maxSalary;
            Department department = new Department();

            do
            {
                Console.WriteLine("1.Employee elave et");
                Console.WriteLine("2.Butun iscilere bax");
                Console.WriteLine("3.Maas araligina gore iscileri axtaris et");
                Console.WriteLine("0.Proqrami bitir");

                
                Choose = Convert.ToByte(Console.ReadLine());

                if (Choose == 0)
                {
                    break;

                }

                if (Choose == 1)
                {
                    Console.WriteLine("Employee adini daxil edin");
                    name = Console.ReadLine();
                    Console.WriteLine("Soyadini daxil edin");
                    surname = Console.ReadLine();
                    Console.WriteLine("Yasini daxil edin");
                    age = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine("Departement adini daxil edin");
                    departmentname = Console.ReadLine();
                    Console.WriteLine("Maasini daxil edin");
                    salary = Convert.ToInt32(Console.ReadLine());

                    Employee employee = new Employee(name, surname, age, departmentname, salary);

                    department.AddEmployee(employee);
                  }
                if (Choose == 2)
                {
                    department.ShowEmployeeInfo();
                }
                if (Choose == 3)
                {
                    Console.WriteLine("minSalary daxil edin");
                    minSalary = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("maxSalary daxil edin");
                    maxSalary = Convert.ToInt32(Console.ReadLine());
                    department.GetAllEmployeesBySalary(minSalary, maxSalary);
                }

            }while (true);

        }
    }
}
