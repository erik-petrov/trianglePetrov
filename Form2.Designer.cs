namespace trianglePetrov
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.aBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ravno = new System.Windows.Forms.RadioButton();
            this.razno = new System.Windows.Forms.RadioButton();
            this.twosides = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rightRadio = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(532, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "a";
            // 
            // aBox
            // 
            this.aBox.Location = new System.Drawing.Point(567, 17);
            this.aBox.Name = "aBox";
            this.aBox.Size = new System.Drawing.Size(196, 20);
            this.aBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "h";
            // 
            // hBox
            // 
            this.hBox.Location = new System.Drawing.Point(567, 43);
            this.hBox.Name = "hBox";
            this.hBox.Size = new System.Drawing.Size(196, 20);
            this.hBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Location = new System.Drawing.Point(13, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(775, 205);
            this.button1.TabIndex = 19;
            this.button1.Text = "Посчитать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Location = new System.Drawing.Point(14, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(229, 215);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Поле";
            this.columnHeader1.Width = 68;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Значение";
            this.columnHeader2.Width = 155;
            // 
            // ravno
            // 
            this.ravno.AutoSize = true;
            this.ravno.Location = new System.Drawing.Point(3, 13);
            this.ravno.Name = "ravno";
            this.ravno.Size = new System.Drawing.Size(109, 17);
            this.ravno.TabIndex = 21;
            this.ravno.TabStop = true;
            this.ravno.Text = "Равносторонний";
            this.ravno.UseVisualStyleBackColor = true;
            // 
            // razno
            // 
            this.razno.AutoSize = true;
            this.razno.Location = new System.Drawing.Point(3, 36);
            this.razno.Name = "razno";
            this.razno.Size = new System.Drawing.Size(109, 17);
            this.razno.TabIndex = 22;
            this.razno.TabStop = true;
            this.razno.Text = "Разносторонний";
            this.razno.UseVisualStyleBackColor = true;
            // 
            // twosides
            // 
            this.twosides.AutoSize = true;
            this.twosides.Location = new System.Drawing.Point(3, 59);
            this.twosides.Name = "twosides";
            this.twosides.Size = new System.Drawing.Size(112, 17);
            this.twosides.TabIndex = 23;
            this.twosides.TabStop = true;
            this.twosides.Text = "Равнобедренный";
            this.twosides.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.twosides);
            this.panel1.Controls.Add(this.ravno);
            this.panel1.Controls.Add(this.razno);
            this.panel1.Location = new System.Drawing.Point(535, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 84);
            this.panel1.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::trianglePetrov.Properties.Resources.triangle_height;
            this.pictureBox1.Location = new System.Drawing.Point(249, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // rightRadio
            // 
            this.rightRadio.AutoSize = true;
            this.rightRadio.Location = new System.Drawing.Point(535, 159);
            this.rightRadio.Name = "rightRadio";
            this.rightRadio.Size = new System.Drawing.Size(108, 17);
            this.rightRadio.TabIndex = 26;
            this.rightRadio.Text = "Прямоугольный";
            this.rightRadio.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rightRadio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hBox);
            this.Controls.Add(this.aBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.RadioButton ravno;
        private System.Windows.Forms.RadioButton razno;
        private System.Windows.Forms.RadioButton twosides;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox rightRadio;
    }
}