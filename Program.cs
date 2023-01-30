using System;
using System.IO;

namespace html_generator
{
    class Program
    {
        static void Main(string[] args)
        
        {
            StreamWriter sw1 = new StreamWriter(@"C:\Users\Pozsgain\Desktop\Új mappa\style.css");

            sw1.WriteLine("table{\nborder-radius: 10px;\nborder-style: double;\nbackground-color: red;}");
            sw1.WriteLine("th{\nborder-style:groove;\nborder-radius: 1px;}");
            sw1.WriteLine("p{\ncolor: white}");

            sw1.Close();

            StreamWriter sw = new StreamWriter(@"C:\Users\Pozsgain\Desktop\Új mappa\index.html");
            sw.WriteLine("<!DOCTYPE html>");
            sw.WriteLine("<html lang="+'"'+"hu"+'"'+">");
            sw.WriteLine("<head>");
            sw.WriteLine("   <meta charset=" + '"' + "UTF - 8" + '"' + ">");
            sw.WriteLine("<meta http-equiv="+'"'+"X - UA - Compatible"+'"'+" content="+'"'+"IE = edge"+'"'+">");
            sw.WriteLine("<meta name = "+'"'+"viewport"+'"'+" content = "+'"'+"width = device - width, initial - scale = 1.0"+'"'+">");
            sw.WriteLine("<title>Document</title>");
            sw.WriteLine("<link rel="+'"'+"stylesheet"+'"'+" href="+'"'+"./style.css"+'"'+">");
            sw.WriteLine("</head>");


            sw.WriteLine("<body>");

            sw.WriteLine("<table>");
            for (int i = 0; i < 10; i++)
            {
                sw.WriteLine("<tr>");
                sw.WriteLine("<th>\n<p>" + i * 1 + "</p>\n</th>\n");
                sw.WriteLine("<th>\n<p>" + i * 2 + "</p>\n</th>\n");
                sw.WriteLine("<th>\n<p>" + i * 3 + "</p>\n</th>\n");
                sw.WriteLine("<th>\n<p>" + i * 4 + "</p>\n</th>\n");
                sw.WriteLine("<th>\n<p>" + i * 5 + "</p>\n</th>\n");
                sw.WriteLine("<th>\n<p>" + i * 6 + "</p>\n</th>\n");
                sw.WriteLine("<th>\n<p>" + i * 7 + "</p>\n</th>\n");
                sw.WriteLine("<th>\n<p>" + i * 8 + "</p>\n</th>\n");
                sw.WriteLine("<th>\n<p>" + i * 9 + "</p>\n</th>\n");
                sw.WriteLine("<th>\n<p>" + i * 10 + "</p>\n</th>\n");
                sw.WriteLine("</tr>\n");
            }
            sw.WriteLine("</table>");


            sw.WriteLine("</body>");
            sw.Close();
        }
    }
}
