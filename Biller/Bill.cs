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
		//ints are based on frequency
		//higher frequency -> lower number
		//except for none
		
		int occurance;
		
		string name;
		//TODO: do stuff with type_bill
		string type_bill;
		
		bool iPaidYou;
		
		double min_bal;
		double balance;
		
		DateTime due_date;
		DateTime paidOn_date;
		
		//TODO: maybe make more classes for bill types
		public Bill(string n, double b, DateTime d, int o)
		{
			occurance = o;
			
			name = n;
			
			iPaidYou = false;
			
			balance = b;
			due_date = d;
		}
		
		//TODO: when adding credit cards have min_bal set
		
		public string getName()
		{
			return name;
		}
		
		public DateTime getDate()
		{
			return due_date;
		}
		
		public double MinBalance
		{
			get{return this.min_bal;}
			set{this.min_bal = value;}
		}
		
		public double Balance
		{
			get{return this.balance;}
			set{this.balance = value;}
		}
		
		public string getTypeOfBill()
		{
			return type_bill;
		}
		
		public bool Paid
		{
			get{return this.iPaidYou;}
			set{this.iPaidYou = value;}
		}
		
		public DateTime getPaidOn()
		{
			
			return paidOn_date;
		}
		
		public override string ToString()
		{
			string message = "";
			message += name;
			message += "-" + "(" + min_bal +")";
			
			return message;
		}
	}
}
