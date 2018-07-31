using StructureMap.Test.smLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureMap.Test.smApp
{
    public class Application
    {
        private readonly IWriter _writer;
        private readonly ILog _logger;

        public Application(IWriter writer, ILog logger)
        {
            _writer = writer;
            _logger = logger;
        }

        public void Run()
        {
            _logger.Info(nameof(Application) + " started.");

            _writer.WriteLine("Hello World!");

            _logger.Info(nameof(Application) + " finished.");
        }
    }
}