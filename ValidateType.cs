using System;
using System.Collections.Generic;

namespace SiteServer.Plugin
{
    public class ValidateType : IEquatable<ValidateType>, IComparable<ValidateType>
    {
       public static readonly ValidateType None = new ValidateType(nameof(None));               //无
       public static readonly ValidateType Chinese = new ValidateType(nameof(Chinese));			//中文
       public static readonly ValidateType English = new ValidateType(nameof(English));	        //英文
       public static readonly ValidateType Email = new ValidateType(nameof(Email));				//Email格式
       public static readonly ValidateType Url = new ValidateType(nameof(Url));				    //网址格式
       public static readonly ValidateType Phone = new ValidateType(nameof(Phone));				//电话号码 
       public static readonly ValidateType Mobile = new ValidateType(nameof(Mobile));			//手机号码
       public static readonly ValidateType Integer = new ValidateType(nameof(Integer));			//整数
       public static readonly ValidateType Currency = new ValidateType(nameof(Currency));		//货币格式
       public static readonly ValidateType Zip = new ValidateType(nameof(Zip));				    //邮政编码
       public static readonly ValidateType IdCard = new ValidateType(nameof(IdCard));			//身份证号码
       public static readonly ValidateType RegExp = new ValidateType(nameof(RegExp));           //正则表达式验证

        private ValidateType(string value)
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
            return Equals(obj as ValidateType);
        }

        public static bool operator ==(ValidateType a, ValidateType b)
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

        public static bool operator !=(ValidateType a, ValidateType b)
        {
            return !(a == b);
        }

        public bool Equals(ValidateType other)
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

        public int CompareTo(ValidateType other)
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
            return -1937169414 + EqualityComparer<string>.Default.GetHashCode(Value);
        }
    }
}
