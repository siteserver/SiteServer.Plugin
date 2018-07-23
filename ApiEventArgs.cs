using System;

namespace SiteServer.Plugin
{
    /// <summary>
    /// 为Rest Api请求事件提供数据。
    /// </summary>
    public class ApiEventArgs : EventArgs
    {
        internal ApiEventArgs(IRequest request, string route, string routeResource, string routeId, string routeAction)
        {
            Request = request;
            Route = route;
            RouteResource = routeResource;
            RouteId = routeId;
            RouteAction = routeAction;
        }


        //internal ApiEventArgs(IRequest request, string route, string routeResource, string routeId, string routeAction)
        //{
        //    Request = request;
        //    Route = route;
        //    RouteResource = routeResource;
        //    RouteId = routeId;
        //    RouteAction = routeAction;
        //}

        /// <summary>
        /// Rest Api 请求对象实例 <see cref="T:SiteServer.Plugin.IRequest" />。
        /// </summary>
        public IRequest Request { get; }

        /// <summary>
        /// Rest Api 请求路径。
        /// </summary>
        public string Route { get; }

        /// <summary>
        /// Rest Api 请求路径中包含的资源名称。
        /// </summary>
        public string RouteResource { get; }

        /// <summary>
        /// Rest Api 请求路径中包含的资源Id。
        /// </summary>
        public string RouteId { get; }

        /// <summary>
        /// Rest Api 请求路径中包含的动作名称。
        /// </summary>
        public string RouteAction { get; }
    }
}