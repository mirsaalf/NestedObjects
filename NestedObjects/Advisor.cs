﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents a college advisor
    /// </summary>
    public class Advisor
    {
        /// <summary>
        /// Advisor legal first and last name
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Advisor work email address
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Building and room number of office 
        /// </summary>
        public string OfficeLocation { get; set; }
    }
}
