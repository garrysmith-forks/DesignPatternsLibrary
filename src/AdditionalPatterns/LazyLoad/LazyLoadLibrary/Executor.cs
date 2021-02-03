﻿using DesignPatternsLibrary.PatternExecutors;
using LazyLoadLibrary.GhostsExample;
using LazyLoadLibrary.LazyInitializationExample;
using LazyLoadLibrary.ValueHolderExample;
using LazyLoadLibrary.VirtualProxyExample;

namespace LazyLoadLibrary
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Lazy Load - Lazy Load Library - Additional Pattern";

        public override void Execute()
        {
            GhostsExecutor.Execute();
            LazyInitializationExecutor.Execute();
            ValueHolderExecutor.Execute();
            VirtualProxyExecutor.Execute();
        }
    }
}