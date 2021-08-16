using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Online_Quiz_Management_System
{
	public partial class AdminLogin : Form
	{

		string path = @"Data Source=LAPTOP-JNKLH8V1;Initial Catalog=QuizMSystem;Integrated Security=True";
		SqlConnection con;
		SqlDataAdapter adpt;
		DataTable dt;

		public AdminLogin()
		{
			InitializeComponent();
			con = new SqlConnection(path);
		}

		private void label9_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void label8_Click(object sender, EventArgs e)
		{
			StudentLogin u1 = new StudentLogin();
			u1.Show();
			this.Hide();
		}

		private void label9_Click_1(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				con.Open();
				adpt = new SqlDataAdapter("select Count(*) from Admins where Admin_ID='" + txtAdminID.Text + "' and Admin_Password='" + txtAdminPass.Text + "' ", con);
				dt = new DataTable();
				adpt.Fill(dt);

				if (dt.Rows[0][0].ToString() == "1")
				{
					Questions q5 = new Questions();
					q5.Show();
					this.Hide();
				}
				else
				{
					MessageBox.Show("Enter Correct Cerdentials");
				}
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
