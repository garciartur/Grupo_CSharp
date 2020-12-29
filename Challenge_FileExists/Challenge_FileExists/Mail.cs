using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Challenge_FileExists
{
    public class Mail
    {
        public bool FileExists { get; private set; }
        public string FilePath { get; set; }
        public string[] FileContent { get; set; }

        public Mail(string filePath)
        {
            this.FilePath = filePath;
        }

        public void CheckFile()
        {
            while(true)
            {
                if (File.Exists(FilePath))
                {
                    FileExists = true;
                    Console.WriteLine("Arquivo encontrado!");
                }
                else
                {
                    FileExists = false;
                    Console.WriteLine("Arquivo não encontrado!");
                }
                SendMail(FileExists);
                Thread.Sleep(TimeSpan.FromSeconds(5));
            }
        }

        private void SendMail(bool fileExists)
        {
            if(fileExists)
            {
                FileContent = ReadFile();
                string mailAddress = FileContent[0];
                string mailContent = FileContent[1];

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("r4c00nt3st@gmail.com");
                mail.To.Add(mailAddress);
                mail.Subject = "Deafio #2 - Grupo de Estudos C# (Artur)";
                mail.Body = mailContent;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("r4c00nt3st@gmail.com", "password");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                Console.WriteLine("Email enviado!");
            }
            else Console.WriteLine("Email não enviado!");
        }

        private string[] ReadFile()
        {
            string c = System.IO.File.ReadAllText(@"C:\Users\tarep\Documents\Grupo_CSharp\Grupo_CSharp\Challenge_FileExists\Pasta\content.txt");
            string[] content = c.Split('=');
            return content;
        }
    }
}
