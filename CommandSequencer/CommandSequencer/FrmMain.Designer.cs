namespace CommandSequencer
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.rtbScript = new System.Windows.Forms.RichTextBox();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.gpScript = new System.Windows.Forms.GroupBox();
            this.gbResponse = new System.Windows.Forms.GroupBox();
            this.rtbResponse = new System.Windows.Forms.RichTextBox();
            this.iptbIP = new CommandSequencer.Views.CustomsComponents.IPTextBox();
            this.tlpMain.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.gpScript.SuspendLayout();
            this.gbResponse.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 6;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.lblIP, 0, 0);
            this.tlpMain.Controls.Add(this.iptbIP, 1, 0);
            this.tlpMain.Controls.Add(this.lblPort, 2, 0);
            this.tlpMain.Controls.Add(this.txtPort, 3, 0);
            this.tlpMain.Controls.Add(this.btnConnect, 4, 0);
            this.tlpMain.Controls.Add(this.pnlControl, 5, 3);
            this.tlpMain.Controls.Add(this.gpScript, 0, 1);
            this.tlpMain.Controls.Add(this.gbResponse, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(653, 429);
            this.tlpMain.TabIndex = 0;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIP.Location = new System.Drawing.Point(3, 0);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(20, 29);
            this.lblIP.TabIndex = 0;
            this.lblIP.Text = "IP:";
            this.lblIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPort.Location = new System.Drawing.Point(165, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 29);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "Port";
            this.lblPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPort
            // 
            this.txtPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPort.Location = new System.Drawing.Point(197, 3);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "10001";
            this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPort_KeyPress);
            // 
            // btnConnect
            // 
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnect.Location = new System.Drawing.Point(303, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // rtbScript
            // 
            this.rtbScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbScript.Location = new System.Drawing.Point(3, 16);
            this.rtbScript.Name = "rtbScript";
            this.rtbScript.Size = new System.Drawing.Size(641, 150);
            this.rtbScript.TabIndex = 5;
            this.rtbScript.Text = "";
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.btnExecute);
            this.pnlControl.Controls.Add(this.btnClear);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControl.Location = new System.Drawing.Point(384, 382);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(266, 44);
            this.pnlControl.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(188, 18);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecute.Location = new System.Drawing.Point(107, 18);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 1;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            // 
            // gpScript
            // 
            this.tlpMain.SetColumnSpan(this.gpScript, 6);
            this.gpScript.Controls.Add(this.rtbScript);
            this.gpScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpScript.Location = new System.Drawing.Point(3, 32);
            this.gpScript.Name = "gpScript";
            this.gpScript.Size = new System.Drawing.Size(647, 169);
            this.gpScript.TabIndex = 7;
            this.gpScript.TabStop = false;
            this.gpScript.Text = "Script";
            // 
            // gbResponse
            // 
            this.tlpMain.SetColumnSpan(this.gbResponse, 6);
            this.gbResponse.Controls.Add(this.rtbResponse);
            this.gbResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbResponse.Location = new System.Drawing.Point(3, 207);
            this.gbResponse.Name = "gbResponse";
            this.gbResponse.Size = new System.Drawing.Size(647, 169);
            this.gbResponse.TabIndex = 8;
            this.gbResponse.TabStop = false;
            this.gbResponse.Text = "Response";
            // 
            // rtbResponse
            // 
            this.rtbResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbResponse.Location = new System.Drawing.Point(3, 16);
            this.rtbResponse.Name = "rtbResponse";
            this.rtbResponse.ReadOnly = true;
            this.rtbResponse.Size = new System.Drawing.Size(641, 150);
            this.rtbResponse.TabIndex = 0;
            this.rtbResponse.Text = "";
            // 
            // iptbIP
            // 
            this.iptbIP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iptbIP.Location = new System.Drawing.Point(29, 3);
            this.iptbIP.Name = "iptbIP";
            this.iptbIP.Size = new System.Drawing.Size(130, 23);
            this.iptbIP.TabIndex = 1;
            this.iptbIP.ToolTipText = "";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 429);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "CS Light";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.pnlControl.ResumeLayout(false);
            this.gpScript.ResumeLayout(false);
            this.gbResponse.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblIP;
        private CommandSequencer.Views.CustomsComponents.IPTextBox iptbIP;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.RichTextBox rtbScript;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gpScript;
        private System.Windows.Forms.GroupBox gbResponse;
        private System.Windows.Forms.RichTextBox rtbResponse;
    }
}

