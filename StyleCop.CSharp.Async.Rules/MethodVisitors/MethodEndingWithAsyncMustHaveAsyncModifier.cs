﻿namespace StyleCop.CSharp.Async.Rules.MethodVisitors
{
    using System.Collections.Generic;

    internal class MethodEndingWithAsyncMustHaveAsyncModifier : IMethodVisitor
    {
        public IEnumerable<MethodViolationData> Visit(Method method)
        {
            if (method.HasAsyncSuffix())
            {
                if (!method.IsAsyncMethod())
                {
                    yield return new MethodViolationData(method);
                }
            }
        }
    }
}