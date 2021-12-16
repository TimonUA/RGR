
namespace RGR
{
    partial class Form1
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
            this.grafWind = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Cmax = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.Xcmax = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grafWind)).BeginInit();
            this.SuspendLayout();
            // 
            // grafWind
            // 
            this.grafWind.BackColor = System.Drawing.Color.White;
            this.grafWind.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grafWind.Location = new System.Drawing.Point(206, 77);
            this.grafWind.Name = "grafWind";
            this.grafWind.Size = new System.Drawing.Size(614, 331);
            this.grafWind.TabIndex = 0;
            this.grafWind.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox1.Location = new System.Drawing.Point(24, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 33);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cmax
            // 
            this.Cmax.Location = new System.Drawing.Point(206, 414);
            this.Cmax.Name = "Cmax";
            this.Cmax.ReadOnly = true;
            this.Cmax.Size = new System.Drawing.Size(127, 31);
            this.Cmax.TabIndex = 3;
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(339, 414);
            this.b.Name = "b";
            this.b.ReadOnly = true;
            this.b.Size = new System.Drawing.Size(123, 31);
            this.b.TabIndex = 4;
            // 
            // Xcmax
            // 
            this.Xcmax.Location = new System.Drawing.Point(468, 414);
            this.Xcmax.Name = "Xcmax";
            this.Xcmax.ReadOnly = true;
            this.Xcmax.Size = new System.Drawing.Size(122, 31);
            this.Xcmax.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 470);
            this.Controls.Add(this.Xcmax);
            this.Controls.Add(this.b);
            this.Controls.Add(this.Cmax);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.grafWind);
            this.Name = "Form1";
            this.Text = "penDrawing";
            ((System.ComponentModel.ISupportInitialize)(this.grafWind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox grafWind;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Cmax;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.TextBox Xcmax;
    }
}

