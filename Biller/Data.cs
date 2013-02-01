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
		public static int size = 0;
		
		public Data()
		{
		}
		
		public static void AddBillToList(string n, double min_b, double b, DateTime d)
		{
			
			_bills.Add(new Bill(n, min_b, b, d));
			size++;
			System.Diagnostics.Debug.WriteLine("Current number of bills " + _bills.Count);
		}
		
		public static void AddBillToList(string n, int m, int d, int y)
		{
			//list[size] = new Bill(n, m, d, y);
			//size++;
		}
	}
}
