using System;

namespace DiffDataTypeArry
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] arr = new object[4];
            arr[0] = 1;
            arr[1] = "sehar";
            arr[2] = 5.2;
            arr[3] = true;
          

            foreach (object item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}
