// Decompiled with JetBrains decompiler
// Type: Calculator.Properties.Settings
// Assembly: Calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF8985BD-F1AC-4CFB-BA44-13F06D0B7BD1
// Assembly location: E:\Артём\Мои программы\Калькулятор.exe

using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Calculator.Properties
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default
    {
      get
      {
        Settings defaultInstance = Settings.defaultInstance;
        return defaultInstance;
      }
    }
  }
}
