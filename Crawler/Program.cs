using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawler
{
    class Program
    {
        private static void Main(string[] args)
        {
            var url = "https://www.google.com.br/search?q=agua&source=lnms&sa=X&ved=0ahUKEwjv6J2sn5zaAhWCGJAKHYGwCn8Q_AUICSgA&biw=1517&bih=447&dpr=0.9";
            var web = new HtmlWeb();
            var doc = web.Load(url);
            //var resultado = doc.GetElementbyId("resultStats").InnerText;
            var docNode = doc.DocumentNode;

            var node = docNode.SelectNodes("//div[@id = 'main']");

            foreach (var nNode in node.Descendants("a"))
            {
                Console.WriteLine(nNode.GetAttributeValue("href", ""));
            }
            //Console.WriteLine(resultado);
            Console.ReadLine();
        }
    }
}