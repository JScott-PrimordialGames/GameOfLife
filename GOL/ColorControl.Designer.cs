
namespace GOL
{
    partial class ColorControl
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
            this.btn_cancle = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbl_gridColor = new System.Windows.Forms.Label();
            this.lbl_BackgroundColor = new System.Windows.Forms.Label();
            this.lbl_CellColor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancle
            // 
            this.btn_cancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancle.Location = new System.Drawing.Point(266, 179);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(75, 23);
            this.btn_cancle.TabIndex = 3;
            this.btn_cancle.Text = "Cancle";
            this.btn_cancle.UseVisualStyleBackColor = true;
            // 
            // btn_Ok
            // 
            this.btn_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Ok.Location = new System.Drawing.Point(59, 179);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 2;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Change Grid Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Change Background Color";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 127);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Change Cell Colors";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_gridColor
            // 
            this.lbl_gridColor.AutoSize = true;
            this.lbl_gridColor.Location = new System.Drawing.Point(170, 32);
            this.lbl_gridColor.Name = "lbl_gridColor";
            this.lbl_gridColor.Size = new System.Drawing.Size(59, 13);
            this.lbl_gridColor.TabIndex = 13;
            this.lbl_gridColor.Text = "Grid Color: ";
            // 
            // lbl_BackgroundColor
            // 
            this.lbl_BackgroundColor.AutoSize = true;
            this.lbl_BackgroundColor.Location = new System.Drawing.Point(170, 82);
            this.lbl_BackgroundColor.Name = "lbl_BackgroundColor";
            this.lbl_BackgroundColor.Size = new System.Drawing.Size(98, 13);
            this.lbl_BackgroundColor.TabIndex = 14;
            this.lbl_BackgroundColor.Text = "Background Color: ";
            // 
            // lbl_CellColor
            // 
            this.lbl_CellColor.AutoSize = true;
            this.lbl_CellColor.Location = new System.Drawing.Point(170, 132);
            this.lbl_CellColor.Name = "lbl_CellColor";
            this.lbl_CellColor.Size = new System.Drawing.Size(57, 13);
            this.lbl_CellColor.TabIndex = 15;
            this.lbl_CellColor.Text = "Cell Color: ";
            // 
            // ColorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 211);
            this.Controls.Add(this.lbl_CellColor);
            this.Controls.Add(this.lbl_BackgroundColor);
            this.Controls.Add(this.lbl_gridColor);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.btn_Ok);
            this.Name = "ColorControl";
            this.Text = "Color Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Label lbl_gridColor;
        public System.Windows.Forms.Label lbl_BackgroundColor;
        public System.Windows.Forms.Label lbl_CellColor;
    }
}