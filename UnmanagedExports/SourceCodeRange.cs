﻿// Decompiled with JetBrains decompiler
// Type: UnmanagedExports.SourceCodeRange
// Assembly: UnmanagedExports, Version=1.2.7.38850, Culture=neutral, PublicKeyToken=8f52d83c1a22df51
// MVID: C9BFF197-CAB3-40A6-BA31-9260266DE1B7
// Assembly location: C:\Users\k.gosse\.nuget\packages\unmanagedexports.repack\1.0.0\tasks\UnmanagedExports.dll

using System.Text;

namespace UnmanagedExports
{
  public sealed class SourceCodeRange
  {
    public string FileName { get; private set; }

    public SourceCodePosition StartPosition { get; private set; }

    public SourceCodePosition EndPosition { get; private set; }

    public static SourceCodeRange FromMsIlLine(string line)
    {
      SourceCodePosition start;
      SourceCodePosition end;
      string fileName;
      if (!SourceCodeRange.ExtractLineParts(line, out start, out end, out fileName))
        return (SourceCodeRange) null;
      return new SourceCodeRange(fileName, start, end);
    }

    private static bool ExtractLineParts(
      string line,
      out SourceCodePosition start,
      out SourceCodePosition end,
      out string fileName)
    {
      start = new SourceCodePosition();
      end = new SourceCodePosition();
      fileName = (string) null;
      line = line.TrimStart();
      if (!line.StartsWith(".line"))
        return false;
      line = line.Substring(5).Trim();
      if (string.IsNullOrEmpty(line))
        return false;
      int startIndex = 0;
      string lineText1 = (string) null;
      string lineText2 = (string) null;
      string columnText1 = (string) null;
      string columnText2 = (string) null;
      StringBuilder stringBuilder = new StringBuilder(line.Length);
      bool flag = false;
      for (int index = 0; index < line.Length; ++index)
      {
        char ch = line[index];
        if (ch == '\'')
        {
          if (!flag)
          {
            string str = line.Substring(startIndex, index - startIndex).Trim();
            if (columnText2 == null)
              columnText2 = str;
          }
          flag = !flag;
        }
        else if (flag)
          stringBuilder.Append(ch);
        else if (ch == ',' || ch == ':')
        {
          string str = line.Substring(startIndex, index - startIndex).Trim();
          startIndex = index + 1;
          switch (ch)
          {
            case ',':
              if (lineText1 == null)
              {
                lineText1 = str;
                continue;
              }
              columnText1 = str;
              continue;
            case ':':
              if (lineText2 == null)
              {
                lineText2 = str;
                continue;
              }
              columnText2 = str;
              continue;
            default:
              continue;
          }
        }
      }
      start = SourceCodePosition.FromText(lineText1, columnText1) ?? start;
      end = SourceCodePosition.FromText(lineText2, columnText2) ?? end;
      fileName = stringBuilder.Length > 0 ? stringBuilder.ToString() : (string) null;
      return fileName != null;
    }

    public SourceCodeRange(
      string fileName,
      SourceCodePosition startPosition,
      SourceCodePosition endPosition)
    {
      this.FileName = fileName;
      this.StartPosition = startPosition;
      this.EndPosition = endPosition;
    }

    private bool Equals(SourceCodeRange other)
    {
      if (string.Equals(this.FileName, other.FileName) && this.StartPosition.Equals(other.StartPosition))
        return this.EndPosition.Equals(other.EndPosition);
      return false;
    }

    public override bool Equals(object obj)
    {
      if (object.ReferenceEquals((object) null, obj))
        return false;
      if (object.ReferenceEquals((object) this, obj))
        return true;
      if (obj is SourceCodeRange)
        return this.Equals((SourceCodeRange) obj);
      return false;
    }

    public override int GetHashCode()
    {
      return ((this.FileName != null ? this.FileName.GetHashCode() : 0) * 397 ^ this.StartPosition.GetHashCode()) * 397 ^ this.EndPosition.GetHashCode();
    }
  }
}
