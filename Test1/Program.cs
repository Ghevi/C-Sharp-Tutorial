using System;
using System.Collections.Generic;
using System.Linq; // for working with collections (map, filter, reduce)
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadLine();
        }

    }
}

// 

//int index = 1;

//while (index <= 5)
//{
//    Console.WriteLine($"Hello, you are at stage {index}");
//    index++;
//}

//int idx = 6;
//do
//{
//    Console.WriteLine($"Hello, now at {idx}");
//    idx++;
//} while (idx <= 5);

/* CALCULATOR
 * Console.Write("Enter a number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter an operator: ");
string calcOperator = Console.ReadLine();

Console.Write("Enter another number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

double result = doCalculation(num1, num2, calcOperator);
Console.Write($"The result is: {result}");

Console.ReadLine();
        }

static double doCalculation(double num1, double num2, string calcOperator)
  {
    switch(calcOperator)
    {
    case "+":
        return num1 + num2;
    case "-":
        return num1 - num2;
    case "*":
        return num1 * num2;
    case "/":
        return num1 / num2;
    default:
        Console.WriteLine("Invalid operator");
    }

    return -1;
  }
*/

//    Console.WriteLine(getMax(100, 9, 221));

//    Console.ReadLine();
//}

//static int getMax(int num1, int num2, int num3)
//{
//    int result;

//    if(num1 >= num2 && num1 >= num3)
//    {
//      result = num1;
//    }
//    else if(num2 >= num1 && num2 >= num3)
//    {
//      result = num2;
//    } else
//    {
//      result = num3;
//    }

//    return result;
//}


//bool isMale = true;
//bool isTall = false;

//if(isMale && isTall)
//{
//    Console.WriteLine("You are a tall male");
//} else
//{
//    Console.WriteLine("You are either not male or not tall or neither");
//}


//if (isMale || isTall)
//{
//    Console.WriteLine("You are a either tall, male or both");
//}
//else
//{
//    Console.WriteLine("You are not a tall male");
//}


//if (isMale && isTall)
//{
//    Console.WriteLine("You are a tall male");
//}
//else if(isMale && !isTall)
//{
//    Console.WriteLine("You are male but not tall");
//} 
//else if(!isMale && isTall)
//{
//    Console.WriteLine("You are tall but not male");
//}
//else
//{
//    Console.WriteLine("You are either not male or not tall or neither");
//}

//    //sayHi("Kevin", 18);
//    //sayHi("Mario", 40);
//    //sayHi("Alex", 23);

//    Console.WriteLine(cube(3));

//    Console.ReadLine();
//}

//static int cube(int num)
//{
//    return Convert.ToInt32(Math.Pow(num, 3));
//}

////static void sayHi(string name, int age) 
////{
////    Console.WriteLine($"Hello {name}, you are {age} years old");
////}
///


//int[] luckyNumbers = {4, 15, 435, 23, 23423};

//string[] friends = new string[5];
//friends[0] = "Janni";
//friends[1] = "Kevin";

//luckyNumbers[1] = 9789;

//Console.WriteLine(luckyNumbers[1]);


//string color, pluralNoun, celebrity;

//Console.Write("Type a color: ");
//color = Console.ReadLine();

//Console.Write("Type a plural noun: ");
//pluralNoun = Console.ReadLine();

//Console.Write("Type a celebrity: ");
//celebrity = Console.ReadLine();

//Console.WriteLine($"Roses are {color}");
//Console.WriteLine($"{pluralNoun} are blue");
//Console.WriteLine($"I hate {celebrity}");


//Console.Write("Enter a number: ");
//Double num1 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Enter another number: ");
//Double num2 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine(num1 + num2);

//int num = Convert.ToInt32("45");
//Console.WriteLine(num + 5);

//Console.ReadLine();

// float, double, decimal 

//string characterName = "John";
//int characterAge = 35;

//Console.WriteLine("There once was a man named " + characterName);
//Console.WriteLine($"He was {characterAge} years old");

//characterName = "Mike";

//Console.WriteLine($"He really liked the name {characterName}");
//Console.WriteLine($"But didn't like being {characterAge}");

//string phrase = "Hello World";
//char grade = 'C';
//int age = 20;
//double gpa = 3.0;
//bool isMale = true;

//string phrase = "Hello pepega" + " any truers in the chat?";

//Console.WriteLine("Hello\nworld");
//Console.WriteLine("Hello \"Dood\"");
//Console.WriteLine(phrase);
//Console.WriteLine(phrase.Length);
//Console.WriteLine(phrase.ToUpper());
//Console.WriteLine(phrase.ToLower());
//Console.WriteLine(phrase.Contains("ello"));
//Console.WriteLine(phrase[0]);
//Console.WriteLine(phrase.IndexOf("pepega"));
//Console.WriteLine(phrase.Substring(6));
//Console.WriteLine(phrase.Substring(6, 8));

//Console.WriteLine(2 + 3);
//Console.WriteLine(6 % 3);
//Console.WriteLine(5 + 3.2); // 5 get coerced to decimal
//Console.WriteLine(5 / 2); // we get a int anyway

//int num = 6;
//num++;
//num--;
//Console.WriteLine(num);
//Console.WriteLine(num++); // logs first then ++
//Console.WriteLine(++num); // ++ first then logs
//Console.WriteLine(Math.Abs(-4)); 
//Console.WriteLine(Math.Pow(2.5, 3)); 
//Console.WriteLine(Math.Sqrt(36)); 
//Console.WriteLine(Math.Max(4, 90)); 
//Console.WriteLine(Math.Round(4.3)); 

//Console.Write("Enter your name: ");
//string name = Console.ReadLine();

//Console.Write("Enter your age: ");
//string age = Console.ReadLine();

//Console.WriteLine($"Hello {name}, You are {age} years old");