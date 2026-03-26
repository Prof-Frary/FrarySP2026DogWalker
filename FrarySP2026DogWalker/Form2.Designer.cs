namespace FrarySP2026DogWalker
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtDogWalkerPrice = new System.Windows.Forms.TextBox();
            this.txtDogParkPrice = new System.Windows.Forms.TextBox();
            this.txtPetSitPrice = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dog Walk Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dog Park Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pet Sitting Price";
            // 
            // txtDogWalkerPrice
            // 
            this.txtDogWalkerPrice.Location = new System.Drawing.Point(128, 48);
            this.txtDogWalkerPrice.Name = "txtDogWalkerPrice";
            this.txtDogWalkerPrice.Size = new System.Drawing.Size(100, 20);
            this.txtDogWalkerPrice.TabIndex = 3;
            // 
            // txtDogParkPrice
            // 
            this.txtDogParkPrice.Location = new System.Drawing.Point(128, 82);
            this.txtDogParkPrice.Name = "txtDogParkPrice";
            this.txtDogParkPrice.Size = new System.Drawing.Size(100, 20);
            this.txtDogParkPrice.TabIndex = 4;
            // 
            // txtPetSitPrice
            // 
            this.txtPetSitPrice.Location = new System.Drawing.Point(128, 126);
            this.txtPetSitPrice.Name = "txtPetSitPrice";
            this.txtPetSitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPetSitPrice.TabIndex = 5;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(102, 183);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "&Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(84, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(103, 16);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Price Settings";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(84, 235);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(117, 13);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "Possible Error Message";
            this.lblError.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 337);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtPetSitPrice);
            this.Controls.Add(this.txtDogParkPrice);
            this.Controls.Add(this.txtDogWalkerPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Dog Walker Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblError;
        internal System.Windows.Forms.TextBox txtDogWalkerPrice;
        internal System.Windows.Forms.TextBox txtDogParkPrice;
        internal System.Windows.Forms.TextBox txtPetSitPrice;
    }
}