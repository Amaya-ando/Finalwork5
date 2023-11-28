using System;
using System.Collections.Generic;
using System.Net.Cache;

namespace Final_work_5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            EnterUser();  
        }

        static (string Name, string LastName, int Age, bool Haspet, int NumPets, int Favcolors) EnterUser()
        {
            (string Name, string LastName, int Age, bool Haspet, int NumPets, int Favcolors) User;

            User.Age = 0;
            User.NumPets = 0;
            User.Favcolors = 0;

            Console.Write("Введите ваше имя:\n");
            User.Name = Console.ReadLine();

            Console.Write("Введите вашу фамилию:\n");
            User.LastName = Console.ReadLine();

            Console.Write("Укажите ваш возраст:\n");
            User.Age = Check();

            Console.Write("Есть ли у вас питомцы? Укажите: Да или Нет\n");

            while (true)
            {
                var result = Console.ReadLine();

                if (result == "Да")
                {
                    User.Haspet = true;

                    Console.Write("Уточните количество ваших питомцев:\n");
                    User.NumPets = Check();

                    string[] Haspet = new string[User.NumPets];

                    for (int i = 0; i < User.NumPets; i++)
                    {
                        Console.WriteLine($"Введите кличку питомца {i + 1}:");
                        Haspet[i] = Console.ReadLine();

                    }
                    break;
                }

                else if (result == "Нет")
                {
                    User.Haspet = false;
                    break;
                }

                else
                {
                    Console.Write("Вы ввели {0}. Введите, пожалуйста, корректное значение:\n", result);
                }
            }

            Console.Write("Уточните количество ваших любимых цветов:\n");

            User.Favcolors = Check();

            if (User.Favcolors > 0)
            {
                string[] color = new string[User.Favcolors];

                Console.Write("Уточните их название, пожалуйста:\n");

                for (int i = 0; i < color.Length; i++)
                {
                    color[i] = Console.ReadLine();
                }

                Console.Write("Спасибо за ваши ответы!");               
            }

            return User;
        }

        static int Check()
        {

            while (true)
            {             
                int lessi = int.Parse(Console.ReadLine());

                    if (lessi >= 0)
                    {
                        Console.WriteLine($"Данные введены корректно: {lessi}");
                        return lessi;
                    }
                else 
                {
                    Console.WriteLine("Значение не может быть отрицательным, попробуйте еще раз!");

                }

            }

        }   
        
    }
}   





     

     