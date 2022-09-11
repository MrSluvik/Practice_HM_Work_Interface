using System;
using static System.Console;
using System.Text;

namespace Practice_Interface   
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputEncoding = Encoding.Unicode;//для кирилиці

            Console.WriteLine("Введіть розмір масиву");
            int size = Convert.ToInt32(Console.ReadLine());

            Array arrc = new Array(size);  
            
            arrc.Init();
            arrc.Show();
            Console.WriteLine("\n");
            arrc.Show("це масив цілих чисел");

            Console.WriteLine($"\n\nМаксимальне значення в масиві:  {arrc.Max()}\n");
            Console.WriteLine($"Мінімальне число в масиві : {arrc.Min()}\n");
            Console.WriteLine($"Середнє арифметичне серед елементів масиву: {arrc.Avg()}\n");
            Console.WriteLine("\nВведіть шуканий елемент");
            int Element = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Чи є такий елемент в масиві true\false : {arrc.Search(Element)}\n");            

            Console.WriteLine("\nСортування за зростанням");
            arrc.SortAsc();
            arrc.Show();
            Console.WriteLine("\n\nСортування за спаданям");
            arrc.SortDesc(); 
            arrc.Show();
            Console.WriteLine("\n\nВведіть вид сортування 1-  за зростанням;-1 - за спаданням");
            int sort = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\nСортування за вибором користувача");
            if (sort == 1)
            {
                arrc.SortByParam(true);
                arrc.Show();
            }
            else if (sort == -1)
            {
                arrc.SortByParam(false);
                arrc.Show();
            }

            Console.WriteLine("\n\nВведіть число щоб знайти кількість елементів масиву меших за введене \n");
            int ElementMax = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Кількість елементів масиву меших за введене = {arrc.Less(ElementMax)}\n");
            Console.WriteLine();
            Console.WriteLine("\nВведіть число щоб знайти кількість елементів масиву більших за введене \n");
            int ElementMin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Кількість елементів масиву більших за введене = {arrc.Greater(ElementMin)}\n");
            Console.WriteLine();

            arrc.ShowEven();
            arrc.ShowOdd();

            Console.WriteLine($"\n\nКількість унікальних чисел в масиві:  {arrc.CountDistinct()}\n");
            Console.WriteLine("\nВведіть число щоб знайти кількість елементів масиву рівних йому \n");
            int @value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Кількість чисел рівних введеному: {arrc.EqualToValue(@value)}\n");

        }
    }
}
