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
	public partial class AddBill : Form
	{
		public AddBill()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			/*
			if(combobox_typeOfBill.Text.Equals("Utility"))
			{
				textbox_min.Enabled(false);
			}
			*/
			textbox_min.ReadOnly = true;
			
		}
		
		//Add Button
		void AddClick(object sender, EventArgs e)
		{
			string n = textbox_name.Text;
			string b = textbox_balance.Text;
			string t_b = combobox_typeOfBill.Text;
			string m_b = textbox_min.Text;
			//added 2/2/13 (t_b = type_bill) drop down box
			double bal = 0;
			double min_bal = 0;
			
			if(t_b.Contains("Utilities bill"))
			{
				m_b = b;
			}	
			if(!(Double.TryParse(b, out bal) && Double.TryParse(m_b, out min_bal)))
			{
				MessageBox.Show("Something went wrong please correct before proceeding");
				return;
			}
			else
			{				
				if(bal < 0 || min_bal < 0)
				{
					MessageBox.Show("Balance and min balance need to positive right???");
					return;
				}
			}
			
			DateTime date = dateTimePicker.Value;
			
			Data.AddBillToList(n, min_bal, bal, date, t_b);
			
			System.Diagnostics.Debug.WriteLine("Added bill");
			
			
			
			this.Close();
		}
		
		//Cancel Button
		void CancelClick(object sender, EventArgs e)
		{
			
			this.Close();
		}
		
		
		void Combobox_typeOfBillClick(object sender, EventArgs e)
		{
			if((combobox_typeOfBill.Text.Equals("Loan") || combobox_typeOfBill.Text.Equals("Credit card")))
			{
				textbox_min.ReadOnly = false;
			}
			else
			{
				textbox_min.Clear();
				textbox_min.ReadOnly = true;
			}
			
			System.Diagnostics.Debug.WriteLine(combobox_typeOfBill.Text);
		}
	}
}
