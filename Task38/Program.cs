Console.WriteLine("\nМассив:   ");
int [] myArray = new int[20];

Random range3 = new Random();

    for (int i = 0; i < myArray.Length; i++)
         {
            myArray[i] = range3.Next(1, 999);
            Console.Write(myArray[i] + " ");
         }

int MaxNumber = myArray[0];
int MinNumber = myArray[0];
    
    for (int i = 0; i < myArray.Length; i++)
    {
        if (MaxNumber < myArray[i])
        {
            MaxNumber = myArray[i];
        }
        if (MinNumber > myArray[i])
        {
            MinNumber = myArray[i];
        }
    }
int Subtract = MaxNumber - MinNumber;

Console.WriteLine($"\nРазница между максимальным элементом массива {MaxNumber} и минимальным элементом {MinNumber} равна {Subtract}");