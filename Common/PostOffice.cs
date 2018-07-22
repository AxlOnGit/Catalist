using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace Products.Common
{
	public class PostOffice : IDisposable
	{

		#region MEMBERS

		SmtpClient myClient;
		readonly string mySender;

		#endregion MEMBERS

		#region ### .ctor ###

		/// <summary>
		/// Creates a new instance of the PostOffice class.
		/// </summary>
		public PostOffice(string username, string pw, string userEmailAddress)
		{
			myClient = new SmtpClient(CatalistRegistry.Application.SmtpServer, CatalistRegistry.Application.SmtpPort);
			var nc = new NetworkCredential(username, pw);
			myClient.Credentials = nc;
			this.mySender = userEmailAddress;
		}

		#endregion

		#region PUBLIC PROCEDURES

		/// <summary>
		/// Erzeugt eine neue E-Mail Nachricht.
		/// </summary>
		/// <param name="to">E-Mail Adresse des Empfängers.</param>
		/// <param name="subject">Betreff der E-Mail.</param>
		/// <param name="body">Der Nachrichtentext.</param>
		/// <param name="attachFile">Pfad und Dateiname einer anzuhängenden Datei.</param>
		/// <returns></returns>
		public MailMessage CreateMailMessage(string to, string subject, string body, FileInfo attachFile = null, List<string> ccList = null, List<string> bccList = null)
		{
			try
			{
				var msg = new MailMessage(mySender, to, subject, body);
				if (msg != null)
				{
					// Attach file if one's available
					if (attachFile != null && attachFile.Exists)
					{
						msg.Attachments.Add(new Attachment(attachFile.FullName));
					}
					if (ccList != null)
					{
						foreach (var address in ccList)
						{
							msg.CC.Add(address);
						}
					}
					if (bccList != null)
					{
						foreach (var address in bccList)
						{
							msg.Bcc.Add(address);
						}
					}
					return msg;
				}
				return null;
			}
			catch (Exception)
			{
				throw;
			}
		}

		/// <summary>
		/// Sendet die übergebene E-Mail.
		/// </summary>
		/// <param name="theMessage"></param>
		public void SendEmail(MailMessage theMessage)
		{
			if (theMessage != null)
			{
				myClient.Send(theMessage);
			}
		}

		/// <summary>
		/// Sendet eine E-Mail über den internen SMTP Server.
		/// </summary>
		/// <param name="to">E-Mail Adresse des Empfängers.</param>
		/// <param name="subject">Betreff der E-Mail.</param>
		/// <param name="body">E-Mail Text.</param>
		/// <param name="attachFile">Pfad und Dateiname einer als Attachment anzufügenden Datei.</param>
		public void SendEmail(string to, string subject, string body, FileInfo attachFile = null, List<string> ccList = null)
		{
			try
			{
				var msg = new MailMessage(mySender, to, subject, body);
				if (msg != null)
				{
					// Attach file if one's available
					if (attachFile != null && attachFile.Exists)
					{
						msg.Attachments.Add(new Attachment(attachFile.FullName));
					}
					if (ccList != null)
					{
						foreach (var address in ccList)
						{
							msg.CC.Add(address);
						}
					}
					myClient.Send(msg);
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		/// <summary>
		/// Öffnet das Standard-Mailprogramm und erstellt eine neue E-Mail mit den angegebenen Informationen.
		/// </summary>
		/// <param name="to">Empfänger-Adresse</param>
		/// <param name="subject">Betreff</param>
		/// <param name="body">Nachrichtentext</param>
		public void SendMailViaDefaultMailer(string to, string subject = "Betreff", string body = "Nachrichtentext")
		{
			var mailto = string.Format("mailto:{0}?Subject={1}&Body={2}", to, subject, body);
			System.Diagnostics.Process.Start(mailto);
		}

		#region IDISPOSABLE SUPPORT

		private bool disposedValue = false; // Dient zur Erkennung redundanter Aufrufe.

		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
					this.myClient.Dispose();
				}
				disposedValue = true;
			}
		}

		// TODO: Finalizer nur überschreiben, wenn Dispose(bool disposing) weiter oben Code für die Freigabe nicht verwalteter Ressourcen enthält.
		~PostOffice()
		{
			// Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in Dispose(bool disposing) weiter oben ein.
			Dispose(false);
		}

		// Dieser Code wird hinzugefügt, um das Dispose-Muster richtig zu implementieren.
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		#endregion IDISPOSABLE SUPPORT

		#endregion PUBLIC PROCEDURES

	}
}
