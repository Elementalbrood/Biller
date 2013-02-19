/*
 * Created by SharpDevelop.
 * User: Elemental
 * Date: 2/18/2013
 * Time: 2:06 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Database
{
	public class DataMonip
	{
		private MySqlConnection connection;
		private string server;
		private string database;
		private string uid;
		private string password;
		
		public DataMonip()
		{
			Initialize();
		}
		
		private void Initialize()
		{
			server = "localhost";
			database = "csharpdata";
			uid = "brandon";
			password = "freckles";
			string connectionString;
			connectionString = "Server=" + server + ";"  + "Database=" + database + ";" + "Uid=" + uid + ";" + "Pwd=" + password + ";";
			
			using(connection = new MySqlConnection(connectionString))
			{
				try
				{
					connection.Open();
				}
				catch(MySqlException ex)
				{
					switch (ex.Number)
					{
						default:
							System.Console.WriteLine(ex.Message);
							break;
					}
					
					connection.Clone();
				}
			}
		}
		
		private bool OpenConnection()
		{
			try
			{
				connection.Open();
				return true;
			}
			catch(MySqlException ex)
			{	
				switch(ex.Number)
				{
					case 0:
						MessageBox.Show("cannot connect to server");
						break;
					
					case 1045:
						MessageBox.Show("Invalid username/password");
						break;
					default:
						MessageBox.Show(ex.Message);
						break;
				}
				return false;
			}
		}
		
		private bool CloseConnection()
		{
			try
			{
				connection.Close();
				return true;
			}
			catch(MySqlException ex)
			{
				MessageBox.Show(ex.Message);
				return false;
			}
		}
		
		
		
		public void Insert(string table, string name, int age)
		{
			string query = "INSERT INTO " + table + " (name, age) VALUES('" + name + "', " + age  + ")";
			
			if(this.OpenConnection() == true)
			{
				MySqlCommand cmd = new MySqlCommand(query, connection);
				
				cmd.ExecuteNonQuery();
				
				this.CloseConnection();
			}
		}
		
		public List<string>[] Select()
		{
			string query = "SELECT * FROM test2";
			
			List<string>[] list = new List<string>[3];
			
			list[0] = new List<string>();
			list[1] = new List<string>();
			list[2] = new List<string>();
			
			if(this.OpenConnection() == true)
			{
				MySqlCommand cmd = new MySqlCommand(query, connection);
				
				MySqlDataReader dataReader = cmd.ExecuteReader();
				
				
				while(dataReader.Read())
				{
					list[0].Add(dataReader["id"] + "");
					list[1].Add(dataReader["name"] + "");
					list[2].Add(dataReader["age"] + "");
				}
				
				dataReader.Close();
				
				this.CloseConnection();
				
			}
			
			return list;
		}
		
		
		public static void Main(string[] args)
		{
			DataMonip db = new DataMonip();
			
			string t = "test";
			
			
			db.Insert(t, "john", 12);
			
			db.Insert(t, "kevin", 21);
			db.Insert(t, "ture", 20);
			db.Insert(t, "will", 20);
			
			List<string>[] list = db.Select();
			
			for(int i = 0; i < list.Length; i++)
			{
				List<string> temp = list[i];
				
				for(int j = 0; j < temp.Count; j++)
				{
					System.Console.WriteLine(temp[j]);
				}
			}
			//*/
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}