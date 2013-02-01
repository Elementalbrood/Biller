/*
 * Created by SharpDevelop.
 * User: Elemental
 * Date: 1/28/2013
 * Time: 3:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Biller
{
	/// <summary>
	/// Description of Data.
	/// </summary>
	public class Data
	{
		static Bill [] list = new Bill[100];
		static int size = 0;
		
		public Data()
		{
		}
		
		public static void AddBillToList(string n, double b)
		{
			list[size] = new Bill(n,b);
			size++;
		}
		
		public static void AddBillToList(string n, int m, int d, int y)
		{
			list[size] = new Bill(n, m, d, y);
			size++;
		}
	}
}
