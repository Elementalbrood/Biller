/*
 * Created by SharpDevelop.
 * User: Elemental
 * Date: 1/28/2013
 * Time: 2:24 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Biller
{
	
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
		
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			amountDueMonth.Clear();
			amountDueMonth.Text = "" + backgroundstooof(4, 10);
			
			
			
			//progressBar1.dostuff();
			progressBar1.PerformStep();
			
			//monthCalendar1.
			
		}
		
		
		public int backgroundstooof(int a, int b)
		{
			return a + b;
		}

		void BillToolStripMenuItemClick(object sender, EventArgs e)
		{
			AddBill k = new AddBill();
			k.ShowDialog();
		}
		
		void Bill_List_Click(object sender, EventArgs e)
		{
			ListBills b = new ListBills();
			b.ShowDialog();
		}
		
		void ProgressBar1Click(object sender, EventArgs e)
		{
			
		}
		
		void BillerCalendarDateChanged(object sender, DateRangeEventArgs e)
		{
			
		}
	}
}
