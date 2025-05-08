using System;

namespace MyUtilities
{
    public struct Color
    {
        private readonly byte _red;
        private readonly byte _green;
        private readonly byte _blue;

       
        public byte Red => _red;
        public byte Green => _green;
        public byte Blue => _blue;

        
        public Color(byte red, byte green, byte blue)
        {
            _red = red;
            _green = green;
            _blue = blue;
        }

        
        public void Display()
        {
            Console.WriteLine($"Color - R: {Red}, G: {Green}, B: {Blue}");
        }

        public string ToHex()
        {
            return $"#{Red:X2}{Green:X2}{Blue:X2}";
        }
    }
}

class Program
{
    static void Main()
    {
        
        MyUtilities.Color skyBlue = new MyUtilities.Color(135, 206, 235);
        skyBlue.Display(); 

        Console.WriteLine("Hex Code: " + skyBlue.ToHex()); 
    }
}
