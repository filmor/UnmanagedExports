﻿// Decompiled with JetBrains decompiler
// Type: UnmanagedExports.AssemblyBinaryProperties
// Assembly: UnmanagedExports, Version=1.2.7.38850, Culture=neutral, PublicKeyToken=8f52d83c1a22df51
// MVID: C9BFF197-CAB3-40A6-BA31-9260266DE1B7
// Assembly location: C:\Users\k.gosse\.nuget\packages\unmanagedexports.repack\1.0.0\tasks\UnmanagedExports.dll

using Mono.Cecil;

namespace UnmanagedExports
{
  public sealed class AssemblyBinaryProperties
  {
    public static readonly AssemblyBinaryProperties EmptyNotScanned = new AssemblyBinaryProperties((ModuleAttributes) 0, TargetArchitecture.I386, false, (string) null, (string) null, false);
    private readonly bool _BinaryWasScanned;
    private readonly bool _IsSigned;
    private readonly string _KeyContainer;
    private readonly string _KeyFileName;
    private readonly TargetArchitecture _MachineKind;
    private readonly ModuleAttributes _PeKind;

    internal AssemblyBinaryProperties(
      ModuleAttributes peKind,
      TargetArchitecture machineKind,
      bool isSigned,
      string keyFileName,
      string keyContainer,
      bool binaryWasScanned)
    {
      this._PeKind = peKind;
      this._MachineKind = machineKind;
      this._IsSigned = isSigned;
      this._KeyFileName = keyFileName;
      this._KeyContainer = keyContainer;
      this._BinaryWasScanned = binaryWasScanned;
    }

    internal AssemblyBinaryProperties(
      ModuleAttributes peKind,
      TargetArchitecture machineKind,
      bool isSigned,
      string keyFileName,
      string keyContainer)
      : this(peKind, machineKind, isSigned, keyFileName, keyContainer, true)
    {
    }

    public string KeyFileName
    {
      get
      {
        return this._KeyFileName;
      }
    }

    public string KeyContainer
    {
      get
      {
        return this._KeyContainer;
      }
    }

    public bool IsIlOnly
    {
      get
      {
        return this.PeKind.Contains(ModuleAttributes.ILOnly);
      }
    }

    public CpuPlatform CpuPlatform
    {
      get
      {
        if (this.PeKind.Contains(ModuleAttributes.ILOnly))
          return !this.MachineKind.Contains(TargetArchitecture.IA64) ? CpuPlatform.X64 : CpuPlatform.Itanium;
        return !this.PeKind.Contains(ModuleAttributes.Required32Bit) ? CpuPlatform.AnyCpu : CpuPlatform.X86;
      }
    }

    internal ModuleAttributes PeKind
    {
      get
      {
        return this._PeKind;
      }
    }

    internal TargetArchitecture MachineKind
    {
      get
      {
        return this._MachineKind;
      }
    }

    public bool IsSigned
    {
      get
      {
        return this._IsSigned;
      }
    }

    public bool BinaryWasScanned
    {
      get
      {
        return this._BinaryWasScanned;
      }
    }

    public static AssemblyBinaryProperties GetEmpty()
    {
      return AssemblyBinaryProperties.EmptyNotScanned;
    }
  }
}
