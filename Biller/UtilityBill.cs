/*
 * Created by SharpDevelop.
 * User: Elemental
 * Date: 2/3/2013
 * Time: 3:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Biller
{
	/// <summary>
	/// Description of UtilityBill.
	/// </summary>
	public class UtilityBill : Bill
	{
		public UtilityBill(string n, double b, DateTime d, int o) : base(n, b, d, o)
		{
			MinBalance = 0;
		}
		
		public override string ToString()
		{
			string message = "";
			message += getName();
			message += "-" + "(" + this.Balance +")";
			return message;
		}
	}
}
