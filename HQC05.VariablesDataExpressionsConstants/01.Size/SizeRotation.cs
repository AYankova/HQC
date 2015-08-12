namespace Size
{
    using System;

    public class SizeRotation
    {
        public static void Main()
        {
            Size size = new Size(5.2, 3.4);
            Size rotatedSize = size.GetRotatedSize(25);

            Console.WriteLine(size);
            Console.WriteLine(rotatedSize);
        }
    }
}
