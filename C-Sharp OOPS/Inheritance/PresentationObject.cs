using System;

namespace C_Sharp_OOPS
{
    public class PresentationObject
    {
        public float Height { get; set; }
        public float Width { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object copied to clipboard.");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated");
        }
    }
}