// Decompiled with JetBrains decompiler
// Type: Calculator.Form1
// Assembly: Calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF8985BD-F1AC-4CFB-BA44-13F06D0B7BD1
// Assembly location: E:\Артём\Мои программы\Калькулятор.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
  public class Form1 : Form
  {
    private bool bigger;
    private IContainer components = (IContainer) null;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem менюToolStripMenuItem;
    private TextBox textBox1;
    private Button buttonC;
    private Button buttonC1;
    private Button buttonBracketOpen;
    private Button buttonPlus;
    private Button buttonMinus;
    private Button buttonMulti;
    private Button buttonDiv;
    private Button buttonDo;
    private Button buttonDot;
    private Button button0;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private Button button5;
    private Button button6;
    private Button button7;
    private Button button8;
    private Button button9;
    private Button buttonBracketClose;
    private ToolStripMenuItem оПрограммеToolStripMenuItem;
    private ToolStripMenuItem EngineerВыклToolStripMenuItem;
    private Button buttonPower;
    private Button buttonRoot;
    private Button buttonFact;
    private Button buttonDiv1;
    private Button buttonMod;
    private Button buttonPerc;

    public Form1() => this.InitializeComponent();

    private void Form1_Load(object sender, EventArgs e)
    {
      this.Size = new Size(294, 307);
      this.bigger = false;
      this.buttonPower.Visible = false;
      this.buttonRoot.Visible = false;
      this.buttonFact.Visible = false;
      this.buttonDiv1.Visible = false;
      this.buttonMod.Visible = false;
      this.textBox1.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Regular);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (this.textBox1.Text == " Автор программы: Артём Быков")
      {
        this.textBox1.Text = "";
        this.textBox1.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Regular);
      }
      this.textBox1.Text += (string) (object) 1;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (this.textBox1.Text == " Автор программы: Артём Быков")
      {
        this.textBox1.Text = "";
        this.textBox1.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Regular);
      }
      this.textBox1.Text += (string) (object) 2;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      if (this.textBox1.Text == " Автор программы: Артём Быков")
      {
        this.textBox1.Text = "";
        this.textBox1.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Regular);
      }
      this.textBox1.Text += (string) (object) 3;
    }

    private void button4_Click(object sender, EventArgs e)
    {
      if (this.textBox1.Text == " Автор программы: Артём Быков")
      {
        this.textBox1.Text = "";
        this.textBox1.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Regular);
      }
      this.textBox1.Text += (string) (object) 4;
    }

    private void button5_Click(object sender, EventArgs e)
    {
      if (this.textBox1.Text == " Автор программы: Артём Быков")
      {
        this.textBox1.Text = "";
        this.textBox1.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Regular);
      }
      this.textBox1.Text += (string) (object) 5;
    }

    private void button6_Click(object sender, EventArgs e)
    {
      if (this.textBox1.Text == " Автор программы: Артём Быков")
      {
        this.textBox1.Text = "";
        this.textBox1.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Regular);
      }
      this.textBox1.Text += (string) (object) 6;
    }

    private void button7_Click(object sender, EventArgs e)
    {
      if (this.textBox1.Text == " Автор программы: Артём Быков")
      {
        this.textBox1.Text = "";
        this.textBox1.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Regular);
      }
      this.textBox1.Text += (string) (object) 7;
    }

    private void button8_Click(object sender, EventArgs e)
    {
      if (this.textBox1.Text == " Автор программы: Артём Быков")
      {
        this.textBox1.Text = "";
        this.textBox1.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Regular);
      }
      this.textBox1.Text += (string) (object) 8;
    }

    private void button9_Click(object sender, EventArgs e)
    {
      if (this.textBox1.Text == " Автор программы: Артём Быков")
      {
        this.textBox1.Text = "";
        this.textBox1.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Regular);
      }
      this.textBox1.Text += (string) (object) 9;
    }

    private void button0_Click(object sender, EventArgs e)
    {
      if (this.textBox1.Text == " Автор программы: Артём Быков")
      {
        this.textBox1.Text = "";
        this.textBox1.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Regular);
      }
      this.textBox1.Text += (string) (object) 0;
    }

    private void buttonDot_Click(object sender, EventArgs e)
    {
      if (this.textBox1.Text == " Автор программы: Артём Быков")
      {
        this.textBox1.Text = "";
        this.textBox1.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Regular);
      }
      this.textBox1.Text += ",";
    }

    private void buttonPlus_Click(object sender, EventArgs e)
    {
      if (this.textBox1.Text == " Автор программы: Артём Быков")
      {
        this.textBox1.Text = "";
        this.textBox1.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Regular);
      }
      this.textBox1.Text += "+";
    }

    private void buttonMinus_Click(object sender, EventArgs e)
    {
      if (this.textBox1.Text == " Автор программы: Артём Быков")
      {
        this.textBox1.Text = "";
        this.textBox1.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Regular);
      }
      this.textBox1.Text += "-";
    }

    private void buttonMulti_Click(object sender, EventArgs e)
    {
      if (this.textBox1.Text == " Автор программы: Артём Быков")
      {
        this.textBox1.Text = "";
        this.textBox1.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Regular);
      }
      this.textBox1.Text += "×";
    }

    private void buttonDiv_Click(object sender, EventArgs e)
    {
      if (this.textBox1.Text == " Автор программы: Артём Быков")
      {
        this.textBox1.Text = "";
        this.textBox1.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Regular);
      }
      this.textBox1.Text += "÷";
    }

    private void buttonDiv1_Click(object sender, EventArgs e)
    {
      if (this.textBox1.Text == " Автор программы: Артём Быков")
      {
        this.textBox1.Text = "";
        this.textBox1.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Regular);
      }
      this.textBox1.Text += " div ";
    }

    private void buttonMod_Click(object sender, EventArgs e)
    {
      if (this.textBox1.Text == " Автор программы: Артём Быков")
      {
        this.textBox1.Text = "";
        this.textBox1.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Regular);
      }
      this.textBox1.Text += " mod ";
    }

    private void buttonPerc_Click(object sender, EventArgs e)
    {
      if (this.textBox1.Text == " Автор программы: Артём Быков")
      {
        this.textBox1.Text = "";
        this.textBox1.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Regular);
      }
      this.textBox1.Text += "%";
    }

    private void buttonPower_Click(object sender, EventArgs e)
    {
      if (this.textBox1.Text == " Автор программы: Артём Быков")
      {
        this.textBox1.Text = "";
        this.textBox1.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Regular);
      }
      this.textBox1.Text += "^";
    }

    private void buttonRoot_Click(object sender, EventArgs e)
    {
      if (this.textBox1.Text == " Автор программы: Артём Быков")
      {
        this.textBox1.Text = "";
        this.textBox1.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Regular);
      }
      this.textBox1.Text = "√" + this.textBox1.Text + "^";
    }

    private void buttonFact_Click(object sender, EventArgs e)
    {
      if (this.textBox1.Text == " Автор программы: Артём Быков")
      {
        this.textBox1.Text = "";
        this.textBox1.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Regular);
      }
      this.textBox1.Text += "!";
    }

    private void buttonC_Click(object sender, EventArgs e)
    {
      this.textBox1.Text = "";
      this.textBox1.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Regular);
    }

    private void buttonC1_Click(object sender, EventArgs e)
    {
      if (this.textBox1.Text == " Автор программы: Артём Быков")
      {
        this.textBox1.Text = "";
        this.textBox1.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Regular);
      }
      else
        this.textBox1.Text = this.textBox1.Text.Substring(0, this.textBox1.Text.Length - 1);
    }

    private void buttonBracketOpen_Click(object sender, EventArgs e) => this.textBox1.Text += "(";

    private void buttonBracketClose_Click(object sender, EventArgs e) => this.textBox1.Text += ")";

    private void buttonDo_Click(object sender, EventArgs e)
    {
      int length1 = this.textBox1.Text.Length;
      char[] chArray1 = new char[length1];
      char[] chArray2 = new char[length1];
      int[] numArray1 = new int[length1];
      string[] strArray = new string[length1];
      double[] numArray2 = new double[length1];
      double[] numArray3 = new double[length1];
      int[] numArray4 = new int[length1];
      for (int index = 0; index < length1; ++index)
        chArray1[index] = this.textBox1.Text[index];
      for (int length2 = 0; length2 < length1; ++length2)
      {
        int index1 = 0;
        if (chArray1[length2] == '+')
        {
          numArray1[index1] = index1;
          strArray[index1] = this.textBox1.Text.Substring(0, length2);
          strArray[index1 + 1] = this.textBox1.Text.Substring(length2 + 1);
          numArray3[index1] = Convert.ToDouble(strArray[index1]);
          numArray3[index1 + 1] = Convert.ToDouble(strArray[index1 + 1]);
          this.textBox1.Text += "=";
          numArray2[index1] = numArray3[index1] + numArray3[index1 + 1];
          this.textBox1.Text += (string) (object) numArray2[index1];
          ++index1;
        }
        if (chArray1[length2] == '-')
        {
          numArray1[index1] = index1;
          strArray[index1] = this.textBox1.Text.Substring(0, length2);
          strArray[index1 + 1] = this.textBox1.Text.Substring(length2 + 1);
          numArray3[index1] = Convert.ToDouble(strArray[index1]);
          numArray3[index1 + 1] = Convert.ToDouble(strArray[index1 + 1]);
          this.textBox1.Text += "=";
          numArray2[index1] = numArray3[index1] - numArray3[index1 + 1];
          this.textBox1.Text += (string) (object) numArray2[index1];
          ++index1;
        }
        if (chArray1[length2] == '×')
        {
          numArray1[index1] = index1;
          strArray[index1] = this.textBox1.Text.Substring(0, length2);
          strArray[index1 + 1] = this.textBox1.Text.Substring(length2 + 1);
          numArray3[index1] = Convert.ToDouble(strArray[index1]);
          numArray3[index1 + 1] = Convert.ToDouble(strArray[index1 + 1]);
          this.textBox1.Text += "=";
          numArray2[index1] = numArray3[index1] * numArray3[index1 + 1];
          this.textBox1.Text += (string) (object) numArray2[index1];
          ++index1;
        }
        if (chArray1[length2] == '÷')
        {
          numArray1[index1] = index1;
          strArray[index1] = this.textBox1.Text.Substring(0, length2);
          strArray[index1 + 1] = this.textBox1.Text.Substring(length2 + 1);
          numArray3[index1] = Convert.ToDouble(strArray[index1]);
          numArray3[index1 + 1] = Convert.ToDouble(strArray[index1 + 1]);
          this.textBox1.Text += "=";
          numArray2[index1] = numArray3[index1] / numArray3[index1 + 1];
          this.textBox1.Text += (string) (object) numArray2[index1];
          ++index1;
        }
        if (chArray1[length2] == ' ' && chArray1[length2 + 1] == 'd' && chArray1[length2 + 2] == 'i' && chArray1[length2 + 3] == 'v' && chArray1[length2 + 4] == ' ')
        {
          numArray1[index1] = index1;
          strArray[index1] = this.textBox1.Text.Substring(0, length2);
          strArray[index1 + 1] = this.textBox1.Text.Substring(length2 + 5);
          numArray4[index1] = Convert.ToInt32(strArray[index1]);
          numArray4[index1 + 1] = Convert.ToInt32(strArray[index1 + 1]);
          this.textBox1.Text += "=";
          numArray2[index1] = (double) Math.DivRem(numArray4[index1], numArray4[index1 + 1], out int _);
          this.textBox1.Text += (string) (object) numArray2[index1];
          ++index1;
        }
        if (chArray1[length2] == ' ' && chArray1[length2 + 1] == 'm' && chArray1[length2 + 2] == 'o' && chArray1[length2 + 3] == 'd' && chArray1[length2 + 4] == ' ')
        {
          numArray1[index1] = index1;
          strArray[index1] = this.textBox1.Text.Substring(0, length2);
          strArray[index1 + 1] = this.textBox1.Text.Substring(length2 + 5);
          numArray4[index1] = Convert.ToInt32(strArray[index1]);
          numArray4[index1 + 1] = Convert.ToInt32(strArray[index1 + 1]);
          this.textBox1.Text += "=";
          int result;
          numArray2[index1] = (double) Math.DivRem(numArray4[index1], numArray4[index1 + 1], out result);
          this.textBox1.Text += (string) (object) result;
          ++index1;
        }
        if (chArray1[length2] == '%')
        {
          numArray1[index1] = index1;
          strArray[index1] = this.textBox1.Text.Substring(0, length2);
          strArray[index1 + 1] = "";
          numArray3[index1] = Convert.ToDouble(strArray[index1]);
          numArray3[index1 + 1] = 100.0;
          this.textBox1.Text += "=";
          numArray2[index1] = numArray3[index1] / numArray3[index1 + 1];
          this.textBox1.Text += (string) (object) numArray2[index1];
          ++index1;
        }
        if (chArray1[length2] == '^')
        {
          if (this.textBox1.Text.Substring(0, 1) == "√")
          {
            numArray1[index1] = index1;
            strArray[index1] = this.textBox1.Text.Substring(0, length2).Replace("√", "");
            strArray[index1 + 1] = this.textBox1.Text.Substring(length2 + 1);
            numArray3[index1] = Convert.ToDouble(strArray[index1]);
            numArray3[index1 + 1] = Convert.ToDouble(strArray[index1 + 1]);
            numArray3[index1 + 1] = 1.0 / numArray3[index1 + 1];
            this.textBox1.Text += "=";
            numArray2[index1] = Math.Pow(numArray3[index1], numArray3[index1 + 1]);
          }
          else if (this.textBox1.Text.Substring(0, 1) != "√")
          {
            numArray1[index1] = index1;
            strArray[index1] = this.textBox1.Text.Substring(0, length2);
            strArray[index1 + 1] = this.textBox1.Text.Substring(length2 + 1);
            numArray3[index1] = Convert.ToDouble(strArray[index1]);
            numArray3[index1 + 1] = Convert.ToDouble(strArray[index1 + 1]);
            this.textBox1.Text += "=";
            numArray2[index1] = Math.Pow(numArray3[index1], numArray3[index1 + 1]);
          }
          this.textBox1.Text += (string) (object) numArray2[index1];
          ++index1;
        }
        if (chArray1[length2] == '!')
        {
          numArray1[index1] = index1;
          strArray[index1] = this.textBox1.Text.Substring(0, length2);
          strArray[index1 + 1] = "";
          numArray3[index1] = Convert.ToDouble(strArray[index1]);
          numArray3[index1 + 1] = 1.0;
          this.textBox1.Text += "=";
          for (int index2 = 1; (double) index2 <= numArray3[index1]; ++index2)
            numArray3[index1 + 1] = numArray3[index1 + 1] * (double) index2;
          numArray2[index1] = numArray3[index1 + 1];
          this.textBox1.Text += (string) (object) numArray2[index1];
          int num = index1 + 1;
        }
      }
    }

    private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.textBox1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular);
      this.textBox1.Text = " Автор программы: Артём Быков";
    }

    private void EngineerВыклToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (!this.bigger)
      {
        this.Size = new Size(492, 307);
        this.bigger = true;
        this.buttonPower.Visible = true;
        this.buttonRoot.Visible = true;
        this.buttonFact.Visible = true;
        this.buttonDiv1.Visible = true;
        this.buttonMod.Visible = true;
        this.EngineerВыклToolStripMenuItem.Text = "Инженерный вкл.";
      }
      else
      {
        if (!this.bigger)
          return;
        this.Size = new Size(294, 307);
        this.bigger = false;
        this.buttonPower.Visible = false;
        this.buttonRoot.Visible = false;
        this.buttonFact.Visible = false;
        this.buttonDiv1.Visible = false;
        this.buttonMod.Visible = false;
        this.EngineerВыклToolStripMenuItem.Text = "Инженерный выкл.";
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.menuStrip1 = new MenuStrip();
      this.менюToolStripMenuItem = new ToolStripMenuItem();
      this.оПрограммеToolStripMenuItem = new ToolStripMenuItem();
      this.EngineerВыклToolStripMenuItem = new ToolStripMenuItem();
      this.textBox1 = new TextBox();
      this.buttonC = new Button();
      this.buttonC1 = new Button();
      this.buttonBracketOpen = new Button();
      this.buttonPlus = new Button();
      this.buttonMinus = new Button();
      this.buttonMulti = new Button();
      this.buttonDiv = new Button();
      this.buttonDo = new Button();
      this.buttonDot = new Button();
      this.button0 = new Button();
      this.button1 = new Button();
      this.button2 = new Button();
      this.button3 = new Button();
      this.button4 = new Button();
      this.button5 = new Button();
      this.button6 = new Button();
      this.button7 = new Button();
      this.button8 = new Button();
      this.button9 = new Button();
      this.buttonBracketClose = new Button();
      this.buttonPower = new Button();
      this.buttonRoot = new Button();
      this.buttonFact = new Button();
      this.buttonDiv1 = new Button();
      this.buttonMod = new Button();
      this.buttonPerc = new Button();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      this.menuStrip1.BackColor = SystemColors.ControlLightLight;
      this.menuStrip1.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.менюToolStripMenuItem,
        (ToolStripItem) this.EngineerВыклToolStripMenuItem
      });
      this.menuStrip1.Location = new Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new Size(480, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      this.менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.оПрограммеToolStripMenuItem
      });
      this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
      this.менюToolStripMenuItem.Size = new Size(53, 20);
      this.менюToolStripMenuItem.Text = "Меню";
      this.оПрограммеToolStripMenuItem.BackColor = SystemColors.ButtonHighlight;
      this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
      this.оПрограммеToolStripMenuItem.Size = new Size(152, 22);
      this.оПрограммеToolStripMenuItem.Text = "О программе";
      this.оПрограммеToolStripMenuItem.Click += new EventHandler(this.оПрограммеToolStripMenuItem_Click);
      this.EngineerВыклToolStripMenuItem.Name = "EngineerВыклToolStripMenuItem";
      this.EngineerВыклToolStripMenuItem.Size = new Size((int) sbyte.MaxValue, 20);
      this.EngineerВыклToolStripMenuItem.Text = "Инженерный выкл.";
      this.EngineerВыклToolStripMenuItem.Click += new EventHandler(this.EngineerВыклToolStripMenuItem_Click);
      this.textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.textBox1.Font = new Font("Microsoft Sans Serif", 20.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.textBox1.Location = new Point(12, 27);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(456, 38);
      this.textBox1.TabIndex = 1;
      this.buttonC.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.buttonC.Location = new Point(12, 71);
      this.buttonC.Name = "buttonC";
      this.buttonC.Size = new Size(60, 33);
      this.buttonC.TabIndex = 2;
      this.buttonC.Text = "C";
      this.buttonC.UseVisualStyleBackColor = true;
      this.buttonC.Click += new EventHandler(this.buttonC_Click);
      this.buttonC1.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.buttonC1.Location = new Point(78, 71);
      this.buttonC1.Name = "buttonC1";
      this.buttonC1.Size = new Size(60, 33);
      this.buttonC1.TabIndex = 3;
      this.buttonC1.Text = "←";
      this.buttonC1.UseVisualStyleBackColor = true;
      this.buttonC1.Click += new EventHandler(this.buttonC1_Click);
      this.buttonBracketOpen.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.buttonBracketOpen.Location = new Point(342, 71);
      this.buttonBracketOpen.Name = "buttonBracketOpen";
      this.buttonBracketOpen.Size = new Size(60, 33);
      this.buttonBracketOpen.TabIndex = 4;
      this.buttonBracketOpen.Text = "(";
      this.buttonBracketOpen.UseVisualStyleBackColor = true;
      this.buttonBracketOpen.Click += new EventHandler(this.buttonBracketOpen_Click);
      this.buttonPlus.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.buttonPlus.Location = new Point(210, 71);
      this.buttonPlus.Name = "buttonPlus";
      this.buttonPlus.Size = new Size(60, 33);
      this.buttonPlus.TabIndex = 5;
      this.buttonPlus.Text = "+";
      this.buttonPlus.UseVisualStyleBackColor = true;
      this.buttonPlus.Click += new EventHandler(this.buttonPlus_Click);
      this.buttonMinus.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.buttonMinus.Location = new Point(210, 110);
      this.buttonMinus.Name = "buttonMinus";
      this.buttonMinus.Size = new Size(60, 33);
      this.buttonMinus.TabIndex = 6;
      this.buttonMinus.Text = "-";
      this.buttonMinus.UseVisualStyleBackColor = true;
      this.buttonMinus.Click += new EventHandler(this.buttonMinus_Click);
      this.buttonMulti.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.buttonMulti.Location = new Point(210, 149);
      this.buttonMulti.Name = "buttonMulti";
      this.buttonMulti.Size = new Size(60, 33);
      this.buttonMulti.TabIndex = 7;
      this.buttonMulti.Text = "×";
      this.buttonMulti.UseVisualStyleBackColor = true;
      this.buttonMulti.Click += new EventHandler(this.buttonMulti_Click);
      this.buttonDiv.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.buttonDiv.Location = new Point(210, 188);
      this.buttonDiv.Name = "buttonDiv";
      this.buttonDiv.Size = new Size(60, 33);
      this.buttonDiv.TabIndex = 8;
      this.buttonDiv.Text = "÷";
      this.buttonDiv.UseVisualStyleBackColor = true;
      this.buttonDiv.Click += new EventHandler(this.buttonDiv_Click);
      this.buttonDo.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.buttonDo.Location = new Point(144, 227);
      this.buttonDo.Name = "buttonDo";
      this.buttonDo.Size = new Size(126, 33);
      this.buttonDo.TabIndex = 9;
      this.buttonDo.Text = "=";
      this.buttonDo.UseVisualStyleBackColor = true;
      this.buttonDo.Click += new EventHandler(this.buttonDo_Click);
      this.buttonDot.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.buttonDot.Location = new Point(78, 227);
      this.buttonDot.Name = "buttonDot";
      this.buttonDot.Size = new Size(60, 33);
      this.buttonDot.TabIndex = 10;
      this.buttonDot.Text = ",";
      this.buttonDot.UseVisualStyleBackColor = true;
      this.buttonDot.Click += new EventHandler(this.buttonDot_Click);
      this.button0.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.button0.Location = new Point(12, 227);
      this.button0.Name = "button0";
      this.button0.Size = new Size(60, 33);
      this.button0.TabIndex = 11;
      this.button0.Text = "0";
      this.button0.UseVisualStyleBackColor = true;
      this.button0.Click += new EventHandler(this.button0_Click);
      this.button1.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.button1.Location = new Point(12, 188);
      this.button1.Name = "button1";
      this.button1.Size = new Size(60, 33);
      this.button1.TabIndex = 12;
      this.button1.Text = "1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.button2.Location = new Point(78, 188);
      this.button2.Name = "button2";
      this.button2.Size = new Size(60, 33);
      this.button2.TabIndex = 13;
      this.button2.Text = "2";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button3.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.button3.Location = new Point(144, 188);
      this.button3.Name = "button3";
      this.button3.Size = new Size(60, 33);
      this.button3.TabIndex = 14;
      this.button3.Text = "3";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.button4.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.button4.Location = new Point(12, 149);
      this.button4.Name = "button4";
      this.button4.Size = new Size(60, 33);
      this.button4.TabIndex = 17;
      this.button4.Text = "4";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.button5.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.button5.Location = new Point(78, 149);
      this.button5.Name = "button5";
      this.button5.Size = new Size(60, 33);
      this.button5.TabIndex = 16;
      this.button5.Text = "5";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new EventHandler(this.button5_Click);
      this.button6.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.button6.Location = new Point(144, 149);
      this.button6.Name = "button6";
      this.button6.Size = new Size(60, 33);
      this.button6.TabIndex = 15;
      this.button6.Text = "6";
      this.button6.UseVisualStyleBackColor = true;
      this.button6.Click += new EventHandler(this.button6_Click);
      this.button7.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.button7.Location = new Point(12, 110);
      this.button7.Name = "button7";
      this.button7.Size = new Size(60, 33);
      this.button7.TabIndex = 20;
      this.button7.Text = "7";
      this.button7.UseVisualStyleBackColor = true;
      this.button7.Click += new EventHandler(this.button7_Click);
      this.button8.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.button8.Location = new Point(78, 110);
      this.button8.Name = "button8";
      this.button8.Size = new Size(60, 33);
      this.button8.TabIndex = 19;
      this.button8.Text = "8";
      this.button8.UseVisualStyleBackColor = true;
      this.button8.Click += new EventHandler(this.button8_Click);
      this.button9.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.button9.Location = new Point(144, 110);
      this.button9.Name = "button9";
      this.button9.Size = new Size(60, 33);
      this.button9.TabIndex = 18;
      this.button9.Text = "9";
      this.button9.UseVisualStyleBackColor = true;
      this.button9.Click += new EventHandler(this.button9_Click);
      this.buttonBracketClose.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.buttonBracketClose.Location = new Point(408, 71);
      this.buttonBracketClose.Name = "buttonBracketClose";
      this.buttonBracketClose.Size = new Size(60, 33);
      this.buttonBracketClose.TabIndex = 21;
      this.buttonBracketClose.Text = ")";
      this.buttonBracketClose.UseVisualStyleBackColor = true;
      this.buttonBracketClose.Click += new EventHandler(this.buttonBracketClose_Click);
      this.buttonPower.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.buttonPower.Location = new Point(276, 71);
      this.buttonPower.Name = "buttonPower";
      this.buttonPower.Size = new Size(60, 33);
      this.buttonPower.TabIndex = 22;
      this.buttonPower.Text = "^";
      this.buttonPower.UseVisualStyleBackColor = true;
      this.buttonPower.Click += new EventHandler(this.buttonPower_Click);
      this.buttonRoot.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.buttonRoot.Location = new Point(276, 110);
      this.buttonRoot.Name = "buttonRoot";
      this.buttonRoot.Size = new Size(60, 33);
      this.buttonRoot.TabIndex = 23;
      this.buttonRoot.Text = "√";
      this.buttonRoot.UseVisualStyleBackColor = true;
      this.buttonRoot.Click += new EventHandler(this.buttonRoot_Click);
      this.buttonFact.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.buttonFact.Location = new Point(276, 149);
      this.buttonFact.Name = "buttonFact";
      this.buttonFact.Size = new Size(60, 33);
      this.buttonFact.TabIndex = 24;
      this.buttonFact.Text = "!";
      this.buttonFact.UseVisualStyleBackColor = true;
      this.buttonFact.Click += new EventHandler(this.buttonFact_Click);
      this.buttonDiv1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.buttonDiv1.Location = new Point(276, 188);
      this.buttonDiv1.Name = "buttonDiv1";
      this.buttonDiv1.Size = new Size(60, 33);
      this.buttonDiv1.TabIndex = 25;
      this.buttonDiv1.Text = "DIV";
      this.buttonDiv1.UseVisualStyleBackColor = true;
      this.buttonDiv1.Click += new EventHandler(this.buttonDiv1_Click);
      this.buttonMod.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.buttonMod.Location = new Point(276, 227);
      this.buttonMod.Name = "buttonMod";
      this.buttonMod.Size = new Size(60, 33);
      this.buttonMod.TabIndex = 26;
      this.buttonMod.Text = "MOD";
      this.buttonMod.UseVisualStyleBackColor = true;
      this.buttonMod.Click += new EventHandler(this.buttonMod_Click);
      this.buttonPerc.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.buttonPerc.Location = new Point(144, 71);
      this.buttonPerc.Name = "buttonPerc";
      this.buttonPerc.Size = new Size(60, 33);
      this.buttonPerc.TabIndex = 27;
      this.buttonPerc.Text = "%";
      this.buttonPerc.UseVisualStyleBackColor = true;
      this.buttonPerc.Click += new EventHandler(this.buttonPerc_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.ButtonHighlight;
      this.ClientSize = new Size(480, 272);
      this.Controls.Add((Control) this.buttonPerc);
      this.Controls.Add((Control) this.buttonMod);
      this.Controls.Add((Control) this.buttonDiv1);
      this.Controls.Add((Control) this.buttonFact);
      this.Controls.Add((Control) this.buttonRoot);
      this.Controls.Add((Control) this.buttonPower);
      this.Controls.Add((Control) this.buttonBracketClose);
      this.Controls.Add((Control) this.button7);
      this.Controls.Add((Control) this.button8);
      this.Controls.Add((Control) this.button9);
      this.Controls.Add((Control) this.button4);
      this.Controls.Add((Control) this.button5);
      this.Controls.Add((Control) this.button6);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.button0);
      this.Controls.Add((Control) this.buttonDot);
      this.Controls.Add((Control) this.buttonDo);
      this.Controls.Add((Control) this.buttonDiv);
      this.Controls.Add((Control) this.buttonMulti);
      this.Controls.Add((Control) this.buttonMinus);
      this.Controls.Add((Control) this.buttonPlus);
      this.Controls.Add((Control) this.buttonBracketOpen);
      this.Controls.Add((Control) this.buttonC1);
      this.Controls.Add((Control) this.buttonC);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.menuStrip1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MainMenuStrip = this.menuStrip1;
      this.MinimumSize = new Size(294, 307);
      this.Name = nameof (Form1);
      this.Text = "Калькулятор";
      this.Load += new EventHandler(this.Form1_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
