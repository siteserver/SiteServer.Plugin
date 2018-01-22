using System;
using System.Collections.Generic;

namespace SiteServer.Plugin
{
    public class DataType : IEquatable<DataType>, IComparable<DataType>
    {
        public static readonly DataType Boolean = new DataType(nameof(Boolean));
        public static readonly DataType DateTime = new DataType(nameof(DateTime));
        public static readonly DataType Decimal = new DataType(nameof(Decimal));
        public static readonly DataType Integer = new DataType(nameof(Integer));
        public static readonly DataType Text = new DataType(nameof(Text));
        public static readonly DataType VarChar = new DataType(nameof(VarChar));

        private DataType(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value;
        }

        public string Value { get; }

        public override bool Equals(object obj)
        {
            return Equals(obj as DataType);
        }

        public static bool operator ==(DataType a, DataType b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            if ((object)a == null || (object)b == null)
            {
                return false;
            }

            return a.Equals(b);
        }

        public static bool operator !=(DataType a, DataType b)
        {
            return !(a == b);
        }

        public bool Equals(DataType other)
        {
            if (other == null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return
                Value.Equals(other.Value, StringComparison.OrdinalIgnoreCase);
        }

        public int CompareTo(DataType other)
        {

            if (other == null)
            {
                return 1;
            }

            if (ReferenceEquals(this, other))
            {
                return 0;
            }

            return StringComparer.OrdinalIgnoreCase.Compare(Value, other.Value);
        }

        public override int GetHashCode()
        {
            return EqualityComparer<string>.Default.GetHashCode(Value);
        }

        public override string ToString()
        {
            return Value;
        }

        public static string GetText(DataType dataType)
        {
            if (dataType == Boolean)
            {
                return "布尔值";
            }
            if (dataType == DateTime)
            {
                return "日期";
            }
            if (dataType == Decimal)
            {
                return "小数";
            }
            if (dataType == Integer)
            {
                return "整数";
            }
            if (dataType == Text)
            {
                return "备注";
            }
            if (dataType == VarChar)
            {
                return "文本";
            }

            throw new Exception();
        }
    }
}
