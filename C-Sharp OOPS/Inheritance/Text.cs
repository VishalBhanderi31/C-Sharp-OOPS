using System;

namespace C_Sharp_OOPS
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHypelink(string url)
        {
            Console.WriteLine("We added a link to " + url);
        }
    }
}