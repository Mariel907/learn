namespace ArtanCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PnlHistory = new System.Windows.Forms.Panel();
            this.RtBoxDisplayHistory = new System.Windows.Forms.RichTextBox();
            this.BtnClearHistory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnHistory = new System.Windows.Forms.Button();
            this.textPreview = new System.Windows.Forms.TextBox();
            this.textDisplay = new System.Windows.Forms.TextBox();
            this.BtnBackspace = new System.Windows.Forms.Button();
            this.BtnPercent = new System.Windows.Forms.Button();
            this.BtnCE = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnSubtraction = new System.Windows.Forms.Button();
            this.BtnMultiplication = new System.Windows.Forms.Button();
            this.BtnAddition = new System.Windows.Forms.Button();
            this.BtnDivision = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.BtnDecimal = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnEqual = new System.Windows.Forms.Button();
            this.PnlHistory.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlHistory
            // 
            this.PnlHistory.Controls.Add(this.RtBoxDisplayHistory);
            this.PnlHistory.Controls.Add(this.BtnClearHistory);
            this.PnlHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlHistory.Location = new System.Drawing.Point(0, 565);
            this.PnlHistory.Margin = new System.Windows.Forms.Padding(0);
            this.PnlHistory.Name = "PnlHistory";
            this.PnlHistory.Size = new System.Drawing.Size(350, 5);
            this.PnlHistory.TabIndex = 1;
            // 
            // RtBoxDisplayHistory
            // 
            this.RtBoxDisplayHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.RtBoxDisplayHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtBoxDisplayHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtBoxDisplayHistory.ForeColor = System.Drawing.Color.Silver;
            this.RtBoxDisplayHistory.Location = new System.Drawing.Point(0, 0);
            this.RtBoxDisplayHistory.Margin = new System.Windows.Forms.Padding(0);
            this.RtBoxDisplayHistory.Name = "RtBoxDisplayHistory";
            this.RtBoxDisplayHistory.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.RtBoxDisplayHistory.Size = new System.Drawing.Size(350, 0);
            this.RtBoxDisplayHistory.TabIndex = 4;
            this.RtBoxDisplayHistory.Text = "";
            // 
            // BtnClearHistory
            // 
            this.BtnClearHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnClearHistory.FlatAppearance.BorderSize = 0;
            this.BtnClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearHistory.Image = ((System.Drawing.Image)(resources.GetObject("BtnClearHistory.Image")));
            this.BtnClearHistory.Location = new System.Drawing.Point(0, -35);
            this.BtnClearHistory.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClearHistory.Name = "BtnClearHistory";
            this.BtnClearHistory.Size = new System.Drawing.Size(350, 40);
            this.BtnClearHistory.TabIndex = 3;
            this.BtnClearHistory.UseVisualStyleBackColor = true;
            this.BtnClearHistory.Click += new System.EventHandler(this.BtnClearHistory_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnHistory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 40);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BtnHistory
            // 
            this.BtnHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnHistory.FlatAppearance.BorderSize = 0;
            this.BtnHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHistory.Image = ((System.Drawing.Image)(resources.GetObject("BtnHistory.Image")));
            this.BtnHistory.Location = new System.Drawing.Point(300, 0);
            this.BtnHistory.Margin = new System.Windows.Forms.Padding(0);
            this.BtnHistory.Name = "BtnHistory";
            this.BtnHistory.Size = new System.Drawing.Size(50, 40);
            this.BtnHistory.TabIndex = 0;
            this.BtnHistory.UseVisualStyleBackColor = true;
            this.BtnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
            // 
            // textPreview
            // 
            this.textPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPreview.Font = new System.Drawing.Font("Gadugi", 14F);
            this.textPreview.ForeColor = System.Drawing.Color.White;
            this.textPreview.Location = new System.Drawing.Point(0, 80);
            this.textPreview.Margin = new System.Windows.Forms.Padding(0);
            this.textPreview.Multiline = true;
            this.textPreview.Name = "textPreview";
            this.textPreview.Size = new System.Drawing.Size(350, 43);
            this.textPreview.TabIndex = 3;
            this.textPreview.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textPreview.TextChanged += new System.EventHandler(this.textPreview_TextChanged);
            // 
            // textDisplay
            // 
            this.textDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.textDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDisplay.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Bold);
            this.textDisplay.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textDisplay.Location = new System.Drawing.Point(0, 123);
            this.textDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.textDisplay.Multiline = true;
            this.textDisplay.Name = "textDisplay";
            this.textDisplay.Size = new System.Drawing.Size(350, 50);
            this.textDisplay.TabIndex = 4;
            this.textDisplay.Text = "0";
            this.textDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textDisplay.TextChanged += new System.EventHandler(this.textDisplay1_TextChanged);
            // 
            // BtnBackspace
            // 
            this.BtnBackspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnBackspace.FlatAppearance.BorderSize = 0;
            this.BtnBackspace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackspace.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnBackspace.Image = ((System.Drawing.Image)(resources.GetObject("BtnBackspace.Image")));
            this.BtnBackspace.Location = new System.Drawing.Point(265, 219);
            this.BtnBackspace.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBackspace.Name = "BtnBackspace";
            this.BtnBackspace.Size = new System.Drawing.Size(85, 55);
            this.BtnBackspace.TabIndex = 3;
            this.BtnBackspace.UseVisualStyleBackColor = false;
            this.BtnBackspace.Click += new System.EventHandler(this.BtnBackspace_Click);
            // 
            // BtnPercent
            // 
            this.BtnPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnPercent.FlatAppearance.BorderSize = 0;
            this.BtnPercent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPercent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnPercent.Location = new System.Drawing.Point(1, 219);
            this.BtnPercent.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPercent.Name = "BtnPercent";
            this.BtnPercent.Size = new System.Drawing.Size(85, 55);
            this.BtnPercent.TabIndex = 12;
            this.BtnPercent.Text = "%";
            this.BtnPercent.UseVisualStyleBackColor = false;
            this.BtnPercent.Click += new System.EventHandler(this.BtnPercent_Click);
            // 
            // BtnCE
            // 
            this.BtnCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnCE.FlatAppearance.BorderSize = 0;
            this.BtnCE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCE.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCE.Location = new System.Drawing.Point(89, 219);
            this.BtnCE.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(85, 55);
            this.BtnCE.TabIndex = 13;
            this.BtnCE.Text = "CE";
            this.BtnCE.UseVisualStyleBackColor = false;
            this.BtnCE.Click += new System.EventHandler(this.BtnCE_Click);
            // 
            // BtnC
            // 
            this.BtnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnC.FlatAppearance.BorderSize = 0;
            this.BtnC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnC.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnC.Location = new System.Drawing.Point(177, 219);
            this.BtnC.Margin = new System.Windows.Forms.Padding(0);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(85, 55);
            this.BtnC.TabIndex = 14;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = false;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnSubtraction
            // 
            this.BtnSubtraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnSubtraction.FlatAppearance.BorderSize = 0;
            this.BtnSubtraction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnSubtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubtraction.Font = new System.Drawing.Font("Gadugi", 14F);
            this.BtnSubtraction.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSubtraction.Location = new System.Drawing.Point(265, 335);
            this.BtnSubtraction.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSubtraction.Name = "BtnSubtraction";
            this.BtnSubtraction.Size = new System.Drawing.Size(85, 55);
            this.BtnSubtraction.TabIndex = 18;
            this.BtnSubtraction.Text = "-";
            this.BtnSubtraction.UseVisualStyleBackColor = false;
            this.BtnSubtraction.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // BtnMultiplication
            // 
            this.BtnMultiplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnMultiplication.FlatAppearance.BorderSize = 0;
            this.BtnMultiplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMultiplication.Font = new System.Drawing.Font("Gadugi", 14F);
            this.BtnMultiplication.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnMultiplication.Location = new System.Drawing.Point(265, 393);
            this.BtnMultiplication.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMultiplication.Name = "BtnMultiplication";
            this.BtnMultiplication.Size = new System.Drawing.Size(85, 55);
            this.BtnMultiplication.TabIndex = 17;
            this.BtnMultiplication.Text = "×";
            this.BtnMultiplication.UseVisualStyleBackColor = false;
            this.BtnMultiplication.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // BtnAddition
            // 
            this.BtnAddition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnAddition.FlatAppearance.BorderSize = 0;
            this.BtnAddition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnAddition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddition.Font = new System.Drawing.Font("Gadugi", 14F);
            this.BtnAddition.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAddition.Location = new System.Drawing.Point(265, 451);
            this.BtnAddition.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAddition.Name = "BtnAddition";
            this.BtnAddition.Size = new System.Drawing.Size(85, 55);
            this.BtnAddition.TabIndex = 16;
            this.BtnAddition.Text = "+";
            this.BtnAddition.UseVisualStyleBackColor = false;
            this.BtnAddition.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // BtnDivision
            // 
            this.BtnDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BtnDivision.FlatAppearance.BorderSize = 0;
            this.BtnDivision.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDivision.Font = new System.Drawing.Font("Gadugi", 14F);
            this.BtnDivision.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDivision.Location = new System.Drawing.Point(265, 277);
            this.BtnDivision.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDivision.Name = "BtnDivision";
            this.BtnDivision.Size = new System.Drawing.Size(85, 55);
            this.BtnDivision.TabIndex = 15;
            this.BtnDivision.Text = "÷";
            this.BtnDivision.UseVisualStyleBackColor = false;
            this.BtnDivision.Click += new System.EventHandler(this.BtnMathOperation_Click);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn9.FlatAppearance.BorderSize = 0;
            this.Btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn9.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn9.Location = new System.Drawing.Point(177, 277);
            this.Btn9.Margin = new System.Windows.Forms.Padding(0);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(85, 55);
            this.Btn9.TabIndex = 22;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn8.FlatAppearance.BorderSize = 0;
            this.Btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn8.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn8.Location = new System.Drawing.Point(89, 277);
            this.Btn8.Margin = new System.Windows.Forms.Padding(0);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(85, 55);
            this.Btn8.TabIndex = 21;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn7.FlatAppearance.BorderSize = 0;
            this.Btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn7.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn7.Location = new System.Drawing.Point(1, 277);
            this.Btn7.Margin = new System.Windows.Forms.Padding(0);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(85, 55);
            this.Btn7.TabIndex = 20;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn3.FlatAppearance.BorderSize = 0;
            this.Btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn3.Location = new System.Drawing.Point(177, 393);
            this.Btn3.Margin = new System.Windows.Forms.Padding(0);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(85, 55);
            this.Btn3.TabIndex = 28;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn2.FlatAppearance.BorderSize = 0;
            this.Btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn2.Location = new System.Drawing.Point(89, 393);
            this.Btn2.Margin = new System.Windows.Forms.Padding(0);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(85, 55);
            this.Btn2.TabIndex = 27;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.btn1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn1.Location = new System.Drawing.Point(1, 393);
            this.btn1.Margin = new System.Windows.Forms.Padding(0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(85, 55);
            this.btn1.TabIndex = 26;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn6.FlatAppearance.BorderSize = 0;
            this.Btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn6.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn6.Location = new System.Drawing.Point(177, 335);
            this.Btn6.Margin = new System.Windows.Forms.Padding(0);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(85, 55);
            this.Btn6.TabIndex = 25;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn5.FlatAppearance.BorderSize = 0;
            this.Btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn5.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn5.Location = new System.Drawing.Point(89, 335);
            this.Btn5.Margin = new System.Windows.Forms.Padding(0);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(85, 55);
            this.Btn5.TabIndex = 24;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn4.FlatAppearance.BorderSize = 0;
            this.Btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn4.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn4.Location = new System.Drawing.Point(1, 335);
            this.Btn4.Margin = new System.Windows.Forms.Padding(0);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(85, 55);
            this.Btn4.TabIndex = 23;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnDecimal
            // 
            this.BtnDecimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BtnDecimal.FlatAppearance.BorderSize = 0;
            this.BtnDecimal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDecimal.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.BtnDecimal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDecimal.Location = new System.Drawing.Point(1, 451);
            this.BtnDecimal.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDecimal.Name = "BtnDecimal";
            this.BtnDecimal.Size = new System.Drawing.Size(85, 55);
            this.BtnDecimal.TabIndex = 35;
            this.BtnDecimal.Text = ".";
            this.BtnDecimal.UseVisualStyleBackColor = false;
            this.BtnDecimal.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn0
            // 
            this.Btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Btn0.FlatAppearance.BorderSize = 0;
            this.Btn0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn0.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.Btn0.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn0.Location = new System.Drawing.Point(89, 451);
            this.Btn0.Margin = new System.Windows.Forms.Padding(0);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(85, 55);
            this.Btn0.TabIndex = 34;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnEqual
            // 
            this.BtnEqual.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnEqual.FlatAppearance.BorderSize = 0;
            this.BtnEqual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEqual.Font = new System.Drawing.Font("Gadugi", 14F);
            this.BtnEqual.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnEqual.Location = new System.Drawing.Point(177, 451);
            this.BtnEqual.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEqual.Name = "BtnEqual";
            this.BtnEqual.Size = new System.Drawing.Size(85, 55);
            this.BtnEqual.TabIndex = 32;
            this.BtnEqual.Text = "=";
            this.BtnEqual.UseVisualStyleBackColor = false;
            this.BtnEqual.Click += new System.EventHandler(this.BtnEqual_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(350, 570);
            this.Controls.Add(this.PnlHistory);
            this.Controls.Add(this.BtnDecimal);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.BtnEqual);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.BtnSubtraction);
            this.Controls.Add(this.BtnMultiplication);
            this.Controls.Add(this.BtnAddition);
            this.Controls.Add(this.BtnDivision);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnCE);
            this.Controls.Add(this.BtnPercent);
            this.Controls.Add(this.BtnBackspace);
            this.Controls.Add(this.textDisplay);
            this.Controls.Add(this.textPreview);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artan Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PnlHistory.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PnlHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnHistory;
        private System.Windows.Forms.TextBox textPreview;
        private System.Windows.Forms.TextBox textDisplay;
        private System.Windows.Forms.Button BtnClearHistory;
        private System.Windows.Forms.RichTextBox RtBoxDisplayHistory;
        private System.Windows.Forms.Button BtnBackspace;
        private System.Windows.Forms.Button BtnPercent;
        private System.Windows.Forms.Button BtnCE;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnSubtraction;
        private System.Windows.Forms.Button BtnMultiplication;
        private System.Windows.Forms.Button BtnAddition;
        private System.Windows.Forms.Button BtnDivision;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button BtnDecimal;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button BtnEqual;
    }
}

