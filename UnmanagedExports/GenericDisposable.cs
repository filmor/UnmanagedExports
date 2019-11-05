// Decompiled with JetBrains decompiler
// Type: UnmanagedExports.GenericDisposable
// Assembly: UnmanagedExports, Version=1.2.7.38850, Culture=neutral, PublicKeyToken=8f52d83c1a22df51
// MVID: C9BFF197-CAB3-40A6-BA31-9260266DE1B7
// Assembly location: C:\Users\k.gosse\.nuget\packages\unmanagedexports.repack\1.0.0\tasks\UnmanagedExports.dll

using System;

namespace UnmanagedExports
{
  public class GenericDisposable : IDisposable
  {
    private readonly Action _Action;

    public GenericDisposable(Action action)
    {
      if (action == null)
        throw new ArgumentNullException(nameof (action));
      this._Action = action;
    }

    public void Dispose()
    {
      this._Action();
    }
  }
}
