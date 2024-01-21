using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net;

namespace HelloWorldApp
{
    public enum PaymentMethod
    {
        None = 0,
        bKash = 1,
        Nogod = 2,
        MasterCard = 3,
        VisaCard = 4
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Calculator.Add(45.5, 5.2));
            //var methodId = 4;
            //var method = PaymentMethod.MasterCard;
            //Console.WriteLine((int)method);
            //Console.WriteLine((PaymentMethod)methodId);

            //var methodName = "bKash";
            //var methodNamee = (PaymentMethod) Enum.Parse(typeof(PaymentMethod), methodName);
            //Console.WriteLine(methodNamee);


            ////Value Type
            //int a = 10;
            //int b = a;
            //b++;
            //Console.WriteLine(String.Format("a:{0}, b:{1}",a,b));
            ////Reference Type
            //var arr = new int[3] { 1, 2, 3 };
            //var arr2 = arr;
            //arr2[1] = 50;
            //Console.WriteLine(String.Format("{0},{1},{2}", arr[0], arr[1], arr[2]));
            //Console.WriteLine(String.Format("{0},{1},{2}", arr2[0], arr2[1], arr2[2]));


            //var rand = new Random();
            //const int passwordLength = 15;
            //var buffer = new char[passwordLength];
            //for (var i=0; i < passwordLength; i++)
            //{
            //    buffer[i] = (char)(rand.Next(48, 126));
            //}
            //var password = new string(buffer);
            //Console.WriteLine(password);



            //while(true)
            //{
            //    Console.Write("Type your name:");
            //    var input = Console.ReadLine();
            //    if (!string.IsNullOrWhiteSpace(input))
            //    {
            //        Console.WriteLine("Hello {0}", input);
            //        continue;
            //    }
            //    break;
            //}


            //var numbers = new[] {5,9,3,2,56,7};
            //var another = new int[6];
            //Array.Copy(numbers, another, numbers.Length);
            //Array.Sort(numbers);
            //Array.Reverse(numbers);
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //var names = new[] { "Tanvir", "Tarif", "Tamzid", "Keya" };
            //var nameList = new List<string>();
            //foreach (var name in names)
            //{
            //    nameList.Add(name);
            //}

            //string sentense = "Contrary Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia";
            //Console.WriteLine(summerizeText(sentense,20));

            //var path = @"G:\vivacoms\HelloWorldApp\HelloWorldApp\";
            //Console.WriteLine(File.ReadAllText(path + "Program.cs"));
            //Console.WriteLine(File.ReadAllLines(path + "Person.cs").Length);

            //var dir = new DirectoryInfo(path);

            //var files = dir.GetFiles();
            //foreach ( var file in files)
            //{
            //    Console.WriteLine(file.Attributes);
            //}

            //var files = Directory.GetFiles(path,"*.*", SearchOption.AllDirectories);
            //var dirs = Directory.GetDirectories(path, "*.*", SearchOption.AllDirectories);

            //foreach (var file in files)
            //{
            //    Console.WriteLine(Path.GetPathRoot(file));
            //}

            var tanvir = new PersonMain();
            tanvir.Name = "Tanvir Ahmed";
            tanvir.Age = 27;
            tanvir.Gender = "Male";
            tanvir.Introduce();





        }

        static string summerizeText(string text, int maxLength)
        {
            if(text.Length <= maxLength) return text;

            var sentenseWords = text.Split(' ');
            var sentenseLength = 0;
            var summery = new List<string>();
            foreach (var word in sentenseWords)
            {
                summery.Add(word);
                sentenseLength += word.Length + 1;
                if (sentenseLength > maxLength)
                    break;
            }
            return string.Join(' ',summery) + "...";
        }
            
    }
}
