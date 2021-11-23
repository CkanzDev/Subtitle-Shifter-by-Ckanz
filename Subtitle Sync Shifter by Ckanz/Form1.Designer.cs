namespace Subtitle_Sync_Shifter_by_Ckanz
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
            this.label3 = new System.Windows.Forms.Label();
            this.loadclik = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.increaseclick = new System.Windows.Forms.Button();
            this.syncdecreases = new System.Windows.Forms.Button();
            this.Saveclicks = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.openfiledialog = new System.Windows.Forms.OpenFileDialog();
            this.savefiledialog = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.testbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Created by Ckanz";
            // 
            // loadclik
            // 
            this.loadclik.Location = new System.Drawing.Point(234, 296);
            this.loadclik.Name = "loadclik";
            this.loadclik.Size = new System.Drawing.Size(140, 59);
            this.loadclik.TabIndex = 1;
            this.loadclik.Text = "Load";
            this.loadclik.UseVisualStyleBackColor = true;
            this.loadclik.Click += new System.EventHandler(this.loadclik_Click_1);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(234, 35);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(581, 255);
            this.textBox3.TabIndex = 2;
            // 
            // increaseclick
            // 
            this.increaseclick.Location = new System.Drawing.Point(383, 296);
            this.increaseclick.Name = "increaseclick";
            this.increaseclick.Size = new System.Drawing.Size(140, 59);
            this.increaseclick.TabIndex = 3;
            this.increaseclick.Text = "Sync Increse";
            this.increaseclick.UseVisualStyleBackColor = true;
            this.increaseclick.Click += new System.EventHandler(this.increaseclick_Click);
            // 
            // syncdecreases
            // 
            this.syncdecreases.Location = new System.Drawing.Point(529, 296);
            this.syncdecreases.Name = "syncdecreases";
            this.syncdecreases.Size = new System.Drawing.Size(140, 59);
            this.syncdecreases.TabIndex = 4;
            this.syncdecreases.Text = "Sync Decrease";
            this.syncdecreases.UseVisualStyleBackColor = true;
            this.syncdecreases.Click += new System.EventHandler(this.syncdecreases_Click);
            // 
            // Saveclicks
            // 
            this.Saveclicks.Location = new System.Drawing.Point(675, 296);
            this.Saveclicks.Name = "Saveclicks";
            this.Saveclicks.Size = new System.Drawing.Size(140, 59);
            this.Saveclicks.TabIndex = 5;
            this.Saveclicks.Text = "Save";
            this.Saveclicks.UseVisualStyleBackColor = true;
            this.Saveclicks.Click += new System.EventHandler(this.Saveclicks_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(234, 368);
            this.textBox4.Name = "textBox4";
            this.textBox4.ShortcutsEnabled = false;
            this.textBox4.Size = new System.Drawing.Size(581, 20);
            this.textBox4.TabIndex = 6;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged_1);
            // 
            // openfiledialog
            // 
            this.openfiledialog.FileName = "openFileDialog1";
            this.openfiledialog.Filter = "srt|*.srt";
            this.openfiledialog.Title = "Choose a file to import";
            this.openfiledialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openfiledialog_FileOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // testbutton
            // 
            this.testbutton.Location = new System.Drawing.Point(740, 6);
            this.testbutton.Name = "testbutton";
            this.testbutton.Size = new System.Drawing.Size(75, 23);
            this.testbutton.TabIndex = 8;
            this.testbutton.Text = "test";
            this.testbutton.UseVisualStyleBackColor = true;
            this.testbutton.Click += new System.EventHandler(this.testbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Miliseconds(Ms) -->";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(827, 400);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.testbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Saveclicks);
            this.Controls.Add(this.syncdecreases);
            this.Controls.Add(this.increaseclick);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.loadclik);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Subtitle Shifter Ckanz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loadclik;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button increaseclick;
        private System.Windows.Forms.Button syncdecreases;
        private System.Windows.Forms.Button Saveclicks;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.OpenFileDialog openfiledialog;
        private System.Windows.Forms.SaveFileDialog savefiledialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button testbutton;
        private System.Windows.Forms.Label label2;
    }
}
