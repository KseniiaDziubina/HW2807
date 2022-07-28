Console.WriteLine("Массив:   ");
    int [] Array = new int[5];
Random range = new Random();

    for (int i = 0; i < Array.Length; i++)
         {
            Array[i] = range.Next(100, 999);
            Console.Write(Array[i] + ",  ");
         }

int EvenNumber = 0;
    for (int i = 0; i < Array.Length; i ++)
        {
           if (Array[i] % 2 == 0) EvenNumber++;
        }


Console.Write($"\nКоличество чётных элементов в массиве равно: {EvenNumber}" );

