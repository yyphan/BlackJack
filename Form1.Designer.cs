
namespace BlackJack
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStay = new System.Windows.Forms.Button();
            this.groupBoxPlayer = new System.Windows.Forms.GroupBox();
            this.textBoxPlayerHand = new System.Windows.Forms.TextBox();
            this.groupBoxDealerHand = new System.Windows.Forms.GroupBox();
            this.textBoxDealerHand = new System.Windows.Forms.TextBox();
            this.labelDealerSum = new System.Windows.Forms.Label();
            this.labelPlayerSum = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.groupBoxPlayer.SuspendLayout();
            this.groupBoxDealerHand.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHit
            // 
            this.btnHit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHit.Location = new System.Drawing.Point(583, 242);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(153, 59);
            this.btnHit.TabIndex = 0;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnPlayerHit_Click);
            // 
            // btnStay
            // 
            this.btnStay.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStay.Location = new System.Drawing.Point(583, 335);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(153, 59);
            this.btnStay.TabIndex = 1;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = true;
            this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
            // 
            // groupBoxPlayer
            // 
            this.groupBoxPlayer.Controls.Add(this.textBoxPlayerHand);
            this.groupBoxPlayer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxPlayer.Location = new System.Drawing.Point(52, 238);
            this.groupBoxPlayer.Name = "groupBoxPlayer";
            this.groupBoxPlayer.Size = new System.Drawing.Size(409, 181);
            this.groupBoxPlayer.TabIndex = 2;
            this.groupBoxPlayer.TabStop = false;
            this.groupBoxPlayer.Text = "Player Hand";
            // 
            // textBoxPlayerHand
            // 
            this.textBoxPlayerHand.Location = new System.Drawing.Point(7, 23);
            this.textBoxPlayerHand.Multiline = true;
            this.textBoxPlayerHand.Name = "textBoxPlayerHand";
            this.textBoxPlayerHand.ReadOnly = true;
            this.textBoxPlayerHand.Size = new System.Drawing.Size(396, 152);
            this.textBoxPlayerHand.TabIndex = 0;
            // 
            // groupBoxDealerHand
            // 
            this.groupBoxDealerHand.Controls.Add(this.textBoxDealerHand);
            this.groupBoxDealerHand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxDealerHand.Location = new System.Drawing.Point(52, 37);
            this.groupBoxDealerHand.Name = "groupBoxDealerHand";
            this.groupBoxDealerHand.Size = new System.Drawing.Size(409, 181);
            this.groupBoxDealerHand.TabIndex = 3;
            this.groupBoxDealerHand.TabStop = false;
            this.groupBoxDealerHand.Text = "Dealer Hand";
            // 
            // textBoxDealerHand
            // 
            this.textBoxDealerHand.Location = new System.Drawing.Point(7, 23);
            this.textBoxDealerHand.Multiline = true;
            this.textBoxDealerHand.Name = "textBoxDealerHand";
            this.textBoxDealerHand.ReadOnly = true;
            this.textBoxDealerHand.Size = new System.Drawing.Size(396, 152);
            this.textBoxDealerHand.TabIndex = 0;
            // 
            // labelDealerSum
            // 
            this.labelDealerSum.AutoSize = true;
            this.labelDealerSum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDealerSum.Location = new System.Drawing.Point(462, 60);
            this.labelDealerSum.Name = "labelDealerSum";
            this.labelDealerSum.Size = new System.Drawing.Size(19, 21);
            this.labelDealerSum.TabIndex = 4;
            this.labelDealerSum.Text = "0";
            // 
            // labelPlayerSum
            // 
            this.labelPlayerSum.AutoSize = true;
            this.labelPlayerSum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlayerSum.Location = new System.Drawing.Point(462, 261);
            this.labelPlayerSum.Name = "labelPlayerSum";
            this.labelPlayerSum.Size = new System.Drawing.Size(19, 21);
            this.labelPlayerSum.TabIndex = 5;
            this.labelPlayerSum.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxResult);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(524, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 119);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(7, 22);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(257, 90);
            this.textBoxResult.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelPlayerSum);
            this.Controls.Add(this.labelDealerSum);
            this.Controls.Add(this.groupBoxDealerHand);
            this.Controls.Add(this.groupBoxPlayer);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.btnHit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxPlayer.ResumeLayout(false);
            this.groupBoxPlayer.PerformLayout();
            this.groupBoxDealerHand.ResumeLayout(false);
            this.groupBoxDealerHand.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.GroupBox groupBoxPlayer;
        private System.Windows.Forms.TextBox textBoxPlayerHand;
        private System.Windows.Forms.GroupBox groupBoxDealerHand;
        private System.Windows.Forms.TextBox textBoxDealerHand;
        private System.Windows.Forms.Label labelDealerSum;
        private System.Windows.Forms.Label labelPlayerSum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}

