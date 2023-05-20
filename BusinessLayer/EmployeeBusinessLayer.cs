using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text.Json;

namespace BusinessLayer
{
    /// <summary>
    /// A custom class representing business logic for data access layer.
    /// <para></para>
    /// <returns></returns>
    /// <value>Value</value>
    /// </summary>
    public class EmployeeBusinessLayer
    {
        /// <summary>
        /// Public property of <code>IEnumerable</code>  Interface.<para></para>
        /// <returns>Returns List of Type/class Employee with variable employees</returns>
        /// <para></para>
        /// <value>Value</value>
        /// <para></para>
        /// <seealso cref="See also"/>
        /// <para></para>
        /// </summary>
        public IEnumerable<Employee> Employees
        {
            get
            {
                //string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString; // XML

                //string JsonText = File.ReadAllText(@"./ConfigJSON.json"); //JSON
                //ConfigClass JsonToObj = JsonSerializer.Deserialize<ConfigClass>(JsonText); // JSON
                //string connectionString = JsonToObj.ConnectionString; // JSON

                string connectionString = "data source=TALHA\\SQLEXPRESS; database=HRDB; user id=ssms; password=password";
                // integrated security=SSPI

                List<Employee> employees = new List<Employee>();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spGetAllEmployees", connection);
                    cmd.CommandType = CommandType.StoredProcedure; // spGetAllEmployees is not a Query, but a stored procedure.
                    connection.Open();
                    SqlDataReader rdr = cmd.ExecuteReader(); // execute the command cmd.

                    while (rdr.Read()) // loop through each row that we get back from Database
                    {
                        // convert each row into an employee object
                        Employee employee = new Employee();
                        // Model Class Properties = Database Column Names
                        employee.ID = Convert.ToInt32(rdr["EmployeeID"]); // EmployeeID is the column in database
                        employee.Name= rdr["_name"].ToString();
                        employee.Gender = rdr["Gender"].ToString();
                        employee.City = rdr["City"].ToString();
                        
                        //employee.DateOfBirth = rdr["Name"].ToString();

                        employees.Add(employee);

                    }
                }
                return employees;

            }
        }
    }
}
