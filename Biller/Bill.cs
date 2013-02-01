/*
 * Created by SharpDevelop.
 * User: Elemental
 * Date: 1/28/2013
 * Time: 3:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Biller
{
	/// <summary>
	/// Description of Bill.
	/// </summary>
	public class Bill
	{
		string name;
		DateTime date;
		
		double min_bal;
		double balance;
		
		public Bill(string n, double min_b, double b, DateTime d)
		{
			name = n;
			min_bal = min_b;
			balance = b;
			date = d;
		}
		
		public string getName()
		{
			return name;
		}
		
		public DateTime getDate()
		{
			return date;
		}
		
		public double getMinBalance()
		{
			return min_bal;
		}
		
		public double getBalance()
		{
			return balance;
		}
	}
}
