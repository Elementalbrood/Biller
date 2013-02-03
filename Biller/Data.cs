/*
 * Created by SharpDevelop.
 * User: Elemental
 * Date: 1/28/2013
 * Time: 3:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Biller
{
	/// <summary>
	/// Description of Data.
	/// </summary>
	public class Data
	{
		public const int OCC_NONE = 0;
		public const int OCC_MONTHLY = 1;
		public const int OCC_BIANNUAL = 2;
		public const int OCC_ANNUAL = 3;
		
		
		public static List<Bill> _bills = new List<Bill>();
		
		
		//TODO: save information, and load information during closing and opening respectively
		
		public Data()
		{
			//TODO: when loaded check to see if new bills need to be added due
			// to occurence data.
			
			//need to check type of bill, can't just add a bill
			
			foreach(Bill b in _bills)
			{
				/*
				if(b.getDate())
				{
					//could cause trouble based on the type of bill that needs to be added
					//_bills.Add(new int)
				}
				*/
			}
			
		}
		
		public static void AddUtilityBillToList(string n, double b, DateTime d, int o)
		{
			UtilityBill n_bill = new UtilityBill(n, b, d, o);
			System.Diagnostics.Debug.WriteLine("n_bill " + n_bill.ToString());
			_bills.Add(n_bill);
			System.Diagnostics.Debug.WriteLine("Current number of bills " + _bills.Count);
		}
	}
}
