using System;
using System.Collections.Specialized;
using System.Web;

namespace SiteServer.Plugin
{
    /// <summary>
    /// request with authentication that plugin can use
    /// </summary>
    public interface IRequest
    {
        HttpRequest HttpRequest { get; }

        NameValueCollection QueryString { get; }

        NameValueCollection Form { get; }

        bool IsQueryExists(string name);

        string GetQueryString(string name);

        int GetQueryInt(string name, int defaultValue = 0);

        decimal GetQueryDecimal(string name, decimal defaultValue = 0);

        bool GetQueryBool(string name, bool defaultValue = false);

        bool IsPostExists(string name);

        string GetPostString(string name);

        int GetPostInt(string name, int defaultValue = 0);

        decimal GetPostDecimal(string name, decimal defaultValue = 0);

        bool GetPostBool(string name, bool defaultValue = false);

        T GetPostObject<T>(string name);

        bool IsUserLoggin { get; }

        string UserName { get; }

        IUserInfo UserInfo { get; }

        void UserLogin(string userName);

        void UserLogout();

        bool IsAdminLoggin { get; }

        string AdminName { get; }

        IAdministratorInfo AdminInfo { get; }

        void AdminLogin(string administratorName);

        void AdminLogout();

        string GetUserTokenByUserName(string userName);

        string GetUserNameByToken(string token);

        string GetAdminTokenByAdminName(string administratorName);

        string GetAdminNameByToken(string token);

        void SetCookie(string name, string value, DateTime expires);

        string GetCookie(string name);

        bool IsCookieExists(string name);
    }
}
