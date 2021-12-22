
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
            this.pointSwitch = new System.Windows.Forms.ComboBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.yTopTextBox = new System.Windows.Forms.TextBox();
            this.yButtomTexBox = new System.Windows.Forms.TextBox();
            this.pointTextBox = new System.Windows.Forms.TextBox();
            this.xValue = new System.Windows.Forms.TextBox();
            this.yTopValue = new System.Windows.Forms.TextBox();
            this.yButtomValue = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grafWind)).BeginInit();
            this.SuspendLayout();
            // 
            // grafWind
            // 
            this.grafWind.BackColor = System.Drawing.Color.White;
            this.grafWind.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grafWind.Location = new System.Drawing.Point(30, 34);
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
            "First Profile",
            "Second Profile",
            "Third Profile",
            "Custom Profile"});
            this.comboBox1.Location = new System.Drawing.Point(260, 409);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(170, 33);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cmax
            // 
            this.Cmax.BackColor = System.Drawing.Color.White;
            this.Cmax.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Cmax.Location = new System.Drawing.Point(279, 325);
            this.Cmax.Name = "Cmax";
            this.Cmax.ReadOnly = true;
            this.Cmax.Size = new System.Drawing.Size(120, 31);
            this.Cmax.TabIndex = 3;
            this.Cmax.Visible = false;
            // 
            // b
            // 
            this.b.BackColor = System.Drawing.Color.White;
            this.b.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.b.Location = new System.Drawing.Point(408, 325);
            this.b.Name = "b";
            this.b.ReadOnly = true;
            this.b.Size = new System.Drawing.Size(85, 31);
            this.b.TabIndex = 4;
            this.b.Visible = false;
            // 
            // Xcmax
            // 
            this.Xcmax.BackColor = System.Drawing.Color.White;
            this.Xcmax.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Xcmax.Location = new System.Drawing.Point(499, 325);
            this.Xcmax.Name = "Xcmax";
            this.Xcmax.ReadOnly = true;
            this.Xcmax.Size = new System.Drawing.Size(136, 31);
            this.Xcmax.TabIndex = 5;
            this.Xcmax.Visible = false;
            // 
            // pointSwitch
            // 
            this.pointSwitch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pointSwitch.FormattingEnabled = true;
            this.pointSwitch.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.pointSwitch.Location = new System.Drawing.Point(129, 382);
            this.pointSwitch.Name = "pointSwitch";
            this.pointSwitch.Size = new System.Drawing.Size(89, 33);
            this.pointSwitch.TabIndex = 6;
            this.pointSwitch.SelectedIndexChanged += new System.EventHandler(this.pointSwitch_SelectedIndexChanged);
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(30, 420);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.ReadOnly = true;
            this.xTextBox.Size = new System.Drawing.Size(91, 31);
            this.xTextBox.TabIndex = 7;
            this.xTextBox.Text = "X=";
            this.xTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // yTopTextBox
            // 
            this.yTopTextBox.Location = new System.Drawing.Point(30, 457);
            this.yTopTextBox.Name = "yTopTextBox";
            this.yTopTextBox.ReadOnly = true;
            this.yTopTextBox.Size = new System.Drawing.Size(91, 31);
            this.yTopTextBox.TabIndex = 8;
            this.yTopTextBox.Text = "Ytop=";
            this.yTopTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // yButtomTexBox
            // 
            this.yButtomTexBox.Location = new System.Drawing.Point(30, 494);
            this.yButtomTexBox.Name = "yButtomTexBox";
            this.yButtomTexBox.ReadOnly = true;
            this.yButtomTexBox.Size = new System.Drawing.Size(91, 31);
            this.yButtomTexBox.TabIndex = 9;
            this.yButtomTexBox.Text = "Ybuttom=";
            this.yButtomTexBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pointTextBox
            // 
            this.pointTextBox.Location = new System.Drawing.Point(30, 382);
            this.pointTextBox.Name = "pointTextBox";
            this.pointTextBox.ReadOnly = true;
            this.pointTextBox.Size = new System.Drawing.Size(91, 31);
            this.pointTextBox.TabIndex = 10;
            this.pointTextBox.Text = "Point:";
            this.pointTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // xValue
            // 
            this.xValue.Location = new System.Drawing.Point(129, 420);
            this.xValue.Name = "xValue";
            this.xValue.Size = new System.Drawing.Size(89, 31);
            this.xValue.TabIndex = 11;
            this.xValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.xValue.TextChanged += new System.EventHandler(this.xValue_TextChanged);
            // 
            // yTopValue
            // 
            this.yTopValue.Location = new System.Drawing.Point(129, 457);
            this.yTopValue.Name = "yTopValue";
            this.yTopValue.Size = new System.Drawing.Size(89, 31);
            this.yTopValue.TabIndex = 12;
            this.yTopValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.yTopValue.TextChanged += new System.EventHandler(this.yTopValue_TextChanged);
            // 
            // yButtomValue
            // 
            this.yButtomValue.Location = new System.Drawing.Point(129, 494);
            this.yButtomValue.Name = "yButtomValue";
            this.yButtomValue.Size = new System.Drawing.Size(89, 31);
            this.yButtomValue.TabIndex = 13;
            this.yButtomValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.yButtomValue.TextChanged += new System.EventHandler(this.yButtomValue_TextChanged);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(497, 448);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(138, 40);
            this.resetButton.TabIndex = 14;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Visible = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 537);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.yButtomValue);
            this.Controls.Add(this.yTopValue);
            this.Controls.Add(this.xValue);
            this.Controls.Add(this.pointTextBox);
            this.Controls.Add(this.yButtomTexBox);
            this.Controls.Add(this.yTopTextBox);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.pointSwitch);
            this.Controls.Add(this.Xcmax);
            this.Controls.Add(this.b);
            this.Controls.Add(this.Cmax);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.grafWind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "wingProfiles";
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
        private System.Windows.Forms.ComboBox pointSwitch;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.TextBox yTopTextBox;
        private System.Windows.Forms.TextBox yButtomTexBox;
        private System.Windows.Forms.TextBox pointTextBox;
        private System.Windows.Forms.TextBox xValue;
        private System.Windows.Forms.TextBox yTopValue;
        private System.Windows.Forms.TextBox yButtomValue;
        private System.Windows.Forms.Button resetButton;
    }
}

