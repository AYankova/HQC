namespace Size
{
    using System;

    public class Size
    {
        private double width;
        private double height;

        /// <summary>
        /// Initializes a new instance of the <see cref="Size"/> class
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <exception cref="ArgumentOutOfRangeException" accessor="set">Width cannot be negative or zero number</exception>
        public double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width cannot be" + "negative or zero number");
                }

                this.width = value;
            }
        }

        /// <exception cref="ArgumentOutOfRangeException" accessor="set">Height cannot be negative or zero number</exception>
        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height cannot be" + "negative or zero number");
                }

                this.height = value;
            }
        }

        /// <summary>
        /// The method calculates the new size after rotating it by predefined degrees
        /// </summary>
        /// <param name="angleOfRotation">The angle of rotation.</param>
        /// <returns>New object of type Size.</returns>
        public Size GetRotatedSize(double angleOfRotation)
        {
            double cosRotation = Math.Cos(angleOfRotation);
            double sinRotation = Math.Sin(angleOfRotation);

            var width = (Math.Abs(cosRotation) * this.Width) + (Math.Abs(sinRotation) * this.Height);
            var height = (Math.Abs(sinRotation) * this.Width) + (Math.Abs(cosRotation) * this.Height);

            Size rotatedSize = new Size(width, height);
            return rotatedSize;
        }

        public override string ToString()
        {
            return string.Format("Width: {0:F2} \nHeight: {1:F2}", this.Width, this.Height);
        }
    }
}
