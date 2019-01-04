namespace Jfk.Prism
{
    using System;

    [AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    public sealed class DescriptionAttribute : Attribute
    {
        public DescriptionAttribute(string description)
        {
            this.Description = description;
        }

        public string Description { get; }

        public string Copyright
        {
            get; set;
        }
    }
}
