using System;

namespace LiveAI.FastBlazor.Helpers
{
    public class ClassMapper : CssMapper
    {
        public ClassMapper() : base()
        {
        }
    }

    public class StyleMapper : CssMapper
    {
        public StyleMapper() : base(suffix: ";")
        {
        }
    }

    public abstract class CssMapper
    {
        private readonly string _prefix;
        private readonly string _suffix;

        private Dictionary<Func<string>, Func<bool>> mapConditions = new Dictionary<Func<string>, Func<bool>>();

        protected CssMapper(string? prefix = null, string? suffix = null)
        {
            _prefix = prefix ?? "";
            _suffix = suffix ?? "";
        }

        public CssMapper Add(string? value)
        {
            return AddIf($"{_prefix}{value}{_suffix}", () => true);
        }

        public CssMapper AddIf(string? value, Func<bool> func)
        {
            if (!String.IsNullOrEmpty(value))
            {
                mapConditions.Add(() => $"{_prefix}{value}{_suffix}", func);
            }
            return this;
        }


        public override string ToString()
        {
            return string.Join(" ", mapConditions.Where(i => i.Value()).Select(i => i.Key()));
        }
    }
}
