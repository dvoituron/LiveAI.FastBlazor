﻿using System;

namespace LiveAI.FastBlazor.Helpers
{
    public class StyleMapper
    {
        private Dictionary<Func<string>, Func<bool>> mapConditions = new Dictionary<Func<string>, Func<bool>>();

        public override string ToString()
        {
            return string.Join(" ", mapConditions.Where(i => i.Value()).Select(i => i.Key()));
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
    }
}