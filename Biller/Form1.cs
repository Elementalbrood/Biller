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
			//Add usb stuuuf login stuff ya
			
			textbox_amountDueMonth.Text = "" + getMonthlyBills();
		}
		
		public double getMonthlyBills()
		{
			//System.DateTime;
		
			double current_month = 0;
			
			DateTime current = DateTime.Now;
			
			System.Diagnostics.Debug.WriteLine(current);
			//TODO make less stupid loop
			foreach(Bill b in Data._bills)
			{	
				if(current.Month == b.getDate().Month)
				{
					current_month += b.getBalance();
				}
			}
			
			return current_month;
		}
		
		//TODO: still deciding on what to do about wheatly stuff
		public double getWeeklyBills()
		{
			double current_week = 0;
			
			DateTime current = DateTime.Now;
			
			System.Diagnostics.Debug.WriteLine(current);
			//TODO make less stupid loop
			foreach(Bill b in Data._bills)
			{	
				//if(current. == b.getDate().Week)
				//{
				//	current_week += b.getBalance();
				//}
			}
			
			return current_week;
		}
		
		public double getBillsByDate(DateTime e)
		{
			double current_due = 0;
			
			DateTime current = DateTime.Now;
			
			System.Diagnostics.Debug.WriteLine(current);
			//TODO make less stupid loop
			foreach(Bill b in Data._bills)
			{	
				if(b.getDate().Day <= e.Day && b.getDate().Day >= current.Day)
				{
					current_due += b.getBalance();
				}
			}
			
			return current_due;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			progressBar1.PerformStep();
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
		
		void Button_refreshClick(object sender, EventArgs e)
		{
			textbox_amountDueMonth.Text = "" + getMonthlyBills();
		}
		
		void BillerCalendarDateSelected(object sender, DateRangeEventArgs e)
		{
			//TODO: fix later
			textbox_amountDueMonth.Text = "" + getMonthlyBills();
			textbox_amountDueByDate.Text = "" + getBillsByDate(e.End);
		}
	}
}
