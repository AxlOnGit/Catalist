using System.Reflection;
using System.Data;
using System;
namespace Products.Data
{

	public partial class dsSage
	{

		/// <summary>
		/// Setzt alle ConnectionStrings auf den lokalen MySql Server.
		/// Leider funktioniert das so nicht ...
		/// </summary>
		public void SetLocalMode<T>(ref T taQueries)
		{
			try
			{
				var fieldInfo = taQueries.GetType().GetField("_commandCollection", BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.NonPublic);
				var mInfo = GetType().GetMethod("InitCommandCollection", BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.NonPublic);
				var methodInfo = fieldInfo.GetType().GetMethod("InitCommandCollection", BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.NonPublic);
				if (fieldInfo != null && mInfo != null)
				{
					mInfo.Invoke(taQueries, null);
					var commandCollection = (IDbCommand[])fieldInfo.GetValue(taQueries);

					foreach (MySql.Data.MySqlClient.MySqlCommand cmd in commandCollection)
					{
						MySql.Data.MySqlClient.MySqlConnection newSQLConnection = cmd.Connection;
						cmd.Connection.ConnectionString = global::Products.Data.Properties.Settings.Default.conSageLocal;
					}
					fieldInfo.SetValue(taQueries, commandCollection);
				}
				else
				{
					throw new Exception("Konnte die CommandCollection nicht finden.");
				}
			}
			catch (Exception _exception)
			{
				throw new Exception(_exception.ToString());
			}
		}

	}
}
