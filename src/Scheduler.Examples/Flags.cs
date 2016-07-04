using System;
using System.Collections.Generic;
using System.Linq;

namespace Utils
{
    public static class Flags
    {
        private static List<IFlag> _flags = new List<IFlag>();

        public static Flag<string> String(string name, string defaultValue, string description)
        {
            var flag = new Flag<string>(name, defaultValue, description);
            _flags.Add(flag);
            return flag;
        }

        public static bool Parse(string[] args)
        {
            if (args.Length == 0)
            {
                return true;
            }

            if (args.Any(a => a == "--help"))
            {
                foreach (var flag in _flags)
                {
                    flag.Print();
                }
                return false;
            }
            else
            {
                foreach (var flag in _flags)
                {
                    flag.Parse(args);
                }
                return true;
            }


        }
    }

    public interface IFlag
    {
        void Print();
        void Parse(string[] args);
    }

    public class Flag<T> : IFlag
    {
        public string Name
        {
            get;
            private set;
        }

        public T DefaultValue
        {
            get;
            private set;
        }

        public string Description
        {
            get;
            private set;
        }

        public Flag(string name, T defaultValue, string description)
        {
            Name = name;
            DefaultValue = defaultValue;
            Description = description;
        }

        public void Print()
        {
            Console.WriteLine("{0,20}{1}", Name, Description);
        }

        public void Parse(string[] args)
        {

        }

        public T GetValue()
        {
            return DefaultValue;
        }
    }
}