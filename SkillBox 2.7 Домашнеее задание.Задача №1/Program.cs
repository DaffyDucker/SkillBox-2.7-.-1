using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillBox_2._7_Домашнеее_задание.Задача__1
{
    class Program
    {
        static void Main(string[] args)
        {
            string FullName = "Иван Иванович Иванов";
            int age = 22;
            string email = "test@test.com";
            double ScoreProgramming = 59.84;
            double ScoreMath = 89.7;
            double ScorePhisics = 90.6;

            Console.WriteLine($"Ф.И.О.: {FullName}" +
                              $"\nВозраст: {age} " +
                              $"\nEmail: {email}" +
                              $"\nБаллы по программированию: {ScoreProgramming}" +
                              $"\nБаллы по математике: {ScoreMath}" +
                              $"\nБаллы по физике: {ScorePhisics}");
        }
    }
}
