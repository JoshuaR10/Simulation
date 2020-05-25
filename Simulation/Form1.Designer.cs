namespace Simulation
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
            this.button1 = new System.Windows.Forms.Button();
            this.Decimal10 = new System.Windows.Forms.Label();
            this.Binary2 = new System.Windows.Forms.Label();
            this.Hex16 = new System.Windows.Forms.Label();
            this.HexDisplay = new System.Windows.Forms.TextBox();
            this.BinaryDisplay = new System.Windows.Forms.TextBox();
            this.DecimalDisplay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(238, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Press Code Generator";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Decimal10
            // 
            this.Decimal10.AutoSize = true;
            this.Decimal10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decimal10.Location = new System.Drawing.Point(12, 191);
            this.Decimal10.Name = "Decimal10";
            this.Decimal10.Size = new System.Drawing.Size(231, 25);
            this.Decimal10.TabIndex = 1;
            this.Decimal10.Text = "Decimal 10 Base Code";
            // 
            // Binary2
            // 
            this.Binary2.AutoSize = true;
            this.Binary2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Binary2.Location = new System.Drawing.Point(294, 191);
            this.Binary2.Name = "Binary2";
            this.Binary2.Size = new System.Drawing.Size(203, 25);
            this.Binary2.TabIndex = 2;
            this.Binary2.Text = "Binary 2 Base Code";
            // 
            // Hex16
            // 
            this.Hex16.AutoSize = true;
            this.Hex16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hex16.Location = new System.Drawing.Point(561, 191);
            this.Hex16.Name = "Hex16";
            this.Hex16.Size = new System.Drawing.Size(192, 25);
            this.Hex16.TabIndex = 3;
            this.Hex16.Text = "Hex 16 Base Code";
            // 
            // HexDisplay
            // 
            this.HexDisplay.Location = new System.Drawing.Point(566, 292);
            this.HexDisplay.Name = "HexDisplay";
            this.HexDisplay.Size = new System.Drawing.Size(187, 20);
            this.HexDisplay.TabIndex = 4;
            // 
            // BinaryDisplay
            // 
            this.BinaryDisplay.Location = new System.Drawing.Point(299, 292);
            this.BinaryDisplay.Name = "BinaryDisplay";
            this.BinaryDisplay.Size = new System.Drawing.Size(198, 20);
            this.BinaryDisplay.TabIndex = 5;
            // 
            // DecimalDisplay
            // 
            this.DecimalDisplay.Location = new System.Drawing.Point(17, 292);
            this.DecimalDisplay.Name = "DecimalDisplay";
            this.DecimalDisplay.Size = new System.Drawing.Size(226, 20);
            this.DecimalDisplay.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Generator of Codes!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(421, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Press the button to get your code!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DecimalDisplay);
            this.Controls.Add(this.BinaryDisplay);
            this.Controls.Add(this.HexDisplay);
            this.Controls.Add(this.Hex16);
            this.Controls.Add(this.Binary2);
            this.Controls.Add(this.Decimal10);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.Text = "Code Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Decimal10;
        private System.Windows.Forms.Label Binary2;
        private System.Windows.Forms.Label Hex16;
        private System.Windows.Forms.TextBox HexDisplay;
        private System.Windows.Forms.TextBox BinaryDisplay;
        private System.Windows.Forms.TextBox DecimalDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

