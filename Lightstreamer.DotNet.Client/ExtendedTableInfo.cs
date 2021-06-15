// Decompiled with JetBrains decompiler
// Type: Lightstreamer.DotNet.Client.ExtendedTableInfo
// Assembly: Lightstreamer_DotNet_PCL_Client, Version=3.1.6640.22649, Culture=neutral, PublicKeyToken=null
// MVID: 34D227FF-FB77-472F-96EF-5762687E571A
// Assembly location: C:\Users\c.esneault\source\repos\TestA\TestA\bin\Debug\net5.0\Lightstreamer_DotNet_PCL_Client.dll

using System.Text;

namespace Lightstreamer.DotNet.Client
{
  public class ExtendedTableInfo : SimpleTableInfo
  {
    internal string[] items;
    internal string[] fields;

    public ExtendedTableInfo(string[] items, string mode, string[] fields, bool snapshot)
      : base(ExtendedTableInfo.GetGroupName(items), mode, ExtendedTableInfo.GetSchemaName(fields), snapshot)
    {
      this.items = (string[]) items.Clone();
      this.fields = (string[]) fields.Clone();
    }

    public virtual string[] Items => (string[]) this.items.Clone();

    public virtual string[] Fields => (string[]) this.fields.Clone();

    public override string Group => this.group;

    public override string Schema => this.schema;

    public override object Clone() => this.MemberwiseClone();

    public override void SetRange(int start, int end)
    {
    }

    private static void checkName(string name)
    {
      switch (name)
      {
        case "":
        case null:
          throw new SubscrException("invalid item or field name");
        default:
          if (!name.Contains(" "))
            break;
          goto case "";
      }
    }

    private static string GetGroupName(string[] items)
    {
      ExtendedTableInfo.checkName(items[0]);
      StringBuilder stringBuilder = new StringBuilder(items[0]);
      for (int index = 1; index < items.Length; ++index)
      {
        ExtendedTableInfo.checkName(items[index]);
        stringBuilder.Append(' ');
        stringBuilder.Append(items[index]);
      }
      return stringBuilder.ToString();
    }

    private static string GetSchemaName(string[] fields)
    {
      ExtendedTableInfo.checkName(fields[0]);
      StringBuilder stringBuilder = new StringBuilder(fields[0]);
      for (int index = 1; index < fields.Length; ++index)
      {
        ExtendedTableInfo.checkName(fields[index]);
        stringBuilder.Append(' ');
        stringBuilder.Append(fields[index]);
      }
      return stringBuilder.ToString();
    }
  }
}
