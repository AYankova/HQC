namespace Abstraction
{
    using System;

    internal static class Validator
    {
        internal static void ValidateValue(double value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException(propertyName + " should be higher than 0(zero).", propertyName);
            }
        }
    }
}
