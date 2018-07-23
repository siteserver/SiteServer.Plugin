using System;
using System.Web;

namespace SiteServer.Plugin
{
    /// <summary>
    /// request with authentication that plugin can use
    /// </summary>
    public interface IRequest
    {
        HttpRequest HttpRequest { get; }

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

        T GetPostObject<T>(string name = "");

        bool IsUserLoggin { get; }

        string UserName { get; }

        IUserInfo UserInfo { get; }

        string UserLogin(string userName, bool isAutoLogin);

        void UserLogout();

        bool IsAdminLoggin { get; }

        string AdminName { get; }

        IAdministratorInfo AdminInfo { get; }

        string AdminLogin(string adminName, bool isAutoLogin);

        void AdminLogout();

        string GetUserTokenByUserName(string userName);

        string GetUserNameByToken(string token);

        string GetAdminTokenByAdminName(string adminName);

        string GetAdminNameByToken(string token);

        bool IsApiAuthorized { get; }

        void SetCookie(string name, string value, DateTime expires);

        string GetCookie(string name);

        bool IsCookieExists(string name);
    }
}
