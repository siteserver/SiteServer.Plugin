using System;

namespace SiteServer.Plugin
{
    public class ApiEventArgs : EventArgs
    {
        public ApiEventArgs(IRequest request, string name, string id)
        {
            Request = request;
            Name = name;
            Id = id;
        }

        public IRequest Request { get; private set; }

        public string Name { get; private set; }

        public string Id { get; private set; }
    }
}
