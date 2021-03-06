// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.Toolkit.Services.Twitter
{
    /// <summary>
    /// Query string configuration.
    /// </summary>
    public class TwitterDataConfig
    {
        /// <summary>
        /// Gets or sets twitter query type.
        /// </summary>
        public TwitterQueryType QueryType { get; set; }

        /// <summary>
        /// Gets or sets query parameters.
        /// </summary>
        public string Query { get; set; }
    }
}
