namespace UdpComm {
   partial class FormMain {
      /// <summary>
      /// 필수 디자이너 변수입니다.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// 사용 중인 모든 리소스를 정리합니다.
      /// </summary>
      /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form 디자이너에서 생성한 코드

      /// <summary>
      /// 디자이너 지원에 필요한 메서드입니다.
      /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
      /// </summary>
      private void InitializeComponent() {
         this.components = new System.ComponentModel.Container();
         this.tbxRecv = new System.Windows.Forms.TextBox();
         this.tbxSend = new System.Windows.Forms.TextBox();
         this.btnConnect = new System.Windows.Forms.Button();
         this.tbxLocalPort = new System.Windows.Forms.TextBox();
         this.tbxRemoteIp = new System.Windows.Forms.TextBox();
         this.tbxRemotePort = new System.Windows.Forms.TextBox();
         this.panel1 = new System.Windows.Forms.Panel();
         this.panel3 = new System.Windows.Forms.Panel();
         this.btnSend = new System.Windows.Forms.Button();
         this.panel2 = new System.Windows.Forms.Panel();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.lbxSendHistory = new System.Windows.Forms.ListBox();
         this.popupMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.splitter1 = new System.Windows.Forms.Splitter();
         this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
         this.panel1.SuspendLayout();
         this.panel3.SuspendLayout();
         this.panel2.SuspendLayout();
         this.popupMenu.SuspendLayout();
         this.SuspendLayout();
         // 
         // tbxRecv
         // 
         this.tbxRecv.BackColor = System.Drawing.SystemColors.Window;
         this.tbxRecv.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tbxRecv.Location = new System.Drawing.Point(0, 21);
         this.tbxRecv.Multiline = true;
         this.tbxRecv.Name = "tbxRecv";
         this.tbxRecv.ReadOnly = true;
         this.tbxRecv.Size = new System.Drawing.Size(422, 584);
         this.tbxRecv.TabIndex = 1;
         // 
         // tbxSend
         // 
         this.tbxSend.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tbxSend.Location = new System.Drawing.Point(0, 0);
         this.tbxSend.Name = "tbxSend";
         this.tbxSend.Size = new System.Drawing.Size(347, 21);
         this.tbxSend.TabIndex = 0;
         this.tbxSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxSend_KeyDown);
         // 
         // btnConnect
         // 
         this.btnConnect.Dock = System.Windows.Forms.DockStyle.Right;
         this.btnConnect.Location = new System.Drawing.Point(347, 0);
         this.btnConnect.Name = "btnConnect";
         this.btnConnect.Size = new System.Drawing.Size(75, 21);
         this.btnConnect.TabIndex = 3;
         this.btnConnect.Text = "connect";
         this.btnConnect.UseVisualStyleBackColor = true;
         this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
         // 
         // tbxLocalPort
         // 
         this.tbxLocalPort.Dock = System.Windows.Forms.DockStyle.Left;
         this.tbxLocalPort.Location = new System.Drawing.Point(64, 0);
         this.tbxLocalPort.Name = "tbxLocalPort";
         this.tbxLocalPort.Size = new System.Drawing.Size(35, 21);
         this.tbxLocalPort.TabIndex = 2;
         this.tbxLocalPort.Text = "9000";
         // 
         // tbxRemoteIp
         // 
         this.tbxRemoteIp.Dock = System.Windows.Forms.DockStyle.Left;
         this.tbxRemoteIp.Location = new System.Drawing.Point(158, 0);
         this.tbxRemoteIp.Name = "tbxRemoteIp";
         this.tbxRemoteIp.Size = new System.Drawing.Size(84, 21);
         this.tbxRemoteIp.TabIndex = 2;
         this.tbxRemoteIp.Text = "127.0.0.1";
         // 
         // tbxRemotePort
         // 
         this.tbxRemotePort.Dock = System.Windows.Forms.DockStyle.Left;
         this.tbxRemotePort.Location = new System.Drawing.Point(299, 0);
         this.tbxRemotePort.Name = "tbxRemotePort";
         this.tbxRemotePort.Size = new System.Drawing.Size(35, 21);
         this.tbxRemotePort.TabIndex = 2;
         this.tbxRemotePort.Text = "9001";
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.tbxRecv);
         this.panel1.Controls.Add(this.panel3);
         this.panel1.Controls.Add(this.panel2);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(422, 626);
         this.panel1.TabIndex = 4;
         // 
         // panel3
         // 
         this.panel3.Controls.Add(this.tbxSend);
         this.panel3.Controls.Add(this.btnSend);
         this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.panel3.Location = new System.Drawing.Point(0, 605);
         this.panel3.Name = "panel3";
         this.panel3.Size = new System.Drawing.Size(422, 21);
         this.panel3.TabIndex = 5;
         // 
         // btnSend
         // 
         this.btnSend.Dock = System.Windows.Forms.DockStyle.Right;
         this.btnSend.Location = new System.Drawing.Point(347, 0);
         this.btnSend.Name = "btnSend";
         this.btnSend.Size = new System.Drawing.Size(75, 21);
         this.btnSend.TabIndex = 6;
         this.btnSend.Text = "Send";
         this.btnSend.UseVisualStyleBackColor = true;
         this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
         // 
         // panel2
         // 
         this.panel2.Controls.Add(this.btnConnect);
         this.panel2.Controls.Add(this.tbxRemotePort);
         this.panel2.Controls.Add(this.label3);
         this.panel2.Controls.Add(this.tbxRemoteIp);
         this.panel2.Controls.Add(this.label2);
         this.panel2.Controls.Add(this.tbxLocalPort);
         this.panel2.Controls.Add(this.label1);
         this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel2.Location = new System.Drawing.Point(0, 0);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(422, 21);
         this.panel2.TabIndex = 5;
         // 
         // label3
         // 
         this.label3.Dock = System.Windows.Forms.DockStyle.Left;
         this.label3.Location = new System.Drawing.Point(242, 0);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(57, 21);
         this.label3.TabIndex = 4;
         this.label3.Text = "Host Port";
         this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // label2
         // 
         this.label2.Dock = System.Windows.Forms.DockStyle.Left;
         this.label2.Location = new System.Drawing.Point(99, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(59, 21);
         this.label2.TabIndex = 4;
         this.label2.Text = "Host IP";
         this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // label1
         // 
         this.label1.Dock = System.Windows.Forms.DockStyle.Left;
         this.label1.Location = new System.Drawing.Point(0, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(64, 21);
         this.label1.TabIndex = 4;
         this.label1.Text = "Local Port";
         this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // lbxSendHistory
         // 
         this.lbxSendHistory.ContextMenuStrip = this.popupMenu;
         this.lbxSendHistory.Dock = System.Windows.Forms.DockStyle.Fill;
         this.lbxSendHistory.FormattingEnabled = true;
         this.lbxSendHistory.ItemHeight = 12;
         this.lbxSendHistory.Location = new System.Drawing.Point(425, 0);
         this.lbxSendHistory.Name = "lbxSendHistory";
         this.lbxSendHistory.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
         this.lbxSendHistory.Size = new System.Drawing.Size(467, 626);
         this.lbxSendHistory.TabIndex = 5;
         this.lbxSendHistory.DoubleClick += new System.EventHandler(this.lbxSendHistory_DoubleClick);
         this.lbxSendHistory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbxSendHistory_KeyDown);
         // 
         // popupMenu
         // 
         this.popupMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
         this.popupMenu.Name = "popupMenu";
         this.popupMenu.Size = new System.Drawing.Size(109, 26);
         // 
         // deleteToolStripMenuItem
         // 
         this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
         this.deleteToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
         this.deleteToolStripMenuItem.Text = "Delete";
         this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
         // 
         // splitter1
         // 
         this.splitter1.Location = new System.Drawing.Point(422, 0);
         this.splitter1.Name = "splitter1";
         this.splitter1.Size = new System.Drawing.Size(3, 626);
         this.splitter1.TabIndex = 6;
         this.splitter1.TabStop = false;
         // 
         // FormMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(892, 626);
         this.Controls.Add(this.lbxSendHistory);
         this.Controls.Add(this.splitter1);
         this.Controls.Add(this.panel1);
         this.Name = "FormMain";
         this.Text = "Form1";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
         this.Load += new System.EventHandler(this.FormMain_Load);
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.panel3.ResumeLayout(false);
         this.panel3.PerformLayout();
         this.panel2.ResumeLayout(false);
         this.panel2.PerformLayout();
         this.popupMenu.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TextBox tbxRecv;
      private System.Windows.Forms.TextBox tbxSend;
      private System.Windows.Forms.Button btnConnect;
      private System.Windows.Forms.TextBox tbxLocalPort;
      private System.Windows.Forms.TextBox tbxRemoteIp;
      private System.Windows.Forms.TextBox tbxRemotePort;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Panel panel3;
      private System.Windows.Forms.Button btnSend;
      private System.Windows.Forms.ListBox lbxSendHistory;
      private System.Windows.Forms.Splitter splitter1;
      private System.Windows.Forms.ContextMenuStrip popupMenu;
      private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
      private System.ComponentModel.BackgroundWorker backgroundWorker1;
   }
}

