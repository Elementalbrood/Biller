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
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		//Add Button
		void AddClick(object sender, EventArgs e)
		{
			string n = Name.Text;
			string b = Balance.Text;
			double bal = 0;
			
			Double.TryParse(b, out bal);
			
			DateTime date = dateTimePicker.Value;
			
			Data.AddBillToList(n, bal, date);
			
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
