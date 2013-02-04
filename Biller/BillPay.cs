/*
 * Created by SharpDevelop.
 * User: Elemental
 * Date: 2/2/2013
 * Time: 12:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Biller
{
	/// <summary>
	/// Description of BillPay.
	/// </summary>
	public partial class BillPay : Form
	{
		public BillPay()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			int a = 0;
			Bill [] list = new Bill[Data._bills.Count];
			foreach(Bill b in Data._bills)
			{
				list[a] = b;
				a++;
			}
			comboBox_bill.DataSource = list;
			//comboBox_bill.AutoCompleteSource = list;
		}
		
		void Button_pay_meClick(object sender, EventArgs e)
		{
			Bill b = (Bill)comboBox_bill.SelectedValue;
			string s_paid = textBox_amount_paid.Text;
			double d_paid_amount = 0;
			DateTime date_paid = dateTimePicker_paid.Value;
			
			//TEST: make sure that all things are correctly account for.
			if(!Double.TryParse(s_paid, out d_paid_amount))
			{
				MessageBox.Show("Please enter an acceptable pay amount");
			}

			//this can be used to check bill type
			if(b is UtilityBill)
			{
				System.Diagnostics.Debug.WriteLine("Pay me: " + b.Name);
				b.Balance -= d_paid_amount; 
			}
			
			//may change when a person tries to pay for something with a minbalance
			// move into the if(b is utilitybill)
			if(b.Balance <= 0)
			{
				b.Paid = true;
			}
			b.PaidOn = DateTime.Today;
			
			//TODO: UTILITIES: update the date of when it was paid, update xp bar on Form1
			this.Close();
		}
	}
}
