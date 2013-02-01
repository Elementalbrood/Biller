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
		public ListBills()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			if(Data._bills.Count > 0)
			{
				billDisplay.DataSource = getResults();
			}
			else
			{
				//TODO would be cool if it would say something if you didn't have any bills
			}
		}
		
		private DataTable getResults()
		{
			DataTable d = new DataTable();
			
			d.Columns.Add("Bill", typeof(string));
			d.Columns.Add("Balance", typeof(double));
			d.Columns.Add("Due", typeof(DateTime));
			
			foreach(Bill b in Data._bills)
			{
				d.Rows.Add(b.getName(), b.getBalance(), b.getDate().Date);
			}
			
			return d;
		}
		
		void ListBillCancelButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
