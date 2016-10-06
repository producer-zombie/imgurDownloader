using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net;

namespace imgurDownloader
{
    class Program
    {
        static void Main()
        {

            string fileNameLocation = "url_file_name";

            //   string saveLocationName = "file_location_path";

            Console.WriteLine("Enter domain without http/https of the image you want to download.");

            fileNameLocation = Console.ReadLine();

            //  Console.WriteLine("Enter the save location of the file.");

            //  saveLocationName = Console.ReadLine();

            WebClient webClient = new WebClient();
            webClient.DownloadFile(fileNameLocation, @"C:\Pictures\filename.jpg");

            Console.ReadLine();
        }

    }
}
