using System;

namespace SiteServer.Plugin
{
    public class ApiEventArgs : EventArgs
    {
        public ApiEventArgs(IRequest request, string name, string id, string action)
        {
            Request = request;
            RouteName = name;
            if (!string.IsNullOrEmpty(id))
            {
                int routeId;
                if (int.TryParse(id, out routeId))
                {
                    RouteId = routeId;
                }
            }
            RouteAction = action;
            Action = name;
            Id = id;
        }

        public IRequest Request { get; }

        public string RouteName { get; }

        public int RouteId { get; }

        public string RouteAction { get; }

        [Obsolete]
        public string Action { get; }

        [Obsolete]
        public string Id { get; }
    }
}
