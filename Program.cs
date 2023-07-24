class Program
{
    static void Main(string[] args)
    {

        void EvenNumbersInArrayTask34()
        {
            bool IsEven(int number) // проверка на четность
            {
                if (number % 2 == 0) return true;
                else return false;
            }

            int arrsize = CustomLibClass.Input("Enter array size: ");
            int[] mainarr = CustomLibClass.GenerateArray(arrsize, 100, 1000);

            Console.Write("Look, this is your array: ");
            CustomLibClass.PrintArray(mainarr);

            int evensum = 0;
             for (int i = 0; i < arrsize; i++)
            {
                if (IsEven(mainarr[i])) evensum ++;
            }

            string s = "s"; // да, это издевательство, но круто же! ))
            string are = "are";
            if (evensum == 1)
            {
                s = "";
                are = "is";
            }
            Console.WriteLine($"There {are} {evensum} even number{s} in your array");

        }

        void OddSumTask36()
        {
            int arrsize2 = CustomLibClass.Input("Enter array size: ");
            int[] mainarr2 = CustomLibClass.GenerateArray(arrsize2, -100, 101);

            Console.Write("Look, this is your array: ");
            CustomLibClass.PrintArray(mainarr2);

            int mainsum2 = 0;
            for (int i = 1; i < arrsize2; i+= 2)
            {
                mainsum2 += mainarr2[i];
            }

            Console.WriteLine("Sum of odd index numbers is " + mainsum2);
        }

        void MinMaxTask38()
        {
            int arrsize3 = CustomLibClass.Input("Enter array size: ");
            double [] mainarr3 = CustomLibClass.GenerateDoubleArray(arrsize3, -10, 10);

            Console.Write("Look, this is your array: ");
            CustomLibClass.PrintDoubleArray(mainarr3);

            double arrmin = mainarr3[0];
            double arrmax = mainarr3[0];
            for (int i = 1; i < arrsize3; i++)
            {
                if (mainarr3[i] < arrmin) arrmin = mainarr3[i];
                else if (mainarr3[i] > arrmax) arrmax = mainarr3[i]; // можно было без else, но это типа оптимизация такая ))
            }

            Console.WriteLine($"Min = {arrmin}\nMax = {arrmax}");
            if (arrmin < 0 ) Console.WriteLine($"{arrmax} - ({arrmin}) = {arrmax - arrmin}");
            else Console.WriteLine($"{arrmax} - {arrmin} = {arrmax - arrmin}");
        }

        Console.Clear();

        EvenNumbersInArrayTask34();

        CustomLibClass.Break();

        OddSumTask36();

        CustomLibClass.Break();

        MinMaxTask38();

        CustomLibClass.Break();

    }
}