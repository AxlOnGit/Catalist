using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using Geocoding.Google;

namespace Products.Common.Geocoding
{
	public static class GeoData
	{
		#region const

		const string MQ_KEY = "i3rES5dwvGCBmvrXAyMtHRbKHpwhVgwT";
		//const string sample = $@"https://www.mapquestapi.com/staticmap/v4/getmap?key={key}&size=800,800&type=map&imagetype=png&pois=B,{addr1},-20,-20|N,{addr2},-20,-20|S,{addr3},-20,-20";

		#endregion const

		#region members

		readonly static Size myDefaultImageSize = new Size(800, 800);

		#endregion members

		#region public procedures

		/// <summary>
		/// Gibt den Längen- und Breitengrad der angegebene Adresse zurück - wenn Google die findet.
		/// </summary>
		/// <param name="address"></param>
		/// <returns></returns>
		public static GeoCoordinate GetAddressCoordinates(string company, string address)
		{
			GeoCoordinate result = null;
			//var key = "i3rES5dwvGCBmvrXAyMtHRbKHpwhVgwT";
			//var geocoder = new MapQuestGeocoder(key);

			var geocoder = new GoogleGeocoder();

			try
			{
				var addresses = geocoder.Geocode(address);
				if (addresses.First() != null)
				{
					result = new GeoCoordinate(addresses.First().Coordinates.Latitude, addresses.First().Coordinates.Longitude);
				}
				return result;
			}
			catch (Exception ex)
			{
				var msg = string.Format("Fehler: {0}\nDer Webservice kann die Adresse '{1}' nicht ermitteln.\nDie Adresse gehört zu Firma '{2}'", ex.Message, address, company);
				throw new ArgumentException(msg, nameof(address));
			}
		}

		/// <summary>
		/// Berechnet die Entfernung in Kilometern zwischen zwei geographischen Punkten, die jeweils
		/// mit ihren Längen- und Breitengraden angegeben werden.
		/// </summary>
		/// <param name="latOne">Längengrad (latitude) des 1. Punkts.</param>
		/// <param name="lonOne">Breitengrad (longitude) des 1. Punkts.</param>
		/// <param name="latTwo">Längengrad (latitude) des 2. Punkts.</param>
		/// <param name="lonTwo">Breitengrad (longitude) des 1. Punkts.</param>
		/// <returns></returns>
		public static double GetDistanceKm(double latOne, double lonOne, double latTwo, double lonTwo)
		{
			var coord1 = new GeoCoordinate(latOne, lonOne);
			var coord2 = new GeoCoordinate(latTwo, lonTwo);
			return Math.Round(coord1.GetDistanceTo(coord2) / 1000, 2);
		}

		/// <summary>
		/// Berechnet die Entfernung in Kilometern zwischen zwei geographischen Punkten, die jeweils
		/// mit ihren Längen- und Breitengraden angegeben werden.
		/// </summary>
		/// <param name="latOne">Längengrad (latitude) des 1. Punkts.</param>
		/// <param name="lonOne">Breitengrad (longitude) des 1. Punkts.</param>
		/// <param name="latTwo">Längengrad (latitude) des 2. Punkts.</param>
		/// <param name="lonTwo">Breitengrad (longitude) des 1. Punkts.</param>
		/// <returns></returns>
		public static double GetDistance(double latOne, double lonOne, double latTwo, double lonTwo)
		{
			var theta = lonOne - lonTwo;
			double distance = Math.Sin(deg2rad(latOne)) * Math.Sin(deg2rad(latTwo)) + Math.Cos(deg2rad(latOne)) * Math.Cos(deg2rad(latTwo)) * Math.Cos(deg2rad(theta));
			distance = Math.Acos(distance);
			distance = rad2deg(distance);
			distance = distance * 60 * 1.1515;
			distance *= 1.609344;
			return Math.Round(distance, 2);
		}

		public static Image GetPoisImage(Dictionary<string, GeoCoordinate> coords, int width = 800, int height = 800)
		{
			if (coords.Count == 0) throw new ArgumentException("Das Dictionary mit den anzuzeigenden Koordinaten ist leer", nameof(coords));

			if (width < 300) width = 300;
			if (height < 300) height = 300;

			var uri = $@"https://www.mapquestapi.com/staticmap/v4/getmap?key={MQ_KEY}&size={width},{height}&type=map&imagetype=png&pois=";
			var counter = 0;
			var culture = CultureInfo.GetCultureInfo("us");
			foreach (var item in coords)
			{
				if (counter == 0)
				{
					var lat = item.Value.Latitude.ToString(culture);
					var lon = item.Value.Longitude.ToString(culture);
					uri = $"{uri}{item.Key},{lat},{lon},-20,-20";
				}
				else
				{
					var lat = item.Value.Latitude.ToString(culture);
					var lon = item.Value.Longitude.ToString(culture);
					uri = $@"{uri}|{item.Key},{lat},{lon},-20,-20";
				}
				counter += 1;
			}
			var request = (HttpWebRequest)WebRequest.Create(uri);
			request.MaximumAutomaticRedirections = 4;
			request.MaximumResponseHeadersLength = 4;
			var response = (HttpWebResponse)request.GetResponse();
			var stream = response.GetResponseStream();
			var pic = Image.FromStream(stream);
			return pic;
		}

		#endregion public procedures

		#region private procedures

		static double deg2rad(double deg)
		{
			return (deg * Math.PI / 180.0);
		}

		static double rad2deg(double rad)
		{
			return (rad / Math.PI * 180.0);
		}

		#endregion private procedures
	}
}