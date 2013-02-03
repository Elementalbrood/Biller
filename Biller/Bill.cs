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
		string type_bill;
		
		bool iPaidYou;
		
		double min_bal;
		double balance;
		
		DateTime due_date;
		DateTime paidOn_date;
		
		//TODO: maybe make more classes for bill types
		public Bill(string n, double min_b, double b, DateTime d, string t_b)
		{
			name = n;
			type_bill = t_b;
			
			iPaidYou = false;
			
			min_bal = min_b;
			balance = b;
			
			due_date = d;
		}
		
		public string getName()
		{
			return name;
		}
		
		public DateTime getDate()
		{
			return due_date;
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
		
		public bool getIsPaid()
		{
			return iPaidYou;
		}
		
		public DateTime getPaidOn()
		{
			
			return paidOn_date;
		}
			
	}
}
