namespace Lexer.Forms.Views
{
    partial class frmLexer
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
            System.Windows.Forms.Button btnRun;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLexer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCode = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            btnRun = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(584, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Write your code!";
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCode.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCode.Location = new System.Drawing.Point(9, 25);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(567, 167);
            this.txtCode.TabIndex = 0;
            this.txtCode.Text = "";
            // 
            // btnRun
            // 
            btnRun.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            btnRun.BackColor = System.Drawing.Color.Transparent;
            btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnRun.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnRun.Image = global::Lexer.Forms.Properties.Resources.índice;
            btnRun.Location = new System.Drawing.Point(234, 223);
            btnRun.Margin = new System.Windows.Forms.Padding(4);
            btnRun.Name = "btnRun";
            btnRun.Size = new System.Drawing.Size(144, 50);
            btnRun.TabIndex = 1;
            btnRun.UseVisualStyleBackColor = false;
            btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtResult);
            this.groupBox2.Location = new System.Drawing.Point(16, 281);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(584, 215);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results:";
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtResult.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtResult.Location = new System.Drawing.Point(9, 18);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(567, 189);
            this.txtResult.TabIndex = 1;
            this.txtResult.Text = "";
            // 
            // frmLexer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(615, 509);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(btnRun);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLexer";
            this.Text = "frmLexer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtCode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txtResult;
    }
}