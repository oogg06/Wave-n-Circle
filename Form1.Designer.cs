namespace Ondas
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
            this.panelDibujo = new System.Windows.Forms.Panel();
            this.numAmplitud = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numGrados = new System.Windows.Forms.NumericUpDown();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRadianes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numNumCurvas = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numAmplitud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumCurvas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDibujo
            // 
            this.panelDibujo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelDibujo.Location = new System.Drawing.Point(13, 194);
            this.panelDibujo.Name = "panelDibujo";
            this.panelDibujo.Size = new System.Drawing.Size(771, 303);
            this.panelDibujo.TabIndex = 0;
            this.panelDibujo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDibujo_Paint);
            this.panelDibujo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDibujo_MouseDown);
            // 
            // numAmplitud
            // 
            this.numAmplitud.Location = new System.Drawing.Point(65, 56);
            this.numAmplitud.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numAmplitud.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numAmplitud.Name = "numAmplitud";
            this.numAmplitud.Size = new System.Drawing.Size(47, 20);
            this.numAmplitud.TabIndex = 1;
            this.numAmplitud.Tag = "Amplitud";
            this.numAmplitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numAmplitud.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numAmplitud.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Amplitud";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Grados";
            // 
            // numGrados
            // 
            this.numGrados.Location = new System.Drawing.Point(171, 56);
            this.numGrados.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numGrados.Name = "numGrados";
            this.numGrados.Size = new System.Drawing.Size(47, 20);
            this.numGrados.TabIndex = 3;
            this.numGrados.Tag = "Amplitud";
            this.numGrados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numGrados.ValueChanged += new System.EventHandler(this.numGrados_ValueChanged);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(65, 123);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(47, 20);
            this.txtX.TabIndex = 5;
            this.txtX.Tag = "Posicion X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Y:";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(141, 123);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(47, 20);
            this.txtY.TabIndex = 7;
            this.txtY.Tag = "Posicion X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Rads";
            // 
            // txtRadianes
            // 
            this.txtRadianes.Location = new System.Drawing.Point(235, 123);
            this.txtRadianes.Name = "txtRadianes";
            this.txtRadianes.Size = new System.Drawing.Size(47, 20);
            this.txtRadianes.TabIndex = 9;
            this.txtRadianes.Tag = "Posicion X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Curvas";
            // 
            // numNumCurvas
            // 
            this.numNumCurvas.Location = new System.Drawing.Point(294, 56);
            this.numNumCurvas.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numNumCurvas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNumCurvas.Name = "numNumCurvas";
            this.numNumCurvas.Size = new System.Drawing.Size(47, 20);
            this.numNumCurvas.TabIndex = 11;
            this.numNumCurvas.Tag = "Amplitud";
            this.numNumCurvas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numNumCurvas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNumCurvas.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 509);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numNumCurvas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRadianes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numGrados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numAmplitud);
            this.Controls.Add(this.panelDibujo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador de ondas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.numAmplitud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumCurvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDibujo;
        private System.Windows.Forms.NumericUpDown numAmplitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numGrados;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRadianes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numNumCurvas;
    }
}

