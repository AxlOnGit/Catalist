using System;
using System.Collections.Generic;
using System.Globalization;

namespace Products.DocxCreator
{
	public static class Utils
	{

		#region enum

		public enum ParseOptions
		{
			RunningMeter,
			SquareMeter
		}

		#endregion

		#region members



		#endregion

		/// <summary>
		/// Analyzes the input string and calculates the given option. Currently running and square meters.
		/// </summary>
		/// <param name="inputString"></param>
		/// <param name="options"></param>
		/// <returns></returns>
		public static double Multiplier(string inputString, ParseOptions options)
		{
			// Replace "," with "." for calculation purposes.
			inputString = inputString.Replace("Zentimeter", " ");
			inputString = inputString.Replace("Meter", " ");
			inputString = inputString.Replace("cm", " ");
			inputString = inputString.Replace("m", " ");

			double result = 1.0F;
			char[] delimiter = (" ").ToCharArray();
			string[] split = inputString.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
			List<double> valueList = new List<double>();
			CultureInfo culture = CultureInfo.CreateSpecificCulture("de-DE");

			foreach (string item in split)
			{
				double outVal = 0F;
				if (double.TryParse(item, System.Globalization.NumberStyles.AllowDecimalPoint, culture, out outVal)) valueList.Add(outVal);
			}

			for (int i = 0; i < valueList.Count; i++)
			{
				if (i == 0) // First value is in centimeters, we need to convert it to meters.
				{
					result *= valueList[i]/100;
				}
				else
				{
					result *= valueList[i];

				}
			}

			return result;
		}

		public static double CalcRunningMeterPrice(string inputString, double price)
		{
			// Replace "," with "." for calculation purposes.
			inputString = inputString.Replace("Zentimeter", " ");
			inputString = inputString.Replace("Meter", " ");
			inputString = inputString.Replace("cm", " ");
			inputString = inputString.Replace("m", " ");

			double result = 1.0F;
			char[] delimiter = (" ").ToCharArray();
			string[] split = inputString.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
			List<double> valueList = new List<double>();
			CultureInfo culture = CultureInfo.CreateSpecificCulture("de-DE");

			foreach (string item in split)
			{
				double outVal = 0F;
				if (double.TryParse(item, System.Globalization.NumberStyles.AllowDecimalPoint, culture, out outVal))
				{
					result = outVal/100 * price;
					return result;
				} 
			}
			return result;
		}

	}
}
