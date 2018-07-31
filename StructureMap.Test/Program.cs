using StructureMap.Test.smApp;
using StructureMap.Test.smRegister;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureMap.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = Container.For<ConsoleRegistry>();
            var app = container.GetInstance<Application>();
            app.Run();
            Console.ReadLine();
        }
    }
}

