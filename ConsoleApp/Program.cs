using System;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var setting = new Dictionary<string, string> {
                {"name","nidexioa"},
                {"age","23" }
            };

            var builder = new ConfigurationBuilder()
                .AddInMemoryCollection(setting)
                .AddCommandLine(args);
            var configuration = builder.Build();
            Console.WriteLine($"name:{configuration["name"]}");
            Console.WriteLine($"age:{configuration["age"]}");
            Console.ReadLine();

            Console.WriteLine("Hello World!");
        }
    }
}
