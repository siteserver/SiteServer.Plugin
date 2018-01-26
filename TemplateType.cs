using System;
using System.Collections.Generic;

namespace SiteServer.Plugin
{
    public class TemplateType : IEquatable<TemplateType>, IComparable<TemplateType>
    {
        public static readonly TemplateType IndexPageTemplate = new TemplateType(nameof(IndexPageTemplate));
        public static readonly TemplateType ChannelTemplate = new TemplateType(nameof(ChannelTemplate));
        public static readonly TemplateType ContentTemplate = new TemplateType(nameof(ContentTemplate));
        public static readonly TemplateType FileTemplate = new TemplateType(nameof(FileTemplate));

        private TemplateType(string value)
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
            return Equals(obj as TemplateType);
        }

        public static bool operator ==(TemplateType a, TemplateType b)
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

        public static bool operator !=(TemplateType a, TemplateType b)
        {
            return !(a == b);
        }

        public bool Equals(TemplateType other)
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

        public int CompareTo(TemplateType other)
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
    }
}
