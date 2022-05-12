namespace Proyecto_Restaurante
{
    partial class menu_control
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
            this.btn_Registrar_Empleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Registrar_Empleado
            // 
            this.btn_Registrar_Empleado.Location = new System.Drawing.Point(400, 77);
            this.btn_Registrar_Empleado.Name = "btn_Registrar_Empleado";
            this.btn_Registrar_Empleado.Size = new System.Drawing.Size(387, 113);
            this.btn_Registrar_Empleado.TabIndex = 0;
            this.btn_Registrar_Empleado.Text = "Registrar Empleado";
            this.btn_Registrar_Empleado.UseVisualStyleBackColor = true;
            this.btn_Registrar_Empleado.Click += new System.EventHandler(this.btn_Registrar_Empleado_Click);
            // 
            // menu_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 686);
            this.Controls.Add(this.btn_Registrar_Empleado);
            this.Name = "menu_control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu_control";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Registrar_Empleado;
    }
}