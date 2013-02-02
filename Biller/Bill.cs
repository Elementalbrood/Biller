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
	
	//TODO: Make bills recurring. Check to see if day is 1st day in month and re-add bills to list?
	
	public class Bill
	{
		string name;
		DateTime date;
		string type_bill;
		bool iPaidYou = false;
		
		double min_bal;
		double balance;
		
		public Bill(string n, double min_b, double b, DateTime d, string t_b)
		{
			name = n;
			min_bal = min_b;
			balance = b;
			date = d;
			type_bill = t_b;
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
		
		public string getTypeOfBill()
		{
			return type_bill;
		}
		
		public string getIsPaid()
		{
			//TODO: Get better logic. I can't logic so early in the morning. Set up Pay a bill button
			//		so that iPaidYou = false until User changes iPaidYou to true
			
			if(getDate() > DateTime.Today)
			{
				iPaidYou = false;
			}
			if(getDate() <= DateTime.Today)
			{
				iPaidYou = true;
			}
			
			if(iPaidYou)
				return "Yes";
			else
				return "No";
		}
			
	}
}
