﻿using System;
using System.Collections.Generic;

namespace SharpLab.Runtime {
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    public sealed class JitGenericAttribute : Attribute {
        public JitGenericAttribute(params Type[] argumentTypes) {
            ArgumentTypes = argumentTypes;
        }

        public Type[] ArgumentTypes { get; }
    }
}
