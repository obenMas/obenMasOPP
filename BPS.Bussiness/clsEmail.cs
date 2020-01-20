using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Runtime.Remoting.Messaging;

namespace BPS.Bussiness
{
    public class clsEmail
    {
        //Attributes
        private string emlSubject;
        private string emlFrom;
        private string emlFromName;
        private List<string> emlTo;
        private List<string> emlToNames;
        private string emlMessageBody;
        private string emlSmtpServer;
        private NetworkCredential emlSmtpCredentials;

        //properties
        public string subject { get { return emlSubject; } set { emlSubject = value; } }

        public string from { get { return emlFrom; } set { emlFrom = value; } }

        public string fromName { get { return emlFromName; } set { emlFromName = value; } }

        public List<string> to { get { return emlTo; } set { emlTo = value; } }

        public List<string> toNames { get { return emlToNames; } set { emlToNames = value; } }

        public string messageBody { get { return emlMessageBody; } set { emlMessageBody = value; } }

        public string smtpServer { get { return emlSmtpServer; } set { emlSmtpServer = value; } }

        public NetworkCredential smtpCredentials { get { return emlSmtpCredentials; } set { emlSmtpCredentials = value; } }


        //Constructor
        public clsEmail()
        {
            subject = "";
            from = "";
            fromName = "";
            to = new List<string>();
            toNames = new List<string>();
            messageBody = "";
            smtpServer = "192.168.0.59";
            smtpCredentials = new NetworkCredential();
        }

        public bool sendEmail(string toEmail, string toName)
        {
            try
            {
                MailMessage Message = new MailMessage();

                Message.IsBodyHtml = true;

                //for (int i = 0; i < to.Count; i++)
                //{
                Message.To.Add(new MailAddress(toEmail, toName));
                Message.From = (new MailAddress(this.from, this.fromName));
                //}
                Message.Subject = this.subject;
                Message.Body = this.messageBody;

                SmtpClient sc = new SmtpClient();
                sc.Host = this.smtpServer;
                //sc.Credentials = smtpCredentials;
                sc.EnableSsl = true;
                sc.UseDefaultCredentials = true;
                sc.EnableSsl = false;


                sc.Send(Message);
            }
            catch (Exception)
            {
                return false;
            }
            return true;

        }

        public delegate bool SendEmailDelegate(string toEmail, string toName);

        public void GetResultsOnCallback(IAsyncResult ar)
        {
            bool result = false;
            SendEmailDelegate del = (SendEmailDelegate)((AsyncResult)ar).AsyncDelegate;
            try
            {
                result = del.EndInvoke(ar);
            }
            catch (Exception)
            {
                result = false;
            }
        }

        public string SendEmailAsync(string toEmail, string toName)
        {
            try
            {
                SendEmailDelegate dc = new SendEmailDelegate(this.sendEmail);
                AsyncCallback cb = new AsyncCallback(this.GetResultsOnCallback);
                IAsyncResult ar = dc.BeginInvoke(toEmail, toName, cb, null);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "si se mando";
        }

    }
}
