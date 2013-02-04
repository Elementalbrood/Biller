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
	
	//TODO: UTILITIES: Make bills recurring. Check to see if day is 1st day in month and re-add bills to list?
	
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
		
		//TODO when adding credit cards have min_bal set
		
		public string Name
		{
			get{return this.name;}
			set{this.name = value;}
		}
		
		public DateTime Date
		{
			get{return this.due_date;}
			set{this.due_date = value;}
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
		
		public string TypeOfBill
		{
			get{return this.type_bill;}
			set{this.type_bill = value;}
		}
		
		public bool Paid
		{
			get{return this.iPaidYou;}
			set{this.iPaidYou = value;}
		}
		
		public DateTime PaidOn
		{
			get{return this.paidOn_date;}
			set{this.paidOn_date = value;}
		}
		
		public int getOccurence()
		{
			return occurance;
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
