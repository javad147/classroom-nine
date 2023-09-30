//static string CheckPowerOfATwo (int n) 
//{
//    int result = 0;
//    while (n > 1 && n % 2 == 0) 
//    {
//     n /= 2;

//    }
//    if (n == 1)
//    {
//        Console.WriteLine("Quvvetdir");

//    }
//    else 
//    {

//        Console.WriteLine("Deyil");

//    }

//    var res = Math.Pow(2, 3);
//    Console.WriteLine(res);

//    var res = Math.Sqrt(36);
//    Console.WriteLine(res);

//}
//CheckPowerOfATwo (1);

using Homework_9;
using Homework_9.Models;

//CustomMath math = new CustomMath();
//Console.WriteLine(math.SumOfOddNumbers(new int[] { 1, 2, 3, 4, 5, 6 }});

//Console.WriteLine(math.CheckNumOddOrEven(10));

//Console.WriteLine(math.SumOfOddNumbers(new int[] { 1, 2, 3, 4, 5, 6 }});

//Console.WriteLine(math.Getfactorial(4);

//static void GetEmployeesByAge(int age)
//{
//    Employee[] employess = GetEmployees();

//    Employee[] filteredEmployees = employess.Where(m => m.age > age).ToArray();

//    foreach (var employee in filteredEmployees) 
//    {
//        string result = $"{employee.name} - {employee.surname} - {employee.age} - {employee.address} - {employee.email}";
//        Console.WriteLine(result);

//    }
//}

//GetEmployeesByAge(20);

//static int GetEmployeesByAge(int astartge, int endAge) => GetEmployees(); Where(m => m.age > startAge && m.age < endAge).ToArray();

//static int SumOfEmployeeAges() 
{
    //var employees = GetEmployees();
    //  int sum = 0;
    //      foreach (var item employees)
    //  {
    //      sum += item.age;

    //  }
    //      return sum;




    //  return employees.Sum(x => x.age);



    //}

    //static int SumOfEmployeeAges() => GetEmployees().Sum(m => m.age);
    //Console.WriteLine(SumOfEmployeeAges());

    //Console.WriteLine(CountOfEmployeeByAge(20,30));



    //    static void GetEmployeeByFilteredEmail(string str) 
    //    {

    //            Employee[] employees = GetEmployees();
    //            Employee[] filteredEmployees = employees.Where(m => m.email.ToLower().StartsWith()str.ToLower())).ToArray();

    //             Console.WriteLine(result);
    //    }

    //foreach (var employee in filteredEmployees) 
    //{

    //    string result = $"{employee.name} - {employee.surname} - {employee.age} - {employee.address} - {employee.email}";
    //         Console.WriteLine(result);

    //}
    //static Employee[] GetEmployees() 
    //{
    //    Employee employee1 = new Employee()
    //    {
    //        id = 1,
    //        name = "Javad",
    //        surname = "Bakirli",
    //        address = "Binagadi",
    //        email = "javad.bakirli@gmail.com",
    //        age = 32,
    //    };
    //    Employee employee2 = new Employee()
    //    {
    //        id = 2,
    //        name = "Kainat",
    //        surname = "Qulizada",
    //        address = "Yasamal",
    //        email = "kainat.gulizada@gmail.com",
    //        age = 38,
    //    };
    //    Employee employee3 = new Employee()
    //    {
    //        id = 3,
    //        name = "Yunis",
    //        surname = "Aliyev",
    //        address = "Ahmadli",
    //        email = "yunis.aliyev@gmail.com",
    //        age = 34,
    //    };
    //    Employee employee4 = new Employee()
    //    {
    //        id = 4,
    //        name = "Qoshqar",
    //        surname = "Jafarov",
    //        address = "Kubinka",
    //        email = "qoshqar.jafarov@gmail.com",
    //        age = 36,
    //    };
    //    Employee employee5 = new Employee()
    //    {
    //        id = 5,
    //        name = "Ali",
    //        surname = "Aliyev",
    //        address = "Sovetski",
    //        email = "ali.aliyev@gmail.com",
    //        age = 29,
    //    };


    //}






    //Animal animal = Animal();
    //animal.name = "sasassa";

    //Bird bird = new();
    //bird name = "ssss";

    //Console.WriteLine(animal.name);


    //Fish fish = new();
    //fish.HasCaviar = true;
    //Console.WriteLine(fish.HasCaviar);

    //Bird bird = new Bird(); 

    //bird.Sound();

    //Animal animal = new Animal();
    //animal SOund();

    //factorial factorial = new();

    //int a = 5;
    //int b = 10 ;
    //int result = a + b;
    //int factorialResult = factorial.GetFactorial(4);
    //Console.WriteLine(factorial.Calculate(2.3) + factorialResult);
    //Console.WriteLine(factorial.GetFactorial(4));


    //Student student = new();
    //student.

    Student student = new Student();

    student.id = 1;
    student.name = "Tunzala";
    student.surname = "Memmedova";
    student.age = 24;
    student.address = "Nesimi";
    Console.WriteLine(student.GetAllFullData());


