//*************************
// практическая работа №11*
// выполнил: Ханов Артур  *
//*************************
using System;

namespace PR_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите строку");
                string s = Console.ReadLine();//ввод строки
                if (s == "") Console.WriteLine("Вы ничего не ввели");
                else
                {
                    int max = 0;
                    string[] mas = s.Split();//разделение строки на массив строк
                    string pod = "";
                    int nomer = 1, k = 1;
                    foreach (string a in mas)
                    {
                        if (a.Length > max) { max = a.Length; pod = a; nomer = k; }//определение макс слова и его номера
                        k++;//счетчик для подсчета количества слов в массиве
                    }
                    Console.WriteLine("Слово максимальной длины {0} стоит под номером {1}", pod, nomer);
                    int index = s.IndexOf(pod);//определения номера позиции слова в строке
                    Console.WriteLine("Номер позиции слова {0} в строке {1}", pod, index);
                }
            }
            catch (Exception e)//обработка исключения
            {
                Console.WriteLine("Ошибка:" + e.Message);
            }
            Console.ReadKey();
        }
    }
}
