namespace ArrayZoeker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] userArray = new int[10];

            for (int i = 0; i < userArray.Length; i++)
            {
                Console.WriteLine("Geef een waarde in: ");
                int waarde = int.Parse(Console.ReadLine());

                userArray[i] = waarde;
            }

            Console.WriteLine("Enter"); Console.ReadLine(); Console.Clear();
            Console.WriteLine("Welk getal moet verwijderd worden?");
            int deleteWaarde = int.Parse(Console.ReadLine());

            bool gevonden = false;
            int index = 0;
            
            

            do
            {
                if (userArray[index] == deleteWaarde)
                {
                    Array.Clear(userArray, index, 1);
                    gevonden = true;
                }
                index++;
            } while (!gevonden && index < userArray.Length);

            for (int i = 0; i < userArray.Length; i++)
            {
                Console.WriteLine(userArray[i]);
            }
        }
    }
}
