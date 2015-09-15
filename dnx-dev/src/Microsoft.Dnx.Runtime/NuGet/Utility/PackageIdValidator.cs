// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Globalization;
using NuGet.Resources;

namespace NuGet
{
    public static class PackageIdValidator
    {
        internal const int MaxPackageIdLength = 100;

        public static bool IsValidPackageId(string packageId)
        {
            if (string.IsNullOrWhiteSpace(packageId))
            {
                throw new ArgumentException(nameof(packageId));
            }

            // Rules: 
            // Should start with a character
            // Can be followed by '.' or '-'. Cannot have 2 of these special characters consecutively. 
            // Cannot end with '-' or '.'

            var firstChar = packageId[0];
            if (!char.IsLetterOrDigit(firstChar) && firstChar != '_')
            {
                // Should start with a char/digit/_.
                return false;
            }

            var lastChar = packageId[packageId.Length - 1];
            if (lastChar == '-' || lastChar == '.')
            {
                // Should not end with a '-' or '.'.
                return false;
            }

            for (int index = 1; index < packageId.Length - 1; index++)
            {
                var ch = packageId[index];
                if (!char.IsLetterOrDigit(ch) && ch != '-' && ch != '.')
                {
                    return false;
                }

                if ((ch == '-' || ch == '.') && ch == packageId[index - 1])
                {
                    // Cannot have two successive '-' or '.' in the name.
                    return false;
                }
            }

            return true;
        }

        public static void ValidatePackageId(string packageId)
        {
            if (packageId.Length > MaxPackageIdLength)
            {
                throw new ArgumentException(NuGetResources.Manifest_IdMaxLengthExceeded);
            }

            if (!IsValidPackageId(packageId))
            {
                throw new ArgumentException(String.Format(CultureInfo.CurrentCulture, NuGetResources.InvalidPackageId, packageId));
            }
        }
    }
}