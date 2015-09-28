using ChangeLoggingReflection.Models;
using ChangeLoggingReflection.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeLoggingReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the old entry
            RetailLocation oldLocation = new RetailLocation()
            {
                Id = 1,
                DateOpened = new DateTime(2009, 12, 3),
                ManagerFirstName = "Steve",
                ManagerLastName = "Harkonnen",
                HasLimitedMenu = true
            };

            RetailLocation newLocation = new RetailLocation()
            {
                Id = 1,
                DateOpened = new DateTime(2009, 12, 3),
                ManagerFirstName = "Kelly",
                ManagerLastName = "Nishimura",
                HasLimitedMenu = false
            };

            ChangeLogService service = new ChangeLogService();
            var logs = service.GetChanges(oldLocation, newLocation, typeof(RetailLocation));

            foreach(var log in logs)
            {
                Console.WriteLine("Primary Key: " + log.PrimaryKey.ToString() + ", Class Name:" + log.ClassName + ", Property Name: " + log.PropertyName + ", Old Value = " + log.OldValue + ", New Value = " + log.NewValue);
            }
        }
    }
}
