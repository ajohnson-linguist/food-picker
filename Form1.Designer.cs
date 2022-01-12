
namespace FoodPicker
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
            this.noCookText = new System.Windows.Forms.TextBox();
            this.noCookRandomize = new System.Windows.Forms.Button();
            this.liteCookRandomize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.liteCookText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // noCookText
            // 
            this.noCookText.AcceptsReturn = true;
            this.noCookText.AcceptsTab = true;
            this.noCookText.AllowDrop = true;
            this.noCookText.HideSelection = false;
            this.noCookText.Location = new System.Drawing.Point(12, 28);
            this.noCookText.Multiline = true;
            this.noCookText.Name = "noCookText";
            this.noCookText.Size = new System.Drawing.Size(381, 354);
            this.noCookText.TabIndex = 0;
            // 
            // noCookRandomize
            // 
            this.noCookRandomize.Location = new System.Drawing.Point(12, 388);
            this.noCookRandomize.Name = "noCookRandomize";
            this.noCookRandomize.Size = new System.Drawing.Size(381, 23);
            this.noCookRandomize.TabIndex = 2;
            this.noCookRandomize.Text = "Randomize";
            this.noCookRandomize.UseVisualStyleBackColor = true;
            this.noCookRandomize.Click += new System.EventHandler(this.noCookRandomize_Click);
            // 
            // liteCookRandomize
            // 
            this.liteCookRandomize.Location = new System.Drawing.Point(405, 388);
            this.liteCookRandomize.Name = "liteCookRandomize";
            this.liteCookRandomize.Size = new System.Drawing.Size(381, 23);
            this.liteCookRandomize.TabIndex = 4;
            this.liteCookRandomize.Text = "Randomize";
            this.liteCookRandomize.UseVisualStyleBackColor = true;
            this.liteCookRandomize.Click += new System.EventHandler(this.liteCookRandomize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "No Cooking Required";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lite Cooking Required";
            // 
            // liteCookText
            // 
            this.liteCookText.AcceptsReturn = true;
            this.liteCookText.AcceptsTab = true;
            this.liteCookText.AllowDrop = true;
            this.liteCookText.HideSelection = false;
            this.liteCookText.Location = new System.Drawing.Point(405, 28);
            this.liteCookText.Multiline = true;
            this.liteCookText.Name = "liteCookText";
            this.liteCookText.Size = new System.Drawing.Size(381, 354);
            this.liteCookText.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.liteCookText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.liteCookRandomize);
            this.Controls.Add(this.noCookRandomize);
            this.Controls.Add(this.noCookText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox noCookText;
        private System.Windows.Forms.Button noCookRandomize;
        private System.Windows.Forms.Button liteCookRandomize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox liteCookText;
    }
}

