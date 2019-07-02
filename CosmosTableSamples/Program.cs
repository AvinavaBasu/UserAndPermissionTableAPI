using System;

namespace CosmosTableSamples
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Azure Cosmos Table Samples");
            //BasicSamples basicSamples = new BasicSamples();
            //basicSamples.RunSamples().Wait();

            AdvancedSamples advancedSamples = new AdvancedSamples();

            advancedSamples.RunSamples("UserDetails").Wait();
            advancedSamples.RunSamples("UserPermission").Wait();

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.Read();
        }
    }
}
