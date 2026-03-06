namespace FrarySP2026DogWalker
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDogOwner = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServicesPerWeek = new System.Windows.Forms.TextBox();
            this.lstOut = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoWalk = new System.Windows.Forms.RadioButton();
            this.rdoPark = new System.Windows.Forms.RadioButton();
            this.rdoPetSitting = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dog Walker Weekly Transaction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dog &Owner";
            // 
            // txtDogOwner
            // 
            this.txtDogOwner.Location = new System.Drawing.Point(158, 120);
            this.txtDogOwner.Name = "txtDogOwner";
            this.txtDogOwner.Size = new System.Drawing.Size(172, 20);
            this.txtDogOwner.TabIndex = 2;
            this.txtDogOwner.Enter += new System.EventHandler(this.txtDogOwner_Enter);
            this.txtDogOwner.Leave += new System.EventHandler(this.txtDogOwner_Leave);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(38, 283);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 54);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate &Amount";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = " &Services Per Week";
            // 
            // txtServicesPerWeek
            // 
            this.txtServicesPerWeek.Location = new System.Drawing.Point(158, 153);
            this.txtServicesPerWeek.Name = "txtServicesPerWeek";
            this.txtServicesPerWeek.Size = new System.Drawing.Size(172, 20);
            this.txtServicesPerWeek.TabIndex = 4;
            this.txtServicesPerWeek.Enter += new System.EventHandler(this.txtServicesPerWeek_Enter);
            this.txtServicesPerWeek.Leave += new System.EventHandler(this.txtServicesPerWeek_Leave);
            // 
            // lstOut
            // 
            this.lstOut.FormattingEnabled = true;
            this.lstOut.Location = new System.Drawing.Point(32, 179);
            this.lstOut.Name = "lstOut";
            this.lstOut.Size = new System.Drawing.Size(339, 95);
            this.lstOut.TabIndex = 6;
            this.lstOut.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(158, 283);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 54);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(276, 283);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 54);
            this.btnQuit.TabIndex = 8;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoPetSitting);
            this.groupBox1.Controls.Add(this.rdoPark);
            this.groupBox1.Controls.Add(this.rdoWalk);
            this.groupBox1.Location = new System.Drawing.Point(38, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 52);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // rdoWalk
            // 
            this.rdoWalk.AutoSize = true;
            this.rdoWalk.Location = new System.Drawing.Point(8, 19);
            this.rdoWalk.Name = "rdoWalk";
            this.rdoWalk.Size = new System.Drawing.Size(96, 17);
            this.rdoWalk.TabIndex = 0;
            this.rdoWalk.TabStop = true;
            this.rdoWalk.Text = "Standard Walk";
            this.rdoWalk.UseVisualStyleBackColor = true;
            this.rdoWalk.CheckedChanged += new System.EventHandler(this.rdoWalk_CheckedChanged);
            // 
            // rdoPark
            // 
            this.rdoPark.AutoSize = true;
            this.rdoPark.Location = new System.Drawing.Point(110, 19);
            this.rdoPark.Name = "rdoPark";
            this.rdoPark.Size = new System.Drawing.Size(70, 17);
            this.rdoPark.TabIndex = 1;
            this.rdoPark.TabStop = true;
            this.rdoPark.Text = "Dog Park";
            this.rdoPark.UseVisualStyleBackColor = true;
            this.rdoPark.CheckedChanged += new System.EventHandler(this.rdoPark_CheckedChanged);
            // 
            // rdoPetSitting
            // 
            this.rdoPetSitting.AutoSize = true;
            this.rdoPetSitting.Location = new System.Drawing.Point(213, 19);
            this.rdoPetSitting.Name = "rdoPetSitting";
            this.rdoPetSitting.Size = new System.Drawing.Size(73, 17);
            this.rdoPetSitting.TabIndex = 2;
            this.rdoPetSitting.TabStop = true;
            this.rdoPetSitting.Text = "Pet Sitting";
            this.rdoPetSitting.UseVisualStyleBackColor = true;
            this.rdoPetSitting.CheckedChanged += new System.EventHandler(this.rdoPetSitting_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 381);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstOut);
            this.Controls.Add(this.txtServicesPerWeek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtDogOwner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Barbara\'s Dog Walking Service";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDogOwner;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServicesPerWeek;
        private System.Windows.Forms.ListBox lstOut;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoPetSitting;
        private System.Windows.Forms.RadioButton rdoPark;
        private System.Windows.Forms.RadioButton rdoWalk;
    }
}

