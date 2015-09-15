// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Runtime.Versioning;

namespace Microsoft.Dnx.Tooling
{
    public class BuildOptions
    {
        public string OutputDir { get; set; }

        public IList<string> ProjectPatterns { get; set; }

        public IList<string> Configurations { get; set; }

        public IList<string> TargetFrameworks { get;set; }

        public bool GeneratePackages { get; set; }

        public Reports Reports { get; set; }

        public BuildOptions()
        {
            Configurations = new List<string>();
            TargetFrameworks = new List<string>();
            ProjectPatterns = new List<string>();
        }
    }
}
