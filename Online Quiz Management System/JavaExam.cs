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
	public partial class JavaExam : Form
	{

		string path = @"Data Source=LAPTOP-JNKLH8V1;Initial Catalog=QuizMSystem;Integrated Security=True";
		SqlConnection con;
		SqlCommand cmd;
		SqlDataAdapter adpt;
		DataTable dt;
		//SqlDataReader dr;

		public JavaExam()
		{
			InitializeComponent();
			con = new SqlConnection(path);
			//multirandom();
			FetchQuestions();
			lblUniID.Text = StudentLogin.UniID;
			lblModule.Text = StudentLogin.Module;
		}

		private void JavaExam_Load(object sender, EventArgs e)
		{
			timer1.Start();
		}

		string[] Ua = new string[10];

		private void label9_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		string A1, A2, A3, A4, A5, A6;

		private void Q1Op2_CheckedChanged(object sender, EventArgs e)
		{
			//Ua[0] = Q1Op2.Text;
			//MessageBox.Show("Selected Answer is" + Ua[0]);
		}

		private void Q1Op1_CheckedChanged(object sender, EventArgs e)
		{
			//Ua[0] = Q1Op1.Text;
			//MessageBox.Show("Selected Answer is" + Ua[0]);
		}

		int Chrono = 350;
		int Count = 0;

		int Score = 0;

		private void checkQ1()
		{
			if (Q1Op1.Checked)
			{
				Ua[0] = "";
				Ua[0] = Q1Op1.Text;
			}
			else if (Q1Op2.Checked)
			{
				Ua[0] = "";
				Ua[0] = Q1Op2.Text;
			}
			else if (Q1Op3.Checked)
			{
				Ua[0] = "";
				Ua[0] = Q1Op3.Text;
			}
			else if (Q1Op4.Checked)
			{
				Ua[0] = "";
				Ua[0] = Q1Op4.Text;
			}
			if (Ua[0] == A1)
			{
				Score = Score + 1;
			}
			else
			{
				Score = Score;
			}
		}

		private void checkQ2()
		{
			if (Q2Op1.Checked)
			{
				Ua[1] = "";
				Ua[1] = Q2Op1.Text;
			}
			else if (Q2Op2.Checked)
			{
				Ua[1] = "";
				Ua[1] = Q2Op2.Text;
			}
			else if (Q2Op3.Checked)
			{
				Ua[1] = "";
				Ua[1] = Q2Op3.Text;
			}
			else if (Q2Op4.Checked)
			{
				Ua[1] = "";
				Ua[1] = Q2Op4.Text;
			}
			if (Ua[1] == A2)
			{
				Score = Score + 1;
			}
			else
			{
				//Score = Score;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Score = 0;
			checkQ1();
			checkQ2();
			checkQ3();
			checkQ4();
			checkQ5();
			checkQ6();
			MessageBox.Show("" + Score);

			StudentLogin u3 = new StudentLogin();
			u3.Show();
			this.Hide();

			InsertResults();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			Chrono -= 1;
			Count += 1;
			timingbar.Value = Count;
			lbltime.Text = "" + Chrono;
			if (timingbar.Value == 350)
			{
				timingbar.Value = 0;
				timer1.Stop();
				MessageBox.Show("Time Over");
				StudentLogin u1 = new StudentLogin();
				u1.Show();
				this.Hide();
			}
		}

		private void checkQ3()
		{
			if (Q3Op1.Checked)
			{
				Ua[2] = "";
				Ua[2] = Q3Op1.Text;
			}
			else if (Q3Op2.Checked)
			{
				Ua[2] = "";
				Ua[2] = Q3Op2.Text;
			}
			else if (Q3Op3.Checked)
			{
				Ua[2] = "";
				Ua[2] = Q3Op3.Text;
			}
			else if (Q3Op4.Checked)
			{
				Ua[2] = "";
				Ua[2] = Q3Op4.Text;
			}
			if (Ua[2] == A3)
			{
				Score = Score + 1;
			}
			else
			{
				//Score = Score;
			}
		}

		private void checkQ4()
		{
			if (Q4Op1.Checked)
			{
				Ua[3] = "";
				Ua[3] = Q4Op1.Text;
			}
			else if (Q4Op2.Checked)
			{
				Ua[3] = "";
				Ua[3] = Q4Op2.Text;
			}
			else if (Q4Op3.Checked)
			{
				Ua[3] = "";
				Ua[3] = Q4Op3.Text;
			}
			else if (Q4Op4.Checked)
			{
				Ua[3] = "";
				Ua[3] = Q4Op4.Text;
			}
			if (Ua[3] == A4)
			{
				Score = Score + 1;
			}
			else
			{
				//Score = Score;
			}
		}

		private void checkQ5()
		{
			if (Q5Op1.Checked)
			{
				Ua[4] = "";
				Ua[4] = Q5Op1.Text;
			}
			else if (Q5Op2.Checked)
			{
				Ua[4] = "";
				Ua[4] = Q5Op2.Text;
			}
			else if (Q5Op3.Checked)
			{
				Ua[4] = "";
				Ua[4] = Q5Op3.Text;
			}
			else if (Q5Op4.Checked)
			{
				Ua[4] = "";
				Ua[4] = Q5Op4.Text;
			}
			if (Ua[4] == A5)
			{
				Score = Score + 1;
			}
			else
			{
				//Score = Score;
			}
		}

		private void checkQ6()
		{
			if (Q6Op1.Checked)
			{
				Ua[5] = "";
				Ua[5] = Q6Op1.Text;
			}
			else if (Q6Op2.Checked)
			{
				Ua[5] = "";
				Ua[5] = Q6Op2.Text;
			}
			else if (Q6Op3.Checked)
			{
				Ua[5] = "";
				Ua[5] = Q6Op3.Text;
			}
			else if (Q6Op4.Checked)
			{
				Ua[5] = "";
				Ua[5] = Q6Op4.Text;
			}
			if (Ua[5] == A6)
			{
				Score = Score + 1;
			}
			else
			{
				//Score = Score;
			}
		}

		private void InsertResults()
		{
			try
			{
				con.Open();
				cmd = new SqlCommand("insert into Results (Student_ID,Module,Date,Time,Marks) values ('" + lblUniID.Text + "','" + lblModule.Text + "','" + QDate.Value.Date + "','" + QTime.Text + "', '" + Score + "')", con);
				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Data has been saved");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private int GenerateRand()
		{
			Random rd = new Random();
			int x = rd.Next(11, 21);
			int y = rd.Next(11, 21);
			int z = rd.Next(11, 21);
			MessageBox.Show("" + x + "and" + y + "and" + z);
			return x;
		}
		/*
		private void Shufle()
		{
			var rnd = new Random();
		}*/

		int[] Keys = new int[10];

		private void multirandom()
		{
			HashSet<int> numbers = new HashSet<int>();
			var rnd = new Random();
			while (numbers.Count < 6)
			{
				numbers.Add(rnd.Next(11, 21));
			}
			for (int i = 0; i < 6; i++)
			{
				Keys[i] = numbers.ElementAt(i);
			}
			/*for (int y=0;y<6;y++)
			{
			     MessageBox.Show("" + Keys[y]);
			}*/
		}


		private void FetchQuestions()
		{
			try
			{
				//int Qnum = GenerateRand();
				multirandom();
				dt = new DataTable();
				con.Open();
				string Query = "select * from Questions where Question_ID=" + Keys[0] + " ";
				cmd = new SqlCommand(Query, con);
				adpt = new SqlDataAdapter(cmd);
				adpt.Fill(dt);
				foreach (DataRow dr in dt.Rows)
				{
					gb1.Text = dr["Question"].ToString();
					Q1Op1.Text = dr["Option1"].ToString();
					Q1Op2.Text = dr["Option2"].ToString();
					Q1Op3.Text = dr["Option3"].ToString();
					Q1Op4.Text = dr["Option4"].ToString();
					A1 = dr["Answer"].ToString();
				}

				string Query1 = "select * from Questions where Question_ID=" + Keys[1] + " ";
				cmd = new SqlCommand(Query1, con);
				adpt = new SqlDataAdapter(cmd);
				adpt.Fill(dt);
				foreach (DataRow dr in dt.Rows)
				{
					gb2.Text = dr["Question"].ToString();
					Q2Op1.Text = dr["Option1"].ToString();
					Q2Op2.Text = dr["Option2"].ToString();
					Q2Op3.Text = dr["Option3"].ToString();
					Q2Op4.Text = dr["Option4"].ToString();
					A2 = dr["Answer"].ToString();
				}

				string Query2 = "select * from Questions where Question_ID=" + Keys[2] + " ";
				cmd = new SqlCommand(Query2, con);
				adpt = new SqlDataAdapter(cmd);
				adpt.Fill(dt);
				foreach (DataRow dr in dt.Rows)
				{
					gb3.Text = dr["Question"].ToString();
					Q3Op1.Text = dr["Option1"].ToString();
					Q3Op2.Text = dr["Option2"].ToString();
					Q3Op3.Text = dr["Option3"].ToString();
					Q3Op4.Text = dr["Option4"].ToString();
					A3 = dr["Answer"].ToString();
				}

				string Query3 = "select * from Questions where Question_ID=" + Keys[3] + " ";
				cmd = new SqlCommand(Query3, con);
				adpt = new SqlDataAdapter(cmd);
				adpt.Fill(dt);
				foreach (DataRow dr in dt.Rows)
				{
					gb4.Text = dr["Question"].ToString();
					Q4Op1.Text = dr["Option1"].ToString();
					Q4Op2.Text = dr["Option2"].ToString();
					Q4Op3.Text = dr["Option3"].ToString();
					Q4Op4.Text = dr["Option4"].ToString();
					A4 = dr["Answer"].ToString();
				}

				string Query4 = "select * from Questions where Question_ID=" + Keys[4] + " ";
				cmd = new SqlCommand(Query4, con);
				adpt = new SqlDataAdapter(cmd);
				adpt.Fill(dt);
				foreach (DataRow dr in dt.Rows)
				{
					gb5.Text = dr["Question"].ToString();
					Q5Op1.Text = dr["Option1"].ToString();
					Q5Op2.Text = dr["Option2"].ToString();
					Q5Op3.Text = dr["Option3"].ToString();
					Q5Op4.Text = dr["Option4"].ToString();
					A5 = dr["Answer"].ToString();
				}

				string Query5 = "select * from Questions where Question_ID=" + Keys[5] + " ";
				cmd = new SqlCommand(Query5, con);
				adpt = new SqlDataAdapter(cmd);
				adpt.Fill(dt);
				foreach (DataRow dr in dt.Rows)
				{
					gb6.Text = dr["Question"].ToString();
					Q6Op1.Text = dr["Option1"].ToString();
					Q6Op2.Text = dr["Option2"].ToString();
					Q6Op3.Text = dr["Option3"].ToString();
					Q6Op4.Text = dr["Option4"].ToString();
					A6 = dr["Answer"].ToString();
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
