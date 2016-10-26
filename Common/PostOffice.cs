using System;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System.IO;

namespace Products.Common
{
	public class PostOffice
	{

		#region members

		SmtpClient myClient;
		readonly string mySender;

		#endregion

		#region public properties

		#endregion

		#region ### .ctor ###

		/// <summary>
		/// Creates a new instance of the PostOffice class.
		/// </summary>
		public PostOffice(string username, string pw, string userEmailAddress)
		{
			myClient = new SmtpClient(Global.SmtpServer, Global.SmtpPort);
			var nc = new NetworkCredential(username, pw);
			myClient.Credentials = nc;
			this.mySender = userEmailAddress;
		}

		#endregion

		#region private procedures


		#endregion

		#region public procedures

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
			catch (Exception ex)
			{
				throw ex;
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
			catch (Exception ex)
			{
				throw ex;
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

		#endregion

	}
}
