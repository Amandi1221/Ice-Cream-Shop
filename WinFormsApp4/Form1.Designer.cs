namespace WinFormsApp4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            labValue = new Label();
            typeIcecream = new ListBox();
            typeCake = new ListBox();
            chkDrinks = new CheckedListBox();
            textBox1 = new TextBox();
            txtValue = new TextBox();
            rdoMS = new RadioButton();
            rdoMS2 = new RadioButton();
            rdoMS3 = new RadioButton();
            rdoMS4 = new RadioButton();
            rdoMS5 = new RadioButton();
            rdoMS6 = new RadioButton();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(731, 667);
            button1.Name = "button1";
            button1.Size = new Size(232, 44);
            button1.TabIndex = 0;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(491, 154);
            button2.Name = "button2";
            button2.Size = new Size(8, 8);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 128);
            label1.Font = new Font("Monotype Corsiva", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(256, -2);
            label1.Name = "label1";
            label1.Size = new Size(572, 72);
            label1.TabIndex = 2;
            label1.Text = "AMA CREAM HOUSE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Lime;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 137);
            label2.Name = "label2";
            label2.Size = new Size(147, 25);
            label2.TabIndex = 3;
            label2.Text = "ICE CREAM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Lime;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(333, 144);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 4;
            label3.Text = "CAKE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Lime;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(184, 350);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 5;
            label4.Text = "DRINKS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Lime;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(800, 144);
            label5.Name = "label5";
            label5.Size = new Size(163, 25);
            label5.TabIndex = 6;
            label5.Text = "MILK SHAKE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 224, 192);
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(358, 560);
            label6.Name = "label6";
            label6.Size = new Size(100, 25);
            label6.TabIndex = 7;
            label6.Text = "Quantity";
            // 
            // labValue
            // 
            labValue.AutoSize = true;
            labValue.BackColor = Color.FromArgb(255, 224, 192);
            labValue.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labValue.Location = new Point(369, 615);
            labValue.Name = "labValue";
            labValue.Size = new Size(67, 25);
            labValue.TabIndex = 8;
            labValue.Text = "Value";
            // 
            // typeIcecream
            // 
            typeIcecream.BackColor = Color.FromArgb(255, 192, 128);
            typeIcecream.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            typeIcecream.FormattingEnabled = true;
            typeIcecream.ItemHeight = 26;
            typeIcecream.Items.AddRange(new object[] { "VANILA", "CHOCOLATE", "FRUIT & NUT", "STAWBERRY", "MANGO", "WOODAPPLE" });
            typeIcecream.Location = new Point(15, 185);
            typeIcecream.Name = "typeIcecream";
            typeIcecream.Size = new Size(193, 108);
            typeIcecream.TabIndex = 9;
            // 
            // typeCake
            // 
            typeCake.BackColor = Color.FromArgb(255, 192, 128);
            typeCake.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            typeCake.FormattingEnabled = true;
            typeCake.ItemHeight = 26;
            typeCake.Items.AddRange(new object[] { "BUTTER", "CHOCOLATE", "RIBBON", "BANANA CAKE", "CUPCAKES" });
            typeCake.Location = new Point(268, 185);
            typeCake.Name = "typeCake";
            typeCake.Size = new Size(201, 108);
            typeCake.TabIndex = 10;
            // 
            // chkDrinks
            // 
            chkDrinks.BackColor = Color.FromArgb(255, 192, 128);
            chkDrinks.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkDrinks.FormattingEnabled = true;
            chkDrinks.Items.AddRange(new object[] { "ORANGE", "LEMON", "AVACADO", "WATER MELON", "PAPAYA", "SMOOTHIE" });
            chkDrinks.Location = new Point(112, 399);
            chkDrinks.Name = "chkDrinks";
            chkDrinks.Size = new Size(233, 120);
            chkDrinks.TabIndex = 11;
            chkDrinks.SelectedIndexChanged += chkDrinks_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(476, 558);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 12;
            // 
            // txtValue
            // 
            txtValue.Location = new Point(476, 615);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(125, 27);
            txtValue.TabIndex = 13;
            // 
            // rdoMS
            // 
            rdoMS.AutoSize = true;
            rdoMS.BackColor = Color.FromArgb(255, 192, 128);
            rdoMS.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoMS.Location = new Point(779, 203);
            rdoMS.Name = "rdoMS";
            rdoMS.Size = new Size(115, 30);
            rdoMS.TabIndex = 14;
            rdoMS.TabStop = true;
            rdoMS.Text = "VANILA";
            rdoMS.UseVisualStyleBackColor = false;
            // 
            // rdoMS2
            // 
            rdoMS2.AutoSize = true;
            rdoMS2.BackColor = Color.FromArgb(255, 192, 128);
            rdoMS2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoMS2.Location = new Point(848, 263);
            rdoMS2.Name = "rdoMS2";
            rdoMS2.Size = new Size(165, 30);
            rdoMS2.TabIndex = 15;
            rdoMS2.TabStop = true;
            rdoMS2.Text = "CHOCOLATE";
            rdoMS2.UseVisualStyleBackColor = false;
            // 
            // rdoMS3
            // 
            rdoMS3.AutoSize = true;
            rdoMS3.BackColor = Color.FromArgb(255, 192, 128);
            rdoMS3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoMS3.Location = new Point(779, 316);
            rdoMS3.Name = "rdoMS3";
            rdoMS3.Size = new Size(117, 30);
            rdoMS3.TabIndex = 16;
            rdoMS3.TabStop = true;
            rdoMS3.Text = "COFFEE";
            rdoMS3.UseVisualStyleBackColor = false;
            // 
            // rdoMS4
            // 
            rdoMS4.AutoSize = true;
            rdoMS4.BackColor = Color.FromArgb(255, 192, 128);
            rdoMS4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoMS4.Location = new Point(831, 379);
            rdoMS4.Name = "rdoMS4";
            rdoMS4.Size = new Size(182, 30);
            rdoMS4.TabIndex = 17;
            rdoMS4.TabStop = true;
            rdoMS4.Text = "STRAWBERRY";
            rdoMS4.UseVisualStyleBackColor = false;
            // 
            // rdoMS5
            // 
            rdoMS5.AutoSize = true;
            rdoMS5.BackColor = Color.FromArgb(255, 192, 128);
            rdoMS5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoMS5.Location = new Point(722, 426);
            rdoMS5.Name = "rdoMS5";
            rdoMS5.Size = new Size(207, 30);
            rdoMS5.TabIndex = 18;
            rdoMS5.TabStop = true;
            rdoMS5.Text = "BUTTERSCOTCH";
            rdoMS5.UseVisualStyleBackColor = false;
            // 
            // rdoMS6
            // 
            rdoMS6.AutoSize = true;
            rdoMS6.BackColor = Color.FromArgb(255, 192, 128);
            rdoMS6.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoMS6.Location = new Point(848, 489);
            rdoMS6.Name = "rdoMS6";
            rdoMS6.Size = new Size(90, 30);
            rdoMS6.TabIndex = 19;
            rdoMS6.TabStop = true;
            rdoMS6.Text = "MILO";
            rdoMS6.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1025, 736);
            Controls.Add(rdoMS6);
            Controls.Add(rdoMS5);
            Controls.Add(rdoMS4);
            Controls.Add(rdoMS3);
            Controls.Add(rdoMS2);
            Controls.Add(rdoMS);
            Controls.Add(txtValue);
            Controls.Add(textBox1);
            Controls.Add(chkDrinks);
            Controls.Add(typeCake);
            Controls.Add(typeIcecream);
            Controls.Add(labValue);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label labValue;
        private ListBox typeIcecream;
        private ListBox typeCake;
        private CheckedListBox chkDrinks;
        private TextBox textBox1;
        private TextBox txtValue;
        private RadioButton rdoMS;
        private RadioButton rdoMS2;
        private RadioButton rdoMS3;
        private RadioButton rdoMS4;
        private RadioButton rdoMS5;
        private RadioButton rdoMS6;
    }
}
