
namespace Carro
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.botonuno = new System.Windows.Forms.Button();
            this.Estado = new System.Windows.Forms.Label();
            this.buttonEncender = new System.Windows.Forms.Button();
            this.buttonAcelerar = new System.Windows.Forms.Button();
            this.labelEstadoVelocidad = new System.Windows.Forms.Label();
            this.buttonBMW = new System.Windows.Forms.Button();
            this.bouttonAltoTotal = new System.Windows.Forms.Button();
            this.Reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.lstCanciones = new System.Windows.Forms.ListBox();
            this.btnAdjuntar = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdjuntar)).BeginInit();
            this.SuspendLayout();
            // 
            // botonuno
            // 
            this.botonuno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonuno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.botonuno.FlatAppearance.BorderSize = 10;
            this.botonuno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonuno.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonuno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botonuno.Location = new System.Drawing.Point(55, 25);
            this.botonuno.Name = "botonuno";
            this.botonuno.Size = new System.Drawing.Size(130, 50);
            this.botonuno.TabIndex = 0;
            this.botonuno.Text = "Crear carro ";
            this.botonuno.UseVisualStyleBackColor = false;
            this.botonuno.Click += new System.EventHandler(this.botonuno_Click);
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.ForeColor = System.Drawing.Color.Red;
            this.Estado.Location = new System.Drawing.Point(239, 111);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(35, 13);
            this.Estado.TabIndex = 1;
            this.Estado.Text = "label1";
            // 
            // buttonEncender
            // 
            this.buttonEncender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonEncender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEncender.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEncender.ForeColor = System.Drawing.Color.White;
            this.buttonEncender.Location = new System.Drawing.Point(55, 92);
            this.buttonEncender.Name = "buttonEncender";
            this.buttonEncender.Size = new System.Drawing.Size(130, 50);
            this.buttonEncender.TabIndex = 2;
            this.buttonEncender.Text = "Encender el carro";
            this.buttonEncender.UseVisualStyleBackColor = false;
            this.buttonEncender.Click += new System.EventHandler(this.buttonEncender_Click);
            // 
            // buttonAcelerar
            // 
            this.buttonAcelerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonAcelerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAcelerar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcelerar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAcelerar.Location = new System.Drawing.Point(55, 155);
            this.buttonAcelerar.Name = "buttonAcelerar";
            this.buttonAcelerar.Size = new System.Drawing.Size(130, 51);
            this.buttonAcelerar.TabIndex = 3;
            this.buttonAcelerar.Text = "Acelerar";
            this.buttonAcelerar.UseVisualStyleBackColor = false;
            this.buttonAcelerar.Click += new System.EventHandler(this.buttonAcelerar_Click);
            // 
            // labelEstadoVelocidad
            // 
            this.labelEstadoVelocidad.AutoSize = true;
            this.labelEstadoVelocidad.ForeColor = System.Drawing.Color.Red;
            this.labelEstadoVelocidad.Location = new System.Drawing.Point(239, 174);
            this.labelEstadoVelocidad.Name = "labelEstadoVelocidad";
            this.labelEstadoVelocidad.Size = new System.Drawing.Size(35, 13);
            this.labelEstadoVelocidad.TabIndex = 4;
            this.labelEstadoVelocidad.Text = "label1";
            this.labelEstadoVelocidad.Click += new System.EventHandler(this.labelEstadoVelocidad_Click);
            // 
            // buttonBMW
            // 
            this.buttonBMW.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonBMW.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBMW.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBMW.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBMW.Location = new System.Drawing.Point(285, 25);
            this.buttonBMW.Name = "buttonBMW";
            this.buttonBMW.Size = new System.Drawing.Size(131, 49);
            this.buttonBMW.TabIndex = 5;
            this.buttonBMW.Text = "BMW";
            this.buttonBMW.UseVisualStyleBackColor = false;
            this.buttonBMW.Click += new System.EventHandler(this.buttonBMW_Click);
            // 
            // bouttonAltoTotal
            // 
            this.bouttonAltoTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bouttonAltoTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bouttonAltoTotal.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bouttonAltoTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bouttonAltoTotal.Location = new System.Drawing.Point(55, 292);
            this.bouttonAltoTotal.Name = "bouttonAltoTotal";
            this.bouttonAltoTotal.Size = new System.Drawing.Size(130, 52);
            this.bouttonAltoTotal.TabIndex = 6;
            this.bouttonAltoTotal.Text = "AltoTotal";
            this.bouttonAltoTotal.UseVisualStyleBackColor = false;
            this.bouttonAltoTotal.Click += new System.EventHandler(this.bouttonAltoTotal_Click);
            // 
            // Reproductor
            // 
            this.Reproductor.Enabled = true;
            this.Reproductor.Location = new System.Drawing.Point(542, 12);
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor.OcxState")));
            this.Reproductor.Size = new System.Drawing.Size(246, 222);
            this.Reproductor.TabIndex = 7;
            // 
            // lstCanciones
            // 
            this.lstCanciones.FormattingEnabled = true;
            this.lstCanciones.Location = new System.Drawing.Point(493, 304);
            this.lstCanciones.Name = "lstCanciones";
            this.lstCanciones.Size = new System.Drawing.Size(295, 134);
            this.lstCanciones.TabIndex = 8;
            this.lstCanciones.SelectedIndexChanged += new System.EventHandler(this.lstCanciones_SelectedIndexChanged);
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdjuntar.Image = global::Carro.Properties.Resources._342_3427273_png_file_svg_imagen_del_signo_mas;
            this.btnAdjuntar.Location = new System.Drawing.Point(603, 244);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(88, 54);
            this.btnAdjuntar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdjuntar.TabIndex = 9;
            this.btnAdjuntar.TabStop = false;
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(55, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 53);
            this.button1.TabIndex = 10;
            this.button1.Text = "Frenar Despacio ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdjuntar);
            this.Controls.Add(this.lstCanciones);
            this.Controls.Add(this.Reproductor);
            this.Controls.Add(this.bouttonAltoTotal);
            this.Controls.Add(this.buttonBMW);
            this.Controls.Add(this.labelEstadoVelocidad);
            this.Controls.Add(this.buttonAcelerar);
            this.Controls.Add(this.buttonEncender);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.botonuno);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdjuntar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonuno;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.Button buttonEncender;
        private System.Windows.Forms.Button buttonAcelerar;
        private System.Windows.Forms.Label labelEstadoVelocidad;
        private System.Windows.Forms.Button buttonBMW;
        private System.Windows.Forms.Button bouttonAltoTotal;
        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
        private System.Windows.Forms.ListBox lstCanciones;
        private System.Windows.Forms.PictureBox btnAdjuntar;
        private System.Windows.Forms.Button button1;
    }
}

