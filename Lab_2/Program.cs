using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Text;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
          
 /*           
            // ###################################	1)  Типы   #############################################
            // 1.a. Определите переменные всех возможных примитивных типов С#  и проинициализируйте их.  

            //bool:  true или false. System.Boolean
            bool boolType1 = true;
            System.Boolean boolType2 = false;

            //byte: от 0 до 255 занимает 1 байт. System.Byte
            byte bit1 = 1;
            System.Byte bit2 = 102;

            //sbyte: от -128 до 127 занимает 1 байт. System.SByte
            sbyte byt1 = -101;
            System.SByte byt2 = 100;

            //short: от -32768 до 32767 занимает 2 байта. System.Int16
            short shor1 = 1;
            System.Int16 shor2 = 102;

            //ushort: 0 до 65535 занимает 2 байта. System.UInt16
            ushort ushor1 = 1;
            System.UInt16 ushor2 = 211;

            //int: от -2147483648 до 2147483647 занимает 4 байта. System.Int32.
            int a1 = 10;
            System.Int32 b1 = -571;

            //uint: от 0 до 4294967295 занимает 4 байта. System.UInt32
            uint a2 = 546;
            System.UInt32 b2 = 455;

            //long: от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 занимает 8 байт. System.Int64
            long a3 = -41591254;
            System.Int64 b3 = 46546;

            //ulong: от 0 до 18 446 744 073 709 551 615 занимает 8 байт. System.UInt64
            ulong a4 = 54648;
            System.UInt64 b4 = 4684654;

            //float: от -3.4*10^38 до 3.4*10^38 занимает 4 байта. System.Single
            float a5 = 12.3F;
            System.Single b5 = 54.58F;

            //double: от ±5.0*10-324 до ±1.7*10308 занимает 8 байта. System.Double
            double a6 = 54.76;
            System.Double b6 = 5846.16;

            //decimal:  десятичное дробное число. Если употребляется без десятичной запятой, имеет значение от ±1.0*10-28 до ±7.9228*1028, может хранить 28 знаков после запятой и занимает 16 байт. System.Decimal
            decimal a7 = 1524.123M;
            System.Decimal b7 = 2341.253457M;

            //char:одиночный символ в кодировке Unicode занимает 2 байта. System.Char
            char a8 = 'A';
            System.Char b8 = 'G';

            //string: набор символов Unicode. System.String.
            string a9 = "saefd";
            System.String b9 = "sfesrf";

            /*object: может хранить значение любого типа данных и занимает 4 байта на 32-разрядной платформе и 8 байт на 64-разрядной платформе.
             System.Object, который является базовым для всех других типов и классов .NET.*/
            object a10 = 10;
            System.Object b10 = "sdfgvdfg";

           
