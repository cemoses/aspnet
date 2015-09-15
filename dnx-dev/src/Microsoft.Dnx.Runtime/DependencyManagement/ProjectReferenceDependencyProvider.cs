// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using NuGet;

namespace Microsoft.Dnx.Runtime
{
    public class ProjectReferenceDependencyProvider : IDependencyProvider
    {
        private readonly IProjectResolver _projectResolver;

        public ProjectReferenceDependencyProvider(IProjectResolver projectResolver)
        {
            _projectResolver = projectResolver;
        }

        public IEnumerable<string> GetAttemptedPaths(FrameworkName targetFramework)
        {
            return _projectResolver.SearchPaths.Select(p => Path.Combine(p, "{name}", "project.json"));
        }

        public LibraryDescription GetDescription(LibraryRange libraryRange, FrameworkName targetFramework)
        {
            if (libraryRange.IsGacOrFrameworkReference)
            {
                return null;
            }

            string name = libraryRange.Name;

            Project project;

            // Can't find a project file with the name so bail
            if (!_projectResolver.TryResolveProject(name, out project))
            {
                return null;
            }

            // This never returns null
            var targetFrameworkInfo = project.GetTargetFramework(targetFramework);
            var targetFrameworkDependencies = new List<LibraryDependency>(targetFrameworkInfo.Dependencies);

            if (VersionUtility.IsDesktop(targetFramework))
            {
                targetFrameworkDependencies.Add(new LibraryDependency
                {
                    LibraryRange = new LibraryRange("mscorlib", frameworkReference: true)
                });

                targetFrameworkDependencies.Add(new LibraryDependency
                {
                    LibraryRange = new LibraryRange("System", frameworkReference: true)
                });

                if (targetFramework.Version >= Constants.Version35)
                {
                    targetFrameworkDependencies.Add(new LibraryDependency
                    {
                        LibraryRange = new LibraryRange("System.Core", frameworkReference: true)
                    });

                    if (targetFramework.Version >= Constants.Version40)
                    {
                        targetFrameworkDependencies.Add(new LibraryDependency
                        {
                            LibraryRange = new LibraryRange("Microsoft.CSharp", frameworkReference: true)
                        });
                    }
                }
            }

            var dependencies = project.Dependencies.Concat(targetFrameworkDependencies).ToList();

            var loadableAssemblies = new List<string>();

            if (project.IsLoadable)
            {
                loadableAssemblies.Add(project.Name);
            }

            // Mark the library as unresolved if there were specified frameworks
            // and none of them resolved
            bool unresolved = targetFrameworkInfo.FrameworkName == null &&
                              project.GetTargetFrameworks().Any();

            return new ProjectDescription(
                libraryRange,
                project,
                dependencies,
                loadableAssemblies,
                targetFrameworkInfo,
                !unresolved);
        }
    }
}
