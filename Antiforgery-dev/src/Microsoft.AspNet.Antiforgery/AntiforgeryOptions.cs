// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Framework.Internal;

namespace Microsoft.AspNet.Antiforgery
{
    /// <summary>
    /// Provides programmatic configuration for the antiforgery token system.
    /// </summary>
    public class AntiforgeryOptions
    {
        private const string AntiforgeryTokenFieldName = "__RequestVerificationToken";

        /// <summary>
        /// Specifies the name of the cookie that is used by the antiforgery
        /// system.
        /// </summary>
        /// <remarks>
        /// If an explicit name is not provided, the system will automatically
        /// generate a name.
        /// </remarks>
        public string CookieName { get; [param: NotNull] set; }

        /// <summary>
        /// Specifies the name of the antiforgery token field that is used by the antiforgery system.
        /// </summary>
        public string FormFieldName { get; [param: NotNull] set; } = AntiforgeryTokenFieldName;

        /// <summary>
        /// Specifies whether SSL is required for the antiforgery system
        /// to operate. If this setting is 'true' and a non-SSL request
        /// comes into the system, all antiforgery APIs will fail.
        /// </summary>
        public bool RequireSsl { get; set; }

        /// <summary>
        /// Specifies whether to suppress the generation of X-Frame-Options header
        /// which is used to prevent ClickJacking. By default, the X-Frame-Options
        /// header is generated with the value SAMEORIGIN. If this setting is 'true',
        /// the X-Frame-Options header will not be generated for the response.
        /// </summary>
        public bool SuppressXFrameOptionsHeader { get; set; }
    }
}