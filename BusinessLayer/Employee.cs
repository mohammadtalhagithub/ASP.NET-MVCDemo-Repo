using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    /// <summary>
    /// A model class that exposes public properties which helps to map the values of the specific columns of the database.
    /// <para>For example : <code><strong>employee.ID= rdr["EmployeeID"].ToString();</strong></code></para>
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// public int property to map with "EmployeeID" column of the Database.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// public string property to map with "_name" column of the Database.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// public string property to map with "Gender" column of the Database.
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// public string property to map with "City" column of the Database.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// public DateTime property
        /// </summary>
        public DateTime DateOfBirth { get; set; }
    }
}
