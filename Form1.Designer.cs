namespace Calculator
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
            this.txtWrite = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnClearLastNumber = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnMalti = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.picDarkMode = new System.Windows.Forms.PictureBox();
            this.picLightMode = new System.Windows.Forms.PictureBox();
            this.picX = new System.Windows.Forms.PictureBox();
            this.picLinkedln = new System.Windows.Forms.PictureBox();
            this.picGithub = new System.Windows.Forms.PictureBox();
            this.lnkGithub = new System.Windows.Forms.LinkLabel();
            this.lnkLinkedln = new System.Windows.Forms.LinkLabel();
            this.lnkX = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLightMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLinkedln)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGithub)).BeginInit();
            this.SuspendLayout();
            // 
            // txtWrite
            // 
            this.txtWrite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWrite.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWrite.ForeColor = System.Drawing.Color.White;
            this.txtWrite.Location = new System.Drawing.Point(12, 44);
            this.txtWrite.Multiline = true;
            this.txtWrite.Name = "txtWrite";
            this.txtWrite.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtWrite.Size = new System.Drawing.Size(392, 89);
            this.txtWrite.TabIndex = 0;
            this.txtWrite.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.IndianRed;
            this.btnClear.Location = new System.Drawing.Point(12, 146);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 44);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(12, 202);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(92, 44);
            this.btn7.TabIndex = 2;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(12, 258);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(92, 44);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(12, 314);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(92, 44);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Black;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(12, 370);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(190, 44);
            this.btn0.TabIndex = 5;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.Black;
            this.btnDot.FlatAppearance.BorderSize = 0;
            this.btnDot.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.ForeColor = System.Drawing.Color.White;
            this.btnDot.Location = new System.Drawing.Point(212, 370);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(92, 44);
            this.btnDot.TabIndex = 10;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Black;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(112, 314);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(92, 44);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Black;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(112, 258);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(92, 44);
            this.btn5.TabIndex = 8;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Black;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(112, 202);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(92, 44);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnClearLastNumber
            // 
            this.btnClearLastNumber.BackColor = System.Drawing.Color.Black;
            this.btnClearLastNumber.FlatAppearance.BorderSize = 0;
            this.btnClearLastNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearLastNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearLastNumber.ForeColor = System.Drawing.Color.White;
            this.btnClearLastNumber.Location = new System.Drawing.Point(112, 146);
            this.btnClearLastNumber.Name = "btnClearLastNumber";
            this.btnClearLastNumber.Size = new System.Drawing.Size(92, 44);
            this.btnClearLastNumber.TabIndex = 6;
            this.btnClearLastNumber.Text = "CE";
            this.btnClearLastNumber.UseVisualStyleBackColor = false;
            this.btnClearLastNumber.Click += new System.EventHandler(this.btnClearLastNumber_Click);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnResult.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnResult.FlatAppearance.BorderSize = 0;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.ForeColor = System.Drawing.Color.White;
            this.btnResult.Location = new System.Drawing.Point(312, 370);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(92, 44);
            this.btnResult.TabIndex = 15;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnMinus.Location = new System.Drawing.Point(312, 314);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(92, 44);
            this.btnMinus.TabIndex = 14;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnSum
            // 
            this.btnSum.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSum.FlatAppearance.BorderSize = 0;
            this.btnSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSum.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnSum.Location = new System.Drawing.Point(312, 258);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(92, 44);
            this.btnSum.TabIndex = 13;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnMalti
            // 
            this.btnMalti.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnMalti.FlatAppearance.BorderSize = 0;
            this.btnMalti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMalti.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMalti.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnMalti.Location = new System.Drawing.Point(312, 202);
            this.btnMalti.Name = "btnMalti";
            this.btnMalti.Size = new System.Drawing.Size(92, 44);
            this.btnMalti.TabIndex = 12;
            this.btnMalti.Text = "x";
            this.btnMalti.UseVisualStyleBackColor = true;
            this.btnMalti.Click += new System.EventHandler(this.btnMalti_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDiv.FlatAppearance.BorderSize = 0;
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnDiv.Location = new System.Drawing.Point(312, 146);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(92, 44);
            this.btnDiv.TabIndex = 11;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Black;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(212, 314);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(92, 44);
            this.btn3.TabIndex = 19;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Black;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(212, 258);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(92, 44);
            this.btn6.TabIndex = 18;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.Number_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Black;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(212, 202);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(92, 44);
            this.btn9.TabIndex = 17;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(212, 146);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 44);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "⌫";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // picDarkMode
            // 
            this.picDarkMode.Image = ((System.Drawing.Image)(resources.GetObject("picDarkMode.Image")));
            this.picDarkMode.Location = new System.Drawing.Point(303, 1);
            this.picDarkMode.Name = "picDarkMode";
            this.picDarkMode.Size = new System.Drawing.Size(100, 37);
            this.picDarkMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDarkMode.TabIndex = 20;
            this.picDarkMode.TabStop = false;
            this.picDarkMode.Click += new System.EventHandler(this.picDarkMode_Click);
            this.picDarkMode.MouseEnter += new System.EventHandler(this.Mouse_EnterCursor);
            // 
            // picLightMode
            // 
            this.picLightMode.Image = ((System.Drawing.Image)(resources.GetObject("picLightMode.Image")));
            this.picLightMode.Location = new System.Drawing.Point(303, 1);
            this.picLightMode.Name = "picLightMode";
            this.picLightMode.Size = new System.Drawing.Size(100, 37);
            this.picLightMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLightMode.TabIndex = 21;
            this.picLightMode.TabStop = false;
            this.picLightMode.Click += new System.EventHandler(this.picLightMode_Click);
            this.picLightMode.MouseEnter += new System.EventHandler(this.Mouse_EnterCursor);
            // 
            // picX
            // 
            this.picX.Image = ((System.Drawing.Image)(resources.GetObject("picX.Image")));
            this.picX.InitialImage = null;
            this.picX.Location = new System.Drawing.Point(329, 420);
            this.picX.Name = "picX";
            this.picX.Size = new System.Drawing.Size(44, 32);
            this.picX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picX.TabIndex = 26;
            this.picX.TabStop = false;
            this.picX.Click += new System.EventHandler(this.picX_Click);
            this.picX.MouseEnter += new System.EventHandler(this.Mouse_EnterCursor);
            // 
            // picLinkedln
            // 
            this.picLinkedln.Image = ((System.Drawing.Image)(resources.GetObject("picLinkedln.Image")));
            this.picLinkedln.InitialImage = ((System.Drawing.Image)(resources.GetObject("picLinkedln.InitialImage")));
            this.picLinkedln.Location = new System.Drawing.Point(179, 420);
            this.picLinkedln.Name = "picLinkedln";
            this.picLinkedln.Size = new System.Drawing.Size(75, 32);
            this.picLinkedln.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLinkedln.TabIndex = 24;
            this.picLinkedln.TabStop = false;
            this.picLinkedln.Click += new System.EventHandler(this.picLinkedln_Click);
            this.picLinkedln.MouseEnter += new System.EventHandler(this.Mouse_EnterCursor);
            // 
            // picGithub
            // 
            this.picGithub.Image = ((System.Drawing.Image)(resources.GetObject("picGithub.Image")));
            this.picGithub.InitialImage = ((System.Drawing.Image)(resources.GetObject("picGithub.InitialImage")));
            this.picGithub.Location = new System.Drawing.Point(60, 420);
            this.picGithub.Name = "picGithub";
            this.picGithub.Size = new System.Drawing.Size(44, 32);
            this.picGithub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGithub.TabIndex = 22;
            this.picGithub.TabStop = false;
            this.picGithub.Click += new System.EventHandler(this.picGithub_Click);
            this.picGithub.MouseEnter += new System.EventHandler(this.Mouse_EnterCursor);
            // 
            // lnkGithub
            // 
            this.lnkGithub.ActiveLinkColor = System.Drawing.Color.ForestGreen;
            this.lnkGithub.AutoSize = true;
            this.lnkGithub.BackColor = System.Drawing.Color.Transparent;
            this.lnkGithub.Font = new System.Drawing.Font("Segoe UI Semibold", 12.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lnkGithub.ForeColor = System.Drawing.Color.Black;
            this.lnkGithub.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkGithub.LinkColor = System.Drawing.Color.Black;
            this.lnkGithub.Location = new System.Drawing.Point(32, 455);
            this.lnkGithub.Name = "lnkGithub";
            this.lnkGithub.Size = new System.Drawing.Size(95, 30);
            this.lnkGithub.TabIndex = 23;
            this.lnkGithub.TabStop = true;
            this.lnkGithub.Text = "LoayCpp";
            this.lnkGithub.VisitedLinkColor = System.Drawing.Color.Transparent;
            this.lnkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGithub_LinkClicked);
            // 
            // lnkLinkedln
            // 
            this.lnkLinkedln.ActiveLinkColor = System.Drawing.Color.ForestGreen;
            this.lnkLinkedln.AutoSize = true;
            this.lnkLinkedln.BackColor = System.Drawing.Color.Transparent;
            this.lnkLinkedln.Font = new System.Drawing.Font("Segoe UI Semibold", 12.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lnkLinkedln.ForeColor = System.Drawing.Color.Black;
            this.lnkLinkedln.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkLinkedln.LinkColor = System.Drawing.Color.Black;
            this.lnkLinkedln.Location = new System.Drawing.Point(156, 455);
            this.lnkLinkedln.Name = "lnkLinkedln";
            this.lnkLinkedln.Size = new System.Drawing.Size(121, 30);
            this.lnkLinkedln.TabIndex = 25;
            this.lnkLinkedln.TabStop = true;
            this.lnkLinkedln.Text = "Luai Anwar";
            this.lnkLinkedln.VisitedLinkColor = System.Drawing.Color.Transparent;
            this.lnkLinkedln.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLinkedln_LinkClicked);
            // 
            // lnkX
            // 
            this.lnkX.ActiveLinkColor = System.Drawing.Color.ForestGreen;
            this.lnkX.AutoSize = true;
            this.lnkX.BackColor = System.Drawing.Color.Transparent;
            this.lnkX.Font = new System.Drawing.Font("Segoe UI Semibold", 12.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lnkX.ForeColor = System.Drawing.Color.Black;
            this.lnkX.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkX.LinkColor = System.Drawing.Color.Black;
            this.lnkX.Location = new System.Drawing.Point(291, 455);
            this.lnkX.Name = "lnkX";
            this.lnkX.Size = new System.Drawing.Size(123, 30);
            this.lnkX.TabIndex = 27;
            this.lnkX.TabStop = true;
            this.lnkX.Text = "Luai Alarify";
            this.lnkX.VisitedLinkColor = System.Drawing.Color.Transparent;
            this.lnkX.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkX_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 494);
            this.Controls.Add(this.lnkX);
            this.Controls.Add(this.picX);
            this.Controls.Add(this.lnkLinkedln);
            this.Controls.Add(this.picLinkedln);
            this.Controls.Add(this.lnkGithub);
            this.Controls.Add(this.picGithub);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnMalti);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnClearLastNumber);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtWrite);
            this.Controls.Add(this.picLightMode);
            this.Controls.Add(this.picDarkMode);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDarkMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLightMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLinkedln)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGithub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWrite;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnClearLastNumber;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnMalti;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox picDarkMode;
        private System.Windows.Forms.PictureBox picLightMode;
        private System.Windows.Forms.PictureBox picX;
        private System.Windows.Forms.PictureBox picLinkedln;
        private System.Windows.Forms.PictureBox picGithub;
        private System.Windows.Forms.LinkLabel lnkGithub;
        private System.Windows.Forms.LinkLabel lnkLinkedln;
        private System.Windows.Forms.LinkLabel lnkX;
    }
}

