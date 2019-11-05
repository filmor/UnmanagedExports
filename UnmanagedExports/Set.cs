// Decompiled with JetBrains decompiler
// Type: UnmanagedExports.Set
// Assembly: UnmanagedExports, Version=1.2.7.38850, Culture=neutral, PublicKeyToken=8f52d83c1a22df51
// MVID: C9BFF197-CAB3-40A6-BA31-9260266DE1B7
// Assembly location: C:\Users\k.gosse\.nuget\packages\unmanagedexports.repack\1.0.0\tasks\UnmanagedExports.dll

using Mono.Cecil;

namespace UnmanagedExports
{
  internal static class Set
  {
    public static bool Contains(this ModuleAttributes input, ModuleAttributes set)
    {
      return (input & set) == input;
    }

    public static bool Contains(this TargetArchitecture input, TargetArchitecture set)
    {
      return (input & set) == input;
    }
  }
}
