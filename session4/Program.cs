using System.Text;
using System.Xml.Linq;

namespace session4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //object obj = 10.4;
            #region c# 7 (pattern matching - case guards(when) )
            //switch (obj)
            //{
            //    case int value :
            //        Console.WriteLine("integar");
            //        break;
            //    case double value:
            //        Console.WriteLine("double");
            //        break;
            //    default:
            //        Console.WriteLine("no match");
            //        break;

            //}
            // case 2 guards when
            //switch (obj)
            //{
            //    case int value when value < 10:
            //        Console.WriteLine("less than 10");
            //        break;
            //    case int value when value > 10:
            //        Console.WriteLine("greater than 10");
            //        break;
            //    default:
            //        Console.WriteLine("equal 10");
            //        break;


            //}
            // example 3 user defiend type
            //object obj = 5;
            //obj = new person()
            //{
            //    id = 1,
            //    name = "mazen",
            //    age = 22,
            //};
            //switch (obj)
            //{
            //    case int value when value > 10:
            //        Console.WriteLine("greater than 10");
            //        break;
            //    case person value when value.id == 1 && value.name == "mazen":
            //        Console.WriteLine("id = 1 and name  mazen");
            //        break;
            //}

            #endregion
            #region C# 8 EVALUTION pattern match without alias name
            //object number = 5;
            //switch (number)
            //{
            //    case int when (int) number < 10:
            //        Console.WriteLine("less than 10");
            //        break;
            //    case decimal when (decimal)number > 10:
            //        Console.WriteLine("greater than 10");
            //        break;
            //};

            // --2 switch case before switch expression
            //Console.WriteLine("enter your option");
            //string option = Console.ReadLine();
            //string message;
            //message = option switch
            //{
            //    "1" => "option 1",
            //    "2" => "option 2",
            //    "3" => "option 3",
            //    _ => "is notvaild"
            //};
            //Console.WriteLine(message); 

            //3- property pattern
            //    person person = new person()
            //    {
            //        name = "mazen",
            //        age = 22,
            //        id = 14,
            //    };

            //    string msg = person switch
            //    {
            //        { name : "mazen", id : 14 } => "correct",
            //        _ => "not correct",
            //    };

            //Console.WriteLine(msg);  


            //4 {nullable type , realtional patterns }
            //int ? x = 10;
            //string msg = x switch
            //{
            //    null => "nullable num",
            //    int number when number > 5 => "greater than 5",
            //    int number when number > 7 => "greater than 7",
            //};
            //Console.WriteLine(msg);

            #endregion
            //#region c#9 {switch expretion with realtion patterns , logical pattern}
            //int x = 17;
            //string msg = x switch
            //{
            //    > 0 and < 10 => "between 1 and 9",
            //    >= 10 and < 20 => "between 10 and 20" ,


            //};
            //Console.WriteLine(msg);
            //#endregion

            #region loops
            //for loop
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //for(int i =0; i<numbers.Length; i++)
            //{
            //    if (i == 3)
            //        continue; //skip cuurent itteration
            //    Console.WriteLine(numbers[i]);
            //}
            //2 for each just for display
            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            //3 while - do while
            //int number;
            //do
            //{
            //    Console.WriteLine("enter even numb");
            //    int.TryParse(Console.ReadLine(), out number);

            //}
            //while (number %2 == 1);
            //Console.WriteLine( $"{number} is even num");\

            // while

            #endregion
            #region string method
            //string message = "   hello route    ";
            //Console.WriteLine(message.Length);
            //Console.WriteLine(message.ToUpper()); //HELLO ROUTE
            //Console.WriteLine(message.ToLower()); //hello route
            //Console.WriteLine(message.Trim());
            //Console.WriteLine(message.Substring(0,5));
            //Console.WriteLine(message.Replace('o' , 'm'));
            //Console.WriteLine(message.Contains('o'));
            #endregion
            #region stringbulder
            //StringBuilder message;
            //message = new StringBuilder();
            //Console.WriteLine($"message {message} ");
            //Console.WriteLine($"message {message.GetHashCode()}");
            //message.Clear();
            //message.Append("route");
            //Console.WriteLine(message);

            #endregion

            #region assignment 4
            //1
            //Console.WriteLine("enter number");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 3 == 0 || num % 4 == 0) 
            //{
            //    Console.WriteLine( $" num is diveded {num} " );
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}

            //2 
            //Console.WriteLine("enter number");
            //int value = int.Parse(Console.ReadLine());
            //if (value > 0)
            //{
            //    Console.WriteLine("postive");
            //}
            //else
            //{
            //    Console.WriteLine("negative");
            //}



            //3
            //Console.WriteLine("enter 3 numbers");
            //int value1 , int value2 , int value3 = int.Parse(Console.ReadLine());
            //if(value1 > value2 && value2 > value3 )
            //{
            //    Console.WriteLine("value 1 the max");
            //}



            //4
            //Console.WriteLine("enter even or odd num");
            //int value = int.Parse(Console.ReadLine());
            //if(value % 2 == 0)
            //{
            //    Console.WriteLine("even num");
            //}
            //else
            //{
            //    Console.WriteLine("odd num");
            //}

            //5

            //6
            //Console.WriteLine("enter number");
            //int value = int.Parse(Console.ReadLine());
            //for (int i =1; i<=value; i++)
            //{
            //    Console.WriteLine( $"nums are {i}");

            //}

            //8
            //Console.WriteLine("enter number");
            //int number = int.Parse(Console.ReadLine());
            //for(int i = 2; i<=number; i += 2)
            //{
            //    Console.WriteLine(i);
            //}


            //9
            //{
            //    Console.Write("Enter base number: ");
            //    int baseNum = int.Parse(Console.ReadLine());

            //    Console.Write("Enter exponent: ");
            //    int exponent = int.Parse(Console.ReadLine());

            //    int result = 1;

            //    for (int i = 1; i <= exponent; i++)
            //    {
            //        result *= baseNum;
            //    }

            //    Console.WriteLine("Result: " + result);
            //}


            //11
            //Console.Write("Enter month number (1-12): ");
            //int month = int.Parse(Console.ReadLine());

            //int days;

            //switch (month)
            //{
            //    case 1:  // January
            //    case 3:  // March
            //    case 5:  // May
            //    case 7:  // July
            //    case 8:  // August
            //    case 10: // October
            //    case 12: // December
            //        days = 31;
            //        break;

            //    case 4:  // April
            //    case 6:  // June
            //    case 9:  // September
            //    case 11: // November
            //        days = 30;
            //        break;

            //    case 2:  // February
            //        days = 28; //   
            //        break;

            //    default:
            //        Console.WriteLine("Invalid month number.");
            //        return;
            //}

            //Console.WriteLine("Days in Month: " + days);




            //12

            #endregion
            #region q1
            //1
            //Console.WriteLine("enter number");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 3 == 0 || num % 4 == 0) 
            //{
            //    Console.WriteLine( $" num is diveded {num} " );
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}
            #endregion
        }
    }
}
