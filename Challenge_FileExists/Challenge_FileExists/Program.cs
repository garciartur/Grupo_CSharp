using System;
using System.IO;
using System.Net.Mail;
using System.Threading;

namespace Challenge_FileExists
{
    class Program
    {
        static void Main(string[] args)
        {
            var mail = new Mail(@"C:\Users\tarep\Documents\Grupo_CSharp\Grupo_CSharp\Challenge_FileExists\Pasta\start.txt");
            mail.CheckFile();
        }
    }
}
