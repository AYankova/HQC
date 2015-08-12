namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;

    internal static class Validator
    {
        internal static void ValidateName(string value, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(propertyName + " can't be an empty string or null.", propertyName);
            }
        }

        internal static void ValidateIfNotNull(ICollection<string> value, string propertyName)
        {
            if (value == null)
            {
                throw new ArgumentNullException(propertyName + " can't be null.", propertyName);
            }
        }
    }
}
