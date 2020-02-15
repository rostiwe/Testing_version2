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
                char Name_char = Name[i], SurName_char = SurName[i];
                resoult += Convert.ToChar(Name_char ^ SurName_char);
                Console.WriteLine("Буквы: " + Name[i] + " и " + SurName[i] + ". Их коды:" + Convert.ToInt32(Name_char) + " и " + Convert.ToInt32(SurName_char)+". После операции XOR: "+(Name_char ^ SurName_char));
                if(SurName.Length == (i + 1) && (i+1) != Name.Length)
                {
                    resoult += Name.Substring((i + 1), (Name.Length - (i + 1)));
                    break;
                }
                if(Name.Length == (i + 1) && (i + 1) != SurName.Length)
                    resoult += SurName.Substring((i + 1), (SurName.Length - (i + 1)));
            }
            Console.WriteLine(resoult);
        }
    }
}
