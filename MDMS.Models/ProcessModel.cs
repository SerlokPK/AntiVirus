﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDMS.Models
{
    public class ProcessModel
    {
        /// <summary>
        /// User that started process.
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Process name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Hour from when process is forbidden to start.
        /// </summary>
        public int StartHours { get; set; }
        
        /// <summary>
        /// Minute from when process is forbidden to start.
        /// </summary>
        public int StartMinutes { get; set; }

        /// <summary>
        /// Hour from when process is allowed to start.
        /// </summary>
        public int EndHours { get; set; }

        /// <summary>
        /// Minute from when process is allowed to start.
        /// </summary>
        public int EndMinutes { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public ProcessModel()
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="name"></param>
        /// <param name="startHours"></param>
        /// <param name="startMinutes"></param>
        /// <param name="endHours"></param>
        /// <param name="endMinutes"></param>
        public ProcessModel(string user, string name, int startHours, int startMinutes, int endHours, int endMinutes)
        {
            User = user;
            Name = name;
            StartHours = startHours;
            StartMinutes = startMinutes;
            EndHours = endHours;
            EndMinutes = endMinutes;
        }

        /// <summary>
        /// Overriden ToString method which prints all data.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Procss:{Name}, User:{User}, Start time:{StartHours}:{StartMinutes}, End time:{EndHours}:{EndMinutes}";
        }

    }
}
