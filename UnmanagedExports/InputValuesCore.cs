﻿// Decompiled with JetBrains decompiler
// Type: UnmanagedExports.InputValuesCore
// Assembly: UnmanagedExports, Version=1.2.7.38850, Culture=neutral, PublicKeyToken=8f52d83c1a22df51
// MVID: C9BFF197-CAB3-40A6-BA31-9260266DE1B7
// Assembly location: C:\Users\k.gosse\.nuget\packages\unmanagedexports.repack\1.0.0\tasks\UnmanagedExports.dll

using UnmanagedExports.Parsing;
using System;
using System.IO;
using System.Threading;

namespace UnmanagedExports
{
  public class InputValuesCore : HasServiceProvider, IInputValues
  {
    private string _DllExportAttributeAssemblyName = Utilities.DllExportAttributeAssemblyName;
    private string _DllExportAttributeFullName = Utilities.DllExportAttributeFullName;
    private string _Filename;

    public InputValuesCore(IServiceProvider serviceProvider)
      : base(serviceProvider)
    {
    }

    public CpuPlatform Cpu { get; set; }

    public string LeaveIntermediateFiles { get; set; }

    public bool EmitDebugSymbols { get; set; }

    public string FrameworkPath { get; set; }

    public string InputFileName { get; set; }

    public string KeyContainer { get; set; }

    public string KeyFile { get; set; }

    public string OutputFileName { get; set; }

    public string RootDirectory { get; set; }

    public string SdkPath { get; set; }

    public string MethodAttributes { get; set; }

    public string LibToolPath { get; set; }

    public string LibToolDllPath { get; set; }

    public string DllExportAttributeFullName
    {
      get
      {
        return this._DllExportAttributeFullName;
      }
      set
      {
        this._DllExportAttributeFullName = value;
      }
    }

    public string DllExportAttributeAssemblyName
    {
      get
      {
        return this._DllExportAttributeAssemblyName;
      }
      set
      {
        this._DllExportAttributeAssemblyName = value;
      }
    }

    public string FileName
    {
      get
      {
        Monitor.Enter((object) this);
        try
        {
          if (string.IsNullOrEmpty(this._Filename))
            this._Filename = Path.GetFileNameWithoutExtension(this.InputFileName);
        }
        finally
        {
          Monitor.Exit((object) this);
        }
        return this._Filename;
      }
      set
      {
        Monitor.Enter((object) this);
        try
        {
          this._Filename = value;
        }
        finally
        {
          Monitor.Exit((object) this);
        }
      }
    }

    public AssemblyBinaryProperties InferAssemblyBinaryProperties()
    {
      AssemblyBinaryProperties binaryProperties = Utilities.CreateAssemblyInspector((IInputValues) this).GetAssemblyBinaryProperties(this.InputFileName);
      if (this.Cpu == CpuPlatform.None && binaryProperties.BinaryWasScanned)
        this.Cpu = binaryProperties.CpuPlatform;
      return binaryProperties;
    }

    public void InferOutputFile()
    {
      if (!string.IsNullOrEmpty(this.OutputFileName))
        return;
      this.OutputFileName = this.InputFileName;
    }
  }
}
