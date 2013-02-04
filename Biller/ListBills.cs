/*
 * Created by SharpDevelop.
 * User: Elemental
 * Date: 1/28/2013
 * Time: 4:13 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Biller
{
	/// <summary>
	/// Description of ListBills.
	/// </summary>
	public partial class ListBills : Form
	{
		
		//TODO: Did the whole Yes/No isPaid thing and Sarah brought up, what if I pay it before the due date?
		//		So need to make it so User can enter whether it has been paid or not. Still thinking of best place
		//      to do this.
		
		public ListBills()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			
			billDisplay.DataSource = getResults();
			
			
		}
		
		private DataTable getResults()
		{
			DataTable d = new DataTable();
			
			d.Columns.Add("Bill", typeof(string));
			d.Columns.Add("Type", typeof(string));
			d.Columns.Add("Min", typeof(double));
			d.Columns.Add("Balance", typeof(double));
			d.Columns.Add("Due", typeof(DateTime));
			d.Columns.Add("Paid", typeof(string));
			d.Columns.Add("Date Paid", typeof(DateTime));
			
			foreach(Bill b in Data._bills)
			{
				d.Rows.Add(b.Name, b.TypeOfBill, b.MinBalance, b.Balance, b.Date.Date, b.Paid, b.PaidOn);
			}
			
			return d;
		}
		
		void ListBillCancelButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
