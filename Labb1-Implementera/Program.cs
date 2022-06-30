using Labb1_Implementera.Adapter;
using Labb1_Implementera.Strategy;


// Jag har använd mig av Adapter, Strategy och Factory Design Pattern.

bool _programOn = true;
string[,] employeesArray = new string[5, 3]
            {
                {"1","Nalle Puh","12400"},
                {"2","Olivia Walter","25200"},
                {"3","Kiki Witch","31100"},
                {"4","Bill Gates","40000"},
                {"5","Klara Berg","66666"}
            };
ITarget target = new EmployeeAdapter();

do
{
    Console.Clear();
    Console.WriteLine("Hello to my Salary, What do you want to do? \n1.Get my Salary \n2.Search for my Salary information \n3.Exit");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1": // Detta görs med hjälp av Adaptern och senare Factory
            Console.Clear();
            Console.WriteLine("What is your Name?");
            string name = Console.ReadLine();
            Console.Clear();
            target.ProcessPayCheck(employeesArray, name);
            Console.Read();
            break;
        case "2": // Detta görs med hjälp av Strategyn
            SearchContext context = new SearchContext();
            Console.WriteLine("Please enter a Searchoption: \nEmployeeid\nName\nSalary");
            string searchOption = Console.ReadLine().ToLower();
            switch (searchOption)
            {
                case "employeeid":
                    Console.WriteLine("Please enter the id");
                    string idSearch = Console.ReadLine();
                    Console.Clear();
                    context.SetSearchStrategy(new EmployeeidStrategy());
                    context.Search(idSearch, employeesArray);
                   
                    break;
                case "name":
                    Console.WriteLine("Please enter the Name");
                    string nameSearch = Console.ReadLine();
                    Console.Clear();
                    context.SetSearchStrategy(new EmployeeNameStrategy());
                    context.Search(nameSearch, employeesArray);
                    
                    break;
                case "salary":
                    Console.WriteLine("Please enter the Salary");
                    string salarySearch = Console.ReadLine();
                    Console.Clear();
                    context.SetSearchStrategy(new EmployeeSalaryStrategy());
                    context.Search(salarySearch, employeesArray);
                   
                    break;
            }
            break;
        case "3":
            Console.WriteLine("Enter any key to exit");
            _programOn = false;
            Console.ReadKey();
            break;
        default:
            Console.WriteLine("option not available...");
            Console.ReadLine();
            break;
    }
} while (_programOn == true);


