﻿// Decompiled with JetBrains decompiler
// Type: UnmanagedExports.Parsing.IlDasm
// Assembly: UnmanagedExports, Version=1.2.7.38850, Culture=neutral, PublicKeyToken=8f52d83c1a22df51
// MVID: C9BFF197-CAB3-40A6-BA31-9260266DE1B7
// Assembly location: C:\Users\k.gosse\.nuget\packages\unmanagedexports.repack\1.0.0\tasks\UnmanagedExports.dll

using System;
using System.Globalization;
using System.IO;
using System.Security.Permissions;

namespace UnmanagedExports.Parsing
{
  [PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
  public sealed class IlDasm : IlToolBase
  {
    public IlDasm(IServiceProvider serviceProvider, IInputValues inputValues)
      : base(serviceProvider, inputValues)
    {
    }

    public int Run()
    {
      return IlParser.RunIlTool(this.InputValues.SdkPath, "ildasm.exe", (string) null, (string) null, "ILDasmPath", string.Format((IFormatProvider) CultureInfo.InvariantCulture, "/quoteallnames /unicode /nobar{2}\"/out:{0}.il\" \"{1}\"", (object) Path.Combine(this.TempDirectory, this.InputValues.FileName), (object) this.InputValues.InputFileName, this.InputValues.EmitDebugSymbols ? (object) " /linenum " : (object) " "), DllExportLogginCodes.IlDasmLogging, DllExportLogginCodes.VerboseToolLogging, this.Notifier, this.Timeout, (Func<string, bool>) null);
    }
  }
}
