// Decompiled with JetBrains decompiler
// Type: UnmanagedExports.Parsing.Actions.MethodPropertiesParserAction
// Assembly: UnmanagedExports, Version=1.2.7.38850, Culture=neutral, PublicKeyToken=8f52d83c1a22df51
// MVID: C9BFF197-CAB3-40A6-BA31-9260266DE1B7
// Assembly location: C:\Users\k.gosse\.nuget\packages\unmanagedexports.repack\1.0.0\tasks\UnmanagedExports.dll

using UnmanagedExports.Properties;
using System;

namespace UnmanagedExports.Parsing.Actions
{
  [ParserStateAction(ParserState.MethodProperties)]
  public sealed class MethodPropertiesParserAction : IlParser.ParserStateAction
  {
    public override void Execute(ParserStateValues state, string trimmedLine)
    {
      if (trimmedLine.StartsWith(".custom instance void ", StringComparison.Ordinal) && trimmedLine.Contains(this.Parser.DllExportAttributeIlAsmFullName))
      {
        state.AddLine = false;
        state.State = ParserState.DeleteExportAttribute;
        this.Notifier.Notify(-2, DllExportLogginCodes.RemovingDllExportAttribute, Resources.Removing_0_from_1_, (object) Utilities.DllExportAttributeFullName, (object) (state.ClassNames.Peek() + "." + state.Method.Name));
      }
      else
      {
        if (!trimmedLine.StartsWith("// Code", StringComparison.Ordinal))
          return;
        state.State = ParserState.Method;
        if (state.MethodPos == 0)
          return;
        state.Result.Insert(state.MethodPos, state.Method.Declaration);
      }
    }
  }
}
