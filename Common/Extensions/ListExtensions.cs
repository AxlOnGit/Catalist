using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Products.Common.Extensions
{
	public static class ListExtensions
	{

		/// <summary>
		/// Berechnet den Mittelwert für alle in der Liste enthaltenen Werte.
		/// </summary>
		/// <param name="values">Wertliste.</param>
		/// <returns></returns>
		public static double Mean(this List<double> values)
		{
			return values.Count == 0 ? 0 : values.Mean(0, values.Count);
		}

		/// <summary>
		/// Berechnet den Mittelwert für die in der Liste enthaltenen Werte mit
		/// der Möglichkeit, das erste und letzte Element der Liste zu bestimmen.
		/// </summary>
		/// <param name="values">Wertliste.</param>
		/// <param name="start">Der Index des Startelements.</param>
		/// <param name="end">Der Index des letzten Elements.</param>
		/// <returns></returns>
		public static double Mean(this List<double> values, int start, int end)
		{
			double s = 0;
			for (int i = start; i < end; i++)
			{
				s += values[i];
			}
			return s / (end - start);
		}

		public static double Median(this List<double> values)
		{
			if (values.Count == 0) return 0.0;
			double[] tempArray = values.ToArray();
			Array.Sort(tempArray);
			if (values.Count % 2 == 0)
			{
				// Die Anzahl der Elemente ist gerade. Wir suchen daher die mittleren zwei Elemente,
				// addieren sie und teilen anschließend durch 2.
				double midItem1 = tempArray[(values.Count / 2) -1];
				double midItem2 = tempArray[(values.Count/2)];
				return (midItem1 + midItem2) / 2;
			}
			else
			{
				return tempArray[values.Count / 2];
			}
		}

		public static double Variance(this List<double> values)
		{
			return values.Variance(values.Mean(), 0, values.Count);
		}

		public static double Variance(this List<double> values, double mean)
		{
			return values.Variance(mean, 0, values.Count);
		}

		public static double Variance(this List<double> values, double mean, int start, int end)
		{
			double variance = 0;
			for (int i = start; i < end; i++)
			{
				variance += Math.Pow((values[i] - mean), 2);
			}
			int n = end - start;
			if (start > 0) n -= 1;

			return variance / (n);
		}

		public static double StandardDeviation(this List<double> values)
		{
			return values.Count == 0 ? 0 : values.StandardDeviation(0, values.Count);
		}

		public static double StandardDeviation(this List<double> values, int start, int end)
		{
			double mean = values.Mean(start, end);
			double variance = values.Variance(mean, start, end);

			return Math.Sqrt(variance);
		}

	}
}
