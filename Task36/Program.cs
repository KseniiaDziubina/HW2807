Console.WriteLine("\nМассив:   ");
    int [] Array2 = new int[15];
Random range2 = new Random();
    Console.Write("[");
    for (int i = 0; i < Array2.Length; i++)
         {
            Array2[i] = range2.Next(-50, 99);
            Console.Write(Array2[i] + " ");
         }
    Console.Write("]");

int SumOfOddNumbers = 0;
    for (int i = 0; i < Array2.Length; i ++)
        {
           if (i % 2 != 0)
           {
            SumOfOddNumbers = SumOfOddNumbers + Array2[i];
           }
        }    
  
Console.WriteLine($"\nСумма элементов массива на нечётных позициях равна: {SumOfOddNumbers}");
