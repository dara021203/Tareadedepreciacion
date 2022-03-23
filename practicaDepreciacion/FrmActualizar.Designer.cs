
namespace practicaDepreciacion
{
    partial class FrmActualizar
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
            this.Id = new System.Windows.Forms.Label();
            this.nudVidaUtil = new System.Windows.Forms.NumericUpDown();
            this.nudValorResidual = new System.Windows.Forms.NumericUpDown();
            this.nudValor = new System.Windows.Forms.NumericUpDown();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudVidaUtil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorResidual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).BeginInit();
            this.SuspendLayout();
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(92, 26);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(0, 13);
            this.Id.TabIndex = 21;
            this.Id.Visible = false;
            // 
            // nudVidaUtil
            // 
            this.nudVidaUtil.Location = new System.Drawing.Point(234, 187);
            this.nudVidaUtil.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudVidaUtil.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudVidaUtil.Name = "nudVidaUtil";
            this.nudVidaUtil.Size = new System.Drawing.Size(149, 20);
            this.nudVidaUtil.TabIndex = 18;
            this.nudVidaUtil.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudValorResidual
            // 
            this.nudValorResidual.Location = new System.Drawing.Point(234, 142);
            this.nudValorResidual.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudValorResidual.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudValorResidual.Name = "nudValorResidual";
            this.nudValorResidual.Size = new System.Drawing.Size(149, 20);
            this.nudValorResidual.TabIndex = 17;
            this.nudValorResidual.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudValor
            // 
            this.nudValor.Location = new System.Drawing.Point(234, 98);
            this.nudValor.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudValor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudValor.Name = "nudValor";
            this.nudValor.Size = new System.Drawing.Size(149, 20);
            this.nudValor.TabIndex = 16;
            this.nudValor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudValor.ValueChanged += new System.EventHandler(this.nudValor_ValueChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(234, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(149, 20);
            this.txtNombre.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(51, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Vida util:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(51, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Valor residual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(51, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Valor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(51, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre:";
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Location = new System.Drawing.Point(146, 239);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(136, 46);
            this.btnModificar.TabIndex = 22;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // FrmActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(476, 343);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.nudVidaUtil);
            this.Controls.Add(this.nudValorResidual);
            this.Controls.Add(this.nudValor);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmActualizar";
            this.Text = "FrmActualizar";
            ((System.ComponentModel.ISupportInitialize)(this.nudVidaUtil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorResidual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Id;
        public System.Windows.Forms.NumericUpDown nudVidaUtil;
        public System.Windows.Forms.NumericUpDown nudValorResidual;
        public System.Windows.Forms.NumericUpDown nudValor;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificar;
    }
}