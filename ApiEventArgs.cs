using System;

namespace SiteServer.Plugin
{
    public class ApiEventArgs : EventArgs
    {
        public ApiEventArgs(IRequest request, string action, string id)
        {
            Request = request;
            Action = action;
            Id = id;
        }

        public IRequest Request { get; private set; }

        public string Action { get; private set; }

        public string Id { get; private set; }
    }
}
