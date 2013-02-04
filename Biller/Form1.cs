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
			//Add usb stuuuf login stuff ya
			
			textbox_amountDueMonth.Text = "" + getMonthlyBills();
			
			/*
			DateTime currentDate = DateTime.Today;
			DateTime notCurrent = DateTime.Today.AddMonths(6);
			
			System.Diagnostics.Debug.WriteLine("CurrentDate = {0} notCurrent = {1}", currentDate, notCurrent);
			System.Diagnostics.Debug.WriteLine("CurrentDate == notCurrent : {0}", currentDate == notCurrent);
			System.Diagnostics.Debug.WriteLine("CurrentDate < notCurrent : {0}", currentDate < notCurrent);
			System.Diagnostics.Debug.WriteLine("CurrentDate > notCurrent : {0}", currentDate > notCurrent);
			*/
			
		}
		
		public double getMonthlyBills()
		{
			//System.DateTime;
		
			double current_month = 0;
			
			DateTime current = DateTime.Now;
			
			System.Diagnostics.Debug.WriteLine(current);
			
			foreach(Bill b in Data._bills)
			{	
				if(current.Month == b.DueDate.Month)
				{
					current_month += b.Balance;
				}
			}
			
			return current_month;
		}
		
		//TODO still deciding on what to do about wheatly stuff
		public double getWeeklyBills()
		{
			double current_week = 0;
			
			DateTime current = DateTime.Now;
			
			System.Diagnostics.Debug.WriteLine(current);
			
			//TODO: NEED?: make less stupid loop
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
			
			//TODO: UTILITIES: make less stupid loop
			foreach(Bill b in Data._bills)
			{	
				if(b.DueDate.Day <= e.Day && b.DueDate.Day >= current.Day)
				{
					current_due += b.Balance;
				}
			}
			
			return current_due;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			progressBar1.PerformStep();
		}
		
		void Bill_List_Click(object sender, EventArgs e)
		{
			ListBills b = new ListBills();
			if(Data._bills.Count > 0)
			{
				b.ShowDialog();
			}
			else
			{
				MessageBox.Show("CONGRATULATIONS! YOU DON'T HAVE ANY BILLS! Power Level = 9001");
			}
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
			//FIXME: fix later
			textbox_amountDueMonth.Text = "" + getMonthlyBills();
			textbox_amountDueByDate.Text = "" + getBillsByDate(e.End);
		}
		
		void Button_PayABillClick(object sender, EventArgs e)
		{			
			BillPay bp = new BillPay();
			bp.ShowDialog();
		}
		

		//For editing existing bills
		//needs to probably create a new form for selecting and stuff
		void EditBillClick(object sender, EventArgs e)
		{
			EditBill ed = new EditBill();
			ed.ShowDialog();
		}
		
		void BillToolStripMenuItem_newUtilityBillClick(object sender, EventArgs e)
		{
			AddUtilityBill k = new AddUtilityBill();
			k.ShowDialog();
		}
		
		void AboutToolStripMenuItem_aboutClick(object sender, EventArgs e)
		{
			About a = new About();
			a.ShowDialog();
		}
	}
}
