using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Star
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			starslabel.Text = string.Empty;
		}

		private void Generationbutton_Click(object sender, EventArgs e)
		{
			int rows = 0;
			try
			{
				rows = GetRows();
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			string stars=Generationstar(rows);
			DisplayStar(stars);
		}
		private void DisplayStar(string stars)
		{
			resulttext.Text = stars;
			starslabel.Text = stars;
		}
		private void symetrybutton_Click(object sender, EventArgs e)
		{
			int rows = 0;
			try
			{
				rows = GetRows();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			string stars = Symetrystar(rows);
			DisplayStar(stars);

		}

		private void rightbutton_Click(object sender, EventArgs e)
		{
			int rows = 0;
			try
			{
				rows = GetRows();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			string stars = Rightstar(rows);
			DisplayStar(stars);
		}
		private int GetRows()
		{
			string input = rowstext.Text;
			bool isInt = int.TryParse(input, out int rows);
			if( isInt==false)
			{
				throw new Exception("您沒有輸入列數");
			}
			if(rows<1||rows>10)
			{
				throw new Exception("列數需介於1~10間");
			}
			return rows;
		}
		private string Generationstar(int rows)
		{
			string result = string.Empty;
			for (int i = 1; i <= rows; i++)
			{
				result += new string('*', i) + "\r\n";
			}
			return result;
		}
		private string Rightstar(int rows)
		{
			string result = string.Empty;
			for (int i = 1; i <= rows; i++)
			{
				int space = rows - i;
				result += new string(' ', 2*space) + new string('*', i) + "\r\n";
			}
			return result;
		}
		private string Symetrystar(int rows)
		{
			string result = string.Empty;
			for (int i = 1; i <= rows; i++)
			{
				int space = rows -i;
				result += new string(' ',2*space) + new string('*', 2 * i - 1) + "\r\n";
				//.PadLeft 
			}
			return result;
		}
	}
}
