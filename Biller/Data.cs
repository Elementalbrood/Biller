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
using System.IO;

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
		
		StreamWriter writer = new StreamWriter("test.txt");
		
		//TODO: UTILITIES: save information, and load information during closing and opening respectively
		
		public Data()
		{
			//TODO: UTILITIES: when loaded check to see if new bills need to be added due
			// to occurence data.
			
			//need to check type of bill, can't just add a bill			
			writer.WriteLine("File created using streamWriter class. ");
			writer.WriteLine("Where it'll be iunno");
			
			
			
			
			
			
			
		}
		
		public static void AddUtilityBillToList(string n, double b, DateTime d, int o)
		{
			UtilityBill n_bill = new UtilityBill(n, b, d, o);
			System.Diagnostics.Debug.WriteLine("n_bill " + n_bill.ToString());
			_bills.Add(n_bill);
			System.Diagnostics.Debug.WriteLine("Current number of bills " + _bills.Count);
		}

		private static Bill getBillByDate(DateTime date)
		{
			Bill bi = null;
			foreach(Bill b in _bills)
			{
				if(b.DueDate.CompareTo(date) == 0)
				{
					bi = b;
					break;
				}
			}
			return bi;
		}
		
		public static void updateOccurences()
		{
			int abdul = _bills.Count;
			//FIXME: needs to check to see if there is a bill already in the list. possibily improve
			for(int i = 0; i < abdul; i++)
			{
				Bill b = _bills[i];
				
				if(b is UtilityBill)
				{
					if(DateTime.Now.CompareTo(b.DueDate) > 0)
					{
						System.Diagnostics.Debug.WriteLine("CompareTo > 0");
						
						DateTime date;
						
						if(b.getOccurence() == OCC_MONTHLY)
						{
							date = b.DueDate.AddMonths(1);
						}
						else if(b.getOccurence() == OCC_BIANNUAL)
						{
							date = b.DueDate.AddMonths(6);
						}
						else if(b.getOccurence() == OCC_ANNUAL)
						{
							date = b.DueDate.AddYears(1);
						}
						else 
						{
							date = DateTime.Now;
						}
						
						if(!_bills.Contains(getBillByDate(date)))
						{
							AddUtilityBillToList(b.Name, b.Balance, date, b.getOccurence());
						}
					}
				}
			}
		}
	}
}
