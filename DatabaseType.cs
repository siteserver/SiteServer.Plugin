using System;
using System.Collections.Generic;

namespace SiteServer.Plugin
{
    /// <summary>
    /// 系统支持的数据库类型
    /// </summary>
    public class DatabaseType : IEquatable<DatabaseType>, IComparable<DatabaseType>
    {
        /// <summary>
        /// MySql 数据库
        /// </summary>
        public static readonly DatabaseType MySql = new DatabaseType(nameof(MySql));

        /// <summary>
        /// SqlServer 数据库
        /// </summary>
        public static readonly DatabaseType SqlServer = new DatabaseType(nameof(SqlServer));

        /// <summary>
        /// PostgreSql 数据库
        /// </summary>
        public static readonly DatabaseType PostgreSql = new DatabaseType(nameof(PostgreSql));

        /// <summary>
        /// Oracle 数据库
        /// </summary>
        public static readonly DatabaseType Oracle = new DatabaseType(nameof(Oracle));

        private DatabaseType(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value;
        }

        /// <summary>
        /// 数据库类型的值。
        /// </summary>
        public string Value { get; }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            return Equals(obj as DatabaseType);
        }

        /// <summary>
        /// 比较两个数据库类型是否一致。
        /// </summary>
        /// <param name="a">需要比较的数据库类型。</param>
        /// <param name="b">需要比较的数据库类型。</param>
        /// <returns>如果一致，则为true；否则为false。</returns>
        public static bool operator ==(DatabaseType a, DatabaseType b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }

            if ((object) a == null || (object) b == null)
            {
                return false;
            }

            return a.Equals(b);
        }

        /// <summary>
        /// 比较两个数据库类型是否不一致。
        /// </summary>
        /// <param name="a">需要比较的数据库类型。</param>
        /// <param name="b">需要比较的数据库类型。</param>
        /// <returns>如果不一致，则为true；否则为false。</returns>
        public static bool operator !=(DatabaseType a, DatabaseType b)
        {
            return !(a == b);
        }

        /// <summary>
        /// 比较两个数据库类型是否一致。
        /// </summary>
        /// <param name="other">需要比较的数据库类型。</param>
        /// <returns>如果一致，则为true；否则为false。</returns>
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

        /// <summary>
        /// 比较两个数据库类型是否一致。
        /// </summary>
        /// <param name="other">需要比较的数据库类型。</param>
        /// <returns>如果一致，则为0；否则为1。</returns>
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

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return EqualityComparer<string>.Default.GetHashCode(Value);
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return Value;
        }
    }
}