public static class CustomLibClass // Почему-то мой ВСКод по умолчанию вообще не показывает неймспейс
{
    // Random rand = new Random(); почему в статическом классе нельзя так сделать?


    public static void Break()
    {
        Console.WriteLine();
        Console.WriteLine(new string('*', 50));
        Console.WriteLine();
    }

    public static int Input(string inputmessage)
    {
        Console.Write(inputmessage);
        int output = Convert.ToInt32(Console.ReadLine());
        return output;
    }

    public static int[] GenerateArray(int arraysize, int from, int to) //create array with 3 digits numbers
    {
        Random rand = new Random();

        int[] newarray = new int[arraysize];
        for (int i = 0; i < arraysize; i++)
        {
            newarray[i] = rand.Next(from, to);
        }
        return newarray;
    }

    public static double[] GenerateDoubleArray(int arraysize, int from, int to) //create array with 3 digits numbers
    {
        Random rand = new Random();

        double[] newarray = new double[arraysize];
        for (int i = 0; i < arraysize; i++)
        {
            newarray[i] = Math.Round(rand.Next(from, to) + rand.NextDouble(), 2);
        }
        return newarray;
    }

        public static void PrintArray(int[] arr)
    {
        int arrsize = arr.Length;
        Console.Write("[");
        for (int i = 0; i < arrsize; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        Console.Write("\b]\n");
    }
    
    public static void PrintDoubleArray(double[] arr)
    {
        int arrsize = arr.Length;
        Console.Write("[");
        for (int i = 0; i < arrsize; i++)
        {
            Console.Write($"{arr[i].ToString("0.00")}  ");
        }
        Console.Write("\b\b]\n");
    }
}