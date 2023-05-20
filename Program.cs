namespace homework2_4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please input N");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input K");
            int K = int.Parse(Console.ReadLine());



            int[] population = new int[N];
            if (N >= 1 && N <= 10000 && K >= 1 && N <= 100)
            {
                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine("Please input population");
                    population[i] = int.Parse(Console.ReadLine());
                }

                int maxCustomers = GetMaxCustomers(population, N, K);
                Console.WriteLine(maxCustomers);
            }
        }

        static int GetMaxCustomers(int[] population, int N, int K)
        {
            int maxCustomers = 0;

            for (int i = K; i < N - K; i++)
            {
                int currentCustomers = 0;
                for (int j = i - K; j <= i + K; j++)
                {
                    currentCustomers += population[j];
                }

                if (currentCustomers > maxCustomers)
                {
                    maxCustomers = currentCustomers;
                }
            }

            return maxCustomers;
        }
    }

}
