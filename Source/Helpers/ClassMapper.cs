using System;

namespace LiveAI.FastBlazor.Helpers
{
    public class ClassMapper
    {
        private Dictionary<Func<string>, Func<bool>> mapConditions = new Dictionary<Func<string>, Func<bool>>();

        public override string ToString()
        {
            return string.Join(" ", mapConditions.Where(i => i.Value()).Select(i => i.Key()));
        }

        public ClassMapper Add(string? name)
        {
            return AddIf(name, () => true);
        }

        public ClassMapper AddIf(string? name, Func<bool> func)
        {
            if (!String.IsNullOrEmpty(name))
            {
                mapConditions.Add(() => name, func);
            }
            return this;
        }
    }
}