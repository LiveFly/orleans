﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Orleans.Hosting
{
    /// <summary>
    /// Constants for HostBuilder configuration keys.
    /// </summary>
    public static class HostDefaults
    {
        /// <summary>
        /// The configuration key used to set <see cref="IHostingEnvironment.ApplicationName"/>.
        /// </summary>
        public static readonly string ApplicationKey = "applicationName";

        /// <summary>
        /// The configuration key used to set <see cref="IHostingEnvironment.EnvironmentName"/>.
        /// </summary>
        public static readonly string EnvironmentKey = "environment";
    }
}
