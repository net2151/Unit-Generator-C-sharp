﻿﻿// <auto-generated>
// THIS (.cs) FILE IS GENERATED BY UnitGenerator. DO NOT CHANGE IT.
// </auto-generated>
#pragma warning disable CS8669
#pragma warning disable CS8625
using System;

namespace UnitGenerator
{
    [AttributeUsage(AttributeTargets.Struct, AllowMultiple = false)]
    internal class UnitOfAttribute : Attribute
    {
        public Type Type { get; }
        public UnitGenerateOptions Options { get; }
        public string Format { get; }

        public UnitOfAttribute(Type type, UnitGenerateOptions options = UnitGenerateOptions.None, string toStringFormat = null)
        {
            this.Type = type;
            this.Options = options;
            this.Format = toStringFormat;
        }
    }

    [Flags]
    internal enum UnitGenerateOptions
    {
        None = 0,
        ImplicitOperator = 1,
        ParseMethod = 2,
        MinMaxMethod = 4,
        ArithmeticOperator = 8,
        ValueArithmeticOperator = 16,
        Comparable = 32,
        Validate = 64,
        JsonConverter = 128,
        MessagePackFormatter = 256,
        DapperTypeHandler = 512,
        EntityFrameworkValueConverter = 1024,
    }
}tor | ValueArithmeticOperator | Comparable | Validate | JsonConverter | MessagePackFormatter | DapperTypeHandler | EntityFrameworkValueConverter,
    }
}