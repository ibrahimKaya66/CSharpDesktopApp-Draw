
namespace Draw
{
    partial class frmDraw
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
            this.txtTicketNr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnControl = new System.Windows.Forms.Button();
            this.btnDrawList = new System.Windows.Forms.Button();
            this.btnDice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTicketNr
            // 
            this.txtTicketNr.Location = new System.Drawing.Point(16, 53);
            this.txtTicketNr.Name = "txtTicketNr";
            this.txtTicketNr.Size = new System.Drawing.Size(130, 22);
            this.txtTicketNr.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyadı";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(299, 117);
            this.txtSurname.Multiline = true;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(130, 30);
            this.txtSurname.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(77, 200);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(352, 71);
            this.txtAddress.TabIndex = 6;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(77, 163);
            this.txtEposta.Multiline = true;
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(352, 30);
            this.txtEposta.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-Posta";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(77, 117);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(130, 30);
            this.txtName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Adı";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(341, 278);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 31);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnControl
            // 
            this.btnControl.BackgroundImage = global::Draw.Properties.Resources.Ok_icon;
            this.btnControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnControl.Location = new System.Drawing.Point(191, 44);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(45, 40);
            this.btnControl.TabIndex = 2;
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // btnDrawList
            // 
            this.btnDrawList.BackgroundImage = global::Draw.Properties.Resources.view_list_details_icon;
            this.btnDrawList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDrawList.Location = new System.Drawing.Point(385, 46);
            this.btnDrawList.Name = "btnDrawList";
            this.btnDrawList.Size = new System.Drawing.Size(44, 36);
            this.btnDrawList.TabIndex = 8;
            this.btnDrawList.UseVisualStyleBackColor = true;
            this.btnDrawList.Click += new System.EventHandler(this.btnDrawList_Click);
            // 
            // btnDice
            // 
            this.btnDice.BackgroundImage = global::Draw.Properties.Resources.Gaming_Dice_icon;
            this.btnDice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDice.Location = new System.Drawing.Point(149, 44);
            this.btnDice.Name = "btnDice";
            this.btnDice.Size = new System.Drawing.Size(45, 40);
            this.btnDice.TabIndex = 1;
            this.btnDice.UseVisualStyleBackColor = true;
            this.btnDice.Click += new System.EventHandler(this.btnDice_Click);
            // 
            // frmDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(442, 321);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnControl);
            this.Controls.Add(this.btnDrawList);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDice);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtTicketNr);
            this.Name = "frmDraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çekiliş";
            this.Load += new System.EventHandler(this.frmDraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTicketNr;
        private System.Windows.Forms.Button btnDice;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDrawList;
    }
}

