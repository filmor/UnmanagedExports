// Decompiled with JetBrains decompiler
// Type: UnmanagedExports.Parsing.Regexes
// Assembly: UnmanagedExports, Version=1.2.7.38850, Culture=neutral, PublicKeyToken=8f52d83c1a22df51
// MVID: C9BFF197-CAB3-40A6-BA31-9260266DE1B7
// Assembly location: C:\Users\k.gosse\.nuget\packages\unmanagedexports.repack\1.0.0\tasks\UnmanagedExports.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace UnmanagedExports.Parsing
{
  [DebuggerNonUserCode]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [CompilerGenerated]
  public class Regexes
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Regexes()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) Regexes.resourceMan, (object) null))
          Regexes.resourceMan = new ResourceManager("UnmanagedExports.Parsing.Regexes", typeof (Regexes).Assembly);
        return Regexes.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public static CultureInfo Culture
    {
      get
      {
        return Regexes.resourceCulture;
      }
      set
      {
        Regexes.resourceCulture = value;
      }
    }
  }
}
