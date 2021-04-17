using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scientific_Calculator
{
    public partial class Form1 : Form
    {
        private TextBox display;
        private RadioButton Radian;
        private Button OFF;
        private Button BackSpace;
        private Button sin;
        private Button cos;
        private Button tan;
        private Button sininverse;
        private Button cosinverse;
        private Button taninverse;
        private Button pi;
        private Button nCr;
        private Button nPr;
        private Button xsquare;
        private Button xcube;
        private Button xtoy;
        private Button onebyx;
        private Button xfactorial;
        private Button sqrt;
        private Button ln;
        private Button log;
        private Button ac;
        private Button ce;
        private Button seven;
        private Button eight;
        private Button nine;
        private Button four;
        private Button five;
        private Button six;
        private Button one;
        private Button two;
        private Button three;
        private Button zero;
        private Button point;
        private Button percent;
        private Button plus;
        private Button minus;
        private Button plusorminus;
        private Button multiplication;
        private Button division;
        private Button equal;
        private RadioButton Degree;
        string opr;
        double result,opr1,opr2;
    
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.display = new System.Windows.Forms.TextBox();
            this.Radian = new System.Windows.Forms.RadioButton();
            this.Degree = new System.Windows.Forms.RadioButton();
            this.OFF = new System.Windows.Forms.Button();
            this.BackSpace = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.sininverse = new System.Windows.Forms.Button();
            this.cosinverse = new System.Windows.Forms.Button();
            this.taninverse = new System.Windows.Forms.Button();
            this.pi = new System.Windows.Forms.Button();
            this.nCr = new System.Windows.Forms.Button();
            this.nPr = new System.Windows.Forms.Button();
            this.xsquare = new System.Windows.Forms.Button();
            this.xcube = new System.Windows.Forms.Button();
            this.xtoy = new System.Windows.Forms.Button();
            this.onebyx = new System.Windows.Forms.Button();
            this.xfactorial = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.ln = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.ac = new System.Windows.Forms.Button();
            this.ce = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plusorminus = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.Silver;
            this.display.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(0, -3);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(299, 42);
            this.display.TabIndex = 0;
            this.display.TextChanged += new System.EventHandler(this.display_TextChanged);
            // 
            // Radian
            // 
            this.Radian.AutoSize = true;
            this.Radian.BackColor = System.Drawing.Color.GhostWhite;
            this.Radian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radian.ForeColor = System.Drawing.Color.Black;
            this.Radian.Location = new System.Drawing.Point(127, 45);
            this.Radian.Name = "Radian";
            this.Radian.Size = new System.Drawing.Size(76, 20);
            this.Radian.TabIndex = 1;
            this.Radian.TabStop = true;
            this.Radian.Text = "Radian";
            this.Radian.UseVisualStyleBackColor = false;
            this.Radian.CheckedChanged += new System.EventHandler(this.Radian_CheckedChanged);
            // 
            // Degree
            // 
            this.Degree.AutoSize = true;
            this.Degree.BackColor = System.Drawing.Color.GhostWhite;
            this.Degree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Degree.ForeColor = System.Drawing.Color.Black;
            this.Degree.Location = new System.Drawing.Point(210, 45);
            this.Degree.Name = "Degree";
            this.Degree.Size = new System.Drawing.Size(78, 20);
            this.Degree.TabIndex = 2;
            this.Degree.TabStop = true;
            this.Degree.Text = "Degree";
            this.Degree.UseVisualStyleBackColor = false;
            this.Degree.CheckedChanged += new System.EventHandler(this.Degree_CheckedChanged);
            // 
            // OFF
            // 
            this.OFF.BackColor = System.Drawing.Color.Red;
            this.OFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OFF.Location = new System.Drawing.Point(12, 44);
            this.OFF.Name = "OFF";
            this.OFF.Size = new System.Drawing.Size(75, 23);
            this.OFF.TabIndex = 3;
            this.OFF.Text = "OFF";
            this.OFF.UseVisualStyleBackColor = false;
            this.OFF.Click += new System.EventHandler(this.OFF_Click);
            // 
            // BackSpace
            // 
            this.BackSpace.BackColor = System.Drawing.Color.Gray;
            this.BackSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackSpace.Location = new System.Drawing.Point(153, 79);
            this.BackSpace.Name = "BackSpace";
            this.BackSpace.Size = new System.Drawing.Size(135, 23);
            this.BackSpace.TabIndex = 4;
            this.BackSpace.Text = "Back Space";
            this.BackSpace.UseVisualStyleBackColor = false;
            this.BackSpace.Click += new System.EventHandler(this.BackSpace_Click);
            // 
            // sin
            // 
            this.sin.BackColor = System.Drawing.Color.Black;
            this.sin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sin.ForeColor = System.Drawing.Color.White;
            this.sin.Location = new System.Drawing.Point(12, 79);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(41, 23);
            this.sin.TabIndex = 5;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = false;
            this.sin.Click += new System.EventHandler(this.sin_Click);
            // 
            // cos
            // 
            this.cos.BackColor = System.Drawing.Color.Black;
            this.cos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cos.ForeColor = System.Drawing.Color.White;
            this.cos.Location = new System.Drawing.Point(59, 79);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(41, 23);
            this.cos.TabIndex = 6;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = false;
            this.cos.Click += new System.EventHandler(this.cos_Click);
            // 
            // tan
            // 
            this.tan.BackColor = System.Drawing.Color.Black;
            this.tan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tan.ForeColor = System.Drawing.Color.White;
            this.tan.Location = new System.Drawing.Point(106, 79);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(41, 23);
            this.tan.TabIndex = 7;
            this.tan.Text = "tan";
            this.tan.UseVisualStyleBackColor = false;
            this.tan.Click += new System.EventHandler(this.tan_Click);
            // 
            // sininverse
            // 
            this.sininverse.BackColor = System.Drawing.Color.Black;
            this.sininverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sininverse.ForeColor = System.Drawing.Color.White;
            this.sininverse.Location = new System.Drawing.Point(12, 117);
            this.sininverse.Name = "sininverse";
            this.sininverse.Size = new System.Drawing.Size(41, 23);
            this.sininverse.TabIndex = 8;
            this.sininverse.Text = "sin-1";
            this.sininverse.UseVisualStyleBackColor = false;
            this.sininverse.Click += new System.EventHandler(this.sininverse_Click);
            // 
            // cosinverse
            // 
            this.cosinverse.BackColor = System.Drawing.Color.Black;
            this.cosinverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cosinverse.ForeColor = System.Drawing.Color.White;
            this.cosinverse.Location = new System.Drawing.Point(59, 117);
            this.cosinverse.Name = "cosinverse";
            this.cosinverse.Size = new System.Drawing.Size(41, 23);
            this.cosinverse.TabIndex = 9;
            this.cosinverse.Text = "cos-1";
            this.cosinverse.UseVisualStyleBackColor = false;
            this.cosinverse.Click += new System.EventHandler(this.cosinverse_Click);
            // 
            // taninverse
            // 
            this.taninverse.BackColor = System.Drawing.Color.Black;
            this.taninverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taninverse.ForeColor = System.Drawing.Color.White;
            this.taninverse.Location = new System.Drawing.Point(106, 117);
            this.taninverse.Name = "taninverse";
            this.taninverse.Size = new System.Drawing.Size(41, 23);
            this.taninverse.TabIndex = 10;
            this.taninverse.Text = "tan-1";
            this.taninverse.UseVisualStyleBackColor = false;
            this.taninverse.Click += new System.EventHandler(this.taninverse_Click);
            // 
            // pi
            // 
            this.pi.BackColor = System.Drawing.Color.Black;
            this.pi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pi.ForeColor = System.Drawing.Color.White;
            this.pi.Location = new System.Drawing.Point(153, 117);
            this.pi.Name = "pi";
            this.pi.Size = new System.Drawing.Size(41, 23);
            this.pi.TabIndex = 11;
            this.pi.Text = "pi";
            this.pi.UseVisualStyleBackColor = false;
            this.pi.Click += new System.EventHandler(this.pi_Click);
            // 
            // nCr
            // 
            this.nCr.BackColor = System.Drawing.Color.Black;
            this.nCr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nCr.ForeColor = System.Drawing.Color.White;
            this.nCr.Location = new System.Drawing.Point(200, 117);
            this.nCr.Name = "nCr";
            this.nCr.Size = new System.Drawing.Size(41, 23);
            this.nCr.TabIndex = 12;
            this.nCr.Text = "nCr";
            this.nCr.UseVisualStyleBackColor = false;
            this.nCr.Click += new System.EventHandler(this.nCr_Click);
            // 
            // nPr
            // 
            this.nPr.BackColor = System.Drawing.Color.Black;
            this.nPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nPr.ForeColor = System.Drawing.Color.White;
            this.nPr.Location = new System.Drawing.Point(247, 117);
            this.nPr.Name = "nPr";
            this.nPr.Size = new System.Drawing.Size(41, 23);
            this.nPr.TabIndex = 13;
            this.nPr.Text = "nPr";
            this.nPr.UseVisualStyleBackColor = false;
            this.nPr.Click += new System.EventHandler(this.nPr_Click);
            // 
            // xsquare
            // 
            this.xsquare.BackColor = System.Drawing.Color.Black;
            this.xsquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xsquare.ForeColor = System.Drawing.Color.White;
            this.xsquare.Location = new System.Drawing.Point(12, 155);
            this.xsquare.Name = "xsquare";
            this.xsquare.Size = new System.Drawing.Size(41, 23);
            this.xsquare.TabIndex = 14;
            this.xsquare.Text = "x^2";
            this.xsquare.UseVisualStyleBackColor = false;
            this.xsquare.Click += new System.EventHandler(this.xsquare_Click);
            // 
            // xcube
            // 
            this.xcube.BackColor = System.Drawing.Color.Black;
            this.xcube.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xcube.ForeColor = System.Drawing.Color.White;
            this.xcube.Location = new System.Drawing.Point(59, 155);
            this.xcube.Name = "xcube";
            this.xcube.Size = new System.Drawing.Size(41, 23);
            this.xcube.TabIndex = 15;
            this.xcube.Text = "x^3";
            this.xcube.UseVisualStyleBackColor = false;
            this.xcube.Click += new System.EventHandler(this.xcube_Click);
            // 
            // xtoy
            // 
            this.xtoy.BackColor = System.Drawing.Color.Black;
            this.xtoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtoy.ForeColor = System.Drawing.Color.White;
            this.xtoy.Location = new System.Drawing.Point(106, 155);
            this.xtoy.Name = "xtoy";
            this.xtoy.Size = new System.Drawing.Size(41, 23);
            this.xtoy.TabIndex = 16;
            this.xtoy.Text = "x^y";
            this.xtoy.UseVisualStyleBackColor = false;
            this.xtoy.Click += new System.EventHandler(this.xtoy_Click);
            // 
            // onebyx
            // 
            this.onebyx.BackColor = System.Drawing.Color.Black;
            this.onebyx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onebyx.ForeColor = System.Drawing.Color.White;
            this.onebyx.Location = new System.Drawing.Point(200, 155);
            this.onebyx.Name = "onebyx";
            this.onebyx.Size = new System.Drawing.Size(41, 23);
            this.onebyx.TabIndex = 17;
            this.onebyx.Text = "1/x";
            this.onebyx.UseVisualStyleBackColor = false;
            this.onebyx.Click += new System.EventHandler(this.onebyx_Click);
            // 
            // xfactorial
            // 
            this.xfactorial.BackColor = System.Drawing.Color.Black;
            this.xfactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xfactorial.ForeColor = System.Drawing.Color.White;
            this.xfactorial.Location = new System.Drawing.Point(153, 155);
            this.xfactorial.Name = "xfactorial";
            this.xfactorial.Size = new System.Drawing.Size(41, 23);
            this.xfactorial.TabIndex = 18;
            this.xfactorial.Text = "x!";
            this.xfactorial.UseVisualStyleBackColor = false;
            this.xfactorial.Click += new System.EventHandler(this.xfactorial_Click);
            // 
            // sqrt
            // 
            this.sqrt.BackColor = System.Drawing.Color.Black;
            this.sqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqrt.ForeColor = System.Drawing.Color.White;
            this.sqrt.Location = new System.Drawing.Point(247, 155);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(41, 23);
            this.sqrt.TabIndex = 19;
            this.sqrt.Text = "sqrt";
            this.sqrt.UseVisualStyleBackColor = false;
            this.sqrt.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // ln
            // 
            this.ln.BackColor = System.Drawing.Color.Black;
            this.ln.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ln.ForeColor = System.Drawing.Color.White;
            this.ln.Location = new System.Drawing.Point(59, 193);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(41, 23);
            this.ln.TabIndex = 20;
            this.ln.Text = "ln x";
            this.ln.UseVisualStyleBackColor = false;
            this.ln.Click += new System.EventHandler(this.ln_Click);
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.Black;
            this.log.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.ForeColor = System.Drawing.Color.White;
            this.log.Location = new System.Drawing.Point(12, 193);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(41, 23);
            this.log.TabIndex = 21;
            this.log.Text = "log x";
            this.log.UseVisualStyleBackColor = false;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // ac
            // 
            this.ac.BackColor = System.Drawing.Color.DarkRed;
            this.ac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ac.ForeColor = System.Drawing.Color.White;
            this.ac.Location = new System.Drawing.Point(200, 193);
            this.ac.Name = "ac";
            this.ac.Size = new System.Drawing.Size(88, 23);
            this.ac.TabIndex = 22;
            this.ac.Text = "AC";
            this.ac.UseVisualStyleBackColor = false;
            this.ac.Click += new System.EventHandler(this.ac_Click);
            // 
            // ce
            // 
            this.ce.BackColor = System.Drawing.Color.DarkRed;
            this.ce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ce.ForeColor = System.Drawing.Color.White;
            this.ce.Location = new System.Drawing.Point(106, 193);
            this.ce.Name = "ce";
            this.ce.Size = new System.Drawing.Size(88, 23);
            this.ce.TabIndex = 23;
            this.ce.Text = "CE";
            this.ce.UseVisualStyleBackColor = false;
            this.ce.Click += new System.EventHandler(this.ce_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.Color.Gray;
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(12, 232);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(88, 23);
            this.seven.TabIndex = 24;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.Color.Gray;
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(106, 232);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(88, 23);
            this.eight.TabIndex = 25;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.Color.Gray;
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(200, 232);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(88, 23);
            this.nine.TabIndex = 26;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.Color.Gray;
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(12, 270);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(88, 23);
            this.four.TabIndex = 27;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.Color.Gray;
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(106, 270);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(88, 23);
            this.five.TabIndex = 28;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.Color.Gray;
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(200, 270);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(88, 23);
            this.six.TabIndex = 29;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.Gray;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(12, 310);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(88, 23);
            this.one.TabIndex = 30;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.Gray;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(106, 310);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(88, 23);
            this.two.TabIndex = 31;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.Gray;
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(200, 310);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(88, 23);
            this.three.TabIndex = 32;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.Gray;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(12, 348);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(88, 23);
            this.zero.TabIndex = 33;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // point
            // 
            this.point.BackColor = System.Drawing.Color.Gray;
            this.point.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point.Location = new System.Drawing.Point(106, 348);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(88, 23);
            this.point.TabIndex = 34;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = false;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // percent
            // 
            this.percent.BackColor = System.Drawing.Color.Gray;
            this.percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percent.Location = new System.Drawing.Point(200, 348);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(88, 23);
            this.percent.TabIndex = 35;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = false;
            this.percent.Click += new System.EventHandler(this.percent_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.Gray;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(12, 387);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(88, 23);
            this.plus.TabIndex = 36;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.Gray;
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(106, 387);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(88, 23);
            this.minus.TabIndex = 37;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // plusorminus
            // 
            this.plusorminus.BackColor = System.Drawing.Color.Gray;
            this.plusorminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusorminus.Location = new System.Drawing.Point(198, 387);
            this.plusorminus.Name = "plusorminus";
            this.plusorminus.Size = new System.Drawing.Size(88, 23);
            this.plusorminus.TabIndex = 38;
            this.plusorminus.Text = "+/-";
            this.plusorminus.UseVisualStyleBackColor = false;
            this.plusorminus.Click += new System.EventHandler(this.plusorminus_Click);
            // 
            // multiplication
            // 
            this.multiplication.BackColor = System.Drawing.Color.Gray;
            this.multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplication.Location = new System.Drawing.Point(12, 430);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(88, 23);
            this.multiplication.TabIndex = 39;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = false;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.Color.Gray;
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.Location = new System.Drawing.Point(106, 430);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(88, 23);
            this.division.TabIndex = 40;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.Color.Gray;
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(198, 430);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(88, 23);
            this.equal.TabIndex = 41;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(298, 465);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.plusorminus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.point);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.ce);
            this.Controls.Add(this.ac);
            this.Controls.Add(this.log);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.xfactorial);
            this.Controls.Add(this.onebyx);
            this.Controls.Add(this.xtoy);
            this.Controls.Add(this.xcube);
            this.Controls.Add(this.xsquare);
            this.Controls.Add(this.nPr);
            this.Controls.Add(this.nCr);
            this.Controls.Add(this.pi);
            this.Controls.Add(this.taninverse);
            this.Controls.Add(this.cosinverse);
            this.Controls.Add(this.sininverse);
            this.Controls.Add(this.tan);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.BackSpace);
            this.Controls.Add(this.OFF);
            this.Controls.Add(this.Degree);
            this.Controls.Add(this.Radian);
            this.Controls.Add(this.display);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Casio Scientific Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Radian_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OFF_Click(object sender, EventArgs e)
        {
            display.Enabled = false;
            display.Text = "";
            one.Enabled = false;
            two.Enabled = false;
            three.Enabled = false;
            four.Enabled = false;
            five.Enabled = false;
            six.Enabled = false;
            seven.Enabled = false;
            eight.Enabled = false;
            nine.Enabled = false;
            zero.Enabled = false;
            equal.Enabled = false;
        }

        private void BackSpace_Click(object sender, EventArgs e)
        {
            string opr=display.Text;
            int n = opr.Length;
            if (n < 0)
            {
                display.Text = (opr.Substring(0, n - 1));
            }
            
        }

        private void nPr_Click(object sender, EventArgs e)
        {
            opr1 = Convert.ToDouble(display.Text);
            opr = "nPr";
            display.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void zero_Click(object sender, EventArgs e)
        {
            display.Text += "0";
        }

        private void display_TextChanged(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {
            display.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            display.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            display.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            display.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            display.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            display.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            display.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            display.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            display.Text += "9";
        }

        private void ce_Click(object sender, EventArgs e)
        {
            display.Text = string.Empty;
        }

        private void ac_Click(object sender, EventArgs e)
        {
            display.Enabled = true;
            display.Text = "0";
            one.Enabled = true;
            two.Enabled = true;
            three.Enabled = true;
            four.Enabled = true;
            five.Enabled = true;
            six.Enabled = true;
            seven.Enabled = true;
            eight.Enabled = true;
            nine.Enabled = true;
            zero.Enabled = true;
            equal.Enabled = true;
        }

        private void point_Click(object sender, EventArgs e)
        {
            if (display.Text.Contains("."))
            {
                display.Text = display.Text;
            }
            else
            {
                display.Text += "0.";
            }
        }

        private void plusorminus_Click(object sender, EventArgs e)
        {
            if (display.Text.Contains("-"))
            {
                display.Text = display.Text.Remove(0, 1);
            }
            else
            {
                display.Text = "-" + display.Text;
            }
        }

        private void percent_Click(object sender, EventArgs e)
        {
            opr1 = Convert.ToDouble(display.Text);
            opr = "%";
            display.Clear();
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            opr1 = Convert.ToDouble(display.Text);
            opr = "*";
            display.Clear();
        }

        private void division_Click(object sender, EventArgs e)
        {
            opr1 = Convert.ToDouble(display.Text);
            opr = "/";
            display.Clear();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            opr1 = Convert.ToDouble(display.Text);
            opr = "-";
            display.Clear();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            opr1 = Convert.ToDouble(display.Text);
            opr = "+";
            display.Clear();
        }

        private void equal_Click(object sender, EventArgs e)
        {
            opr2 = Convert.ToDouble(display.Text);
            switch (opr)
            {
                case "+":
                    result = opr1 + opr2;
                    display.Text = Convert.ToString(result);
                    break;
                case"-":
                    result = opr1 - opr2;
                    display.Text = Convert.ToString(result);
                    break;
                case "*":
                    result=opr1 * opr2;
                    display.Text = Convert.ToString(result);
                    break;
                case "/":
                    if(opr2 == 0)
                    {
                        display.Text ="0.0";
                        break;
                    }
                    else
                    {
                        result = opr1 / opr2;
                        display.Text = Convert.ToString(result);
                        break;
                    }
                case "%":
                    result = opr1 % opr2;
                    display.Text = Convert.ToString(result);
                    break;
                case"x^y":
                    result = System.Math.Pow(Convert.ToDouble(opr1),Convert.ToDouble(opr2));
                    display.Text = Convert.ToString(result);
                    break;
                case "nPr" :
                    int var,var1,var2;
                    var=factorial(Convert.ToInt32(opr1));
                    var1=factorial(Convert.ToInt32(opr1)-Convert.ToInt32(display.Text));
                    display.Text=Convert.ToString(var/var1);
                    break;
                case "nCr":
                    var=factorial(Convert.ToInt32(opr1));
                    var1=factorial(Convert.ToInt32(opr1)-Convert.ToInt32(display.Text));
                    var2=factorial(Convert.ToInt32(display.Text));
                    display.Text=Convert.ToString(var/(var1*var2));
                    break;
               }
            }
        private int factorial(int x)
        {
            int i = 1;
            for (int s = 1; s <= x; s++)
            {
                i = i * s;
            }
            return i;
        }

        private void xsquare_Click(object sender, EventArgs e)
        {
            result = Convert.ToDouble(display.Text) * Convert.ToDouble(display.Text);
            display.Text = Convert.ToString(result);
        }

        private void xcube_Click(object sender, EventArgs e)
        {
            result = Convert.ToDouble(display.Text) * Convert.ToDouble(display.Text) * Convert.ToDouble(display.Text);
            display.Text = Convert.ToString(result);
        }

        private void xtoy_Click(object sender, EventArgs e)
        {
            opr1 = Convert.ToDouble(display.Text);
            opr = "x^y";
            display.Clear();

        }

        private void pi_Click(object sender, EventArgs e)
        {
            display.Text = "3.14159265359";
        }

        private void log_Click(object sender, EventArgs e)
        {
            result = System.Math.Log10(Convert.ToDouble(display.Text));
            display.Text = Convert.ToString(display.Text);
        }

        private void xfactorial_Click(object sender, EventArgs e)
        {
            int var = 1;
            for (int i = 1; i <= (Convert.ToInt16(display.Text)); i++)
            {
                var = i * var;
            }
        }

        private void onebyx_Click(object sender, EventArgs e)
        {
            result =Convert.ToDouble (1.0 / Convert.ToDouble(display.Text));
            display.Text = Convert.ToString(display.Text);
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            result = System.Math.Sqrt(Convert.ToDouble(display.Text));
            display.Text = Convert.ToString(result);
        }

        private void nCr_Click(object sender, EventArgs e)
        {
            opr1 = Convert.ToDouble(display.Text);
            opr = "nCr";
            display.Clear();
        }

        private void taninverse_Click(object sender, EventArgs e)
        {
            if (Radian.Checked == true)
            {
                display.Text = Convert.ToString(System.Math.Atan(Convert.ToDouble(display.Text)));
            }
            else
            {

                display.Text = Convert.ToString(System.Math.Atan((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(display.Text))));

            }
        }

        private void cosinverse_Click(object sender, EventArgs e)
        {
            if (Radian.Checked == true)
            {
                display.Text = Convert.ToString(System.Math.Acos(Convert.ToDouble(display.Text)));
            }
            else
            {

                display.Text = Convert.ToString(System.Math.Acos((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(display.Text))));

            }
        }

        private void sininverse_Click(object sender, EventArgs e)
        {
            if (Radian.Checked == true)
            {
                display.Text = Convert.ToString(System.Math.Asin(Convert.ToDouble(display.Text)));
            }
            else
            {

                display.Text = Convert.ToString(System.Math.Asin((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(display.Text))));

            }
        }

        private void cos_Click(object sender, EventArgs e)
        {
            if (Radian.Checked == true)
            {
                display.Text = Convert.ToString(System.Math.Cos(Convert.ToDouble(display.Text)));
            }
            else
            {

                display.Text = Convert.ToString(System.Math.Cos((Convert.ToDouble(System.Math.PI)/180)*(Convert.ToDouble(display.Text))));

             }
        }

        private void tan_Click(object sender, EventArgs e)
        {
            if (Radian.Checked == true)
            {
                display.Text = Convert.ToString(System.Math.Tan(Convert.ToDouble(display.Text)));
            }
            else
            {

                display.Text = Convert.ToString(System.Math.Tan((Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(display.Text))));

            }
        }

        private void Degree_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ln_Click(object sender, EventArgs e)
        {
            result = System.Math.Log(Convert.ToDouble(display.Text));
            display.Text = Convert.ToString(result);
        }

        private void sin_Click(object sender, EventArgs e)
        {
            if (Radian.Checked == true)
            {
                display.Text = Convert.ToString(System.Math.Sin(Convert.ToDouble(display.Text)));
            }
            else
            {
                display.Text = Convert.ToString(System.Math.Sin(Convert.ToDouble(System.Math.PI) / 180) * (Convert.ToDouble(display.Text)));

            }
        }



    }
}
