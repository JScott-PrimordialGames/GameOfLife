
namespace GOL
{
    partial class SingleInput
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
            this.lbl_Message = new System.Windows.Forms.Label();
            this.txb_NewSeed = new System.Windows.Forms.TextBox();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Message
            // 
            this.lbl_Message.AutoSize = true;
            this.lbl_Message.Location = new System.Drawing.Point(70, 49);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(133, 13);
            this.lbl_Message.TabIndex = 7;
            this.lbl_Message.Text = "Random seed for Universe";
            // 
            // txb_NewSeed
            // 
            this.txb_NewSeed.Location = new System.Drawing.Point(85, 75);
            this.txb_NewSeed.Name = "txb_NewSeed";
            this.txb_NewSeed.Size = new System.Drawing.Size(100, 20);
            this.txb_NewSeed.TabIndex = 6;
            this.txb_NewSeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_NewSeed_KeyPress);
            // 
            // btn_Ok
            // 
            this.btn_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Ok.Location = new System.Drawing.Point(12, 115);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 5;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            // 
            // btn_cancle
            // 
            this.btn_cancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancle.Location = new System.Drawing.Point(183, 115);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(75, 23);
            this.btn_cancle.TabIndex = 8;
            this.btn_cancle.Text = "Cancle";
            this.btn_cancle.UseVisualStyleBackColor = true;
            // 
            // SingleInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 149);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.lbl_Message);
            this.Controls.Add(this.txb_NewSeed);
            this.Controls.Add(this.btn_Ok);
            this.Name = "SingleInput";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txb_NewSeed;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_cancle;
        public System.Windows.Forms.Label lbl_Message;
    }
}