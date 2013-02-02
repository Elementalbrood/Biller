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
		
		public static void AddBillToList(string n, double min_b, double b, DateTime d)
		{
			_bills.Add(new Bill(n, min_b, b, d));
			System.Diagnostics.Debug.WriteLine("Current number of bills " + _bills.Count);
		}
	}
}
