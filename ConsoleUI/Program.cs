using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch=true)]

namespace ConsoleUI
{
    class Program
    {
        // 3 ways of log declaration

        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger("Program.cs");
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //private static readonly log4net.ILog log = LogHelper.GetLogger();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            //log.Error("This is my error message");

            log.Debug("Developer: Tutorial was run");
            log.Info("Maintenance: water pump turned on");
            log.Warn("Maintenance: the water pump is getting hot");

            double n = 0;
            double q = 10;

            try
            {
                double x = q / n;
            }
            catch (Exception ex)
            {
                log.Error("Developer: we tried to divide by zero again", ex);
            }

            Counter j = new Counter();
            log4net.GlobalContext.Properties["Counter"] = j;

            for (j.LoopCounter = 0; j.LoopCounter < 5; j.LoopCounter++)
            {
                //log.Fatal($"This is message number: { i.ToString() }");       
                //log4net.GlobalContext.Properties["Counter"] = i;
                log.Fatal("This is a fatal error");
            }

            //log.Fatal("Maintenance: water pump exploded");

            Console.ReadLine();
        }
    }
}
