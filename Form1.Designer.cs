namespace TriviaPro
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboNivel = new System.Windows.Forms.ComboBox();
            this.btnResponder = new System.Windows.Forms.Button();
            this.lblPreguntasRestantes = new System.Windows.Forms.Label();
            this.progressTiempo = new System.Windows.Forms.ProgressBar();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.rbOpcion4 = new System.Windows.Forms.RadioButton();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.rbOpcion3 = new System.Windows.Forms.RadioButton();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.rbOpcion2 = new System.Windows.Forms.RadioButton();
            this.rbOpcion1 = new System.Windows.Forms.RadioButton();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.listHistorial = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(373, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Juego de Trivia";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.comboNivel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnResponder, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblPreguntasRestantes, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.progressTiempo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPuntaje, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboCategoria, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbOpcion4, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnIniciar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.rbOpcion3, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnReiniciar, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblPregunta, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.rbOpcion2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.rbOpcion1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblTiempo, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50328F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(457, 403);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // comboNivel
            // 
            this.comboNivel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboNivel.FormattingEnabled = true;
            this.comboNivel.Location = new System.Drawing.Point(3, 64);
            this.comboNivel.Name = "comboNivel";
            this.comboNivel.Size = new System.Drawing.Size(146, 21);
            this.comboNivel.TabIndex = 1;
            // 
            // btnResponder
            // 
            this.btnResponder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResponder.Location = new System.Drawing.Point(155, 365);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(146, 23);
            this.btnResponder.TabIndex = 8;
            this.btnResponder.Text = "Responder";
            this.btnResponder.UseVisualStyleBackColor = true;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
            // 
            // lblPreguntasRestantes
            // 
            this.lblPreguntasRestantes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPreguntasRestantes.AutoSize = true;
            this.lblPreguntasRestantes.Location = new System.Drawing.Point(307, 68);
            this.lblPreguntasRestantes.Name = "lblPreguntasRestantes";
            this.lblPreguntasRestantes.Size = new System.Drawing.Size(147, 13);
            this.lblPreguntasRestantes.TabIndex = 11;
            this.lblPreguntasRestantes.Text = "Preguntas: 15";
            // 
            // progressTiempo
            // 
            this.progressTiempo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressTiempo.Location = new System.Drawing.Point(155, 63);
            this.progressTiempo.Name = "progressTiempo";
            this.progressTiempo.Size = new System.Drawing.Size(146, 24);
            this.progressTiempo.TabIndex = 13;
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Location = new System.Drawing.Point(307, 18);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(147, 13);
            this.lblPuntaje.TabIndex = 10;
            this.lblPuntaje.Text = "Puntaje: 0";
            // 
            // comboCategoria
            // 
            this.comboCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(3, 14);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(146, 21);
            this.comboCategoria.TabIndex = 0;
            this.comboCategoria.SelectedIndexChanged += new System.EventHandler(this.comboCategoria_SelectedIndexChanged);
            // 
            // rbOpcion4
            // 
            this.rbOpcion4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbOpcion4.AutoSize = true;
            this.rbOpcion4.Location = new System.Drawing.Point(3, 370);
            this.rbOpcion4.Name = "rbOpcion4";
            this.rbOpcion4.Size = new System.Drawing.Size(146, 13);
            this.rbOpcion4.TabIndex = 6;
            this.rbOpcion4.TabStop = true;
            this.rbOpcion4.UseVisualStyleBackColor = true;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIniciar.Location = new System.Drawing.Point(3, 113);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(146, 23);
            this.btnIniciar.TabIndex = 7;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // rbOpcion3
            // 
            this.rbOpcion3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbOpcion3.AutoSize = true;
            this.rbOpcion3.Location = new System.Drawing.Point(3, 318);
            this.rbOpcion3.Name = "rbOpcion3";
            this.rbOpcion3.Size = new System.Drawing.Size(146, 13);
            this.rbOpcion3.TabIndex = 5;
            this.rbOpcion3.TabStop = true;
            this.rbOpcion3.UseVisualStyleBackColor = true;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReiniciar.Location = new System.Drawing.Point(307, 365);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(147, 23);
            this.btnReiniciar.TabIndex = 9;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // lblPregunta
            // 
            this.lblPregunta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(3, 168);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(146, 13);
            this.lblPregunta.TabIndex = 2;
            this.lblPregunta.Text = "Pregunta";
            // 
            // rbOpcion2
            // 
            this.rbOpcion2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbOpcion2.AutoSize = true;
            this.rbOpcion2.Location = new System.Drawing.Point(3, 268);
            this.rbOpcion2.Name = "rbOpcion2";
            this.rbOpcion2.Size = new System.Drawing.Size(146, 13);
            this.rbOpcion2.TabIndex = 4;
            this.rbOpcion2.TabStop = true;
            this.rbOpcion2.UseVisualStyleBackColor = true;
            // 
            // rbOpcion1
            // 
            this.rbOpcion1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbOpcion1.AutoSize = true;
            this.rbOpcion1.Location = new System.Drawing.Point(3, 218);
            this.rbOpcion1.Name = "rbOpcion1";
            this.rbOpcion1.Size = new System.Drawing.Size(146, 13);
            this.rbOpcion1.TabIndex = 3;
            this.rbOpcion1.TabStop = true;
            this.rbOpcion1.UseVisualStyleBackColor = true;
            // 
            // lblTiempo
            // 
            this.lblTiempo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(155, 18);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(146, 13);
            this.lblTiempo.TabIndex = 12;
            this.lblTiempo.Text = "Tiempo: 0s";
            // 
            // listHistorial
            // 
            this.listHistorial.FormattingEnabled = true;
            this.listHistorial.Location = new System.Drawing.Point(488, 25);
            this.listHistorial.Name = "listHistorial";
            this.listHistorial.Size = new System.Drawing.Size(300, 407);
            this.listHistorial.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.listHistorial);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboNivel;
        private System.Windows.Forms.Button btnResponder;
        private System.Windows.Forms.Label lblPreguntasRestantes;
        private System.Windows.Forms.ProgressBar progressTiempo;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.RadioButton rbOpcion4;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.RadioButton rbOpcion3;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.RadioButton rbOpcion2;
        private System.Windows.Forms.RadioButton rbOpcion1;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.ListBox listHistorial;
    }
}

