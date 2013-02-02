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
			
			//TODO: Would be cool if textbox_min was greyed out/not enabled if the type of bill is
			//		Utility. Reason is cause Utilities dont have a min balance while credit cards/loans do.
			
			//TODO: GOTTA FIX THE TAB ORDER AGAIN...... sorry.... >.>
			//		couldn't find where that file was to do it myself
			/*
			if(combobox_typeOfBill.Text.Equals("Utility"))
			{
				textbox_min.Enabled(false);
			}
			*/
			
		}
		
		//Add Button
		void AddClick(object sender, EventArgs e)
		{
			string n = textbox_name.Text;
			string b = textbox_balance.Text;
			string m_b = textbox_min.Text;
					//added 2/2/13 (t_b = type_bill) drop down box
					//TODO make combobox_typeOfBill read only/where you cant type in the box, only pick from drop menu
			string t_b = combobox_typeOfBill.Text;
			double bal = 0;
			double min_bal = 0;
			
			   
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
		
	}
}
