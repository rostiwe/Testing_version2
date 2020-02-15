using System;
using System.Collections.Generic;
using System.Text;

namespace Testing_version2
{
    static class Names
    {
        public static void Shake ()
        {
            Console.Write("Введите имя: ");
            string Name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string SurName = Console.ReadLine(), resoult = "";
            for (int i = 0; i < Name.Length; i++)
            {
                resoult += Convert.ToChar(Name[i] ^ SurName[i]);        
                Console.WriteLine("Буквы: " + Name[i] + " и " + SurName[i] + ". Их коды:" + Convert.ToInt32(Name[i]) + " и " + Convert.ToInt32(SurName[i]) + ". После операции XOR: " + (Name[i] ^ SurName[i]));
                if (SurName.Length == (i + 1) && (i + 1) != Name.Length)
                {
                    resoult += Name.Substring((i + 1), (Name.Length - (i + 1)));
                    break;
                }
                if (Name.Length == (i + 1) && (i + 1) != SurName.Length)
                    resoult += SurName.Substring((i + 1), (SurName.Length - (i + 1)));//
            }
            Console.WriteLine("Результат: \n" + resoult);
        }
    }
}
