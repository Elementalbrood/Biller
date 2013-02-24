/*
 * Created by SharpDevelop.
 * User: Elemental
 * Date: 2/18/2013
 * Time: 2:06 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

//using MySql.Data.MySqlClient;

namespace Database
{
	public class SQLiteMonip
	{
		String dbConnection;
		
		public SQLiteMonip()
		{
			dbConnection = "Data Source = recipes.s3db";
		}
		
		public SQLiteMonip(String inputFile)
		{
			String loc = @"test.db";
			
			SQLiteConnection.CreateFile(loc);
			dbConnection = String.Format("Database Source={0}", inputFile + ";");
		}
		
		public SQLiteMonip(Dictionary<String, String> connectionOpts)
		{
			String str = "";
			foreach(KeyValuePair<String, String> row in connectionOpts)
			{
				str += String.Format("{0}={1}; ", row.Key, row.Value);
			}
			str = str.Trim().Substring(0, str.Length - 1);
			dbConnection = str;
		}
		
		public DataTable GetDataTable(string sql)
		{
			DataTable dt = new DataTable();
			
			try
			{
				SQLiteConnection cnn = new SQLiteConnection(dbConnection);
				cnn.Open();
				SQLiteCommand mycommand = new SQLiteCommand(cnn);
				mycommand.CommandText = sql;
				SQLiteDataReader reader = mycommand.ExecuteReader();
				dt.Load(reader);
				reader.Close();
				cnn.Close();
			}
			catch(Exception e)
			{
				throw new Exception(e.Message);
			}
			return dt;
		}
		
		public int ExecuteNonQuery(string sql)
		{
			SQLiteConnection cnn = new SQLiteConnection(dbConnection);
			cnn.Open();
			SQLiteCommand mycommand = new SQLiteCommand(cnn);
			mycommand.CommandText = sql;
			int rowsUpdate = mycommand.ExecuteNonQuery();
			cnn.Close();
			return rowsUpdate;
		}
		
		public string ExecuteScalar(string sql)
		{
			SQLiteConnection cnn = new SQLiteConnection(dbConnection);
			cnn.Open();
			SQLiteCommand mycommand = new SQLiteCommand(cnn);
			mycommand.CommandText = sql;
			object value = mycommand.ExecuteScalar();
			cnn.Close();
			if(value != null)
			{
				return value.ToString();
			}
			return "";
		}
		
		public bool Update(String tableName, Dictionary<String, String> data, String where)
		{
			String vals = "";
			Boolean returnCode = true;
			if(data.Count >= 1)
			{
				foreach(KeyValuePair<String, String> val in data)
				{
					vals += String.Format(" {0}= '{1}',", val.Key.ToString(), val.Value.ToString());
				}
				vals = vals.Substring(0, vals.Length - 1);
			}
			try
			{
				this.ExecuteNonQuery(String.Format("update {0} set {1} where {2};", tableName, vals, where));
			}
			catch
			{
				returnCode = false;
			}
			return returnCode;
		}
		
		public bool Delete(String tableName, String where)
		{
			Boolean returnCode = true;
			try
			{
				this.ExecuteNonQuery(String.Format("delete from {0} where {1};", tableName, where));
			}
			catch(Exception fail)
			{
				MessageBox.Show(fail.Message);
				returnCode = false;
			}
			return returnCode;
		}
		
		public bool Insert(String tableName, Dictionary<String, String> data)
		{
			String columns ="";
			String values = "";
			Boolean returnCode = true;
			
			foreach(KeyValuePair<String, String> val in data)
			{
				columns += String.Format(" {0},", val.Key.ToString());
				values += String.Format(" '{0}',", val.Value);
			}
			
			columns = columns.Substring(0, columns.Length - 1);
			values = values.Substring(0, values.Length -1);
			try
			{
				this.ExecuteNonQuery(String.Format("insert into {0}({1}) values){2});", tableName, columns, values));
				
			}
			catch(Exception fail)
			{
				MessageBox.Show(fail.Message);
				returnCode = false;
			}
			return returnCode;
		}
		
		public bool ClearDB()
		{
			DataTable tables;
			
			try
			{
				tables = this.GetDataTable("select NAME from SQLITE_MASTER where type='table' order by NAME;");
				foreach(DataRow table in tables.Rows)
				{
					this.ClearTable(table["Name"].ToString());
				}
				return true;
			}
			catch
			{
				return false;
			}
		}
		
		public bool ClearTable(String table)
		{
			try
			{
				this.ExecuteNonQuery(String.Format("delete from {0};", table));
				return true;
			}
			catch
			{
				return false;
			}
		}
	}
	
	/*
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
	}

	*/
}