namespace Jfk.Reflector
{
    partial class MainForm
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
            this.topMenuStrip = new System.Windows.Forms.MenuStrip();
            this.openFileStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assemblyTreeView = new System.Windows.Forms.TreeView();
            this.Descpription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bit0 = new System.Windows.Forms.CheckBox();
            this.bit1 = new System.Windows.Forms.CheckBox();
            this.bit2 = new System.Windows.Forms.CheckBox();
            this.bit3 = new System.Windows.Forms.CheckBox();
            this.bit4 = new System.Windows.Forms.CheckBox();
            this.bit5 = new System.Windows.Forms.CheckBox();
            this.bit6 = new System.Windows.Forms.CheckBox();
            this.bit7 = new System.Windows.Forms.CheckBox();
            this.bit7a = new System.Windows.Forms.CheckBox();
            this.bit6a = new System.Windows.Forms.CheckBox();
            this.bit5a = new System.Windows.Forms.CheckBox();
            this.bit4a = new System.Windows.Forms.CheckBox();
            this.bit3a = new System.Windows.Forms.CheckBox();
            this.bit2a = new System.Windows.Forms.CheckBox();
            this.bit1a = new System.Windows.Forms.CheckBox();
            this.bit0a = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.wyniktext = new System.Windows.Forms.TextBox();
            this.wynikbittext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.inputStyle = new System.Windows.Forms.CheckBox();
            this.textArgument1 = new System.Windows.Forms.TextBox();
            this.textArgument2 = new System.Windows.Forms.TextBox();
            this.textBit1 = new System.Windows.Forms.TextBox();
            this.textBit2 = new System.Windows.Forms.TextBox();
            this.topMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // topMenuStrip
            // 
            this.topMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileStripItem});
            this.topMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.topMenuStrip.Name = "topMenuStrip";
            this.topMenuStrip.Size = new System.Drawing.Size(624, 24);
            this.topMenuStrip.TabIndex = 0;
            this.topMenuStrip.Text = "menuStrip1";
            // 
            // openFileStripItem
            // 
            this.openFileStripItem.Name = "openFileStripItem";
            this.openFileStripItem.Size = new System.Drawing.Size(48, 20);
            this.openFileStripItem.Text = "Open";
            this.openFileStripItem.Click += new System.EventHandler(this.openFileStripItem_Click);
            // 
            // assemblyTreeView
            // 
            this.assemblyTreeView.Location = new System.Drawing.Point(0, 28);
            this.assemblyTreeView.Name = "assemblyTreeView";
            this.assemblyTreeView.Size = new System.Drawing.Size(304, 321);
            this.assemblyTreeView.TabIndex = 1;
            this.assemblyTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.memberNode_AfterSelect);
            // 
            // Descpription
            // 
            this.Descpription.Location = new System.Drawing.Point(310, 47);
            this.Descpription.Name = "Descpription";
            this.Descpription.ReadOnly = true;
            this.Descpription.Size = new System.Drawing.Size(302, 20);
            this.Descpription.TabIndex = 2;
            this.Descpription.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "7     6     5     4     3     2     1     0";
            // 
            // bit0
            // 
            this.bit0.AutoSize = true;
            this.bit0.Location = new System.Drawing.Point(538, 130);
            this.bit0.Name = "bit0";
            this.bit0.Size = new System.Drawing.Size(15, 14);
            this.bit0.TabIndex = 4;
            this.bit0.UseVisualStyleBackColor = true;
            this.bit0.CheckedChanged += new System.EventHandler(this.bit0_CheckedChanged);
            // 
            // bit1
            // 
            this.bit1.AutoSize = true;
            this.bit1.Location = new System.Drawing.Point(517, 130);
            this.bit1.Name = "bit1";
            this.bit1.Size = new System.Drawing.Size(15, 14);
            this.bit1.TabIndex = 5;
            this.bit1.UseVisualStyleBackColor = true;
            // 
            // bit2
            // 
            this.bit2.AutoSize = true;
            this.bit2.Location = new System.Drawing.Point(496, 130);
            this.bit2.Name = "bit2";
            this.bit2.Size = new System.Drawing.Size(15, 14);
            this.bit2.TabIndex = 6;
            this.bit2.UseVisualStyleBackColor = true;
            // 
            // bit3
            // 
            this.bit3.AutoSize = true;
            this.bit3.Location = new System.Drawing.Point(475, 130);
            this.bit3.Name = "bit3";
            this.bit3.Size = new System.Drawing.Size(15, 14);
            this.bit3.TabIndex = 7;
            this.bit3.UseVisualStyleBackColor = true;
            // 
            // bit4
            // 
            this.bit4.AutoSize = true;
            this.bit4.Location = new System.Drawing.Point(454, 130);
            this.bit4.Name = "bit4";
            this.bit4.Size = new System.Drawing.Size(15, 14);
            this.bit4.TabIndex = 8;
            this.bit4.UseVisualStyleBackColor = true;
            // 
            // bit5
            // 
            this.bit5.AutoSize = true;
            this.bit5.Location = new System.Drawing.Point(433, 130);
            this.bit5.Name = "bit5";
            this.bit5.Size = new System.Drawing.Size(15, 14);
            this.bit5.TabIndex = 9;
            this.bit5.UseVisualStyleBackColor = true;
            // 
            // bit6
            // 
            this.bit6.AutoSize = true;
            this.bit6.Location = new System.Drawing.Point(412, 130);
            this.bit6.Name = "bit6";
            this.bit6.Size = new System.Drawing.Size(15, 14);
            this.bit6.TabIndex = 10;
            this.bit6.UseVisualStyleBackColor = true;
            // 
            // bit7
            // 
            this.bit7.AutoSize = true;
            this.bit7.Location = new System.Drawing.Point(391, 130);
            this.bit7.Name = "bit7";
            this.bit7.Size = new System.Drawing.Size(15, 14);
            this.bit7.TabIndex = 11;
            this.bit7.UseVisualStyleBackColor = true;
            // 
            // bit7a
            // 
            this.bit7a.AutoSize = true;
            this.bit7a.Location = new System.Drawing.Point(391, 195);
            this.bit7a.Name = "bit7a";
            this.bit7a.Size = new System.Drawing.Size(15, 14);
            this.bit7a.TabIndex = 20;
            this.bit7a.UseVisualStyleBackColor = true;
            // 
            // bit6a
            // 
            this.bit6a.AutoSize = true;
            this.bit6a.Location = new System.Drawing.Point(412, 195);
            this.bit6a.Name = "bit6a";
            this.bit6a.Size = new System.Drawing.Size(15, 14);
            this.bit6a.TabIndex = 19;
            this.bit6a.UseVisualStyleBackColor = true;
            // 
            // bit5a
            // 
            this.bit5a.AutoSize = true;
            this.bit5a.Location = new System.Drawing.Point(433, 195);
            this.bit5a.Name = "bit5a";
            this.bit5a.Size = new System.Drawing.Size(15, 14);
            this.bit5a.TabIndex = 18;
            this.bit5a.UseVisualStyleBackColor = true;
            // 
            // bit4a
            // 
            this.bit4a.AutoSize = true;
            this.bit4a.Location = new System.Drawing.Point(454, 195);
            this.bit4a.Name = "bit4a";
            this.bit4a.Size = new System.Drawing.Size(15, 14);
            this.bit4a.TabIndex = 17;
            this.bit4a.UseVisualStyleBackColor = true;
            // 
            // bit3a
            // 
            this.bit3a.AutoSize = true;
            this.bit3a.Location = new System.Drawing.Point(475, 195);
            this.bit3a.Name = "bit3a";
            this.bit3a.Size = new System.Drawing.Size(15, 14);
            this.bit3a.TabIndex = 16;
            this.bit3a.UseVisualStyleBackColor = true;
            // 
            // bit2a
            // 
            this.bit2a.AutoSize = true;
            this.bit2a.Location = new System.Drawing.Point(496, 195);
            this.bit2a.Name = "bit2a";
            this.bit2a.Size = new System.Drawing.Size(15, 14);
            this.bit2a.TabIndex = 15;
            this.bit2a.UseVisualStyleBackColor = true;
            // 
            // bit1a
            // 
            this.bit1a.AutoSize = true;
            this.bit1a.Location = new System.Drawing.Point(517, 195);
            this.bit1a.Name = "bit1a";
            this.bit1a.Size = new System.Drawing.Size(15, 14);
            this.bit1a.TabIndex = 14;
            this.bit1a.UseVisualStyleBackColor = true;
            // 
            // bit0a
            // 
            this.bit0a.AutoSize = true;
            this.bit0a.Location = new System.Drawing.Point(538, 195);
            this.bit0a.Name = "bit0a";
            this.bit0a.Size = new System.Drawing.Size(15, 14);
            this.bit0a.TabIndex = 13;
            this.bit0a.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "7     6     5     4     3     2     1     0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "  128  64   32   16    8     4     2     1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "  128  64   32   16    8     4     2     1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 27);
            this.button1.TabIndex = 23;
            this.button1.Text = "Execute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // wyniktext
            // 
            this.wyniktext.Location = new System.Drawing.Point(384, 297);
            this.wyniktext.Name = "wyniktext";
            this.wyniktext.ReadOnly = true;
            this.wyniktext.Size = new System.Drawing.Size(171, 20);
            this.wyniktext.TabIndex = 24;
            this.wyniktext.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // wynikbittext
            // 
            this.wynikbittext.Location = new System.Drawing.Point(384, 323);
            this.wynikbittext.Name = "wynikbittext";
            this.wynikbittext.ReadOnly = true;
            this.wynikbittext.Size = new System.Drawing.Size(171, 20);
            this.wynikbittext.TabIndex = 25;
            this.wynikbittext.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(530, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Damian TOMASIK";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(310, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Info";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Argument 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Argument 2";
            // 
            // inputStyle
            // 
            this.inputStyle.AutoSize = true;
            this.inputStyle.Location = new System.Drawing.Point(409, 78);
            this.inputStyle.Name = "inputStyle";
            this.inputStyle.Size = new System.Drawing.Size(76, 17);
            this.inputStyle.TabIndex = 30;
            this.inputStyle.Text = "Input Style";
            this.inputStyle.UseVisualStyleBackColor = true;
            this.inputStyle.CheckedChanged += new System.EventHandler(this.inputStyle_CheckedChanged);
            // 
            // textArgument1
            // 
            this.textArgument1.Enabled = false;
            this.textArgument1.Location = new System.Drawing.Point(382, 127);
            this.textArgument1.Name = "textArgument1";
            this.textArgument1.Size = new System.Drawing.Size(171, 20);
            this.textArgument1.TabIndex = 31;
            this.textArgument1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textArgument1.Visible = false;
            this.textArgument1.TextChanged += new System.EventHandler(this.textArgument1_TextChanged);
            // 
            // textArgument2
            // 
            this.textArgument2.Enabled = false;
            this.textArgument2.Location = new System.Drawing.Point(384, 192);
            this.textArgument2.Name = "textArgument2";
            this.textArgument2.Size = new System.Drawing.Size(171, 20);
            this.textArgument2.TabIndex = 32;
            this.textArgument2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textArgument2.Visible = false;
            this.textArgument2.TextChanged += new System.EventHandler(this.textArgument2_TextChanged);
            // 
            // textBit1
            // 
            this.textBit1.Enabled = false;
            this.textBit1.Location = new System.Drawing.Point(382, 147);
            this.textBit1.Name = "textBit1";
            this.textBit1.ReadOnly = true;
            this.textBit1.Size = new System.Drawing.Size(171, 20);
            this.textBit1.TabIndex = 33;
            this.textBit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBit1.Visible = false;
            // 
            // textBit2
            // 
            this.textBit2.Enabled = false;
            this.textBit2.Location = new System.Drawing.Point(384, 211);
            this.textBit2.Name = "textBit2";
            this.textBit2.ReadOnly = true;
            this.textBit2.Size = new System.Drawing.Size(171, 20);
            this.textBit2.TabIndex = 34;
            this.textBit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBit2.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 361);
            this.Controls.Add(this.textBit2);
            this.Controls.Add(this.textBit1);
            this.Controls.Add(this.textArgument2);
            this.Controls.Add(this.textArgument1);
            this.Controls.Add(this.inputStyle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.wynikbittext);
            this.Controls.Add(this.wyniktext);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bit7a);
            this.Controls.Add(this.bit6a);
            this.Controls.Add(this.bit5a);
            this.Controls.Add(this.bit4a);
            this.Controls.Add(this.bit3a);
            this.Controls.Add(this.bit2a);
            this.Controls.Add(this.bit1a);
            this.Controls.Add(this.bit0a);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bit7);
            this.Controls.Add(this.bit6);
            this.Controls.Add(this.bit5);
            this.Controls.Add(this.bit4);
            this.Controls.Add(this.bit3);
            this.Controls.Add(this.bit2);
            this.Controls.Add(this.bit1);
            this.Controls.Add(this.bit0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Descpription);
            this.Controls.Add(this.assemblyTreeView);
            this.Controls.Add(this.topMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(640, 400);
            this.MinimumSize = new System.Drawing.Size(640, 400);
            this.Name = "MainForm";
            this.Text = "Reflector";
            this.topMenuStrip.ResumeLayout(false);
            this.topMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip topMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openFileStripItem;
        private System.Windows.Forms.TreeView assemblyTreeView;
        private System.Windows.Forms.TextBox Descpription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox bit0;
        private System.Windows.Forms.CheckBox bit1;
        private System.Windows.Forms.CheckBox bit2;
        private System.Windows.Forms.CheckBox bit3;
        private System.Windows.Forms.CheckBox bit4;
        private System.Windows.Forms.CheckBox bit5;
        private System.Windows.Forms.CheckBox bit6;
        private System.Windows.Forms.CheckBox bit7;
        private System.Windows.Forms.CheckBox bit7a;
        private System.Windows.Forms.CheckBox bit6a;
        private System.Windows.Forms.CheckBox bit5a;
        private System.Windows.Forms.CheckBox bit4a;
        private System.Windows.Forms.CheckBox bit3a;
        private System.Windows.Forms.CheckBox bit2a;
        private System.Windows.Forms.CheckBox bit1a;
        private System.Windows.Forms.CheckBox bit0a;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox wyniktext;
        private System.Windows.Forms.TextBox wynikbittext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox inputStyle;
        private System.Windows.Forms.TextBox textArgument1;
        private System.Windows.Forms.TextBox textArgument2;
        private System.Windows.Forms.TextBox textBit1;
        private System.Windows.Forms.TextBox textBit2;
    }
}

