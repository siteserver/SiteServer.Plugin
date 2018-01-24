using System;
using System.Collections.Generic;

namespace SiteServer.Plugin
{
    public class DatabaseType : IEquatable<DatabaseType>, IComparable<DatabaseType>
    {
        public static readonly DatabaseType MySql = new DatabaseType(nameof(MySql));
        public static readonly DatabaseType SqlServer = new DatabaseType(nameof(SqlServer));
        public static readonly DatabaseType PostgreSql = new DatabaseType(nameof(PostgreSql));
        public static readonly DatabaseType Oracle = new DatabaseType(nameof(Oracle));

        private DatabaseType(string value)
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
            return Equals(obj as DatabaseType);
        }

        public static bool operator ==(DatabaseType a, DatabaseType b)
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

        public static bool operator !=(DatabaseType a, DatabaseType b)
        {
            return !(a == b);
        }

        public bool Equals(DatabaseType other)
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

        public int CompareTo(DatabaseType other)
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
