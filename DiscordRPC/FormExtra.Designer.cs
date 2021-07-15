
namespace DiscordRPC
{
    partial class FormExtra
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dis_enable_extra = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.dis_enable_extra);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 391);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extra Option";
            // 
            // dis_enable_extra
            // 
            this.dis_enable_extra.AutoSize = true;
            this.dis_enable_extra.Location = new System.Drawing.Point(6, 22);
            this.dis_enable_extra.Name = "dis_enable_extra";
            this.dis_enable_extra.Size = new System.Drawing.Size(137, 19);
            this.dis_enable_extra.TabIndex = 0;
            this.dis_enable_extra.Text = "Enable Lobby Option";
            this.dis_enable_extra.UseVisualStyleBackColor = true;
            this.dis_enable_extra.CheckedChanged += new System.EventHandler(this.dis_enable_extra_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(6, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 338);
            this.panel1.TabIndex = 1;
            // 
            // FormExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(470, 415);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FormExtra";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Extra Properties";
            this.Load += new System.EventHandler(this.FormExtra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox dis_enable_extra;
        private System.Windows.Forms.Panel panel1;
    }
}