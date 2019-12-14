using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace upcourse
{
    static class Program
    {
        public static
           //    string databaseString = "Data Source=DESKTOP-KHVRBGT\\SQLEXPRESS;Initial Catalog=Course Mangment System;Integrated Security=True";
        //string databaseString = "Data Source=LAPCOM\\SQLS;Initial Catalog=Course Mangment System.bacpac;Integrated Security=True";
        string databaseString = "Server =(local);Database=Course Mangment System.bacpac;Trusted_Connection=True;";
     public static SqlConnection dbconnection = new SqlConnection(databaseString);
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            try
            {
                dbconnection.Open();
                MessageBox.Show("Connection Open to database  ! ");
               
            }
            catch (Exception )
            {
                
                MessageBox.Show("Can not open connection to database ! ");
            }
        

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Program.dbconnection.Close();
        }
    }
}
