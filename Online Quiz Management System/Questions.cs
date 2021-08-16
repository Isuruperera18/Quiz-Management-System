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
	public partial class Questions : Form
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
		public Questions()
		{
			InitializeComponent();
			con = new SqlConnection(path);
			display();

			pnlNav.Height = btnQu.Height;
			pnlNav.Top = btnQu.Top;
			pnlNav.Left = btnQu.Left;
			btnQu.BackColor = Color.FromArgb(205, 92, 92);
		}

		private void Questions_Load(object sender, EventArgs e)
		{
			fillcombo();
			fillcombo1();
		}

		private void btnQu_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnQu.Height;
			pnlNav.Top = btnQu.Top;
			pnlNav.Left = btnQu.Left;
			btnQu.BackColor = Color.FromArgb(205, 92, 92);
		}

		private void btnSub_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnSub.Height;
			pnlNav.Top = btnSub.Top;
			btnSub.BackColor = Color.FromArgb(205, 92, 92);

			Subjects s1 = new Subjects();
			s1.Show();
			this.Hide();
		}

		private void btnCan_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnCan.Height;
			pnlNav.Top = btnCan.Top;
			btnCan.BackColor = Color.FromArgb(205, 92, 92);

			Candidates c1 = new Candidates();
			c1.Show();
			this.Hide();
		}

		private void btnIns_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnIns.Height;
			pnlNav.Top = btnIns.Top;
			btnIns.BackColor = Color.FromArgb(205, 92, 92);

			Instructions i1 = new Instructions();
			i1.Show();
			this.Hide();
		}

		private void btnLog_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnLog.Height;
			pnlNav.Top = btnLog.Top;
			btnLog.BackColor = Color.FromArgb(205, 92, 92);

			AdminLogin a1 = new AdminLogin();
			a1.Show();
			this.Hide();
		}

		private void btnQu_Leave(object sender, EventArgs e)
		{
			btnQu.BackColor = Color.FromArgb(240,128,128);
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

		private void label9_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnRe_Click(object sender, EventArgs e)
		{
			pnlNav.Height = btnRe.Height;
			pnlNav.Top = btnRe.Top;
			btnRe.BackColor = Color.FromArgb(205, 92, 92);

			Results r1 = new Results();
			r1.Show();
			this.Hide();
		}

		private void btnRe_Leave(object sender, EventArgs e)
		{
			btnRe.BackColor = Color.FromArgb(240, 128, 128);
		}

		private void btnQueSave_Click(object sender, EventArgs e)
		{
			if (txtQues.Text == "" || txtOp1.Text == "" || txtOp2.Text == "" || txtOp3.Text == "" || txtOp4.Text == "" || txtAns.Text == "")
			{
				MessageBox.Show("Enter Required Fields");
			}
			else
			{
				try
				{
					con.Open();
					cmd = new SqlCommand("insert into Questions (Question,Option1,Option2,Option3,Option4,Answer,Module,Degree) values ('" + txtQues.Text + "','" + txtOp1.Text + "','" + txtOp2.Text + "','" + txtOp3.Text + "', '" + txtOp4.Text + "', '" + txtAns.Text + "','" + cbQueModule.SelectedValue.ToString() + "','" + cbQueDegree.SelectedValue.ToString() + "')", con);
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
			txtQues.Text = "";
			txtOp1.Text = "";
			txtOp2.Text = "";
			txtOp3.Text = "";
			txtOp4.Text = "";
			txtAns.Text = "";
		}

		public void display()
		{
			try
			{
				dt = new DataTable();
				con.Open();
				adpt = new SqlDataAdapter("select * from Questions", con);
				adpt.Fill(dt);
				DGV1.DataSource = dt;
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
				cmd = new SqlCommand("select Module from Modules", con);
				dr = cmd.ExecuteReader();
				dt = new DataTable();
				dt.Columns.Add("Module", typeof(string));
				dt.Load(dr);
				cbQueModule.ValueMember = "Module";
				cbQueModule.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void fillcombo1()
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
				cbQueDegree.ValueMember = "Degree_Name";
				cbQueDegree.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnQueUp_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtQues.Text == "" || txtOp1.Text == "" || txtOp2.Text == "" || txtOp3.Text == "" || txtOp4.Text == "" || txtAns.Text == "")
				{
					MessageBox.Show("Enter Required Fields");
				}
				else
				{
					con.Open();
					cmd = new SqlCommand("update Questions set Question='" + txtQues.Text + "' , Option1='" + txtOp1.Text + "', Option2='" + txtOp2.Text + "', Option3='" + txtOp3.Text + "', Option4='" + txtOp4.Text + "', Answer='" + txtAns.Text + "', Module='" + cbQueModule.SelectedValue.ToString() + "', Degree='" + cbQueDegree.SelectedValue.ToString() + "' where Question_ID= @QID ", con);
					cmd.Parameters.AddWithValue("@QID", ID);
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

		int ID = 0;
		private void Reset()
		{
			txtQues.Text = "";
			ID = 0;
		}

		private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			txtQues.Text = DGV1.SelectedRows[0].Cells[1].Value.ToString();
			txtOp1.Text = DGV1.SelectedRows[0].Cells[2].Value.ToString();
			txtOp2.Text = DGV1.SelectedRows[0].Cells[3].Value.ToString();
			txtOp3.Text = DGV1.SelectedRows[0].Cells[4].Value.ToString();
			txtOp4.Text = DGV1.SelectedRows[0].Cells[5].Value.ToString();
			txtAns.Text = DGV1.SelectedRows[0].Cells[6].Value.ToString();
			cbQueModule.SelectedValue = DGV1.SelectedRows[0].Cells[7].Value.ToString();
			cbQueDegree.SelectedValue = DGV1.SelectedRows[0].Cells[8].Value.ToString();
			if (txtQues.Text == "")
			{
				ID = 0;
			}
			else
			{
				ID = Convert.ToInt32(DGV1.SelectedRows[0].Cells[0].Value.ToString());
			}
		}

		private void btnQueDelete_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtQues.Text == "")
				{
					MessageBox.Show("Select the Question to Delete");
				}
				else
				{
					con.Open();
					cmd = new SqlCommand("delete from Questions where Question_ID= @QID ", con);
					cmd.Parameters.AddWithValue("@QID", ID);
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
	}
}
