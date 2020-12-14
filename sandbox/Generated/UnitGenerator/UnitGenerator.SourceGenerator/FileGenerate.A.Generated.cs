﻿﻿#pragma warning disable CS8669
using System;

namespace FileGenerate
{
    [System.ComponentModel.TypeConverter(typeof(ATypeConverter))]
    public readonly partial struct A : IEquatable<A> 
    {
        readonly int value;

        public readonly int AsPrimitive() => value;

        public A(int value)
        {
            this.value = value;
        }


        public static explicit operator int(A value)
        {
            return value.value;
        }

        public static explicit operator A(int value)
        {
            return new A(value);
        }

        public bool Equals(A other)
        {
            return value.Equals(other.value);
        }

        public override bool Equals(object? obj)
        {
            if (obj is A v)
            {
                return Equals(v);
            }
            if (obj is int v2)
            {
                return value.Equals(v2);
            }
            return value.Equals(obj);
        }

        public override int GetHashCode()
        {
            return value.GetHashCode();
        }

        public override string ToString()
        {
            return "A(" + value + ")";
        }

        public static bool operator ==(in A x, in A y)
        {
            return x.value == y.value;
        }

        public static bool operator !=(in A x, in A y)
        {
            return x.value != y.value;
        }










        private class ATypeConverter : System.ComponentModel.TypeConverter
        {
            private static readonly Type WrapperType = typeof(A);
            private static readonly Type ValueType = typeof(int);

            public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, Type sourceType)
            {
                if (sourceType == WrapperType || sourceType == ValueType)
                {
                    return true;
                }

                return base.CanConvertFrom(context, sourceType);
            }

            public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, Type destinationType)
            {
                if (destinationType == WrapperType || destinationType == ValueType)
                {
                    return true;
                }

                return base.CanConvertTo(context, destinationType);
            }

            public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
            {
                if (value is int underlyingValue)
                {
                    return new A(underlyingValue);
                }
                
                if (value is A wrapperValue)
                {
                    return wrapperValue;
                }

                return base.ConvertFrom(context, culture, value);
            }

            public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
            {
                if (value is A wrappedValue)
                {
                    if (destinationType == WrapperType)
                    {
                        return wrappedValue;
                    }

                    if (destinationType == ValueType)
                    {
                        return wrappedValue.AsPrimitive();
                    }
                }

                return base.ConvertTo(context, culture, value, destinationType);
            }
        }
    }
}
