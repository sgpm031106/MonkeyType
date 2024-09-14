namespace MonkeyTypeApp
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(399, 30);
            label1.Name = "label1";
            label1.Size = new Size(369, 69);
            label1.TabIndex = 0;
            label1.Text = "MonkeyType";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(475, 108);
            label2.Name = "label2";
            label2.Size = new Size(211, 35);
            label2.TabIndex = 1;
            label2.Text = "Show your best";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 151);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 2;
            // 
            // iconButton1
            // 
            iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            iconButton1.Font = new Font("Lucida Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Keyboard;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 120;
            iconButton1.Location = new Point(499, 367);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(170, 116);
            iconButton1.TabIndex = 4;
            iconButton1.Text = "Start";
            iconButton1.TextAlign = ContentAlignment.BottomCenter;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(908, 478);
            label5.Name = "label5";
            label5.Size = new Size(97, 41);
            label5.TabIndex = 6;
            label5.Text = "Score";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(143, 478);
            label4.Name = "label4";
            label4.Size = new Size(87, 41);
            label4.TabIndex = 7;
            label4.Text = "Time";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.MediumSlateBlue;
            richTextBox1.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(12, 237);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1153, 104);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // iconButton2
            // 
            iconButton2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 55;
            iconButton2.Location = new Point(1057, 21);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(94, 87);
            iconButton2.TabIndex = 9;
            iconButton2.Text = "Exit";
            iconButton2.TextAlign = ContentAlignment.BottomCenter;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSpringGreen;
            ClientSize = new Size(1177, 648);
            Controls.Add(iconButton2);
            Controls.Add(richTextBox1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(iconButton1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "MonkeyType App";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label5;
        private System.Windows.Forms.Timer timer1;
        private Label label4;
        private RichTextBox richTextBox1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}
