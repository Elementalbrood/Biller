/*
 * Created by SharpDevelop.
 * User: Elemental
 * Date: 1/28/2013
 * Time: 3:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Biller
{
	/// <summary>
	/// Description of AddBill.
	/// </summary>
	public partial class AddUtilityBill : Form
	{
		public AddUtilityBill()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		//Add Button
		void AddClick(object sender, EventArgs e)
		{
			string n = textbox_name.Text;
			string b = textbox_balance.Text;
			//added 2/2/13 (t_b = type_bill) drop down box
			double bal = 0;
			double min_bal = 0;
			DateTime date = dateTimePicker.Value;
			
			if(!(Double.TryParse(b, out bal)))
			{
				MessageBox.Show("Something went wrong please correct before proceeding");
				return;
			}
			else
			{				
				if(bal < 0 || min_bal < 0)
				{
					MessageBox.Show("Balance needs to positive right???");
					return;
				}
			}
			
			if(date < DateTime.Today)
			{
				MessageBox.Show("The date you have chosen is in the past, please choose a future date");
				return;
			}
			
			int occ = -1;
			
			if(radioButton_none.Checked)
			{
				occ = Data.OCC_NONE;
			}
			else if(radioButton_monthly.Checked)
			{
				occ = Data.OCC_MONTHLY;
			}
			else if(radioButton_biannual.Checked)
			{
				occ = Data.OCC_BIANNUAL;
			}
			else if(radioButton_annual.Checked)
			{
				occ = Data.OCC_ANNUAL;
			}
			
			//if occ was not selected
			if(occ == -1)
			{
				MessageBox.Show("An occurence was not selected. Please select an occurence and try again");
				return;
			}
			
			Data.AddUtilityBillToList(n, bal, date, occ);
			
			System.Diagnostics.Debug.WriteLine("Added bill");
			
			this.Close();
		}
		
		//Cancel Button
		void CancelClick(object sender, EventArgs e)
		{
			
			this.Close();
		}
	}
}
