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
		public static List<Bill> _bills = new List<Bill>();
		
		
		//TODO: save information, and load information during closing and opening respectively
		
		public Data()
		{
		}
		
		public static void AddBillToList(string n, double min_b, double b, DateTime d, string t_b)
		{
			Bill n_bill = new Bill(n, min_b, b, d, t_b);
			System.Diagnostics.Debug.WriteLine("n_bill " + n_bill.ToString());
			_bills.Add(n_bill);
			System.Diagnostics.Debug.WriteLine("Current number of bills " + _bills.Count);
		}
	}
}
