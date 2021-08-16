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

	public partial class Subjects : Form
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

		public Subjects()
		{
			InitializeComponent();
			con = new SqlConnection(path);
			display();

			pnlNav.Height = btnSub.Height;
			pnlNav.Top = btnSub.Top;
			pnlNav.Left = btnSub.Left;
			btnSub.BackColor = Color.FromArgb(205, 92, 92);
		}

		private void btnQu_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnQu.Height;
			pnlNav.Top = btnQu.Top;
			btnQu.BackColor = Color.FromArgb(205, 92, 92);

			Questions q4 = new Questions();
			q4.Show();
			this.Hide();
		}

		private void Subjects_Load(object sender, EventArgs e)
		{
			fillcombo();
		}

		private void btnSub_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnSub.Height;
			pnlNav.Top = btnSub.Top;
			pnlNav.Left = btnSub.Left;
			btnSub.BackColor = Color.FromArgb(205, 92, 92);
		}

		private void btnCan_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnCan.Height;
			pnlNav.Top = btnCan.Top;
			btnCan.BackColor = Color.FromArgb(205, 92, 92);

			Candidates c4 = new Candidates();
			c4.Show();
			this.Hide();
		}

		private void btnIns_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnIns.Height;
			pnlNav.Top = btnIns.Top;
			btnIns.BackColor = Color.FromArgb(205, 92, 92);

			Instructions i4 = new Instructions();
			i4.Show();
			this.Hide();
		}

		private void btnLog_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnLog.Height;
			pnlNav.Top = btnLog.Top;
			btnLog.BackColor = Color.FromArgb(205, 92, 92);

			AdminLogin a4 = new AdminLogin();
			a4.Show();
			this.Hide();
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

		private void btnIns_Leave(object sender, EventArgs e)
		{
			btnIns.BackColor = Color.FromArgb(240, 128, 128);
		}

		private void btnLog_Leave(object sender, EventArgs e)
		{
			btnLog.BackColor = Color.FromArgb(240, 128, 128);
		}

		private void label9_Click_1(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnRe_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnRe.Height;
			pnlNav.Top = btnRe.Top;
			btnRe.BackColor = Color.FromArgb(205, 92, 92);

			Results r4 = new Results();
			r4.Show();
			this.Hide();
		}

		private void btnRe_Leave(object sender, EventArgs e)
		{
			btnRe.BackColor = Color.FromArgb(240, 128, 128);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (txtMCode.Text == "" || txtModule.Text == "" || txtDegree.Text == "")
			{
				MessageBox.Show("Enter Required Fields");
			}
			else
			{
				try
				{
					con.Open();
					cmd = new SqlCommand("insert into Modules (Module_Code,Module,Degree) values ('" + txtMCode.Text + "','" + txtModule.Text + "','" + txtDegree.Text + "')", con);
					cmd.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("Data has been saved");
					clear();
					display();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		public void clear()
		{
			txtMCode.Text = "";
			txtModule.Text = "";
			txtDegree.Text = "";
		}

		public void display()
		{
			try
			{
				dt = new DataTable();
				con.Open();
				adpt = new SqlDataAdapter("select * from Modules", con);
				adpt.Fill(dt);
				DGV3.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtMCode.Text == "" || txtModule.Text == "" || txtDegree.Text == "")
				{
					MessageBox.Show("Enter Required Fields");
				}
				else
				{
					con.Open();
					cmd = new SqlCommand("update Modules set Module='" + txtModule.Text + "' , Degree='" + txtDegree.Text + "' where Module_Code='" + txtMCode.Text + "' ", con);
					cmd.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("Data has been updated");
					clear();
					display();
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtMCode.Text == "")
				{
					MessageBox.Show("Select the Module to Delete");
				}
				else
				{
					con.Open();
					cmd = new SqlCommand("delete from Modules where Module_Code='" + txtMCode.Text + "' ", con);
					cmd.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("Data has been deleted");
					clear();
					display();
				}

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
				cbModDegree.ValueMember = "Degree_Name";
				cbModDegree.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void cbModDegree_SelectionChangeCommitted(object sender, EventArgs e)
		{
			try
			{
				dt = new DataTable();
				con.Open();
				adpt = new SqlDataAdapter("select * from Modules where Degree='" + cbModDegree.SelectedValue.ToString() + "' ", con);
				adpt.Fill(dt);
				DGV3.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void label4_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			display();
		}

		private void DGV3_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			txtMCode.Text = DGV3.SelectedRows[0].Cells[1].Value.ToString();
			txtModule.Text = DGV3.SelectedRows[0].Cells[2].Value.ToString();
			txtDegree.Text = DGV3.SelectedRows[0].Cells[3].Value.ToString();
		}
	}
}
