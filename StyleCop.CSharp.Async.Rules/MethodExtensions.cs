﻿namespace StyleCop.CSharp
{
    internal static class MethodExtensions
    {
        public static bool IsAsyncMethod(this Method method)
        {
            return method.Declaration.ContainsModifier(CsTokenType.Async);
        }

        public static bool HasAsyncSuffix(this Method method)
        {
            return method
                .Name
                .RemoveGenericParantheses()
                .EndsWith("Async");
        }
    }
}