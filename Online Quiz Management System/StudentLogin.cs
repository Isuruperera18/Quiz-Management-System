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
	public partial class StudentLogin : Form
	{
		string path = @"Data Source=LAPTOP-JNKLH8V1;Initial Catalog=QuizMSystem;Integrated Security=True";
		SqlConnection con;
		//SqlCommand cmd;
		SqlDataAdapter adpt;
		DataTable dt;
		//SqlDataReader dr;

		public StudentLogin()
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
			AdminLogin a1 = new AdminLogin();
			a1.Show();
			this.Hide();
		}

		public static string UniID = "", Module = "";

		private void btnIns_Click(object sender, EventArgs e)
		{
			StuInstructions s2 = new StuInstructions();
			s2.Show();
			this.Hide();
		}

		private void StudentLogin_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtUniID.Text == "" || txtUniPass.Text == "")
				{
					MessageBox.Show("Enter Required Fields");
				}
				else
				{
					if (cbModule.SelectedIndex > -1)
					{
						if (cbModule.SelectedItem.ToString() == "C# Development")
						{
							if (txtUniID.Text == "" || txtUniPass.Text == "")
							{
								MessageBox.Show("Enter Required Fields");
							}
							else
							{
								try
								{
									con.Open();
									adpt = new SqlDataAdapter("select Count(*) from Students where University_ID='" + txtUniID.Text + "' and Student_Password='" + txtUniPass.Text + "' ", con);
									dt = new DataTable();
									adpt.Fill(dt);

									if (dt.Rows[0][0].ToString() == "1")
									{
										UniID = txtUniID.Text;
										Module = cbModule.SelectedItem.ToString();
										Exams e1 = new Exams();
										e1.Show();
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
						else if (cbModule.SelectedItem.ToString() == "Java")
						{
							try
							{
								con.Open();
								adpt = new SqlDataAdapter("select Count(*) from Students where University_ID='" + txtUniID.Text + "' and Student_Password='" + txtUniPass.Text + "' ", con);
								dt = new DataTable();
								adpt.Fill(dt);

								if (dt.Rows[0][0].ToString() == "1")
								{
									UniID = txtUniID.Text;
									Module = cbModule.SelectedItem.ToString();
									JavaExam e2 = new JavaExam();
									e2.Show();
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
						else
						{
							try
							{
								con.Open();
								adpt = new SqlDataAdapter("select Count(*) from Students where University_ID='" + txtUniID.Text + "' and Student_Password='" + txtUniPass.Text + "' ", con);
								dt = new DataTable();
								adpt.Fill(dt);

								if (dt.Rows[0][0].ToString() == "1")
								{
									CyberExam e3 = new CyberExam();
									e3.Show();
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
					else
					{
						MessageBox.Show("Select a Module");
					}
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
