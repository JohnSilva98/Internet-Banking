namespace SisBanco.Telas
{
    partial class TelaDeposito
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
            this.lblSelecione = new System.Windows.Forms.Label();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn50 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.btn200 = new System.Windows.Forms.Button();
            this.btnOther = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelecione
            // 
            this.lblSelecione.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecione.Location = new System.Drawing.Point(156, 31);
            this.lblSelecione.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblSelecione.Name = "lblSelecione";
            this.lblSelecione.Size = new System.Drawing.Size(463, 55);
            this.lblSelecione.TabIndex = 0;
            this.lblSelecione.Text = "Selecione o valor que deseja depositar\r\n";
            this.lblSelecione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn20
            // 
            this.btn20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn20.Location = new System.Drawing.Point(43, 129);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(84, 75);
            this.btn20.TabIndex = 1;
            this.btn20.Text = "R$ 20,00";
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.btn20_Click);
            // 
            // btn50
            // 
            this.btn50.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn50.Location = new System.Drawing.Point(161, 129);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(84, 75);
            this.btn50.TabIndex = 2;
            this.btn50.Text = "R$ 50,00";
            this.btn50.UseVisualStyleBackColor = true;
            // 
            // btn100
            // 
            this.btn100.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn100.Location = new System.Drawing.Point(283, 129);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(84, 75);
            this.btn100.TabIndex = 3;
            this.btn100.Text = "R$ 100,00";
            this.btn100.UseVisualStyleBackColor = true;
            // 
            // btn200
            // 
            this.btn200.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn200.Location = new System.Drawing.Point(410, 129);
            this.btn200.Name = "btn200";
            this.btn200.Size = new System.Drawing.Size(84, 75);
            this.btn200.TabIndex = 4;
            this.btn200.Text = "R$ 200,00";
            this.btn200.UseVisualStyleBackColor = true;
            // 
            // btnOther
            // 
            this.btnOther.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOther.Location = new System.Drawing.Point(571, 129);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(201, 75);
            this.btnOther.TabIndex = 5;
            this.btnOther.Text = "Outros valores";
            this.btnOther.UseVisualStyleBackColor = true;
            // 
            // TelaDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOther);
            this.Controls.Add(this.btn200);
            this.Controls.Add(this.btn100);
            this.Controls.Add(this.btn50);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.lblSelecione);
            this.Name = "TelaDeposito";
            this.Text = "TelaDeposito";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSelecione;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btn200;
        private System.Windows.Forms.Button btnOther;
    }
}