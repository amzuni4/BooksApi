﻿using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			System.DateTime firstDate = new System.DateTime(2000, 01, 01);
			System.DateTime secondDate = new System.DateTime(2000, 05, 31);

			System.TimeSpan diff = secondDate.Subtract(firstDate);
			System.TimeSpan diff1 = secondDate - firstDate;

			String diff2 = (secondDate - firstDate).TotalDays.ToString();

			MessageBox.Show(diff1.ToString());
		}
	}
}