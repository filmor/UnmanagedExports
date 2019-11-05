// Decompiled with JetBrains decompiler
// Type: UnmanagedExports.IExportAssemblyInspector
// Assembly: UnmanagedExports, Version=1.2.7.38850, Culture=neutral, PublicKeyToken=8f52d83c1a22df51
// MVID: C9BFF197-CAB3-40A6-BA31-9260266DE1B7
// Assembly location: C:\Users\k.gosse\.nuget\packages\unmanagedexports.repack\1.0.0\tasks\UnmanagedExports.dll

using Mono.Cecil;
using System.IO;

namespace UnmanagedExports
{
  internal interface IExportAssemblyInspector
  {
    IInputValues InputValues { get; }

    AssemblyExports ExtractExports();

    AssemblyExports ExtractExports(AssemblyDefinition assemblyDefinition);

    AssemblyExports ExtractExports(string fileName);

    AssemblyExports ExtractExports(
      AssemblyDefinition assemblyDefinition,
      ExtractExportHandler exportFilter);

    AssemblyExports ExtractExports(
      string fileName,
      ExtractExportHandler exportFilter);

    AssemblyBinaryProperties GetAssemblyBinaryProperties(
      string assemblyFileName);

    AssemblyDefinition LoadAssembly(string fileName);

    bool SafeExtractExports(string fileName, Stream stream);
  }
}
