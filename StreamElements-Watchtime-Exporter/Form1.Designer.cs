namespace StreamElements_Watchtime_Exporter
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
            this.lbl_jwt = new System.Windows.Forms.Label();
            this.txt_jwt = new System.Windows.Forms.TextBox();
            this.lnk_settings = new System.Windows.Forms.LinkLabel();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.lbl_output = new System.Windows.Forms.Label();
            this.btn_browse_output = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.lbl_acc_id = new System.Windows.Forms.Label();
            this.txt_acc_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_jwt
            // 
            this.lbl_jwt.AutoSize = true;
            this.lbl_jwt.Location = new System.Drawing.Point(12, 9);
            this.lbl_jwt.Name = "lbl_jwt";
            this.lbl_jwt.Size = new System.Drawing.Size(67, 15);
            this.lbl_jwt.TabIndex = 0;
            this.lbl_jwt.Text = "JWT-Token:";
            // 
            // txt_jwt
            // 
            this.txt_jwt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_jwt.Location = new System.Drawing.Point(12, 27);
            this.txt_jwt.Name = "txt_jwt";
            this.txt_jwt.Size = new System.Drawing.Size(674, 23);
            this.txt_jwt.TabIndex = 1;
            this.txt_jwt.UseSystemPasswordChar = true;
            // 
            // lnk_settings
            // 
            this.lnk_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnk_settings.AutoSize = true;
            this.lnk_settings.Location = new System.Drawing.Point(488, 9);
            this.lnk_settings.Name = "lnk_settings";
            this.lnk_settings.Size = new System.Drawing.Size(198, 15);
            this.lnk_settings.TabIndex = 2;
            this.lnk_settings.TabStop = true;
            this.lnk_settings.Text = "Open StreamElements Settings Page";
            this.lnk_settings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_settings_LinkClicked);
            // 
            // txt_output
            // 
            this.txt_output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_output.Location = new System.Drawing.Point(12, 115);
            this.txt_output.Name = "txt_output";
            this.txt_output.Size = new System.Drawing.Size(639, 23);
            this.txt_output.TabIndex = 3;
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Location = new System.Drawing.Point(12, 97);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(48, 15);
            this.lbl_output.TabIndex = 4;
            this.lbl_output.Text = "Output:";
            // 
            // btn_browse_output
            // 
            this.btn_browse_output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_browse_output.Location = new System.Drawing.Point(657, 114);
            this.btn_browse_output.Name = "btn_browse_output";
            this.btn_browse_output.Size = new System.Drawing.Size(29, 23);
            this.btn_browse_output.TabIndex = 5;
            this.btn_browse_output.Text = "...";
            this.btn_browse_output.UseVisualStyleBackColor = true;
            this.btn_browse_output.Click += new System.EventHandler(this.btn_browse_output_Click);
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(312, 144);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(75, 23);
            this.btn_export.TabIndex = 6;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // sfd
            // 
            this.sfd.Filter = "CSV Files|*.csv|All Files|*.*";
            // 
            // lbl_acc_id
            // 
            this.lbl_acc_id.AutoSize = true;
            this.lbl_acc_id.Location = new System.Drawing.Point(12, 53);
            this.lbl_acc_id.Name = "lbl_acc_id";
            this.lbl_acc_id.Size = new System.Drawing.Size(71, 15);
            this.lbl_acc_id.TabIndex = 7;
            this.lbl_acc_id.Text = "Account-ID:";
            // 
            // txt_acc_id
            // 
            this.txt_acc_id.Location = new System.Drawing.Point(12, 71);
            this.txt_acc_id.Name = "txt_acc_id";
            this.txt_acc_id.Size = new System.Drawing.Size(674, 23);
            this.txt_acc_id.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 182);
            this.Controls.Add(this.txt_acc_id);
            this.Controls.Add(this.lbl_acc_id);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_browse_output);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.lnk_settings);
            this.Controls.Add(this.txt_jwt);
            this.Controls.Add(this.lbl_jwt);
            this.Name = "Form1";
            this.Text = "StreamElements-Watchtime-Exporter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_jwt;
        private TextBox txt_jwt;
        private LinkLabel lnk_settings;
        private TextBox txt_output;
        private Label lbl_output;
        private Button btn_browse_output;
        private Button btn_export;
        private SaveFileDialog sfd;
        private Label lbl_acc_id;
        private TextBox txt_acc_id;
    }
}