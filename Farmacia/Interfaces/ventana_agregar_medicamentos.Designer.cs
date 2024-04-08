namespace Farmacia.Interfaces
{
    partial class ventana_agregar_medicamentos
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
            this.SuspendLayout();
            // 
            // ventana_agregar_medicamentos
            // 
            this.ClientSize = new System.Drawing.Size(596, 392);
            this.Name = "ventana_agregar_medicamentos";
            this.Load += new System.EventHandler(this.ventana_agregar_medicamentos_Load_1);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button bt_calcular_venta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.RichTextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown txt_cantidad_agregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_salir;
    }
}