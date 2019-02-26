namespace Jfk.Prism
{
    using System;
    using System.IO;
    using System.Reflection;

    using static System.Console;

    public static class Program
    {
        public static void Main(string[] args)
        {
            /*var path = 0 == args.Length ? string.Empty : args[0];
            if (!File.Exists(path))
            {
                return;
            }
            var assembly = Assembly.LoadFrom(path);
            foreach (var type in assembly.GetExportedTypes())
            {
                var descriptionAttribute = type.GetCustomAttribute<DescriptionAttribute>(true);
                if (null != descriptionAttribute)
                {
                    Write("Description: '{0}'", descriptionAttribute.Description);
                    WriteLine(string.IsNullOrEmpty(descriptionAttribute.Copyright) ? string.Empty : $" Copyright: '{descriptionAttribute.Copyright}'");
                }

                if (!typeof(ICallable).IsAssignableFrom(type))
                {
                    continue;
                }

                if (!(Activator.CreateInstance(type) is ICallable callable))
                {
                    throw new InvalidOperationException();
                }

                WriteLine("Result: {0}", callable.Call());
            }*/
        }
    }
}
