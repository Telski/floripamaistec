{
            List<int> numImpar = new List<int>();
            List<int> numPar = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Digite o número inteiro " + i + ":");
                int userInput = int.Parse(Console.ReadLine());

                if (userInput % 2 == 0)
                {
                    numPar.Add(userInput);
                }
                else
                {
                    numImpar.Add(userInput);
                }
            }

            numImpar.Sort();
            numPar.Sort();

            int oddSum = 0;
            int evenSum = 0;

            foreach (int num in numImpar)
            {
                oddSum += num;
            }

            foreach (int num in numPar)
            {
                evenSum += num;
            }

            Console.WriteLine("A lista de números ímpares possui " + numImpar.Count + " números e a soma deles é igual a " + oddSum + ".");
            Console.WriteLine("A lista de números pares possui " + numPar.Count + " números e a soma deles é igual a " + evenSum + ".");

            Console.ReadLine();
        }