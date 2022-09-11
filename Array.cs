using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;

namespace Practice_Interface
{
     class Array:IOutput,IMath,ISort,ICalc,IOutput2,ICalc2
     {
        public int[] arr;      
        public Array(int size)
        {
            arr = new int [size];

        }      

        public void Init()
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0,10);

            }
        }      

        public void Show()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}");

            }
        }
        public void Show(string info)
        {
            Console.WriteLine($"{info}");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}");
            }            
        }
        public int Max()
        {
            return arr.Max() ;
        }

        public int Min()
        {
            return arr.Min();
        }
        public float Avg()
        {
            double avg= Queryable.Average(arr.AsQueryable());
            float avg2 = (float)avg;
            return avg2;
        }

        public bool Search(int valueToSearch)
        {
            int t=0;            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == valueToSearch)
                {
                    t++;
                }
               
            }
            if (t > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SortAsc()
        {
            int temp=0;
            for (int i = 0; i <arr.Length-1; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }
                }
            }
            
        }
        public void SortDesc()
        {
            int temp = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;

                    }
                }
            }

        }
           public  void SortByParam(bool isAsc)
           {
              if (isAsc == true)
              {
                int temp = 0;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] > arr[j])
                        {

                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;

                        }
                    }
                }
              }
              if (isAsc == false)
              {
                int temp = 0;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] < arr[j])
                        {
                            temp = arr[j];
                            arr[j] = arr[i];
                            arr[i] = temp;

                        }
                    }
                }
              }
           }
        public int Less(int valueToCompare)
        {
            int c = 0;
            foreach (int item in arr)
            {
                if (item < valueToCompare) 
                { c++; }
            }
            return c;
        }
        public int Greater(int valueToCompare)
        {
            int c = 0;
            foreach (int item in arr)
            {
                if (item > valueToCompare) 
                { c++; }
            }
            return c;
        }
        public void ShowEven()
        {
            Console.Write("Парні елементи: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.Write($"{arr[i]}");
                }
            }
            Console.WriteLine();
        }
        public void ShowOdd()
        {
            Console.Write("Непарні елементи: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    Console.Write($"{arr[i]}");
                }
            }
            Console.WriteLine();
        }

        public int CountDistinct()
        {
            int c = 0;
            for (int i = 0; i < arr.Length ; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                   if(i!=j && arr[i] == arr[j]) 
                   {
                        c++;
                   }
                }
            }
            int size = arr.Length - c;
            return size;
        }
        public int EqualToValue(int valueToCompare) 
        {
            int c = 0;
            foreach (int item in arr)
            {
                if (item == valueToCompare)
                {
                    c++; 
                }
            }
            return c;
        }
    }
}
