namespace P110_Tasks
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
            this.btnCalculateSync = new System.Windows.Forms.Button();
            this.txtResultSync = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResultAsync = new System.Windows.Forms.TextBox();
            this.btnCalculateAsync = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculateSync
            // 
            this.btnCalculateSync.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateSync.Location = new System.Drawing.Point(84, 164);
            this.btnCalculateSync.Name = "btnCalculateSync";
            this.btnCalculateSync.Size = new System.Drawing.Size(412, 126);
            this.btnCalculateSync.TabIndex = 0;
            this.btnCalculateSync.Text = "Calculate Sync";
            this.btnCalculateSync.UseVisualStyleBackColor = true;
            this.btnCalculateSync.Click += new System.EventHandler(this.btnCalculateSync_Click);
            // 
            // txtResultSync
            // 
            this.txtResultSync.Location = new System.Drawing.Point(84, 93);
            this.txtResultSync.Name = "txtResultSync";
            this.txtResultSync.Size = new System.Drawing.Size(412, 20);
            this.txtResultSync.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sync";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(542, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Async";
            // 
            // txtResultAsync
            // 
            this.txtResultAsync.Location = new System.Drawing.Point(542, 93);
            this.txtResultAsync.Name = "txtResultAsync";
            this.txtResultAsync.Size = new System.Drawing.Size(412, 20);
            this.txtResultAsync.TabIndex = 4;
            // 
            // btnCalculateAsync
            // 
            this.btnCalculateAsync.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateAsync.Location = new System.Drawing.Point(542, 164);
            this.btnCalculateAsync.Name = "btnCalculateAsync";
            this.btnCalculateAsync.Size = new System.Drawing.Size(412, 126);
            this.btnCalculateAsync.TabIndex = 3;
            this.btnCalculateAsync.Text = "Calculate Async";
            this.btnCalculateAsync.UseVisualStyleBackColor = true;
            this.btnCalculateAsync.Click += new System.EventHandler(this.btnCalculateAsync_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Calculating numbers...";
            this.label3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 632);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResultAsync);
            this.Controls.Add(this.btnCalculateAsync);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResultSync);
            this.Controls.Add(this.btnCalculateSync);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculateSync;
        private System.Windows.Forms.TextBox txtResultSync;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultAsync;
        private System.Windows.Forms.Button btnCalculateAsync;
        private System.Windows.Forms.Label label3;
    }
}

