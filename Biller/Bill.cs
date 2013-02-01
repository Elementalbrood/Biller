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
		int month;
		int day;
		int year;
		
		double balance;
		
		public Bill(string n, double b)
		{
			name = n;
			balance = b;
		}
		
		public Bill(string n, int m, int d, int y)
		{
			name = n;
			month = m;
			day = d;
			year = y;
		}
		
		public string getName()
		{
			return name;
		}
		
		public string getDate()
		{
			return month + "/" + day + "/" + year;
		}
		
		public double getBalance()
		{
			return balance;
		}
	}
}
