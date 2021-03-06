﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.Identity.Client.CacheV2.Impl.Utils
{
    internal static class PathUtils
    {
        public static string Normalize(string inputPath)
        {
            return inputPath.Replace('\\', '/');
        }
    }
}
