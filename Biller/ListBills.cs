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
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			
			billDisplay.DataSource = getResults();
			
		}
		
		private DataTable getResults()
		{
			DataTable d = billDisplay.DataSource;
			
			while(d.Rows.Count < Data._bills.Count)
			{
				d.Rows.Add();
				System.Diagnostics.Debug.WriteLine("Adding rows");
			}
			
			for(int i = 0; i < d.Rows.Count; i++)
			{
				d.Rows[i][0] = Data._bills[0].getName();
			}
			
			return d;
		}
		
		void ListBillCancelButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
