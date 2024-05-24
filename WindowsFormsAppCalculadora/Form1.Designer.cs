namespace WindowsFormsAppCalculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPorcent = new System.Windows.Forms.Button();
            this.containerButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancelEntry = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNothing = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.btnRoot = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnSubt = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMoreOrLess = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnComma = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.displayExpression = new System.Windows.Forms.Label();
            this.containerButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPorcent
            // 
            this.btnPorcent.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPorcent.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorcent.Location = new System.Drawing.Point(111, 5);
            this.btnPorcent.Name = "btnPorcent";
            this.btnPorcent.Size = new System.Drawing.Size(100, 60);
            this.btnPorcent.TabIndex = 0;
            this.btnPorcent.Text = "%";
            this.btnPorcent.UseVisualStyleBackColor = true;
            // 
            // containerButtons
            // 
            this.containerButtons.AutoSize = true;
            this.containerButtons.Controls.Add(this.btnCancelEntry);
            this.containerButtons.Controls.Add(this.btnPorcent);
            this.containerButtons.Controls.Add(this.btnClean);
            this.containerButtons.Controls.Add(this.btnBack);
            this.containerButtons.Controls.Add(this.btnNothing);
            this.containerButtons.Controls.Add(this.btnPow);
            this.containerButtons.Controls.Add(this.btnRoot);
            this.containerButtons.Controls.Add(this.btnDiv);
            this.containerButtons.Controls.Add(this.btnSeven);
            this.containerButtons.Controls.Add(this.btnEight);
            this.containerButtons.Controls.Add(this.btnNine);
            this.containerButtons.Controls.Add(this.btnMult);
            this.containerButtons.Controls.Add(this.btnFour);
            this.containerButtons.Controls.Add(this.btnFive);
            this.containerButtons.Controls.Add(this.btnSix);
            this.containerButtons.Controls.Add(this.btnSubt);
            this.containerButtons.Controls.Add(this.btnOne);
            this.containerButtons.Controls.Add(this.btnTwo);
            this.containerButtons.Controls.Add(this.btnThree);
            this.containerButtons.Controls.Add(this.btnAdd);
            this.containerButtons.Controls.Add(this.btnMoreOrLess);
            this.containerButtons.Controls.Add(this.btnZero);
            this.containerButtons.Controls.Add(this.btnComma);
            this.containerButtons.Controls.Add(this.btnEqual);
            this.containerButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.containerButtons.Location = new System.Drawing.Point(0, 123);
            this.containerButtons.Margin = new System.Windows.Forms.Padding(0);
            this.containerButtons.Name = "containerButtons";
            this.containerButtons.Padding = new System.Windows.Forms.Padding(2);
            this.containerButtons.Size = new System.Drawing.Size(428, 400);
            this.containerButtons.TabIndex = 1;
            // 
            // btnCancelEntry
            // 
            this.btnCancelEntry.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelEntry.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEntry.Location = new System.Drawing.Point(5, 5);
            this.btnCancelEntry.Name = "btnCancelEntry";
            this.btnCancelEntry.Size = new System.Drawing.Size(100, 60);
            this.btnCancelEntry.TabIndex = 1;
            this.btnCancelEntry.Text = "CE";
            this.btnCancelEntry.UseVisualStyleBackColor = true;
            // 
            // btnClean
            // 
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClean.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(217, 5);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(100, 60);
            this.btnClean.TabIndex = 2;
            this.btnClean.Text = "C";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBack.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(323, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 60);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "⌫";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNothing
            // 
            this.btnNothing.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNothing.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNothing.Location = new System.Drawing.Point(5, 71);
            this.btnNothing.Name = "btnNothing";
            this.btnNothing.Size = new System.Drawing.Size(100, 60);
            this.btnNothing.TabIndex = 4;
            this.btnNothing.Text = "1/x";
            this.btnNothing.UseVisualStyleBackColor = true;
            // 
            // btnPow
            // 
            this.btnPow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPow.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPow.Location = new System.Drawing.Point(111, 71);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(100, 60);
            this.btnPow.TabIndex = 5;
            this.btnPow.Text = "x²";
            this.btnPow.UseVisualStyleBackColor = true;
            // 
            // btnRoot
            // 
            this.btnRoot.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRoot.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoot.Location = new System.Drawing.Point(217, 71);
            this.btnRoot.Name = "btnRoot";
            this.btnRoot.Size = new System.Drawing.Size(100, 60);
            this.btnRoot.TabIndex = 6;
            this.btnRoot.Text = "√x";
            this.btnRoot.UseVisualStyleBackColor = true;
            // 
            // btnDiv
            // 
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDiv.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(323, 71);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(100, 60);
            this.btnDiv.TabIndex = 7;
            this.btnDiv.Tag = "/";
            this.btnDiv.Text = " ÷";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSeven.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.Location = new System.Drawing.Point(5, 137);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(100, 60);
            this.btnSeven.TabIndex = 8;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnEight
            // 
            this.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEight.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.Location = new System.Drawing.Point(111, 137);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(100, 60);
            this.btnEight.TabIndex = 9;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnNine
            // 
            this.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNine.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.Location = new System.Drawing.Point(217, 137);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(100, 60);
            this.btnNine.TabIndex = 10;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnMult
            // 
            this.btnMult.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMult.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.Location = new System.Drawing.Point(323, 137);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(100, 60);
            this.btnMult.TabIndex = 11;
            this.btnMult.Tag = "*";
            this.btnMult.Text = "x";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnFour
            // 
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFour.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.Location = new System.Drawing.Point(5, 203);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(100, 60);
            this.btnFour.TabIndex = 12;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnFive
            // 
            this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFive.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.Location = new System.Drawing.Point(111, 203);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(100, 60);
            this.btnFive.TabIndex = 13;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSix
            // 
            this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSix.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.Location = new System.Drawing.Point(217, 203);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(100, 60);
            this.btnSix.TabIndex = 14;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSubt
            // 
            this.btnSubt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSubt.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubt.Location = new System.Drawing.Point(323, 203);
            this.btnSubt.Name = "btnSubt";
            this.btnSubt.Size = new System.Drawing.Size(100, 60);
            this.btnSubt.TabIndex = 15;
            this.btnSubt.Tag = "-";
            this.btnSubt.Text = "-";
            this.btnSubt.UseVisualStyleBackColor = true;
            this.btnSubt.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnOne
            // 
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOne.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.Location = new System.Drawing.Point(5, 269);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(100, 60);
            this.btnOne.TabIndex = 16;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTwo.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.Location = new System.Drawing.Point(111, 269);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(100, 60);
            this.btnTwo.TabIndex = 17;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnThree
            // 
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnThree.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.Location = new System.Drawing.Point(217, 269);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(100, 60);
            this.btnThree.TabIndex = 18;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(323, 269);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 60);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Tag = "+";
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnMoreOrLess
            // 
            this.btnMoreOrLess.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMoreOrLess.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoreOrLess.Location = new System.Drawing.Point(5, 335);
            this.btnMoreOrLess.Name = "btnMoreOrLess";
            this.btnMoreOrLess.Size = new System.Drawing.Size(100, 60);
            this.btnMoreOrLess.TabIndex = 20;
            this.btnMoreOrLess.Text = "+/-";
            this.btnMoreOrLess.UseVisualStyleBackColor = true;
            // 
            // btnZero
            // 
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnZero.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(111, 335);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(100, 60);
            this.btnZero.TabIndex = 21;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnComma
            // 
            this.btnComma.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnComma.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComma.Location = new System.Drawing.Point(217, 335);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(100, 60);
            this.btnComma.TabIndex = 22;
            this.btnComma.Text = ".";
            this.btnComma.UseVisualStyleBackColor = true;
            // 
            // btnEqual
            // 
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEqual.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(323, 335);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(100, 60);
            this.btnEqual.TabIndex = 23;
            this.btnEqual.Tag = "=";
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // display
            // 
            this.display.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.display.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.ForeColor = System.Drawing.Color.White;
            this.display.Location = new System.Drawing.Point(0, 31);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(428, 90);
            this.display.TabIndex = 0;
            this.display.Text = "0";
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.displayExpression);
            this.panel1.Controls.Add(this.display);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 121);
            this.panel1.TabIndex = 2;
            // 
            // displayExpression
            // 
            this.displayExpression.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayExpression.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayExpression.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.displayExpression.Location = new System.Drawing.Point(0, 0);
            this.displayExpression.Name = "displayExpression";
            this.displayExpression.Padding = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.displayExpression.Size = new System.Drawing.Size(428, 31);
            this.displayExpression.TabIndex = 1;
            this.displayExpression.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(428, 523);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.containerButtons);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.containerButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPorcent;
        private System.Windows.Forms.FlowLayoutPanel containerButtons;
        private System.Windows.Forms.Button btnCancelEntry;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNothing;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button btnRoot;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnSubt;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMoreOrLess;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnComma;
        private System.Windows.Forms.Label display;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label displayExpression;
    }
}

