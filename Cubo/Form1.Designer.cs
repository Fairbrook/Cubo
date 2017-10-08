namespace Cubo
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
            this.acercar = new System.Windows.Forms.Button();
            this.alejar = new System.Windows.Forms.Button();
            this.btnRotateX = new System.Windows.Forms.Button();
            this.btnRotateY = new System.Windows.Forms.Button();
            this.btnRotateZ = new System.Windows.Forms.Button();
            this.btnAbajo = new System.Windows.Forms.Button();
            this.btnArriba = new System.Windows.Forms.Button();
            this.btnIzq = new System.Windows.Forms.Button();
            this.btnDer = new System.Windows.Forms.Button();
            this.lblRotateX = new System.Windows.Forms.Label();
            this.lblRotateY = new System.Windows.Forms.Label();
            this.lblRotateZ = new System.Windows.Forms.Label();
            this.lblZoom = new System.Windows.Forms.Label();
            this.btnFrente = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // acercar
            // 
            this.acercar.Location = new System.Drawing.Point(12, 529);
            this.acercar.Name = "acercar";
            this.acercar.Size = new System.Drawing.Size(23, 23);
            this.acercar.TabIndex = 0;
            this.acercar.TabStop = false;
            this.acercar.Text = "+";
            this.acercar.UseVisualStyleBackColor = true;
            this.acercar.Click += new System.EventHandler(this.acercar_Click);
            // 
            // alejar
            // 
            this.alejar.Location = new System.Drawing.Point(54, 529);
            this.alejar.Name = "alejar";
            this.alejar.Size = new System.Drawing.Size(22, 23);
            this.alejar.TabIndex = 1;
            this.alejar.Text = "-";
            this.alejar.UseVisualStyleBackColor = true;
            this.alejar.Click += new System.EventHandler(this.alejar_Click);
            // 
            // btnRotateX
            // 
            this.btnRotateX.Location = new System.Drawing.Point(120, 529);
            this.btnRotateX.Name = "btnRotateX";
            this.btnRotateX.Size = new System.Drawing.Size(53, 23);
            this.btnRotateX.TabIndex = 2;
            this.btnRotateX.Text = "Rotar X";
            this.btnRotateX.UseVisualStyleBackColor = true;
            this.btnRotateX.Click += new System.EventHandler(this.btnRotateX_Click);
            // 
            // btnRotateY
            // 
            this.btnRotateY.Location = new System.Drawing.Point(199, 529);
            this.btnRotateY.Name = "btnRotateY";
            this.btnRotateY.Size = new System.Drawing.Size(54, 23);
            this.btnRotateY.TabIndex = 3;
            this.btnRotateY.Text = "Rotar Y";
            this.btnRotateY.UseVisualStyleBackColor = true;
            this.btnRotateY.Click += new System.EventHandler(this.btnRotateY_Click);
            // 
            // btnRotateZ
            // 
            this.btnRotateZ.Location = new System.Drawing.Point(288, 529);
            this.btnRotateZ.Name = "btnRotateZ";
            this.btnRotateZ.Size = new System.Drawing.Size(51, 23);
            this.btnRotateZ.TabIndex = 4;
            this.btnRotateZ.Text = "Rotar Z";
            this.btnRotateZ.UseVisualStyleBackColor = true;
            this.btnRotateZ.Click += new System.EventHandler(this.btnRotateZ_Click);
            // 
            // btnAbajo
            // 
            this.btnAbajo.Location = new System.Drawing.Point(444, 539);
            this.btnAbajo.Name = "btnAbajo";
            this.btnAbajo.Size = new System.Drawing.Size(48, 23);
            this.btnAbajo.TabIndex = 5;
            this.btnAbajo.Text = "Abajo";
            this.btnAbajo.UseVisualStyleBackColor = true;
            this.btnAbajo.Click += new System.EventHandler(this.btnAbajo_Click);
            // 
            // btnArriba
            // 
            this.btnArriba.Location = new System.Drawing.Point(444, 480);
            this.btnArriba.Name = "btnArriba";
            this.btnArriba.Size = new System.Drawing.Size(48, 23);
            this.btnArriba.TabIndex = 6;
            this.btnArriba.Text = "Arriba";
            this.btnArriba.UseVisualStyleBackColor = true;
            this.btnArriba.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnIzq
            // 
            this.btnIzq.Location = new System.Drawing.Point(388, 509);
            this.btnIzq.Name = "btnIzq";
            this.btnIzq.Size = new System.Drawing.Size(58, 23);
            this.btnIzq.TabIndex = 7;
            this.btnIzq.Text = "Izquierda";
            this.btnIzq.UseVisualStyleBackColor = true;
            this.btnIzq.Click += new System.EventHandler(this.btnIzq_Click);
            // 
            // btnDer
            // 
            this.btnDer.Location = new System.Drawing.Point(491, 509);
            this.btnDer.Name = "btnDer";
            this.btnDer.Size = new System.Drawing.Size(59, 23);
            this.btnDer.TabIndex = 8;
            this.btnDer.Text = "Derecha";
            this.btnDer.UseVisualStyleBackColor = true;
            this.btnDer.Click += new System.EventHandler(this.btnDer_Click);
            // 
            // lblRotateX
            // 
            this.lblRotateX.AutoSize = true;
            this.lblRotateX.Location = new System.Drawing.Point(117, 559);
            this.lblRotateX.Name = "lblRotateX";
            this.lblRotateX.Size = new System.Drawing.Size(35, 13);
            this.lblRotateX.TabIndex = 9;
            this.lblRotateX.Text = "label1";
            // 
            // lblRotateY
            // 
            this.lblRotateY.AutoSize = true;
            this.lblRotateY.Location = new System.Drawing.Point(196, 559);
            this.lblRotateY.Name = "lblRotateY";
            this.lblRotateY.Size = new System.Drawing.Size(35, 13);
            this.lblRotateY.TabIndex = 10;
            this.lblRotateY.Text = "label1";
            // 
            // lblRotateZ
            // 
            this.lblRotateZ.AutoSize = true;
            this.lblRotateZ.Location = new System.Drawing.Point(285, 559);
            this.lblRotateZ.Name = "lblRotateZ";
            this.lblRotateZ.Size = new System.Drawing.Size(35, 13);
            this.lblRotateZ.TabIndex = 11;
            this.lblRotateZ.Text = "label1";
            // 
            // lblZoom
            // 
            this.lblZoom.AutoSize = true;
            this.lblZoom.Location = new System.Drawing.Point(12, 559);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(35, 13);
            this.lblZoom.TabIndex = 12;
            this.lblZoom.Text = "label1";
            // 
            // btnFrente
            // 
            this.btnFrente.Location = new System.Drawing.Point(594, 480);
            this.btnFrente.Name = "btnFrente";
            this.btnFrente.Size = new System.Drawing.Size(36, 23);
            this.btnFrente.TabIndex = 13;
            this.btnFrente.Text = "Z+";
            this.btnFrente.UseVisualStyleBackColor = true;
            this.btnFrente.Click += new System.EventHandler(this.btnFrente_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(594, 529);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(36, 23);
            this.btnAtras.TabIndex = 14;
            this.btnAtras.Text = "Z-";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 13);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 584);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnFrente);
            this.Controls.Add(this.lblZoom);
            this.Controls.Add(this.lblRotateZ);
            this.Controls.Add(this.lblRotateY);
            this.Controls.Add(this.lblRotateX);
            this.Controls.Add(this.btnDer);
            this.Controls.Add(this.btnIzq);
            this.Controls.Add(this.btnArriba);
            this.Controls.Add(this.btnAbajo);
            this.Controls.Add(this.btnRotateZ);
            this.Controls.Add(this.btnRotateY);
            this.Controls.Add(this.btnRotateX);
            this.Controls.Add(this.alejar);
            this.Controls.Add(this.acercar);
            this.Name = "Form1";
            this.Text = "Cubo";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button acercar;
        private System.Windows.Forms.Button alejar;
        private System.Windows.Forms.Button btnRotateX;
        private System.Windows.Forms.Button btnRotateY;
        private System.Windows.Forms.Button btnRotateZ;
        private System.Windows.Forms.Button btnAbajo;
        private System.Windows.Forms.Button btnArriba;
        private System.Windows.Forms.Button btnIzq;
        private System.Windows.Forms.Button btnDer;
        private System.Windows.Forms.Label lblRotateX;
        private System.Windows.Forms.Label lblRotateY;
        private System.Windows.Forms.Label lblRotateZ;
        private System.Windows.Forms.Label lblZoom;
        private System.Windows.Forms.Button btnFrente;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnReset;
    }
}

