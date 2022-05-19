using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPL.Practice.T02.Problem01
{
    internal class Program
    {
        static public string GetArticleSummary(string content, int maxLength)
        {
            if(content.Length > maxLength)
            {
                content = content.Substring(0, maxLength);

                content = content.Remove(content.LastIndexOf(' '));
                content = content + "...";

            }
            return content;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetArticleSummary("abc decccdd sdee", 15));
            
        }
    }
}
