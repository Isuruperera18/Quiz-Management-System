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
	public partial class Candidates : Form
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

		public Candidates()
		{
			InitializeComponent();
			con = new SqlConnection(path);
			display();

			pnlNav.Height = btnCan.Height;
			pnlNav.Top = btnCan.Top;
			pnlNav.Left = btnCan.Left;
			btnCan.BackColor = Color.FromArgb(205, 92, 92);
		}

		private void label9_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Candidates_Load(object sender, EventArgs e)
		{
			fillcombo();
			fillcombo1();
		}

		private void btnQu_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnQu.Height;
			pnlNav.Top = btnQu.Top;
			btnQu.BackColor = Color.FromArgb(205, 92, 92);

			Questions q2 = new Questions();
			q2.Show();
			this.Hide();
		}

		private void btnSub_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnSub.Height;
			pnlNav.Top = btnSub.Top;
			btnSub.BackColor = Color.FromArgb(205, 92, 92);

			Subjects s2 = new Subjects();
			s2.Show();
			this.Hide();
		}

		private void btnCan_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnCan.Height;
			pnlNav.Top = btnCan.Top;
			pnlNav.Left = btnCan.Left;
			btnCan.BackColor = Color.FromArgb(205, 92, 92);
		}

		private void btnIns_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnIns.Height;
			pnlNav.Top = btnIns.Top;
			btnIns.BackColor = Color.FromArgb(205, 92, 92);

			Instructions i2 = new Instructions();
			i2.Show();
			this.Hide();
		}

		private void btnLog_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnLog.Height;
			pnlNav.Top = btnLog.Top;
			btnLog.BackColor = Color.FromArgb(205, 92, 92);

			AdminLogin a2 = new AdminLogin();
			a2.Show();
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

		private void btnRe_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnRe.Height;
			pnlNav.Top = btnRe.Top;
			btnRe.BackColor = Color.FromArgb(205, 92, 92);

			Results r2 = new Results();
			r2.Show();
			this.Hide();
		}

		private void btnRe_Leave(object sender, EventArgs e)
		{
			btnRe.BackColor = Color.FromArgb(240, 128, 128);
		}

		private void btnCanSave_Click(object sender, EventArgs e)
		{
			if (txtUniID.Text == "" || txtName.Text == "" || txtDegree.Text == "" || txtBatch.Text == "" || txtPassword.Text == "")
			{
				MessageBox.Show("Enter Required Fields");
			}
			else
			{
				try
				{
					con.Open();
					cmd = new SqlCommand("insert into Students (University_ID,Full_Name,Degree,Batch,Student_Password) values ('" + txtUniID.Text + "','" + txtName.Text + "','" + txtDegree.Text + "','" + txtBatch.Text + "', '" + txtPassword.Text + "')", con);
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
			txtUniID.Text = "";
			txtName.Text = "";
			txtDegree.Text = "";
			txtBatch.Text = "";
			txtPassword.Text = "";
		}

		public void display()
		{
			try
			{
				dt = new DataTable();
				con.Open();
				adpt = new SqlDataAdapter("select * from Students", con);
				adpt.Fill(dt);
				DGV2.DataSource = dt;
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
				cbCanDegree.ValueMember = "Degree_Name";
				cbCanDegree.DataSource = dt;
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
			cmd = new SqlCommand("select Batch from Batch", con);
			dr = cmd.ExecuteReader();
			dt = new DataTable();
			dt.Columns.Add("Batch", typeof(string));
			dt.Load(dr);
			cbCanBatch.ValueMember = "Batch";
			cbCanBatch.DataSource = dt;
			con.Close();
		}

		private void cbCanDegree_SelectionChangeCommitted(object sender, EventArgs e)
		{
			try
			{
				dt = new DataTable();
				con.Open();
				adpt = new SqlDataAdapter("select * from Students where Degree='" + cbCanDegree.SelectedValue.ToString() + "' ", con);
				adpt.Fill(dt);
				DGV2.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void cbCanBatch_SelectionChangeCommitted(object sender, EventArgs e)
		{
			try
			{
				dt = new DataTable();
				con.Open();
				adpt = new SqlDataAdapter("select * from Students where Batch='" + cbCanBatch.SelectedValue.ToString() + "' ", con);
				adpt.Fill(dt);
				DGV2.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			display();
		}

		private void btnCanUp_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtUniID.Text == "" || txtName.Text == "" || txtDegree.Text == "" || txtBatch.Text == "" || txtPassword.Text == "")
				{
					MessageBox.Show("Enter Required Fields");
				}
				else
				{
					con.Open();
					cmd = new SqlCommand("update Studnets set Full_Name='" + txtName.Text + "' , Degree='" + txtDegree.Text + "', Batch='" + txtBatch.Text + "', Student_Password='" + txtPassword.Text + "' where University_ID='" + txtUniID.Text + "' ", con);
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

		private void btnCanDelete_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtUniID.Text == "")
				{
					MessageBox.Show("Select the Student to Delete");
				}
				else
				{
					con.Open();
					cmd = new SqlCommand("delete from Students where University_ID='" + txtUniID.Text + "' ", con);
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

		private void DGV2_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			txtUniID.Text = DGV2.SelectedRows[0].Cells[1].Value.ToString();
			txtName.Text = DGV2.SelectedRows[0].Cells[2].Value.ToString();
			txtDegree.Text = DGV2.SelectedRows[0].Cells[3].Value.ToString();
			txtBatch.Text = DGV2.SelectedRows[0].Cells[4].Value.ToString();
			txtPassword.Text = DGV2.SelectedRows[0].Cells[5].Value.ToString();
		}

		private void label9_Click_1(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
