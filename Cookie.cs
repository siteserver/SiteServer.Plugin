using System;

namespace SiteServer.Plugin
{
    public class Cookie
    {
        /// <summary>
        /// Gets or sets the domain to associate the cookie with.
        /// </summary>
        /// <returns>The domain to associate the cookie with.</returns>
        public string Domain { get; set; }

        /// <summary>
        /// Gets or sets the cookie path.
        /// </summary>
        /// <returns>The cookie path.</returns>
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the expiration date and time for the cookie.
        /// </summary>
        /// <returns>The expiration date and time for the cookie.</returns>
        public DateTimeOffset? Expires { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates whether to transmit the cookie using Secure Sockets Layer (SSL)--that is, over HTTPS only.
        /// </summary>
        /// <returns>true to transmit the cookie only over an SSL connection (HTTPS); otherwise, false.</returns>
        public bool Secure { get; set; }

        /// <summary>
        /// Gets or sets a value that indicates whether a cookie is accessible by client-side script.
        /// </summary>
        /// <returns>true if a cookie must not be accessible by client-side script; otherwise, false.</returns>
        public bool HttpOnly { get; set; }

        public string Value { get; set; }
    }
}
