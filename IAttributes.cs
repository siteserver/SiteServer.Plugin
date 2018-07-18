using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;

namespace SiteServer.Plugin
{
    /// <summary>
    /// 可扩展属性的对象接口
    /// </summary>
    public interface IAttributes
    {
        void Load(DataRowView view);

        void Load(DataRow row);

        void Load(IDataReader reader);

        void Load(IDataRecord record);

        void Load(NameValueCollection attributes);

        void Load(Dictionary<string, object> dict);

        void Load(string json);

        object Get(string name);

        void Set(string name, object value);

        void Remove(string name);

        string GetString(string name, string defaultValue = "");

        bool GetBool(string name, bool defaultValue = false);

        int GetInt(string name, int defaultValue = 0);

        decimal GetDecimal(string name, decimal defaultValue = 0);

        DateTime GetDateTime(string name, DateTime defaultValue);

        bool ContainsKey(string name);

        int Count { get; }

        string ToString();

        string ToString(List<string> excludeAttributeNames);

        Dictionary<string, object> ToDictionary();
    }
}
