﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
using MDMS.Utilities.Models;

namespace MDMS.Utilities.Utilities
{
    public static class IEnumerableExtensions
    {
        private static readonly ILog Logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static IEnumerableExtensions()
        {
        }

        public static void LogIntrusions(this IEnumerable<Tuple<string, string, int>> data)
        {
            if (data.Count() == 0)
            {
                Logger.Info($"No critical intrusions.");
                return;
            }

            foreach(var tuple in data)
            {
                Logger.Info($"Critical: Name:{tuple.Item1}, User:{tuple.Item2}, Count:{tuple.Item3}");
            }
        }
    }
}
