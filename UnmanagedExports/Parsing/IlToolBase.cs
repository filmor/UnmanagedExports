// Decompiled with JetBrains decompiler
// Type: UnmanagedExports.Parsing.IlToolBase
// Assembly: UnmanagedExports, Version=1.2.7.38850, Culture=neutral, PublicKeyToken=8f52d83c1a22df51
// MVID: C9BFF197-CAB3-40A6-BA31-9260266DE1B7
// Assembly location: C:\Users\k.gosse\.nuget\packages\unmanagedexports.repack\1.0.0\tasks\UnmanagedExports.dll

using System;

namespace UnmanagedExports.Parsing
{
  public abstract class IlToolBase : HasServiceProvider
  {
    protected IlToolBase(IServiceProvider serviceProvider, IInputValues inputValues)
      : base(serviceProvider)
    {
      if (inputValues == null)
        throw new ArgumentNullException(nameof (inputValues));
      this.InputValues = inputValues;
    }

    protected IDllExportNotifier Notifier
    {
      get
      {
        return this.ServiceProvider.GetService<IDllExportNotifier>();
      }
    }

    public int Timeout { get; set; }

    public IInputValues InputValues { get; private set; }

    public string TempDirectory { get; set; }
  }
}
