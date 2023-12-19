namespace ASE_Assignment
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
            this.inputTextbox = new System.Windows.Forms.TextBox();
            this.longInputTextbox = new System.Windows.Forms.RichTextBox();
            this.buttonToLoad = new System.Windows.Forms.Button();
            this.buttonToSave = new System.Windows.Forms.Button();
            this.textboxForSyntaxErrors = new System.Windows.Forms.RichTextBox();
            this.textboxToShowFill = new System.Windows.Forms.Label();
            this.drawingOutput = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.drawingOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // inputTextbox
            // 
            this.inputTextbox.BackColor = System.Drawing.Color.Fuchsia;
            this.inputTextbox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextbox.Location = new System.Drawing.Point(29, 315);
            this.inputTextbox.Name = "inputTextbox";
            this.inputTextbox.Size = new System.Drawing.Size(250, 22);
            this.inputTextbox.TabIndex = 1;
            this.inputTextbox.Text = "Type Here";
            this.inputTextbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.commandLine_MouseClick);
            this.inputTextbox.TextChanged += new System.EventHandler(this.commandLine_TextChanged);
            this.inputTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.commandLine_KeyDown);
            // 
            // longInputTextbox
            // 
            this.longInputTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.longInputTextbox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longInputTextbox.Location = new System.Drawing.Point(29, 12);
            this.longInputTextbox.Name = "longInputTextbox";
            this.longInputTextbox.Size = new System.Drawing.Size(250, 299);
            this.longInputTextbox.TabIndex = 2;
            this.longInputTextbox.Text = "";
            this.longInputTextbox.TextChanged += new System.EventHandler(this.programInput_TextChanged);
            // 
            // buttonToLoad
            // 
            this.buttonToLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonToLoad.Location = new System.Drawing.Point(616, 314);
            this.buttonToLoad.Name = "buttonToLoad";
            this.buttonToLoad.Size = new System.Drawing.Size(323, 23);
            this.buttonToLoad.TabIndex = 3;
            this.buttonToLoad.Text = "Load Image";
            this.buttonToLoad.UseVisualStyleBackColor = false;
            this.buttonToLoad.Click += new System.EventHandler(this.buttonToLoad_Click);
            // 
            // buttonToSave
            // 
            this.buttonToSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonToSave.Location = new System.Drawing.Point(307, 314);
            this.buttonToSave.Name = "buttonToSave";
            this.buttonToSave.Size = new System.Drawing.Size(303, 23);
            this.buttonToSave.TabIndex = 4;
            this.buttonToSave.Text = "Save Image";
            this.buttonToSave.UseVisualStyleBackColor = false;
            this.buttonToSave.Click += new System.EventHandler(this.buttonToSave_Click);
            // 
            // textboxForSyntaxErrors
            // 
            this.textboxForSyntaxErrors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textboxForSyntaxErrors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxForSyntaxErrors.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxForSyntaxErrors.ForeColor = System.Drawing.Color.Red;
            this.textboxForSyntaxErrors.Location = new System.Drawing.Point(429, 15);
            this.textboxForSyntaxErrors.Name = "textboxForSyntaxErrors";
            this.textboxForSyntaxErrors.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textboxForSyntaxErrors.Size = new System.Drawing.Size(499, 28);
            this.textboxForSyntaxErrors.TabIndex = 5;
            this.textboxForSyntaxErrors.Text = "";
            this.textboxForSyntaxErrors.TextChanged += new System.EventHandler(this.textboxForSyntaxErrors_TextChanged);
            // 
            // textboxToShowFill
            // 
            this.textboxToShowFill.AutoSize = true;
            this.textboxToShowFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textboxToShowFill.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxToShowFill.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textboxToShowFill.Location = new System.Drawing.Point(312, 15);
            this.textboxToShowFill.Name = "textboxToShowFill";
            this.textboxToShowFill.Size = new System.Drawing.Size(15, 16);
            this.textboxToShowFill.TabIndex = 6;
            this.textboxToShowFill.Text = "  ";
            this.textboxToShowFill.Click += new System.EventHandler(this.textboxToShowFill_Click);
            // 
            // drawingOutput
            // 
            this.drawingOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.drawingOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawingOutput.Location = new System.Drawing.Point(307, 12);
            this.drawingOutput.Name = "drawingOutput";
            this.drawingOutput.Size = new System.Drawing.Size(632, 299);
            this.drawingOutput.TabIndex = 0;
            this.drawingOutput.TabStop = false;
            this.drawingOutput.Paint += new System.Windows.Forms.PaintEventHandler(this.outputCanvas_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 538);
            this.Controls.Add(this.textboxToShowFill);
            this.Controls.Add(this.textboxForSyntaxErrors);
            this.Controls.Add(this.buttonToSave);
            this.Controls.Add(this.buttonToLoad);
            this.Controls.Add(this.longInputTextbox);
            this.Controls.Add(this.inputTextbox);
            this.Controls.Add(this.drawingOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.drawingOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox inputTextbox;
        private System.Windows.Forms.RichTextBox longInputTextbox;
        private System.Windows.Forms.Button buttonToLoad;
        private System.Windows.Forms.Button buttonToSave;
        private System.Windows.Forms.RichTextBox textboxForSyntaxErrors;
        private System.Windows.Forms.Label textboxToShowFill;
        public System.Windows.Forms.PictureBox drawingOutput;
    }
}
