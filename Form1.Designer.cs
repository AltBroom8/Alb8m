namespace WindowsFormsApp1
{
    partial class altavoz
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(altavoz));
            this.guardaButton = new System.Windows.Forms.Button();
            this.cargarButton = new System.Windows.Forms.Button();
            this.milistBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.keydef = new System.Windows.Forms.Label();
            this.bpmdef = new System.Windows.Forms.Label();
            this.generodef = new System.Windows.Forms.Label();
            this.fechadef = new System.Windows.Forms.Label();
            this.autordef = new System.Windows.Forms.Label();
            this.titulodef = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.actualImagen = new System.Windows.Forms.PictureBox();
            this.nuevoButton = new System.Windows.Forms.Button();
            this.eliminarbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actualImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // guardaButton
            // 
            this.guardaButton.Location = new System.Drawing.Point(125, 417);
            this.guardaButton.Name = "guardaButton";
            this.guardaButton.Size = new System.Drawing.Size(183, 43);
            this.guardaButton.TabIndex = 0;
            this.guardaButton.Text = "GUARDA";
            this.guardaButton.UseVisualStyleBackColor = true;
            this.guardaButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // cargarButton
            // 
            this.cargarButton.Location = new System.Drawing.Point(314, 417);
            this.cargarButton.Name = "cargarButton";
            this.cargarButton.Size = new System.Drawing.Size(183, 43);
            this.cargarButton.TabIndex = 1;
            this.cargarButton.Text = "CARGA";
            this.cargarButton.UseVisualStyleBackColor = true;
            this.cargarButton.Click += new System.EventHandler(this.cargarButton_Click);
            // 
            // milistBox
            // 
            this.milistBox.FormattingEnabled = true;
            this.milistBox.Location = new System.Drawing.Point(786, 39);
            this.milistBox.Name = "milistBox";
            this.milistBox.Size = new System.Drawing.Size(213, 342);
            this.milistBox.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.keydef);
            this.panel1.Controls.Add(this.bpmdef);
            this.panel1.Controls.Add(this.generodef);
            this.panel1.Controls.Add(this.fechadef);
            this.panel1.Controls.Add(this.autordef);
            this.panel1.Controls.Add(this.titulodef);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(125, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 232);
            this.panel1.TabIndex = 3;
            // 
            // keydef
            // 
            this.keydef.AutoSize = true;
            this.keydef.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keydef.Location = new System.Drawing.Point(96, 179);
            this.keydef.Name = "keydef";
            this.keydef.Size = new System.Drawing.Size(0, 20);
            this.keydef.TabIndex = 11;
            // 
            // bpmdef
            // 
            this.bpmdef.AutoSize = true;
            this.bpmdef.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpmdef.Location = new System.Drawing.Point(96, 145);
            this.bpmdef.Name = "bpmdef";
            this.bpmdef.Size = new System.Drawing.Size(0, 20);
            this.bpmdef.TabIndex = 10;
            // 
            // generodef
            // 
            this.generodef.AutoSize = true;
            this.generodef.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generodef.Location = new System.Drawing.Point(96, 111);
            this.generodef.Name = "generodef";
            this.generodef.Size = new System.Drawing.Size(0, 20);
            this.generodef.TabIndex = 9;
            // 
            // fechadef
            // 
            this.fechadef.AutoSize = true;
            this.fechadef.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechadef.Location = new System.Drawing.Point(96, 79);
            this.fechadef.Name = "fechadef";
            this.fechadef.Size = new System.Drawing.Size(0, 20);
            this.fechadef.TabIndex = 8;
            // 
            // autordef
            // 
            this.autordef.AutoSize = true;
            this.autordef.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autordef.Location = new System.Drawing.Point(96, 46);
            this.autordef.Name = "autordef";
            this.autordef.Size = new System.Drawing.Size(0, 20);
            this.autordef.TabIndex = 7;
            // 
            // titulodef
            // 
            this.titulodef.AutoSize = true;
            this.titulodef.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulodef.Location = new System.Drawing.Point(96, 14);
            this.titulodef.Name = "titulodef";
            this.titulodef.Size = new System.Drawing.Size(0, 20);
            this.titulodef.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "BPM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Género";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título ";
           
            // 
            // actualImagen
            // 
            this.actualImagen.BackColor = System.Drawing.Color.Transparent;
            this.actualImagen.Location = new System.Drawing.Point(517, 39);
            this.actualImagen.Name = "actualImagen";
            this.actualImagen.Size = new System.Drawing.Size(232, 232);
            this.actualImagen.TabIndex = 4;
            this.actualImagen.TabStop = false;
            // 
            // nuevoButton
            // 
            this.nuevoButton.Location = new System.Drawing.Point(805, 417);
            this.nuevoButton.Name = "nuevoButton";
            this.nuevoButton.Size = new System.Drawing.Size(183, 43);
            this.nuevoButton.TabIndex = 5;
            this.nuevoButton.Text = "NUEVO";
            this.nuevoButton.UseVisualStyleBackColor = true;
            this.nuevoButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // eliminarbutton
            // 
            this.eliminarbutton.Location = new System.Drawing.Point(546, 417);
            this.eliminarbutton.Name = "eliminarbutton";
            this.eliminarbutton.Size = new System.Drawing.Size(183, 43);
            this.eliminarbutton.TabIndex = 6;
            this.eliminarbutton.Text = "ELIMINAR";
            this.eliminarbutton.UseVisualStyleBackColor = true;
            this.eliminarbutton.Click += new System.EventHandler(this.eliminarbutton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(125, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 76);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // altavoz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1049, 551);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eliminarbutton);
            this.Controls.Add(this.nuevoButton);
            this.Controls.Add(this.actualImagen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.milistBox);
            this.Controls.Add(this.cargarButton);
            this.Controls.Add(this.guardaButton);
            this.Name = "altavoz";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actualImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button guardaButton;
        private System.Windows.Forms.Button cargarButton;
        private System.Windows.Forms.ListBox milistBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox actualImagen;
        private System.Windows.Forms.Button nuevoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button eliminarbutton;
        private System.Windows.Forms.Label keydef;
        private System.Windows.Forms.Label bpmdef;
        private System.Windows.Forms.Label generodef;
        private System.Windows.Forms.Label fechadef;
        private System.Windows.Forms.Label autordef;
        private System.Windows.Forms.Label titulodef;
        private System.Windows.Forms.Button button1;
    }
}

