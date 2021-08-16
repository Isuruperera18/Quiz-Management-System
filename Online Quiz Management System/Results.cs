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
using System.Runtime.InteropServices;

namespace Online_Quiz_Management_System
{
	public partial class Results : Form
	{
		string path = @"Data Source=LAPTOP-JNKLH8V1;Initial Catalog=QuizMSystem;Integrated Security=True";
		SqlConnection con;
		SqlCommand cmd;
		SqlDataAdapter adpt;
		DataTable dt;
		SqlDataReader dr;

		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

		private static extern IntPtr CreateRoundRectRgn
		 (
			  int nLeftRect,
			  int nTopRect,
			  int nRightRect,
			  int nBottomRect,
			  int nWidthEllipse,
			  int nHeightEllipse

		  );

		public Results()
		{
			InitializeComponent();
			con = new SqlConnection(path);
			display();

			pnlNav.Height = btnRe.Height;
			pnlNav.Top = btnRe.Top;
			pnlNav.Left = btnRe.Left;
			btnRe.BackColor = Color.FromArgb(205, 92, 92);
		}

		private void btnQu_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnQu.Height;
			pnlNav.Top = btnQu.Top;
			btnQu.BackColor = Color.FromArgb(205, 92, 92);

			Questions q3 = new Questions();
			q3.Show();
			this.Hide();
		}

		private void Results_Load(object sender, EventArgs e)
		{
			fillcombo();
			fillcombo1();
		}

		private void btnSub_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnSub.Height;
			pnlNav.Top = btnSub.Top;
			btnSub.BackColor = Color.FromArgb(205, 92, 92);

			Subjects s3 = new Subjects();
			s3.Show();
			this.Hide();
		}

		private void btnCan_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnCan.Height;
			pnlNav.Top = btnCan.Top;
			btnCan.BackColor = Color.FromArgb(205, 92, 92);

			Candidates c3 = new Candidates();
			c3.Show();
			this.Hide();
		}

		private void btnRe_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnRe.Height;
			pnlNav.Top = btnRe.Top;
			pnlNav.Left = btnRe.Left;
			btnRe.BackColor = Color.FromArgb(205, 92, 92);
		}

		private void btnIns_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnIns.Height;
			pnlNav.Top = btnIns.Top;
			btnIns.BackColor = Color.FromArgb(205, 92, 92);

			Instructions i3 = new Instructions();
			i3.Show();
			this.Hide();
		}

		private void btnLog_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnLog.Height;
			pnlNav.Top = btnLog.Top;
			btnLog.BackColor = Color.FromArgb(205, 92, 92);

			AdminLogin a3 = new AdminLogin();
			a3.Show();
			this.Hide();
		}

		private void label2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnQu_Leave(object sender, EventArgs e)
		{
			btnQu.BackColor = Color.FromArgb(240, 128, 128);
		}

		private void btnSub_Leave(object sender, EventArgs e)
		{
			btnSub.BackColor = Color.FromArgb(240, 128, 128);
		}

		private void btnCan_Leave(object sender, EventArgs e)
		{
			btnCan.BackColor = Color.FromArgb(240, 128, 128);
		}

		private void btnRe_Leave(object sender, EventArgs e)
		{
			btnRe.BackColor = Color.FromArgb(240, 128, 128);
		}

		private void btnIns_Leave(object sender, EventArgs e)
		{
			btnIns.BackColor = Color.FromArgb(240, 128, 128);
		}

		private void btnLog_Leave(object sender, EventArgs e)
		{
			btnLog.BackColor = Color.FromArgb(240, 128, 128);
		}

		public void display()
		{
			try
			{
				dt = new DataTable();
				con.Open();
				adpt = new SqlDataAdapter("select * from Results", con);
				adpt.Fill(dt);
				DGV4.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void fillcombo()
		{
			try
			{
				//This method will bind the combobox with the Database
				con.Open();
				cmd = new SqlCommand("select Degree_Name from DegreePrograms", con);
				dr = cmd.ExecuteReader();
				dt = new DataTable();
				dt.Columns.Add("Degree_Name", typeof(string));
				dt.Load(dr);
				cbReDegree.ValueMember = "Degree_Name";
				cbReDegree.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void fillcombo1()
		{
			//This method will bind the combobox with the Database
			con.Open();
			cmd = new SqlCommand("select Module from Modules", con);
			dr = cmd.ExecuteReader();
			dt = new DataTable();
			dt.Columns.Add("Module", typeof(string));
			dt.Load(dr);
			cbReModule.ValueMember = "Module";
			cbReModule.DataSource = dt;
			con.Close();
		}

		private void cbReDegree_SelectionChangeCommitted(object sender, EventArgs e)
		{
			try
			{
				dt = new DataTable();
				con.Open();
				adpt = new SqlDataAdapter("select * from Students where Degree='" + cbReDegree.SelectedValue.ToString() + "' ", con);
				adpt.Fill(dt);
				DGV4.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void cbReModule_SelectionChangeCommitted(object sender, EventArgs e)
		{
			try
			{
				dt = new DataTable();
				con.Open();
				adpt = new SqlDataAdapter("select * from Results where Module='" + cbReModule.SelectedValue.ToString() + "' ", con);
				adpt.Fill(dt);
				DGV4.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
