using System;

namespace AutoMapperConfiguration
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                RegisterMapping.Initialize();
                Console.WriteLine("Mapping Successful!");
            } catch (Exception) {
                Console.WriteLine("Mapping Unsuccessful!");
            }
        }
    }
}
