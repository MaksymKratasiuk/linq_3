namespace linq_3
{
    internal class Task1
    {
        public static void task1()
        {
            string[] strings = { "apple", "banana", "cherry", "date", "elderberry" };

            // Сортування за зростанням кількості символів
            Array.Sort(strings, CompareByLengthAscending);
            Console.WriteLine("Сортування за зростанням кількості символів:");
            foreach (var str in strings)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine();

            // Сортування за спаданням кількості символів
            Array.Sort(strings, CompareByLengthDescending);
            Console.WriteLine("Сортування за спаданням кількості символів:");
            foreach (var str in strings)
            {
                Console.WriteLine(str);
            }
        }

        // Порівняння двох рядків за зростанням кількості символів
        static int CompareByLengthAscending(string x, string y)
        {
            return x.Length.CompareTo(y.Length);
        }

        // Порівняння двох рядків за спаданням кількості символів
        static int CompareByLengthDescending(string x, string y)
        {
            return y.Length.CompareTo(x.Length);
        }
    }
}