/*
            // 1.b.	Выполните 5 операций явного и 5 неявного приведения.
            // неявные преобразования
            byte ter = 4;
            ushort ter1 = ter;

            sbyte ter2 = 4;
            short ter3 = ter2;

            sbyte ter4 = -6;
            short ter5 = ter4;

            int ter6 = 10;
            float ter7 = ter6;

            int ter8 = 165463516;
            long ter9 = ter8;

            //явные преобразования
            double x1 = 467.7;
            int x2 = (int)x1;

            char y1 = 'r';
            short y2 = (short)y1;

            sbyte c1 = 122;
            decimal c2 = (decimal)c1;

            float e1 = 1233.4F;
            double e2 = (double)e1;

            int f1 = -125;
            ulong f2 = (ulong)f1;



            //1.c.Выполните упаковку и распаковку значимых типов.
            int up = 123;
            object up1 = up; //упаковали

            int rup = (int)up1; //распокавали

            //1.d.Продемонстрируйте работу с неявно типизированной переменной.
            var s = "1sadf";
            var test = new { Name = "12sqqq", Age = 23 };

            //1.e.	Продемонстрируйте пример работы с Nullable переменной.
            int? f = null;
            if (!f.HasValue)
            {
                Console.WriteLine("null");
            }
            f = 5;
            Console.WriteLine("\n{0}",f);

*/
/*


            // ###################################	2) Строки  #############################################
            //2a.	Объявите строковые литералы. Сравните их.
            char name1 = 'c';
            char name2 = 'd';
            Console.WriteLine("\n c == d \n {0}", name1 == name2);

            string name3 = "12zx";
            string name4 = "12zx";
            Console.WriteLine("\n {0} == {1} \n {2}", name3 ,name4 ,name3 == name4);

            /*b.	Создайте три строки на основе String. 
             * Выполните: сцепление, копирование, выделение подстроки, разделение строки на слова, 
             * вставки подстроки в заданную позицию, удаление заданной подстроки.

            

            string str1 = "asd";
            string str2 = "12sdv sm34";
            string str3 = "wefkm wpefm 23f";

            // сцепление
            Console.WriteLine("\n сцепление: {0}", str1 + str2 + str3);
            // копирование
            string str4 = str2;
            Console.WriteLine("\n копирование: {0}", str4);
            //выделение подстроки
            Console.WriteLine("\n выделение подстроки: {0}", str2.Substring(0, 4));
            //разделение строки на слова
            Console.WriteLine("\n разделение строки на слова:");
            string[] str5 = str3.Split(" ");
            foreach (var element in str5)
            {
                Console.WriteLine(element);
            }
            //вставки подстроки в заданную позицию
            Console.WriteLine("\nвставки подстроки в заданную позицию: {0}", str2.Insert(2, str1));
            //удаление заданной подстроки
            Console.WriteLine("\nСтрока: {0}", str3);
            Console.WriteLine("\nВведите подсторку: ");
            string str6 = Console.ReadLine();
            int n = str3.IndexOf(str6);
            str3 = str3.Remove(n, str6.Length);
            Console.WriteLine("\nСтрока: {0}", str3);


            //2.c.	Создайте пустую и null строку. Продемонстрируйте что можно выполнить с такими строками
            string tempTxt_1 = "";
            string tempTxt_2 = null;

            Console.WriteLine("Создайте пустую и null строку. Продемонстрируйте что можно выполнить с такими строками:");
            Console.WriteLine("Plus: " + (tempTxt_1 + tempTxt_2));
            Console.WriteLine("Equals: " + (tempTxt_1.Equals(tempTxt_2)));
            Console.WriteLine("CompareTo: " + tempTxt_1.CompareTo(tempTxt_2));
            Console.WriteLine("String.Concat: " + String.Concat(tempTxt_2, tempTxt_1));
            Console.WriteLine("Interpolation: " + $"{tempTxt_2}{tempTxt_1}");

            string[] array = { tempTxt_1, tempTxt_2 };


            //2.d.	Создайте строку на основе StringBuilder. Удалите определенные позиции и добавьте новые символы в начало и конец строки
            StringBuilder strtemp = new StringBuilder("sdf wpoeolw [okwrm");

            Console.WriteLine("\n\nИсходная строка " + strtemp);
            
            Console.WriteLine("Удаление позици. Ввелите начало: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Удаление позици. Ввелите конец: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Удаленные позиции " + strtemp.Remove(n1,n2));
            Console.WriteLine("добавьте новые символы в начало ");
            tempTxt_1 = Console.ReadLine();
            Console.WriteLine("Добавление в начало строки " + strtemp.Insert(0, tempTxt_1));
            Console.WriteLine("добавьте новые символы в конец ");
            tempTxt_1 = Console.ReadLine();
            Console.WriteLine("Добавление в конец строки " + strtemp.Insert(strtemp.Length, tempTxt_1));

*/
/*

            // ###################################	3)	Массивы  #############################################
            //3.a.	Создайте целый двумерный массив и выведите его на консоль в отформатированном виде (матрица). 
            
                    int[,] arr1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } }; ;
                    int row = arr1.GetUpperBound(0) + 1;
                    int col = arr1.Length / row;

                    for (int i = 0; i<row;i++)
                    {
                        for(int j=0; j<col;j++)
                        {
                            Console.Write($"{arr1[i, j]}\t");
                        }
                        Console.WriteLine();
                    }

                    //3.b.	Создайте одномерный массив строк. Выведите на консоль его содержимое, длину массива. 
                    //Поменяйте произвольный элемент (пользователь определяет позицию и значение).

                    string[] strarr = { "1111111111111", "22222222222222", "33333333333333" };
                    Console.WriteLine("\nМассив строк:");
                    for (int i = 0; i < strarr.Length; i++)
                    {
                        Console.WriteLine(i + ": " + $"{strarr[i]}");
                    }

                    Console.WriteLine("Длинна массива: " + strarr.Length);
                    int temp1, temp2;
                    Console.WriteLine("Выберите номер строки: ");
                    temp1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Выберите номер элемента: ");
                    temp2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите данные: ");
                    string tmpffx = Console.ReadLine();

                    string temp_1 = strarr[temp1];
                    temp_1 = temp_1.Remove(temp2, temp2);
                    temp_1 = temp_1.Insert(temp2, tmpffx);

                    strarr[temp1] = temp_1;

                    Console.WriteLine("\nИзмененный Массив строк:");
                    for (int i = 0; i < strarr.Length; i++)
                    {
                        Console.WriteLine(i + ": " + $"{strarr[i]}");
                    }
            
            //3.c.	Создайте ступечатый (не выровненный) массив вещественных чисел с 3-мя строками, в каждой из которых 2, 3 и 4 столбцов соответственно. 
            //Значения массива введите с консоли.
            
                    int row = 3;
                    int colums = 2;
                    int[,] array = new int[3, 4];

                    for(int i = 0; i < row; i++)
                    {
                        int chek = 0;
                        while (chek != colums)
                        {
                            Console.WriteLine("Введите " + i + " строку " + chek + " столбец");
                            array[i, chek] = Convert.ToInt32(Console.ReadLine());
                            chek++;
                        }
                        colums++;
                    }

                    Console.WriteLine("\nМассив:\n");
                    colums = 2;
                    for (int i = 0; i < row; i++)
                    {
                        int chek = 0;
                        while (chek != colums)
                        {
                            Console.Write($"{array[i, chek]}\t");
                            chek++;
                        }
                        colums++;
                        Console.WriteLine();
                    }

            

            //3.d.	Создайте неявно типизированные переменные для хранения массива и строки.
            var array_3 = new object[0];
            var str_3 = "";

*/
/*
            // ###################################	4)	Кортежи  #############################################
            //4.a.	Задайте кортеж из 5 элементов с типами int, string, char, string, ulong. 

            (int, string, char, string, ulong) kort_4 = (10, "AAA", 'B', "CCC", 48);

            //b.	Сделайте именование его элементов.
            var kort_4_1 = (ind1: 10, ind2: "AAA", ind3: 'B', ind4: "CCC", ind5: 48);

            //c.	Выведите кортеж на консоль целиком и выборочно (1, 3, 4  элементы)
            Console.WriteLine(kort_4);
            Console.WriteLine(kort_4_1.ind1 + " " + kort_4_1.ind3 + " " + kort_4_1.ind4);

            //d.	Выполните распаковку кортежа в переменные.
            int K = kort_4_1.ind1;
            char C = kort_4_1.ind3;

            //e.	Сравните два кортежа.

           // ((IComparable)kort_4).CompareTo(kort_4_1);


*/



            // ###################################	4)	локальную функцию  #############################################
            /*5)	Создайте локальную функцию в main и вызовите ее. Формальные параметры функции – массив целых и строка. 
            * Функция должна вернуть кортеж, содержащий: максимальный и минимальный элементы массива, сумму элементов массива 
            * и первую букву строки .*/
            int[] N = { 1, 13, -456, 45, -56, 0, 48 };
            string M = "Abracatabra";


            Console.WriteLine(ReturnCort(N,M));


        }

        private static (int max, int min, int summ, char letter) ReturnCort(int[] arr_5, string str_5)
        {
            var result = (max: 0, min: 0, summ: 0, lettet: ' ');

            for(int i=0; i < arr_5.Length;i++)
            {
                result.summ += arr_5[i];

                if(result.max < arr_5[i])
                {
                    result.max = arr_5[i];
                }

                if(result.min > arr_5[i])
                {
                    result.min = arr_5[i];
                }
            }

            result.lettet = str_5[0];

            return result;
        }
           

            









    }






}
