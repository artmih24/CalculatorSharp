// Decompiled with JetBrains decompiler
// Type: Calculator.Properties.Resources
// Assembly: Calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF8985BD-F1AC-4CFB-BA44-13F06D0B7BD1
// Assembly location: E:\Артём\Мои программы\Калькулятор.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Calculator.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (Calculator.Properties.Resources.resourceMan == null)
          Calculator.Properties.Resources.resourceMan = new ResourceManager("Calculator.Properties.Resources", typeof (Calculator.Properties.Resources).Assembly);
        return Calculator.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => Calculator.Properties.Resources.resourceCulture;
      set => Calculator.Properties.Resources.resourceCulture = value;
    }
  }
}
