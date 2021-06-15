// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Extensions
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using ATPlatform.Model.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace ATPlatform.Model
{
  public static class Extensions
  {
    public static bool AreEqual<TModel>(
      this IEnumerable<TModel> items,
      IEnumerable<TModel> otherItems)
      where TModel : IEquatable<TModel>
    {
      if (!(items is IList<TModel> modelList1))
        modelList1 = (IList<TModel>) items.ToList<TModel>();
      IList<TModel> source1 = modelList1;
      if (!(otherItems is IList<TModel> modelList2))
        modelList2 = (IList<TModel>) otherItems.ToList<TModel>();
      IList<TModel> source2 = modelList2;
      if (!source1.Any<TModel>() || !source2.Any<TModel>())
        return true;
      if (source1.Count != source2.Count)
        return false;
      List<TModel> modelList3 = new List<TModel>();
      for (int index = 0; index < source2.Count; ++index)
      {
        TModel model = source1[index];
        TModel other = source2[index];
        if (model.Equals(other))
          modelList3.Add(model);
      }
      return source2.Count == modelList3.Count;
    }
  }
}
