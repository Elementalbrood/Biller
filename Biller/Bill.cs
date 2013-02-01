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
		
		double balance;
		
		public Bill(string n, double b)
		{
			name = n;
			balance = b;
		}
		
		public Bill(string n, double b, DateTime d)
		{
			name = n;
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
		
		public double getBalance()
		{
			return balance;
		}
	}
}
