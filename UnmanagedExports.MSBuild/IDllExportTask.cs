// Decompiled with JetBrains decompiler
// Type: UnmanagedExports.MSBuild.IDllExportTask
// Assembly: UnmanagedExports.MSBuild, Version=1.2.7.38851, Culture=neutral, PublicKeyToken=8f52d83c1a22df51
// MVID: 94CA1E2E-92CF-42B1-82E4-1A993050CA42
// Assembly location: C:\Users\k.gosse\.nuget\packages\unmanagedexports.repack\1.0.0\tasks\UnmanagedExports.MSBuild.dll

using Microsoft.Build.Utilities;
using System;

namespace UnmanagedExports.MSBuild
{
  public interface IDllExportTask : IInputValues, IServiceProvider
  {
    TaskLoggingHelper Log { get; }

    bool? SkipOnAnyCpu { get; set; }

    string TargetFrameworkVersion { get; set; }

    string Platform { get; set; }

    string PlatformTarget { get; set; }
  }
}
