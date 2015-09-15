// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Linq;
using System.Collections.Generic;

namespace Microsoft.Dnx.DesignTimeHost.Models.OutgoingMessages
{
    public class DependenciesMessage
    {
        public FrameworkData Framework { get; set; }
        public string RootDependency { get; set; }
        public IDictionary<string, DependencyDescription> Dependencies { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as DependenciesMessage;

            return other != null &&
                   string.Equals(RootDependency, other.RootDependency) &&
                   object.Equals(Framework, other.Framework) &&
                   Enumerable.SequenceEqual(Dependencies, other.Dependencies);
        }

        public override int GetHashCode()
        {
            // These objects are currently POCOs and we're overriding equals
            // so that things like Enumerable.SequenceEqual just work.
            return base.GetHashCode();
        }
    }
}