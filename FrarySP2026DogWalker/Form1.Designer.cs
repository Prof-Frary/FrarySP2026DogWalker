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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dog Walker Weekly Transaction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dog &Owner";
            // 
            // txtDogOwner
            // 
            this.txtDogOwner.Location = new System.Drawing.Point(328, 173);
            this.txtDogOwner.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDogOwner.Name = "txtDogOwner";
            this.txtDogOwner.Size = new System.Drawing.Size(340, 31);
            this.txtDogOwner.TabIndex = 2;
            this.txtDogOwner.Enter += new System.EventHandler(this.txtDogOwner_Enter);
            this.txtDogOwner.Leave += new System.EventHandler(this.txtDogOwner_Leave);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(76, 544);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(150, 104);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate &Amount";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = " &Services Per Week";
            // 
            // txtServicesPerWeek
            // 
            this.txtServicesPerWeek.Location = new System.Drawing.Point(328, 237);
            this.txtServicesPerWeek.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtServicesPerWeek.Name = "txtServicesPerWeek";
            this.txtServicesPerWeek.Size = new System.Drawing.Size(340, 31);
            this.txtServicesPerWeek.TabIndex = 4;
            this.txtServicesPerWeek.Enter += new System.EventHandler(this.txtServicesPerWeek_Enter);
            this.txtServicesPerWeek.Leave += new System.EventHandler(this.txtServicesPerWeek_Leave);
            // 
            // lstOut
            // 
            this.lstOut.FormattingEnabled = true;
            this.lstOut.ItemHeight = 25;
            this.lstOut.Location = new System.Drawing.Point(76, 287);
            this.lstOut.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstOut.Name = "lstOut";
            this.lstOut.Size = new System.Drawing.Size(674, 179);
            this.lstOut.TabIndex = 6;
            this.lstOut.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(316, 544);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 104);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(552, 544);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(150, 104);
            this.btnQuit.TabIndex = 8;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 733);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstOut);
            this.Controls.Add(this.txtServicesPerWeek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtDogOwner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Barbara\'s Dog Walking Service";
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
    }
}

