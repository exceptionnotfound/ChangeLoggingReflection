using ChangeLoggingReflection.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeLoggingReflection.Models
{
    public class RetailLocation
    {
        [PrimaryKey]
        public int Id { get; set; }
        public DateTime DateOpened { get; set; }
        [IgnoreLogging]
        public string ManagerFirstName { get; set; }
        public string ManagerLastName { get; set; }
        public bool HasLimitedMenu { get; set; }

    }
}
