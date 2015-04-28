﻿using JustDecompile.EngineInfrastructure;
using Mono.Cecil;
using System.Collections.Generic;
using Telerik.JustDecompiler.External.Interfaces;
using Telerik.JustDecompiler.Languages;
namespace JustDecompile.Tools.MSBuildProjectBuilder
{
    public class TestWinRTProjectBuilder : WinRTProjectBuilder
    {
        public TestWinRTProjectBuilder(string assemblyPath, AssemblyDefinition assembly,
            Dictionary<ModuleDefinition, Mono.Collections.Generic.Collection<TypeDefinition>> userDefinedTypes,
            Dictionary<ModuleDefinition, Mono.Collections.Generic.Collection<Resource>> resources,
            string targetPath, ILanguage language, IDecompilationPreferences preferences, VisualStudioVersion visualStudioVersion, ProjectGenerationSettings projectGenerationSettings = null)
            : base(assemblyPath, assembly, userDefinedTypes, resources, targetPath, language, preferences, NoCacheAssemblyInfoService.Instance, visualStudioVersion, projectGenerationSettings)
        {
        }
    }
}