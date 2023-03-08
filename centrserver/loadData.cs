using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace centrserver
{
    public class loadData
    {
        public static void loadImages()
        {
            var datafile = File.ReadAllLines("C:/Users/admin/Desktop/Отборочные 2023/sd.txt");
            var images = Directory.GetFiles("C:/Users/admin/Desktop/Отборочные 2023/images");

            foreach (var line in datafile)
            {
                var data = line.Split('\t');

                var tempNumber = new numberInfo
                {
                    number = data[2].Replace("\"", "")
                };
                try
                {
                    tempNumber.picture = File.ReadAllBytes(images.FirstOrDefault(p=> p.Contains(tempNumber.number)));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                speedrunEntities3.GetContext().numberInfo.Add(tempNumber);
                speedrunEntities3.GetContext().SaveChanges();
            }
        }
    }
}