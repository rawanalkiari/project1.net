
namespace WindowsFormsApp2
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
            this.but_Search = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.but_read = new System.Windows.Forms.Button();
            this.but_write = new System.Windows.Forms.Button();
            this.tex_read = new System.Windows.Forms.RichTextBox();
            this.txt_update = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // but_Search
            // 
            this.but_Search.Location = new System.Drawing.Point(639, 380);
            this.but_Search.Name = "but_Search";
            this.but_Search.Size = new System.Drawing.Size(149, 23);
            this.but_Search.TabIndex = 0;
            this.but_Search.Text = "Search file";
            this.but_Search.UseVisualStyleBackColor = true;
            this.but_Search.Click += new System.EventHandler(this.but_Search_Click);
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(53, 383);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(483, 20);
            this.txt_path.TabIndex = 1;
            this.txt_path.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // but_read
            // 
            this.but_read.Location = new System.Drawing.Point(67, 318);
            this.but_read.Name = "but_read";
            this.but_read.Size = new System.Drawing.Size(117, 23);
            this.but_read.TabIndex = 2;
            this.but_read.Text = "Read file";
            this.but_read.UseVisualStyleBackColor = true;
            this.but_read.Click += new System.EventHandler(this.but_read_Click);
            // 
            // but_write
            // 
            this.but_write.Location = new System.Drawing.Point(482, 318);
            this.but_write.Name = "but_write";
            this.but_write.Size = new System.Drawing.Size(101, 23);
            this.but_write.TabIndex = 3;
            this.but_write.Text = "update";
            this.but_write.UseVisualStyleBackColor = true;
            this.but_write.Click += new System.EventHandler(this.button1_Click);
            // 
            // tex_read
            // 
            this.tex_read.Location = new System.Drawing.Point(84, 23);
            this.tex_read.Name = "tex_read";
            this.tex_read.Size = new System.Drawing.Size(499, 96);
            this.tex_read.TabIndex = 4;
            this.tex_read.Text = "";
            // 
            // txt_update
            // 
            this.txt_update.Location = new System.Drawing.Point(84, 165);
            this.txt_update.Name = "txt_update";
            this.txt_update.Size = new System.Drawing.Size(499, 96);
            this.txt_update.TabIndex = 5;
            this.txt_update.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_update);
            this.Controls.Add(this.tex_read);
            this.Controls.Add(this.but_write);
            this.Controls.Add(this.but_read);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.but_Search);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_Search;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Button but_read;
        private System.Windows.Forms.Button but_write;
        private System.Windows.Forms.RichTextBox tex_read;
        private System.Windows.Forms.RichTextBox txt_update;
    }
}

