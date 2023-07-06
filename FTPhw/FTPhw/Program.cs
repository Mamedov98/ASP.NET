using System;
using System.IO;
using System.Net;
using System.Text;

namespace FtpConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri("ftp://127.0.0.1/")) as FtpWebRequest;

            request.Method = WebRequestMethods.Ftp.ListDirectory;
            request.Credentials = new NetworkCredential("SECRETS", "12345");

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();


            StreamReader reader = new StreamReader(responseStream);

            Console.WriteLine(reader.ReadToEnd());
            
        }
    }
}