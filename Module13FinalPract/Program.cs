using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13FinalPract
{
    class Program
    {
        static string[] FavColor(int length)
        {
            var mas = new string[length];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = Console.ReadLine();               
            }
            return mas;
        }
        static string[] Pets(int length)
        {
            var mas = new string[length];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = Console.ReadLine();
            }
            return mas;
        }
        static bool HasPet(string res)
        {                       
            if (res == "да")
            {             
                return true;
            }
            else return false;                                
        }
        static bool Check(string a, out int result)
        {
            if (int.TryParse(a, out int check))
            {
                if (check > 0)
                {
                    result = check;
                    return true;
                }
            }
            {
                result = 0;                
                return false;
            }
        }
        
        static (string Name, string LastName, int Age, bool HasPet) Data()
        {
            (string Name, string LastName, int Age, bool HasPet) UserData;

            Console.WriteLine("Введите имя");
            UserData.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            UserData.LastName = Console.ReadLine();
             
            string a;
            int inta;           
            do
            {
                Console.WriteLine("Введите возраст > 0");
                a = Console.ReadLine();
            } while (!Check(a, out inta));
            UserData.Age = inta;

            string b;
            int count;
            do
            {
                Console.WriteLine("Введите кол-во любимых цветов > 0");
                b = Console.ReadLine();
            }  while (!Check(b, out count));
            Console.WriteLine("Перечислите цвета");
            foreach (var color in FavColor(count))
            {
                 Console.WriteLine("Вы выбрали цвет: {0}", color);
            }

            string c;
            int pets;
            Console.WriteLine("Есть ли у вас питомец?");
            string haspet = Console.ReadLine();
            UserData.HasPet = HasPet(haspet);
            if (HasPet(haspet) == true)
            {
                do
                {
                    Console.WriteLine("Введите кол-во питомцев > 0");
                    c = Console.ReadLine();
                } while (!Check(c, out pets));
                Console.WriteLine("Перечислите клички");
                foreach (var pet in FavColor(pets))
                {
                    Console.WriteLine("Питомец с кличкой: {0}", pet);
                }
            } else Console.WriteLine("Питомцев нет");
           
            return UserData;
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Data()); 
            
            Console.ReadKey();
        }
    }
}
