using System;

namespace LiveAI.FastBlazor.Helpers
{
    public class StyleMapper
    {
        private Dictionary<Func<string>, Func<bool>> mapConditions = new Dictionary<Func<string>, Func<bool>>();
        private Dictionary<Func<string>, Func<string>> mapValues = new Dictionary<Func<string>, Func<string>>();

        public string Style => ToString();

        public override string ToString()
        {
            var values = string.Join(" ", mapValues.Select(i => $"{i.Key()}: {i.Value()};"));
            var conditions = string.Join(" ", mapConditions.Where(i => i.Value()).Select(i => i.Key()));
            return values + " " + conditions;
        }

        public StyleMapper Add(string? style)
        {
            return AddIf(style + ";", () => true);
        }

        public StyleMapper AddIf(string? style, Func<bool> func)
        {
            if (!String.IsNullOrEmpty(style))
            {
                mapConditions.Add(() => style + ";", func);
            }
            return this;
        }

        public StyleMapper AddIf(string key, string? value, Func<bool> func)
        {
            if (!String.IsNullOrEmpty(value))
            {
                mapConditions.Add(() => $"{key}: {value};", func);
            }
            return this;
        }

        public StyleMapper AddValue(string key, Func<string> func)
        {
            if (!String.IsNullOrEmpty(key))
            {
                mapValues.Add(() => key, func);
            }
            return this;
        }
    }
}