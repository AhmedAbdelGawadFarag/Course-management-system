using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace upcourse
{
    public partial class trainerFormSearch : UserControl
    {
        public trainerFormSearch()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchPanel.Controls.Clear();
            SqlCommand Search = new SqlCommand("GetTraineeByname",Program.dbconnection);
            Search.CommandType = CommandType.StoredProcedure;
            Search.Parameters.AddWithValue("@firstName", SearchBox.Text.Substring(0,SearchBox.Text.IndexOf(' ')));
            Search.Parameters.AddWithValue("@lastName",SearchBox.Text.Substring(SearchBox.Text.IndexOf(' ') + 1));
          SqlDataReader data = Search.ExecuteReader();
            while (data.Read())
            {

                TraineePanel pnl = new TraineePanel(data.GetString(data.GetOrdinal("UserName")), data.GetString(data.GetOrdinal("FirstName")),
                data.GetString(data.GetOrdinal("LastName")), data.GetInt32(data.GetOrdinal("iD")), data.GetString(data.GetOrdinal("Email")),
                data.GetString(data.GetOrdinal("Gender")), data.GetString(data.GetOrdinal("Pass")), data.GetString(data.GetOrdinal("Qualification")), data.GetString(data.GetOrdinal("Phone")));
               

                SearchPanel.Controls.Add(pnl);
            }
            data.Close();
        }
    }
}
