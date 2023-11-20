namespace WindowsFormsApp1
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
            this.tituloTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.aceptarbutton = new System.Windows.Forms.Button();
            this.autorTextbox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.portadaTextbox = new System.Windows.Forms.TextBox();
            this.buscarButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.audiotextBox = new System.Windows.Forms.TextBox();
            this.audiobutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Título ";
            // 
            // tituloTextbox
            // 
            this.tituloTextbox.Location = new System.Drawing.Point(83, 31);
            this.tituloTextbox.Name = "tituloTextbox";
            this.tituloTextbox.Size = new System.Drawing.Size(252, 20);
            this.tituloTextbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Autor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Género";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "BPM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Key";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Portada";
            // 
            // aceptarbutton
            // 
            this.aceptarbutton.Location = new System.Drawing.Point(118, 375);
            this.aceptarbutton.Name = "aceptarbutton";
            this.aceptarbutton.Size = new System.Drawing.Size(148, 35);
            this.aceptarbutton.TabIndex = 9;
            this.aceptarbutton.Text = "Aceptar";
            this.aceptarbutton.UseVisualStyleBackColor = true;
            this.aceptarbutton.Click += new System.EventHandler(this.aceptarbutton_Click);
            // 
            // autorTextbox
            // 
            this.autorTextbox.Location = new System.Drawing.Point(83, 71);
            this.autorTextbox.Name = "autorTextbox";
            this.autorTextbox.Size = new System.Drawing.Size(252, 20);
            this.autorTextbox.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(83, 116);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(252, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pop",
            "Rock",
            "Jazz",
            "Blues",
            "Hip Hop",
            "Reggae",
            "R&B (Rhythm and Blues)",
            "Country",
            "Folk",
            "Electronic",
            "Classical",
            "Latin",
            "Indie",
            "Metal",
            "Punk",
            "Funk",
            "Soul",
            "Gospel",
            "Ska",
            "Dubstep",
            "Techno",
            "House",
            "Trance",
            "Ambient",
            "Reggaeton",
            "Alternative",
            "Grunge",
            "Disco",
            "Rap",
            "Dancehall",
            "Salsa",
            "Merengue",
            "Cumbia",
            "Flamenco",
            "Tango",
            "Bluegrass",
            "Psychedelic",
            "New Wave",
            "Hard Rock",
            "Trap",
            "Samba",
            "J-pop (Pop japonés)",
            "K-pop (Pop coreano)",
            "Bollywood",
            "Afrobeat",
            "Zydeco",
            "Bossa Nova",
            "Mariachi",
            "Irish Folk",
            "Hardstyle"});
            this.comboBox1.Location = new System.Drawing.Point(83, 159);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(83, 204);
            this.maskedTextBox1.Mask = "99999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PromptChar = ' ';
            this.maskedTextBox1.Size = new System.Drawing.Size(38, 20);
            this.maskedTextBox1.TabIndex = 14;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Fa Mayor",
            "Re menor",
            "Sol Mayor",
            "Mi menor",
            "La Mayor",
            "Fa# menor",
            "Si♭ Mayor",
            "Sol menor",
            "Mi♭ Mayor",
            "Do menor",
            "Re Mayor",
            "Si menor",
            "Do Mayor",
            "La menor",
            "Si Mayor",
            "Sol# menor",
            "Fa# Mayor",
            "Re# menor",
            "Mi Mayor",
            "Do# menor",
            "Si♭ Mayor",
            "Sol menor",
            "La♭ Mayor",
            "Fa menor"});
            this.comboBox2.Location = new System.Drawing.Point(83, 246);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(252, 21);
            this.comboBox2.TabIndex = 15;
            // 
            // portadaTextbox
            // 
            this.portadaTextbox.Location = new System.Drawing.Point(93, 288);
            this.portadaTextbox.Name = "portadaTextbox";
            this.portadaTextbox.Size = new System.Drawing.Size(201, 20);
            this.portadaTextbox.TabIndex = 16;
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(300, 288);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(62, 20);
            this.buscarButton.TabIndex = 17;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Audio";
            // 
            // audiotextBox
            // 
            this.audiotextBox.Location = new System.Drawing.Point(93, 339);
            this.audiotextBox.Name = "audiotextBox";
            this.audiotextBox.Size = new System.Drawing.Size(201, 20);
            this.audiotextBox.TabIndex = 19;
            // 
            // audiobutton
            // 
            this.audiobutton.Location = new System.Drawing.Point(300, 340);
            this.audiobutton.Name = "audiobutton";
            this.audiobutton.Size = new System.Drawing.Size(62, 20);
            this.audiobutton.TabIndex = 20;
            this.audiobutton.Text = "Buscar";
            this.audiobutton.UseVisualStyleBackColor = true;
            this.audiobutton.Click += new System.EventHandler(this.audiobutton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(374, 450);
            this.Controls.Add(this.audiobutton);
            this.Controls.Add(this.audiotextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.portadaTextbox);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.autorTextbox);
            this.Controls.Add(this.aceptarbutton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tituloTextbox);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tituloTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button aceptarbutton;
        private System.Windows.Forms.TextBox autorTextbox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox portadaTextbox;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox audiotextBox;
        private System.Windows.Forms.Button audiobutton;
    }
}