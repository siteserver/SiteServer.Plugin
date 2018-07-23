namespace SiteServer.Plugin
{
    /// <summary>
    /// 工具类Api接口。
    /// </summary>
    public interface IUtilsApi
    {
        /// <summary>
        /// 根据Web.config中设置的SecretKey加密字符串。
        /// </summary>
        /// <param name="inputString">原始字符串。</param>
        /// <returns>加密后的字符串。</returns>
        string Encrypt(string inputString);

        /// <summary>
        /// 根据Web.config中设置的SecretKey解密字符串。
        /// </summary>
        /// <param name="inputString">原始字符串。</param>
        /// <returns>解密后的字符串。</returns>
        string Decrypt(string inputString);

        /// <summary>
        /// 防XSS攻击过滤。
        /// </summary>
        /// <param name="html">需要过滤的Html。</param>
        /// <returns>过滤后的Html。</returns>
        string FilterXss(string html);

        /// <summary>
        /// 防Sql注入过滤。
        /// </summary>
        /// <param name="sql">需要过滤的SQL语句。</param>
        /// <returns>过滤后的SQL语句。</returns>
        string FilterSql(string sql);
    }
}