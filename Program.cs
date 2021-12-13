// Decompiled with JetBrains decompiler
// Type: Calculator.Program
// Assembly: Calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF8985BD-F1AC-4CFB-BA44-13F06D0B7BD1
// Assembly location: E:\Артём\Мои программы\Калькулятор.exe

using System;
using System.Windows.Forms;

namespace Calculator
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }
  }
}
