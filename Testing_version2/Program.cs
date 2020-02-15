using System;

namespace Testing_version2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string Name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string SurName = Console.ReadLine(), resoult = "";
            for (int i = 0; i < Name.Length; i++)
            {
                resoult += Convert.ToChar(Name[i] ^ SurName[i]);
                // Name[i] - символ(char), из строки Name. К двум строкам нельзя применять побитовые операции, а к 2 символам можно.
                Console.WriteLine("Буквы: " + Name[i] + " и " + SurName[i] + ". Их коды:" + Convert.ToInt32(Name[i]) + " и " + Convert.ToInt32(SurName[i]) +". После операции XOR: "+(Name[i] ^ SurName[i]));
                if(SurName.Length == (i + 1) && (i + 1) != Name.Length)
                // если мы подошли к концу SurName, но name ещё не закончилось.(SurName.Length - возвращает общее количество символов, а в SurName[i] счёт начинается с 0, отсюда +1)
                {
                    resoult += Name.Substring((i + 1), (Name.Length - (i + 1)));
                // Добавим к результату часть строки Name, которую не трогали. Name.Substring(a,b) возвращает часть строки Name, начиная с символа с номером a. Всего возвращает  b - символов.
                    break; // заканчиваем цикл for, т.к. достигли конца одной из строк
                }
                if(Name.Length == (i + 1) && (i + 1) != SurName.Length)
                // Аналогично с кодом выше, но если заканчивается Name, а в SurName ещё есть символы. for не прерываем - он и так сейчас закончится.
                    resoult += SurName.Substring((i + 1), (SurName.Length - (i + 1)));//
            }
            Console.WriteLine( "Результат: \n"+resoult);
            //Конец
            // Вариант 2 (как стоит делать). Что бы не засорять main просто перенесём код в статичеcкий метод класса Names  
            // Используем этот метод
            Names.Shake();
        }
    }
}
