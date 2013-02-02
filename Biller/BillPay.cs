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
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			int a =0;
			string [] list = new string[Data._bills.Count];
			foreach(Bill b in Data._bills)
			{
				list[a] = b.getName();
				a++;
			}
			
			comboBox_bill.DataSource = list;
		}
	}
}
