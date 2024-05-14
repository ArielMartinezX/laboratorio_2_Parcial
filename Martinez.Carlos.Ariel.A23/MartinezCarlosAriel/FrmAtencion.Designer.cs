namespace MartinezCarlosAriel
{
    partial class FrmAtencion
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
            lstMedicos = new ListBox();
            lstPacientes = new ListBox();
            btnAtender = new Button();
            btnSalir = new Button();
            rtbInfoMedico = new RichTextBox();
            lblMedicos = new Label();
            lblPacientes = new Label();
            SuspendLayout();
            // 
            // lstMedicos
            // 
            lstMedicos.FormattingEnabled = true;
            lstMedicos.ItemHeight = 15;
            lstMedicos.Location = new Point(12, 42);
            lstMedicos.Name = "lstMedicos";
            lstMedicos.Size = new Size(381, 379);
            lstMedicos.TabIndex = 0;
            lstMedicos.SelectedIndexChanged += lstMedicos_SelectedIndexChanged;
            // 
            // lstPacientes
            // 
            lstPacientes.FormattingEnabled = true;
            lstPacientes.ItemHeight = 15;
            lstPacientes.Location = new Point(424, 42);
            lstPacientes.Name = "lstPacientes";
            lstPacientes.Size = new Size(381, 379);
            lstPacientes.TabIndex = 1;
            // 
            // btnAtender
            // 
            btnAtender.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtender.Location = new Point(811, 42);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(156, 93);
            btnAtender.TabIndex = 2;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += btnAtender_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(811, 622);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(156, 93);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // rtbInfoMedico
            // 
            rtbInfoMedico.Location = new Point(15, 443);
            rtbInfoMedico.Name = "rtbInfoMedico";
            rtbInfoMedico.Size = new Size(790, 272);
            rtbInfoMedico.TabIndex = 4;
            rtbInfoMedico.Text = "";
            // 
            // lblMedicos
            // 
            lblMedicos.AutoSize = true;
            lblMedicos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMedicos.Location = new Point(12, 12);
            lblMedicos.Name = "lblMedicos";
            lblMedicos.Size = new Size(137, 21);
            lblMedicos.TabIndex = 5;
            lblMedicos.Text = "Personal Medico";
            // 
            // lblPacientes
            // 
            lblPacientes.AutoSize = true;
            lblPacientes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPacientes.Location = new Point(424, 12);
            lblPacientes.Name = "lblPacientes";
            lblPacientes.Size = new Size(83, 21);
            lblPacientes.TabIndex = 6;
            lblPacientes.Text = "Pacientes";
            // 
            // FrmAtencion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 727);
            Controls.Add(lblPacientes);
            Controls.Add(lblMedicos);
            Controls.Add(rtbInfoMedico);
            Controls.Add(btnSalir);
            Controls.Add(btnAtender);
            Controls.Add(lstPacientes);
            Controls.Add(lstMedicos);
            Name = "FrmAtencion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Martinez Carlos Ariel";
            FormClosing += FrmAtencion_FormClosing;
            Load += FrmAtencion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstMedicos;
        private ListBox lstPacientes;
        private Button btnAtender;
        private Button btnSalir;
        private RichTextBox rtbInfoMedico;
        private Label lblMedicos;
        private Label lblPacientes;
    }
}
