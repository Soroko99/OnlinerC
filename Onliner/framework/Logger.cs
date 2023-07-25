using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog.Core;
using NUnit.Framework.Internal;

namespace OnlinerUITest.framework
{
    internal class Logger
    {
        private static void LoggerConfiguration() {
            Log.Logger = new LoggerConfiguration()
                            .MinimumLevel.Debug()
                            .WriteTo.Console()
                            .CreateLogger();
        }

        public static void Info(string info) {
            LoggerConfiguration();
            Log.Information(info);
            Log.CloseAndFlush();
        }

        public static void Warn(string warning)
        {
            LoggerConfiguration();
            Log.Warning(warning);
            Log.CloseAndFlush();
        }

        public static void Error(string error)
        {
            LoggerConfiguration();
            Log.Error(error);
            Log.CloseAndFlush();
        }

    }
}
