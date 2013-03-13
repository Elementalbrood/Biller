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
using System.Data;
using System.IO;

using Database;

namespace Biller
{
	/// <summary>
	/// Description of Data.
	/// </summary>
	public class Data
	{
		public const int OCC_NONE = 0;
		public const int OCC_BIWEEKLY = 1;
		public const int OCC_MONTHLY = 2;
		public const int OCC_BIANNUAL = 3;
		public const int OCC_ANNUAL = 4;
		
		public static List<Bill> _bills = new List<Bill>();
		
		static string data_folder = @"Data_Folder";
		static string saved_data = "\\bills.billz";
		static StreamWriter writer;
		static StreamWriter billsaver;
		
		//TODO: UTILITIES: save information, and load information during closing and opening respectively
		
		public Data()
		{
			//TODO: UTILITIES: when loaded check to see if new bills need to be added due
			// to occurence data.
			
			//need to check type of bill, can't just add a bill		

		}
		/*
		public ~Data()
		{
			billsaver.Close();
		}
		*/
		
		static SQLiteMonip bob;
		
		//this is were all data init stuff goes
		// such as directory creation, file loading, etc.
		public static void DataInit()
		{
			if(!System.IO.Directory.Exists(data_folder))
			{
				System.IO.Directory.CreateDirectory(data_folder);
			}
			
			bob = new SQLiteMonip(data_folder + "\\test.s3db");
			
			//Initial file initialization 
			
			
			//sqllite table creation
			if(!bob.tableExist("bills"))
			{
				bob.ExecuteNonQuery("create table bills(name text, type varchar(30), min_bal real, balance real, due text, paid text, date_paid text);");
			}
			if(!bob.tableExist("test"))
			{
				//bob.ExecuteNonQuery("create table test(one int, message varchar(30));");
			}
			
			//bob.ExecuteNonQuery("insert into test(one, message) values (1, 'hello');");
			//bob.ExecuteNonQuery("insert into test(one, message) values (2, 'world');");
			//bob.ExecuteNonQuery("insert into test(one, message) values (3, '!');");

			//oooh man dat data
			/*
			 *	•_•)
			 *	( •_•)>⌐■-■
			 *	(⌐■_■) 
			 */
			
			//OOOH ya
			
			/*
			System.IO.Directory.CreateDirectory(data_folder);
			string path = data_folder + "\\test.txt";
			
			
			
			writer = new StreamWriter(path);
			writer.WriteLine("Data initalization");
			
			
			path = data_folder + saved_data;
			billsaver = new StreamWriter(path);
			
			
			writer.Close();
			*/
		}
		
		public static DataSet getTable(string table)
		{
			return bob.GetDataTable("SELECT * FROM " + table + ";");
		}
		
		public static DataSet getBill(string name)
		{
			return bob.GetDataTable("SELECT * FROM bills WHERE name IN('" + name + "');");
		}
		
		public static void AddUtilityBillToList(string n, double b, DateTime d, int o)
		{
			//billsaver.WriteLine("added bill " + n);
			UtilityBill n_bill = new UtilityBill(n, b, d, o);
			System.Diagnostics.Debug.WriteLine("n_bill " + n_bill.ToString());
			_bills.Add(n_bill);
			string format = "MM/dd/yyyy";
			
			bob.ExecuteNonQuery("INSERT INTO bills(name, type, balance, due, paid) values ('" + n + "', 'utilities', " +  b + ", '" + d.ToString(format) + "', 'No');");
			
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
		
		public static int getNumMonthlyBill()
		{
			int num = 0;
			
			DateTime current_month = DateTime.Today;
			
			foreach(Bill b in _bills)
			{
				if(b.DueDate.Month == current_month.Month)
				{
					num++;
				}
			}
			
			return num;
		}
		
		public static int getNumPaidMonthlyBill()
		{
			int num = 0;
			
			DateTime current_month = DateTime.Today;
			
			foreach(Bill b in _bills)
			{
				if(b.DueDate.Month == current_month.Month && b.Paid)
				{
					num++;
				}
			}
			return num;
		}
		
		public static void updateOccurences()
		{
			int z = _bills.Count;
			for(int i = 0; i < z; i++)
			{
				Bill b = _bills[i];
				
				if(b is UtilityBill)
				{
					if(DateTime.Now.CompareTo(b.DueDate) > 0)
					{
						System.Diagnostics.Debug.WriteLine("CompareTo > 0");
						
						DateTime date;
						
						if(b.getOccurence() == OCC_BIWEEKLY)
						{							
							date = b.DueDate.AddDays(14);
						}
						else if(b.getOccurence() == OCC_MONTHLY)
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
						
						//stuff
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
