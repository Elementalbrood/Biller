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
		
		
		//TODO: UTILITIES: save information, and load information during closing and opening respectively
		
		public Data()
		{
			//TODO: UTILITIES: when loaded check to see if new bills need to be added due
			// to occurence data.
			
			//need to check type of bill, can't just add a bill			
			
		}
		
		public static void AddUtilityBillToList(string n, double b, DateTime d, int o)
		{
			UtilityBill n_bill = new UtilityBill(n, b, d, o);
			System.Diagnostics.Debug.WriteLine("n_bill " + n_bill.ToString());
			_bills.Add(n_bill);
			System.Diagnostics.Debug.WriteLine("Current number of bills " + _bills.Count);
		}
		
		public static void updateOccurences()
		{
			int abdul = _bills.Count;
			
			for(int i = 0; i < abdul; i++)
			{
				Bill b = _bills[i];
				
				if(b is UtilityBill)
				{
					if(DateTime.Now.CompareTo(b.DueDate) > 0)
					{
						System.Diagnostics.Debug.WriteLine("CompareTo > 0");
						if(b.getOccurence() == OCC_MONTHLY)
						{
							AddUtilityBillToList(b.Name, b.Balance, b.DueDate.AddMonths(1), b.getOccurence());
						}
						if(b.getOccurence() == OCC_BIANNUAL)
						{
							AddUtilityBillToList(b.Name, b.Balance, b.DueDate.AddMonths(6), b.getOccurence());
						}
						if(b.getOccurence() == OCC_ANNUAL)
						{
							AddUtilityBillToList(b.Name, b.Balance, b.DueDate.AddYears(1), b.getOccurence());
						}
					}
				}
			}
			
		}
	}
}
