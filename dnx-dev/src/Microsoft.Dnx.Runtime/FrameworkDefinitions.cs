﻿using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Microsoft.Dnx.Runtime
{
    internal static class FrameworkDefinitions
    {
        private const string NetFrameworkIdentifier = ".NETFramework";

        public static bool TryPopulateFrameworkFastPath(string identifier, Version version, string referenceAssembliesPath, out FrameworkInformation frameworkInfo)
        {
            // 4.6
            if (identifier == NetFrameworkIdentifier &&
                version.Major == 4 &&
                version.Minor == 6)
            {
                frameworkInfo = PopulateNet46(referenceAssembliesPath);
                return true;
            }

            // 4.5.2
            if (identifier == NetFrameworkIdentifier &&
                version.Major == 4 &&
                version.Minor == 5 &&
                version.Build == 2)
            {
                frameworkInfo = PopulateNet452(referenceAssembliesPath);
                return true;
            }

            // 4.5.1
            if (identifier == NetFrameworkIdentifier &&
                version.Major == 4 &&
                version.Minor == 5 &&
                version.Build == 1)
            {
                frameworkInfo = PopulateNet451(referenceAssembliesPath);
                return true;
            }

            // 4.5
            if (identifier == NetFrameworkIdentifier &&
                version.Major == 4 &&
                version.Minor == 5)
            {
                frameworkInfo = PopulateNet45(referenceAssembliesPath);
                return true;
            }

            // 4.0
            if (identifier == NetFrameworkIdentifier &&
                version.Major == 4 &&
                version.Minor == 0)
            {
                frameworkInfo = PopulateNet40(referenceAssembliesPath);
                return true;
            }

            frameworkInfo = null;
            return false;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static FrameworkInformation PopulateNet46(string referenceAssembliesPath)
        {
            // Generated framework information for .NETFramework,Version=v4.6
            var frameworkInfo = new FrameworkInformation();
            frameworkInfo.Path = Path.Combine(referenceAssembliesPath, ".NETFramework", "v4.6");
            frameworkInfo.RedistListPath = Path.Combine(referenceAssembliesPath, ".NETFramework", "v4.6", "RedistList", "FrameworkList.xml");
            frameworkInfo.Name = ".NET Framework 4.6";
            frameworkInfo.SearchPaths = new[]
            {
                frameworkInfo.Path,
                Path.Combine(frameworkInfo.Path, "Facades")
            };
            frameworkInfo.Assemblies["Accessibility"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Accessibility.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["CustomMarshalers"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "CustomMarshalers.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["ISymWrapper"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "ISymWrapper.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.Activities.Build"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.Activities.Build.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.Build"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.Build.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.Build.Conversion.v4.0"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.Build.Conversion.v4.0.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.Build.Engine"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.Build.Engine.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.Build.Framework"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.Build.Framework.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.Build.Tasks.v4.0"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.Build.Tasks.v4.0.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.Build.Utilities.v4.0"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.Build.Utilities.v4.0.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.CSharp"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.CSharp.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.JScript"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.JScript.dll"), Version = new Version(10, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.VisualBasic"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.VisualBasic.dll"), Version = new Version(10, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.VisualBasic.Compatibility"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.VisualBasic.Compatibility.dll"), Version = new Version(10, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.VisualBasic.Compatibility.Data"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.VisualBasic.Compatibility.Data.dll"), Version = new Version(10, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.VisualC"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.VisualC.dll"), Version = new Version(10, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.VisualC.STLCLR"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.VisualC.STLCLR.dll"), Version = new Version(2, 0, 0, 0) };
            frameworkInfo.Assemblies["mscorlib"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "mscorlib.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationBuildTasks"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationBuildTasks.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationCore"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationCore.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationFramework.Aero"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationFramework.Aero.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationFramework.Aero2"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationFramework.Aero2.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationFramework.AeroLite"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationFramework.AeroLite.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationFramework.Classic"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationFramework.Classic.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationFramework"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationFramework.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationFramework.Luna"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationFramework.Luna.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationFramework.Royale"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationFramework.Royale.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["ReachFramework"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "ReachFramework.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["sysglobl"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "sysglobl.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Activities"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Activities.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Activities.Core.Presentation"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Activities.Core.Presentation.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Activities.DurableInstancing"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Activities.DurableInstancing.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Activities.Presentation"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Activities.Presentation.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Activities.Statements"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Activities.Statements.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.AddIn.Contract"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.AddIn.Contract.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.AddIn"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.AddIn.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ComponentModel.Composition"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ComponentModel.Composition.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ComponentModel.Composition.Registration"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ComponentModel.Composition.Registration.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ComponentModel.DataAnnotations"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ComponentModel.DataAnnotations.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Configuration"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Configuration.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Configuration.Install"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Configuration.Install.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Core"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Core.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.DataSetExtensions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.DataSetExtensions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.Entity.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.Entity.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.Entity"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.Entity.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.Linq"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.Linq.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.OracleClient"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.OracleClient.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.Services.Client"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.Services.Client.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.Services.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.Services.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.Services"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.Services.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.SqlXml"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.SqlXml.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Deployment"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Deployment.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Device"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Device.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.DirectoryServices.AccountManagement"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.DirectoryServices.AccountManagement.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.DirectoryServices"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.DirectoryServices.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.DirectoryServices.Protocols"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.DirectoryServices.Protocols.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Drawing.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Drawing.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Drawing"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Drawing.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Dynamic"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Dynamic.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.EnterpriseServices"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.EnterpriseServices.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.IdentityModel"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.IdentityModel.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.IdentityModel.Selectors"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.IdentityModel.Selectors.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.IdentityModel.Services"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.IdentityModel.Services.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.IO.Log"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.IO.Log.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.IO.Compression"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.IO.Compression.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.IO.Compression.FileSystem"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.IO.Compression.FileSystem.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Management"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Management.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Management.Instrumentation"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Management.Instrumentation.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Messaging"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Messaging.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Net"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Net.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Net.Http"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Net.Http.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Net.Http.WebRequest"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Net.Http.WebRequest.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Numerics"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Numerics.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Numerics.Vectors"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Numerics.Vectors.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Printing"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Printing.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Reflection.Context"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Reflection.Context.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.DurableInstancing"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Runtime.DurableInstancing.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Caching"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Runtime.Caching.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Remoting"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Runtime.Remoting.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Serialization"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Runtime.Serialization.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Serialization.Formatters.Soap"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Runtime.Serialization.Formatters.Soap.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Security"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Security.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Activation"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.Activation.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Activities"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.Activities.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Channels"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.Channels.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Discovery"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.Discovery.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Routing"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.Routing.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Web"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.Web.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceProcess"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceProcess.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Speech"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Speech.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Transactions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Transactions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Abstractions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Abstractions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.ApplicationServices"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.ApplicationServices.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.DataVisualization.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.DataVisualization.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.DataVisualization"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.DataVisualization.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.DynamicData.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.DynamicData.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.DynamicData"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.DynamicData.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Entity.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Entity.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Entity"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Entity.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Extensions.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Extensions.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Extensions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Extensions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Mobile"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Mobile.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.RegularExpressions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.RegularExpressions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Routing"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Routing.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Services"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Services.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Windows"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Windows.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Windows.Controls.Ribbon"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Windows.Controls.Ribbon.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Windows.Forms.DataVisualization.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Windows.Forms.DataVisualization.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Windows.Forms.DataVisualization"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Windows.Forms.DataVisualization.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Windows.Forms"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Windows.Forms.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Windows.Input.Manipulations"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Windows.Input.Manipulations.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Windows.Presentation"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Windows.Presentation.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Workflow.Activities"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Workflow.Activities.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Workflow.ComponentModel"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Workflow.ComponentModel.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Workflow.Runtime"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Workflow.Runtime.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.WorkflowServices"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.WorkflowServices.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Xaml"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Xaml.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Xml"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Xml.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Xml.Linq"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Xml.Linq.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Xml.Serialization"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Xml.Serialization.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["UIAutomationClient"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "UIAutomationClient.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["UIAutomationClientsideProviders"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "UIAutomationClientsideProviders.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["UIAutomationProvider"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "UIAutomationProvider.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["UIAutomationTypes"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "UIAutomationTypes.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["WindowsBase"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "WindowsBase.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["WindowsFormsIntegration"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "WindowsFormsIntegration.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["XamlBuildTask"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "XamlBuildTask.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Collections"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Collections.dll"), Version = new Version(4, 0, 10, 0) };
            frameworkInfo.Assemblies["System.Collections.Concurrent"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Collections.Concurrent.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ComponentModel"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ComponentModel.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ComponentModel.Annotations"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ComponentModel.Annotations.dll"), Version = new Version(4, 0, 10, 0) };
            frameworkInfo.Assemblies["System.ComponentModel.EventBasedAsync"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ComponentModel.EventBasedAsync.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Diagnostics.Contracts"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Diagnostics.Contracts.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Diagnostics.Debug"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Diagnostics.Debug.dll"), Version = new Version(4, 0, 10, 0) };
            frameworkInfo.Assemblies["System.Diagnostics.Tools"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Diagnostics.Tools.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Diagnostics.Tracing"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Diagnostics.Tracing.dll"), Version = new Version(4, 0, 10, 0) };
            frameworkInfo.Assemblies["System.Dynamic.Runtime"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Dynamic.Runtime.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Globalization"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Globalization.dll"), Version = new Version(4, 0, 10, 0) };
            frameworkInfo.Assemblies["System.IO"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.IO.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Linq"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Linq.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Linq.Expressions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Linq.Expressions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Linq.Parallel"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Linq.Parallel.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Linq.Queryable"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Linq.Queryable.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Net.NetworkInformation"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Net.NetworkInformation.dll"), Version = new Version(4, 0, 10, 0) };
            frameworkInfo.Assemblies["System.Net.Primitives"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Net.Primitives.dll"), Version = new Version(4, 0, 10, 0) };
            frameworkInfo.Assemblies["System.Net.Requests"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Net.Requests.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ObjectModel"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ObjectModel.dll"), Version = new Version(4, 0, 10, 0) };
            frameworkInfo.Assemblies["System.Reflection"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Reflection.dll"), Version = new Version(4, 0, 10, 0) };
            frameworkInfo.Assemblies["System.Reflection.Emit"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Reflection.Emit.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Reflection.Emit.ILGeneration"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Reflection.Emit.ILGeneration.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Reflection.Emit.Lightweight"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Reflection.Emit.Lightweight.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Reflection.Extensions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Reflection.Extensions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Reflection.Primitives"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Reflection.Primitives.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Resources.ResourceManager"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Resources.ResourceManager.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Runtime.dll"), Version = new Version(4, 0, 20, 0) };
            frameworkInfo.Assemblies["System.Runtime.Extensions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Runtime.Extensions.dll"), Version = new Version(4, 0, 10, 0) };
            frameworkInfo.Assemblies["System.Runtime.Handles"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Runtime.Handles.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.InteropServices"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Runtime.InteropServices.dll"), Version = new Version(4, 0, 20, 0) };
            frameworkInfo.Assemblies["System.Runtime.InteropServices.WindowsRuntime"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Runtime.InteropServices.WindowsRuntime.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Numerics"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Runtime.Numerics.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Serialization.Json"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Runtime.Serialization.Json.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Serialization.Primitives"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Runtime.Serialization.Primitives.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Serialization.Xml"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Runtime.Serialization.Xml.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Security.Principal"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Security.Principal.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Duplex"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ServiceModel.Duplex.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Http"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ServiceModel.Http.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.NetTcp"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ServiceModel.NetTcp.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Primitives"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ServiceModel.Primitives.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Security"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ServiceModel.Security.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Text.Encoding"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Text.Encoding.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Text.Encoding.Extensions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Text.Encoding.Extensions.dll"), Version = new Version(4, 0, 10, 0) };
            frameworkInfo.Assemblies["System.Text.RegularExpressions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Text.RegularExpressions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Threading"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Threading.dll"), Version = new Version(4, 0, 10, 0) };
            frameworkInfo.Assemblies["System.Threading.Tasks"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Threading.Tasks.dll"), Version = new Version(4, 0, 10, 0) };
            frameworkInfo.Assemblies["System.Threading.Tasks.Parallel"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Threading.Tasks.Parallel.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Threading.Timer"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Threading.Timer.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Xml.ReaderWriter"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Xml.ReaderWriter.dll"), Version = new Version(4, 0, 10, 0) };
            frameworkInfo.Assemblies["System.Xml.XDocument"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Xml.XDocument.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Xml.XmlSerializer"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Xml.XmlSerializer.dll"), Version = new Version(4, 0, 0, 0) };

            return frameworkInfo;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static FrameworkInformation PopulateNet452(string referenceAssembliesPath)
        {
            // Generated framework information for .NETFramework,Version=v4.5.2
            var frameworkInfo = new FrameworkInformation();
            frameworkInfo.Path = Path.Combine(referenceAssembliesPath, ".NETFramework", "v4.5.2");
            frameworkInfo.RedistListPath = Path.Combine(referenceAssembliesPath, ".NETFramework", "v4.5.2", "RedistList", "FrameworkList.xml");
            frameworkInfo.Name = ".NET Framework 4.5.2";
            frameworkInfo.SearchPaths = new[]
            {
                frameworkInfo.Path,
                Path.Combine(frameworkInfo.Path, "Facades")
            };
            frameworkInfo.Assemblies["Accessibility"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Accessibility.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["CustomMarshalers"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "CustomMarshalers.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["ISymWrapper"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "ISymWrapper.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.Activities.Build"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.Activities.Build.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.Build"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.Build.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.Build.Conversion.v4.0"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.Build.Conversion.v4.0.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.Build.Engine"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.Build.Engine.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.Build.Framework"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.Build.Framework.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.Build.Tasks.v4.0"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.Build.Tasks.v4.0.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.Build.Utilities.v4.0"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.Build.Utilities.v4.0.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.CSharp"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.CSharp.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.JScript"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.JScript.dll"), Version = new Version(10, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.VisualBasic"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.VisualBasic.dll"), Version = new Version(10, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.VisualBasic.Compatibility"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.VisualBasic.Compatibility.dll"), Version = new Version(10, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.VisualBasic.Compatibility.Data"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.VisualBasic.Compatibility.Data.dll"), Version = new Version(10, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.VisualC"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.VisualC.dll"), Version = new Version(10, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.VisualC.STLCLR"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.VisualC.STLCLR.dll"), Version = new Version(2, 0, 0, 0) };
            frameworkInfo.Assemblies["mscorlib"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "mscorlib.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationBuildTasks"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationBuildTasks.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationCore"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationCore.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationFramework.Aero"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationFramework.Aero.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationFramework.Aero2"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationFramework.Aero2.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationFramework.AeroLite"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationFramework.AeroLite.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationFramework.Classic"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationFramework.Classic.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationFramework"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationFramework.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationFramework.Luna"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationFramework.Luna.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationFramework.Royale"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationFramework.Royale.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["ReachFramework"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "ReachFramework.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["sysglobl"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "sysglobl.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Activities"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Activities.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Activities.Core.Presentation"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Activities.Core.Presentation.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Activities.DurableInstancing"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Activities.DurableInstancing.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Activities.Presentation"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Activities.Presentation.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Activities.Statements"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Activities.Statements.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.AddIn.Contract"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.AddIn.Contract.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.AddIn"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.AddIn.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ComponentModel.Composition"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ComponentModel.Composition.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ComponentModel.Composition.Registration"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ComponentModel.Composition.Registration.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ComponentModel.DataAnnotations"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ComponentModel.DataAnnotations.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Configuration"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Configuration.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Configuration.Install"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Configuration.Install.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Core"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Core.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.DataSetExtensions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.DataSetExtensions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.Entity.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.Entity.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.Entity"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.Entity.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.Linq"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.Linq.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.OracleClient"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.OracleClient.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.Services.Client"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.Services.Client.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.Services.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.Services.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.Services"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.Services.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.SqlXml"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.SqlXml.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Deployment"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Deployment.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Device"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Device.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.DirectoryServices.AccountManagement"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.DirectoryServices.AccountManagement.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.DirectoryServices"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.DirectoryServices.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.DirectoryServices.Protocols"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.DirectoryServices.Protocols.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Drawing.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Drawing.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Drawing"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Drawing.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Dynamic"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Dynamic.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.EnterpriseServices"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.EnterpriseServices.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.IdentityModel"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.IdentityModel.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.IdentityModel.Selectors"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.IdentityModel.Selectors.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.IdentityModel.Services"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.IdentityModel.Services.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.IO.Log"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.IO.Log.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.IO.Compression"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.IO.Compression.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.IO.Compression.FileSystem"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.IO.Compression.FileSystem.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Management"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Management.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Management.Instrumentation"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Management.Instrumentation.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Messaging"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Messaging.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Net"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Net.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Net.Http"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Net.Http.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Net.Http.WebRequest"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Net.Http.WebRequest.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Numerics"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Numerics.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Printing"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Printing.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Reflection.Context"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Reflection.Context.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.DurableInstancing"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Runtime.DurableInstancing.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Caching"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Runtime.Caching.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Remoting"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Runtime.Remoting.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Serialization"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Runtime.Serialization.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Serialization.Formatters.Soap"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Runtime.Serialization.Formatters.Soap.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Security"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Security.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Activation"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.Activation.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Activities"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.Activities.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Channels"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.Channels.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Discovery"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.Discovery.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Routing"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.Routing.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Web"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.Web.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceProcess"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceProcess.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Speech"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Speech.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Transactions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Transactions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Abstractions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Abstractions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.ApplicationServices"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.ApplicationServices.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.DataVisualization.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.DataVisualization.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.DataVisualization"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.DataVisualization.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.DynamicData.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.DynamicData.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.DynamicData"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.DynamicData.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Entity.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Entity.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Entity"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Entity.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Extensions.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Extensions.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Extensions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Extensions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Mobile"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Mobile.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.RegularExpressions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.RegularExpressions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Routing"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Routing.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Services"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Services.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Windows"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Windows.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Windows.Controls.Ribbon"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Windows.Controls.Ribbon.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Windows.Forms.DataVisualization.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Windows.Forms.DataVisualization.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Windows.Forms.DataVisualization"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Windows.Forms.DataVisualization.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Windows.Forms"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Windows.Forms.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Windows.Input.Manipulations"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Windows.Input.Manipulations.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Windows.Presentation"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Windows.Presentation.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Workflow.Activities"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Workflow.Activities.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Workflow.ComponentModel"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Workflow.ComponentModel.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Workflow.Runtime"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Workflow.Runtime.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.WorkflowServices"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.WorkflowServices.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Xaml"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Xaml.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Xml"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Xml.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Xml.Linq"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Xml.Linq.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Xml.Serialization"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Xml.Serialization.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["UIAutomationClient"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "UIAutomationClient.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["UIAutomationClientsideProviders"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "UIAutomationClientsideProviders.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["UIAutomationProvider"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "UIAutomationProvider.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["UIAutomationTypes"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "UIAutomationTypes.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["WindowsBase"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "WindowsBase.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["WindowsFormsIntegration"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "WindowsFormsIntegration.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["XamlBuildTask"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "XamlBuildTask.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Collections"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Collections.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Collections.Concurrent"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Collections.Concurrent.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ComponentModel"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ComponentModel.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ComponentModel.Annotations"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ComponentModel.Annotations.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ComponentModel.EventBasedAsync"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ComponentModel.EventBasedAsync.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Diagnostics.Contracts"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Diagnostics.Contracts.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Diagnostics.Debug"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Diagnostics.Debug.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Diagnostics.Tools"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Diagnostics.Tools.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Diagnostics.Tracing"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Diagnostics.Tracing.dll"), Version = new Version(4, 0, 10, 0) };
            frameworkInfo.Assemblies["System.Dynamic.Runtime"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Dynamic.Runtime.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Globalization"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Globalization.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.IO"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.IO.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Linq"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Linq.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Linq.Expressions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Linq.Expressions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Linq.Parallel"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Linq.Parallel.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Linq.Queryable"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Linq.Queryable.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Net.NetworkInformation"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Net.NetworkInformation.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Net.Primitives"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Net.Primitives.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Net.Requests"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Net.Requests.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ObjectModel"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ObjectModel.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Reflection"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Reflection.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Reflection.Emit"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Reflection.Emit.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Reflection.Emit.ILGeneration"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Reflection.Emit.ILGeneration.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Reflection.Emit.Lightweight"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Reflection.Emit.Lightweight.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Reflection.Extensions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Reflection.Extensions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Reflection.Primitives"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Reflection.Primitives.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Resources.ResourceManager"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Resources.ResourceManager.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Runtime.dll"), Version = new Version(4, 0, 10, 0) };
            frameworkInfo.Assemblies["System.Runtime.Extensions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Runtime.Extensions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.InteropServices"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Runtime.InteropServices.dll"), Version = new Version(4, 0, 10, 0) };
            frameworkInfo.Assemblies["System.Runtime.InteropServices.WindowsRuntime"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Runtime.InteropServices.WindowsRuntime.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Numerics"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Runtime.Numerics.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Serialization.Json"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Runtime.Serialization.Json.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Serialization.Primitives"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Runtime.Serialization.Primitives.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Serialization.Xml"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Runtime.Serialization.Xml.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Security.Principal"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Security.Principal.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Duplex"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ServiceModel.Duplex.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Http"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ServiceModel.Http.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.NetTcp"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ServiceModel.NetTcp.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Primitives"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ServiceModel.Primitives.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Security"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ServiceModel.Security.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Text.Encoding"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Text.Encoding.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Text.Encoding.Extensions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Text.Encoding.Extensions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Text.RegularExpressions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Text.RegularExpressions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Threading"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Threading.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Threading.Tasks"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Threading.Tasks.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Threading.Tasks.Parallel"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Threading.Tasks.Parallel.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Threading.Timer"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Threading.Timer.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Xml.ReaderWriter"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Xml.ReaderWriter.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Xml.XDocument"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Xml.XDocument.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Xml.XmlSerializer"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Xml.XmlSerializer.dll"), Version = new Version(4, 0, 0, 0) };

            return frameworkInfo;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static FrameworkInformation PopulateNet451(string referenceAssembliesPath)
        {
            // Generated framework information for .NETFramework,Version=v4.5.1
            var frameworkInfo = new FrameworkInformation();
            frameworkInfo.Path = Path.Combine(referenceAssembliesPath, ".NETFramework", "v4.5.1");
            frameworkInfo.RedistListPath = Path.Combine(referenceAssembliesPath, ".NETFramework", "v4.5.1", "RedistList", "FrameworkList.xml");
            frameworkInfo.Name = ".NET Framework 4.5.1";
            frameworkInfo.SearchPaths = new[]
            {
                frameworkInfo.Path,
                Path.Combine(frameworkInfo.Path, "Facades")
            };
            frameworkInfo.Assemblies["Accessibility"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Accessibility.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["CustomMarshalers"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "CustomMarshalers.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["ISymWrapper"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "ISymWrapper.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.Activities.Build"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.Activities.Build.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.Build"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.Build.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.Build.Conversion.v4.0"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.Build.Conversion.v4.0.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.Build.Engine"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.Build.Engine.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.Build.Framework"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.Build.Framework.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.Build.Tasks.v4.0"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.Build.Tasks.v4.0.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.Build.Utilities.v4.0"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.Build.Utilities.v4.0.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.CSharp"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.CSharp.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.JScript"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.JScript.dll"), Version = new Version(10, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.VisualBasic"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.VisualBasic.dll"), Version = new Version(10, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.VisualBasic.Compatibility"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.VisualBasic.Compatibility.dll"), Version = new Version(10, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.VisualBasic.Compatibility.Data"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.VisualBasic.Compatibility.Data.dll"), Version = new Version(10, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.VisualC"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.VisualC.dll"), Version = new Version(10, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.VisualC.STLCLR"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.VisualC.STLCLR.dll"), Version = new Version(2, 0, 0, 0) };
            frameworkInfo.Assemblies["mscorlib"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "mscorlib.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationBuildTasks"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationBuildTasks.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationCore"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationCore.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationFramework.Aero"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationFramework.Aero.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationFramework.Aero2"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationFramework.Aero2.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationFramework.AeroLite"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationFramework.AeroLite.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationFramework.Classic"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationFramework.Classic.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationFramework"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationFramework.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationFramework.Luna"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationFramework.Luna.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationFramework.Royale"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationFramework.Royale.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["ReachFramework"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "ReachFramework.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["sysglobl"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "sysglobl.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Activities"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Activities.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Activities.Core.Presentation"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Activities.Core.Presentation.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Activities.DurableInstancing"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Activities.DurableInstancing.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Activities.Presentation"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Activities.Presentation.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Activities.Statements"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Activities.Statements.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.AddIn.Contract"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.AddIn.Contract.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.AddIn"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.AddIn.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ComponentModel.Composition"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ComponentModel.Composition.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ComponentModel.Composition.Registration"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ComponentModel.Composition.Registration.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ComponentModel.DataAnnotations"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ComponentModel.DataAnnotations.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Configuration"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Configuration.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Configuration.Install"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Configuration.Install.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Core"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Core.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.DataSetExtensions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.DataSetExtensions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.Entity.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.Entity.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.Entity"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.Entity.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.Linq"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.Linq.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.OracleClient"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.OracleClient.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.Services.Client"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.Services.Client.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.Services.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.Services.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.Services"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.Services.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.SqlXml"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.SqlXml.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Deployment"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Deployment.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Device"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Device.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.DirectoryServices.AccountManagement"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.DirectoryServices.AccountManagement.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.DirectoryServices"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.DirectoryServices.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.DirectoryServices.Protocols"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.DirectoryServices.Protocols.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Drawing.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Drawing.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Drawing"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Drawing.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Dynamic"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Dynamic.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.EnterpriseServices"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.EnterpriseServices.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.IdentityModel"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.IdentityModel.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.IdentityModel.Selectors"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.IdentityModel.Selectors.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.IdentityModel.Services"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.IdentityModel.Services.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.IO.Log"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.IO.Log.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.IO.Compression"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.IO.Compression.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.IO.Compression.FileSystem"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.IO.Compression.FileSystem.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Management"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Management.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Management.Instrumentation"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Management.Instrumentation.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Messaging"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Messaging.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Net"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Net.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Net.Http"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Net.Http.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Net.Http.WebRequest"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Net.Http.WebRequest.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Numerics"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Numerics.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Printing"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Printing.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Reflection.Context"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Reflection.Context.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.DurableInstancing"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Runtime.DurableInstancing.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Caching"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Runtime.Caching.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Remoting"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Runtime.Remoting.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Serialization"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Runtime.Serialization.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Serialization.Formatters.Soap"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Runtime.Serialization.Formatters.Soap.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Security"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Security.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Activation"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.Activation.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Activities"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.Activities.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Channels"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.Channels.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Discovery"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.Discovery.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Routing"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.Routing.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Web"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.Web.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceProcess"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceProcess.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Speech"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Speech.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Transactions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Transactions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Abstractions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Abstractions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.ApplicationServices"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.ApplicationServices.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.DataVisualization.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.DataVisualization.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.DataVisualization"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.DataVisualization.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.DynamicData.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.DynamicData.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.DynamicData"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.DynamicData.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Entity.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Entity.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Entity"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Entity.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Extensions.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Extensions.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Extensions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Extensions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Mobile"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Mobile.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.RegularExpressions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.RegularExpressions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Routing"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Routing.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Services"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Services.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Windows"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Windows.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Windows.Controls.Ribbon"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Windows.Controls.Ribbon.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Windows.Forms.DataVisualization.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Windows.Forms.DataVisualization.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Windows.Forms.DataVisualization"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Windows.Forms.DataVisualization.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Windows.Forms"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Windows.Forms.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Windows.Input.Manipulations"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Windows.Input.Manipulations.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Windows.Presentation"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Windows.Presentation.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Workflow.Activities"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Workflow.Activities.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Workflow.ComponentModel"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Workflow.ComponentModel.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Workflow.Runtime"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Workflow.Runtime.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.WorkflowServices"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.WorkflowServices.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Xaml"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Xaml.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Xml"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Xml.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Xml.Linq"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Xml.Linq.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Xml.Serialization"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Xml.Serialization.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["UIAutomationClient"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "UIAutomationClient.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["UIAutomationClientsideProviders"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "UIAutomationClientsideProviders.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["UIAutomationProvider"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "UIAutomationProvider.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["UIAutomationTypes"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "UIAutomationTypes.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["WindowsBase"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "WindowsBase.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["WindowsFormsIntegration"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "WindowsFormsIntegration.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["XamlBuildTask"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "XamlBuildTask.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Collections"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Collections.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Collections.Concurrent"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Collections.Concurrent.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ComponentModel"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ComponentModel.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ComponentModel.Annotations"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ComponentModel.Annotations.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ComponentModel.EventBasedAsync"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ComponentModel.EventBasedAsync.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Diagnostics.Contracts"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Diagnostics.Contracts.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Diagnostics.Debug"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Diagnostics.Debug.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Diagnostics.Tools"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Diagnostics.Tools.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Diagnostics.Tracing"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Diagnostics.Tracing.dll"), Version = new Version(4, 0, 10, 0) };
            frameworkInfo.Assemblies["System.Dynamic.Runtime"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Dynamic.Runtime.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Globalization"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Globalization.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.IO"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.IO.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Linq"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Linq.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Linq.Expressions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Linq.Expressions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Linq.Parallel"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Linq.Parallel.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Linq.Queryable"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Linq.Queryable.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Net.NetworkInformation"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Net.NetworkInformation.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Net.Primitives"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Net.Primitives.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Net.Requests"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Net.Requests.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ObjectModel"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ObjectModel.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Reflection"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Reflection.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Reflection.Emit"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Reflection.Emit.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Reflection.Emit.ILGeneration"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Reflection.Emit.ILGeneration.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Reflection.Emit.Lightweight"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Reflection.Emit.Lightweight.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Reflection.Extensions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Reflection.Extensions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Reflection.Primitives"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Reflection.Primitives.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Resources.ResourceManager"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Resources.ResourceManager.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Runtime.dll"), Version = new Version(4, 0, 10, 0) };
            frameworkInfo.Assemblies["System.Runtime.Extensions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Runtime.Extensions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.InteropServices"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Runtime.InteropServices.dll"), Version = new Version(4, 0, 10, 0) };
            frameworkInfo.Assemblies["System.Runtime.InteropServices.WindowsRuntime"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Runtime.InteropServices.WindowsRuntime.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Numerics"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Runtime.Numerics.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Serialization.Json"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Runtime.Serialization.Json.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Serialization.Primitives"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Runtime.Serialization.Primitives.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Serialization.Xml"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Runtime.Serialization.Xml.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Security.Principal"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Security.Principal.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Duplex"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ServiceModel.Duplex.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Http"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ServiceModel.Http.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.NetTcp"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ServiceModel.NetTcp.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Primitives"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ServiceModel.Primitives.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Security"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ServiceModel.Security.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Text.Encoding"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Text.Encoding.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Text.Encoding.Extensions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Text.Encoding.Extensions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Text.RegularExpressions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Text.RegularExpressions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Threading"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Threading.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Threading.Tasks"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Threading.Tasks.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Threading.Tasks.Parallel"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Threading.Tasks.Parallel.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Threading.Timer"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Threading.Timer.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Xml.ReaderWriter"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Xml.ReaderWriter.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Xml.XDocument"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Xml.XDocument.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Xml.XmlSerializer"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Xml.XmlSerializer.dll"), Version = new Version(4, 0, 0, 0) };

            return frameworkInfo;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static FrameworkInformation PopulateNet45(string referenceAssembliesPath)
        {
            var frameworkInfo = new FrameworkInformation();
            // Generated framework information for .NETFramework,Version=v4.5
            frameworkInfo.Path = Path.Combine(referenceAssembliesPath, ".NETFramework", "v4.5");
            frameworkInfo.RedistListPath = Path.Combine(referenceAssembliesPath, ".NETFramework", "v4.5", "RedistList", "FrameworkList.xml");
            frameworkInfo.Name = ".NET Framework 4.5";
            frameworkInfo.SearchPaths = new[]
            {
                frameworkInfo.Path,
                Path.Combine(frameworkInfo.Path, "Facades")
            };
            frameworkInfo.Assemblies["Accessibility"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Accessibility.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["CustomMarshalers"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "CustomMarshalers.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["ISymWrapper"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "ISymWrapper.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.Activities.Build"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.Activities.Build.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.Build"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.Build.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.Build.Conversion.v4.0"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.Build.Conversion.v4.0.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.Build.Engine"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.Build.Engine.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.Build.Framework"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.Build.Framework.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.Build.Tasks.v4.0"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.Build.Tasks.v4.0.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.Build.Utilities.v4.0"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.Build.Utilities.v4.0.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.CSharp"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.CSharp.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.JScript"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.JScript.dll"), Version = new Version(10, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.VisualBasic"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.VisualBasic.dll"), Version = new Version(10, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.VisualBasic.Compatibility"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.VisualBasic.Compatibility.dll"), Version = new Version(10, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.VisualBasic.Compatibility.Data"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.VisualBasic.Compatibility.Data.dll"), Version = new Version(10, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.VisualC"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.VisualC.dll"), Version = new Version(10, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.VisualC.STLCLR"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.VisualC.STLCLR.dll"), Version = new Version(2, 0, 0, 0) };
            frameworkInfo.Assemblies["mscorlib"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "mscorlib.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationBuildTasks"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationBuildTasks.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationCore"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationCore.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationFramework.Aero"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationFramework.Aero.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationFramework.Aero2"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationFramework.Aero2.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationFramework.AeroLite"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationFramework.AeroLite.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationFramework.Classic"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationFramework.Classic.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationFramework"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationFramework.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationFramework.Luna"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationFramework.Luna.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationFramework.Royale"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationFramework.Royale.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["ReachFramework"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "ReachFramework.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["sysglobl"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "sysglobl.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Activities"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Activities.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Activities.Core.Presentation"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Activities.Core.Presentation.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Activities.DurableInstancing"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Activities.DurableInstancing.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Activities.Presentation"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Activities.Presentation.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Activities.Statements"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Activities.Statements.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.AddIn.Contract"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.AddIn.Contract.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.AddIn"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.AddIn.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ComponentModel.Composition"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ComponentModel.Composition.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ComponentModel.Composition.Registration"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ComponentModel.Composition.Registration.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ComponentModel.DataAnnotations"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ComponentModel.DataAnnotations.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Configuration"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Configuration.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Configuration.Install"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Configuration.Install.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Core"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Core.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.DataSetExtensions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.DataSetExtensions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.Entity.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.Entity.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.Entity"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.Entity.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.Linq"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.Linq.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.OracleClient"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.OracleClient.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.Services.Client"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.Services.Client.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.Services.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.Services.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.Services"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.Services.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.SqlXml"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.SqlXml.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Deployment"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Deployment.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Device"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Device.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.DirectoryServices.AccountManagement"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.DirectoryServices.AccountManagement.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.DirectoryServices"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.DirectoryServices.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.DirectoryServices.Protocols"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.DirectoryServices.Protocols.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Drawing.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Drawing.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Drawing"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Drawing.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Dynamic"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Dynamic.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.EnterpriseServices"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.EnterpriseServices.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.IdentityModel"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.IdentityModel.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.IdentityModel.Selectors"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.IdentityModel.Selectors.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.IdentityModel.Services"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.IdentityModel.Services.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.IO.Log"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.IO.Log.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.IO.Compression"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.IO.Compression.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.IO.Compression.FileSystem"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.IO.Compression.FileSystem.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Management"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Management.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Management.Instrumentation"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Management.Instrumentation.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Messaging"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Messaging.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Net"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Net.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Net.Http"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Net.Http.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Net.Http.WebRequest"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Net.Http.WebRequest.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Numerics"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Numerics.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Printing"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Printing.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Reflection.Context"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Reflection.Context.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.DurableInstancing"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Runtime.DurableInstancing.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Caching"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Runtime.Caching.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Remoting"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Runtime.Remoting.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Serialization"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Runtime.Serialization.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Serialization.Formatters.Soap"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Runtime.Serialization.Formatters.Soap.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Security"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Security.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Activation"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.Activation.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Activities"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.Activities.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Channels"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.Channels.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Discovery"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.Discovery.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Routing"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.Routing.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Web"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.Web.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceProcess"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceProcess.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Speech"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Speech.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Transactions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Transactions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Abstractions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Abstractions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.ApplicationServices"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.ApplicationServices.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.DataVisualization.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.DataVisualization.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.DataVisualization"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.DataVisualization.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.DynamicData.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.DynamicData.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.DynamicData"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.DynamicData.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Entity.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Entity.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Entity"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Entity.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Extensions.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Extensions.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Extensions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Extensions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Mobile"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Mobile.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.RegularExpressions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.RegularExpressions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Routing"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Routing.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Services"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Services.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Windows"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Windows.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Windows.Controls.Ribbon"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Windows.Controls.Ribbon.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Windows.Forms.DataVisualization.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Windows.Forms.DataVisualization.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Windows.Forms.DataVisualization"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Windows.Forms.DataVisualization.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Windows.Forms"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Windows.Forms.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Windows.Input.Manipulations"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Windows.Input.Manipulations.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Windows.Presentation"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Windows.Presentation.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Workflow.Activities"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Workflow.Activities.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Workflow.ComponentModel"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Workflow.ComponentModel.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Workflow.Runtime"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Workflow.Runtime.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.WorkflowServices"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.WorkflowServices.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Xaml"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Xaml.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Xml"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Xml.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Xml.Linq"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Xml.Linq.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Xml.Serialization"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Xml.Serialization.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["UIAutomationClient"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "UIAutomationClient.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["UIAutomationClientsideProviders"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "UIAutomationClientsideProviders.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["UIAutomationProvider"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "UIAutomationProvider.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["UIAutomationTypes"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "UIAutomationTypes.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["WindowsBase"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "WindowsBase.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["WindowsFormsIntegration"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "WindowsFormsIntegration.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["XamlBuildTask"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "XamlBuildTask.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Collections"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Collections.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Collections.Concurrent"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Collections.Concurrent.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ComponentModel"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ComponentModel.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ComponentModel.Annotations"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ComponentModel.Annotations.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ComponentModel.EventBasedAsync"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ComponentModel.EventBasedAsync.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Diagnostics.Contracts"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Diagnostics.Contracts.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Diagnostics.Debug"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Diagnostics.Debug.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Diagnostics.Tools"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Diagnostics.Tools.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Diagnostics.Tracing"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Diagnostics.Tracing.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Dynamic.Runtime"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Dynamic.Runtime.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Globalization"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Globalization.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.IO"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.IO.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Linq"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Linq.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Linq.Expressions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Linq.Expressions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Linq.Parallel"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Linq.Parallel.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Linq.Queryable"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Linq.Queryable.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Net.NetworkInformation"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Net.NetworkInformation.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Net.Primitives"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Net.Primitives.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Net.Requests"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Net.Requests.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ObjectModel"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ObjectModel.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Reflection"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Reflection.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Reflection.Emit"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Reflection.Emit.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Reflection.Emit.ILGeneration"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Reflection.Emit.ILGeneration.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Reflection.Emit.Lightweight"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Reflection.Emit.Lightweight.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Reflection.Extensions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Reflection.Extensions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Reflection.Primitives"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Reflection.Primitives.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Resources.ResourceManager"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Resources.ResourceManager.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Runtime.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Extensions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Runtime.Extensions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.InteropServices"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Runtime.InteropServices.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.InteropServices.WindowsRuntime"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Runtime.InteropServices.WindowsRuntime.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Numerics"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Runtime.Numerics.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Serialization.Json"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Runtime.Serialization.Json.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Serialization.Primitives"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Runtime.Serialization.Primitives.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Serialization.Xml"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Runtime.Serialization.Xml.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Security.Principal"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Security.Principal.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Duplex"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ServiceModel.Duplex.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Http"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ServiceModel.Http.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.NetTcp"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ServiceModel.NetTcp.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Primitives"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ServiceModel.Primitives.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Security"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.ServiceModel.Security.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Text.Encoding"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Text.Encoding.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Text.Encoding.Extensions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Text.Encoding.Extensions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Text.RegularExpressions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Text.RegularExpressions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Threading"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Threading.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Threading.Tasks"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Threading.Tasks.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Threading.Tasks.Parallel"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Threading.Tasks.Parallel.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Xml.ReaderWriter"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Xml.ReaderWriter.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Xml.XDocument"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Xml.XDocument.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Xml.XmlSerializer"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Facades", "System.Xml.XmlSerializer.dll"), Version = new Version(4, 0, 0, 0) };

            return frameworkInfo;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static FrameworkInformation PopulateNet40(string referenceAssembliesPath)
        {
            // Generated framework information for .NETFramework,Version=v4.0
            var frameworkInfo = new FrameworkInformation();
            frameworkInfo.Path = Path.Combine(referenceAssembliesPath, ".NETFramework", "v4.0");
            frameworkInfo.RedistListPath = Path.Combine(referenceAssembliesPath, ".NETFramework", "v4.0", "RedistList", "FrameworkList.xml");
            frameworkInfo.Name = ".NET Framework 4";
            frameworkInfo.SearchPaths = new[]
            {
                frameworkInfo.Path,
                Path.Combine(frameworkInfo.Path, "Facades")
            };
            frameworkInfo.Assemblies["Accessibility"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Accessibility.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["CustomMarshalers"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "CustomMarshalers.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["ISymWrapper"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "ISymWrapper.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.Build"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.Build.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.Build.Conversion.v4.0"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.Build.Conversion.v4.0.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.Build.Engine"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.Build.Engine.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.Build.Framework"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.Build.Framework.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.Build.Tasks.v4.0"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.Build.Tasks.v4.0.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.Build.Utilities.v4.0"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.Build.Utilities.v4.0.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.CSharp"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.CSharp.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.JScript"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.JScript.dll"), Version = new Version(10, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.VisualBasic"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.VisualBasic.dll"), Version = new Version(10, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.VisualBasic.Compatibility"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.VisualBasic.Compatibility.dll"), Version = new Version(10, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.VisualBasic.Compatibility.Data"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.VisualBasic.Compatibility.Data.dll"), Version = new Version(10, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.VisualC"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.VisualC.dll"), Version = new Version(10, 0, 0, 0) };
            frameworkInfo.Assemblies["Microsoft.VisualC.STLCLR"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "Microsoft.VisualC.STLCLR.dll"), Version = new Version(2, 0, 0, 0) };
            frameworkInfo.Assemblies["mscorlib"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "mscorlib.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationBuildTasks"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationBuildTasks.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationCore"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationCore.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationFramework.Aero"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationFramework.Aero.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationFramework.Classic"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationFramework.Classic.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationFramework"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationFramework.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationFramework.Luna"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationFramework.Luna.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["PresentationFramework.Royale"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "PresentationFramework.Royale.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["ReachFramework"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "ReachFramework.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["sysglobl"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "sysglobl.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Activities"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Activities.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Activities.Core.Presentation"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Activities.Core.Presentation.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Activities.DurableInstancing"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Activities.DurableInstancing.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Activities.Presentation"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Activities.Presentation.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.AddIn.Contract"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.AddIn.Contract.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.AddIn"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.AddIn.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ComponentModel.Composition"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ComponentModel.Composition.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ComponentModel.DataAnnotations"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ComponentModel.DataAnnotations.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Configuration"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Configuration.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Configuration.Install"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Configuration.Install.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Core"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Core.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.DataSetExtensions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.DataSetExtensions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.Entity.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.Entity.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.Entity"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.Entity.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.Linq"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.Linq.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.OracleClient"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.OracleClient.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.Services.Client"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.Services.Client.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.Services.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.Services.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.Services"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.Services.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Data.SqlXml"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Data.SqlXml.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Deployment"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Deployment.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Device"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Device.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.DirectoryServices.AccountManagement"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.DirectoryServices.AccountManagement.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.DirectoryServices"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.DirectoryServices.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.DirectoryServices.Protocols"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.DirectoryServices.Protocols.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Drawing.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Drawing.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Drawing"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Drawing.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Dynamic"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Dynamic.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.EnterpriseServices"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.EnterpriseServices.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.IdentityModel"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.IdentityModel.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.IdentityModel.Selectors"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.IdentityModel.Selectors.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.IO.Log"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.IO.Log.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Management"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Management.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Management.Instrumentation"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Management.Instrumentation.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Messaging"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Messaging.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Net"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Net.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Numerics"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Numerics.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Printing"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Printing.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.DurableInstancing"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Runtime.DurableInstancing.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Caching"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Runtime.Caching.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Remoting"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Runtime.Remoting.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Serialization"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Runtime.Serialization.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Runtime.Serialization.Formatters.Soap"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Runtime.Serialization.Formatters.Soap.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Security"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Security.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Activation"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.Activation.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Activities"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.Activities.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Channels"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.Channels.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Discovery"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.Discovery.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Routing"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.Routing.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceModel.Web"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceModel.Web.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.ServiceProcess"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.ServiceProcess.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Speech"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Speech.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Transactions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Transactions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Abstractions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Abstractions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.ApplicationServices"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.ApplicationServices.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.DataVisualization.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.DataVisualization.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.DataVisualization"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.DataVisualization.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.DynamicData.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.DynamicData.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.DynamicData"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.DynamicData.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Entity.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Entity.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Entity"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Entity.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Extensions.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Extensions.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Extensions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Extensions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Mobile"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Mobile.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.RegularExpressions"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.RegularExpressions.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Routing"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Routing.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Web.Services"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Web.Services.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Windows.Forms.DataVisualization.Design"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Windows.Forms.DataVisualization.Design.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Windows.Forms.DataVisualization"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Windows.Forms.DataVisualization.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Windows.Forms"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Windows.Forms.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Windows.Input.Manipulations"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Windows.Input.Manipulations.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Windows.Presentation"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Windows.Presentation.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Workflow.Activities"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Workflow.Activities.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Workflow.ComponentModel"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Workflow.ComponentModel.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Workflow.Runtime"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Workflow.Runtime.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.WorkflowServices"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.WorkflowServices.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Xaml"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Xaml.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Xml"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Xml.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["System.Xml.Linq"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "System.Xml.Linq.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["UIAutomationClient"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "UIAutomationClient.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["UIAutomationClientsideProviders"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "UIAutomationClientsideProviders.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["UIAutomationProvider"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "UIAutomationProvider.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["UIAutomationTypes"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "UIAutomationTypes.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["WindowsBase"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "WindowsBase.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["WindowsFormsIntegration"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "WindowsFormsIntegration.dll"), Version = new Version(4, 0, 0, 0) };
            frameworkInfo.Assemblies["XamlBuildTask"] = new AssemblyEntry { Path = Path.Combine(frameworkInfo.Path, "XamlBuildTask.dll"), Version = new Version(4, 0, 0, 0) };

            return frameworkInfo;
        }

    }
}