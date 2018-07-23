using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.IO;

namespace UdpComm {
   public partial class FormMain : Form {
      public FormMain(bool first = true) {
         InitializeComponent();
         if (!first) {
            this.tbxLocalPort.Text = "9001";
            this.tbxRemotePort.Text = "9000";
         }
      }

      private Udp udp = null;

      private void SendText() {
         try {
            string text = this.tbxSend.Text;
            this.tbxSend.Text = string.Empty;

            this.tbxRecv.AppendText("<send> " + text + Environment.NewLine);
            byte[] buf = Encoding.Default.GetBytes(text);
            this.udp.Send(buf);
            this.lbxSendHistory.Items.Add(text);
         } catch (Exception ex) {
            this.tbxRecv.AppendText(ex.Message + Environment.NewLine);
         }
      }

      private void udp_Recv(object sender, byte[] buf) {
         this.Invoke((Action<byte[]>)this.ProcessReceive, buf);
      }

      private void ProcessReceive(byte[] buf) {
         //string text = BitConverter.ToString(buf);
         string text = Encoding.Default.GetString(buf);
         this.tbxRecv.AppendText("<recv> " + text + Environment.NewLine);
      }

      private void tbxSend_KeyDown(object sender, KeyEventArgs e) {
         if (e.KeyCode == Keys.Enter) {
            this.SendText();
         }
      }

      private void UdpConnect() {
         try {
            int localPort = int.Parse(this.tbxLocalPort.Text);
            string remoteIp = this.tbxRemoteIp.Text;
            int remotePort = int.Parse(this.tbxRemotePort.Text);

            this.udp = new Udp();
            this.udp.Recv += this.udp_Recv;
            this.udp.Connect(localPort, remoteIp, remotePort);
               
            this.tbxRecv.AppendText("<connect> " + "succ " + remoteIp + ":" + remotePort.ToString() + Environment.NewLine);
            this.btnConnect.Text = "DisConnect";
         } catch (Exception ex) {
            this.tbxRecv.AppendText("<connect> " + "error " + ex.Message + Environment.NewLine);
            this.udp = null;
         }
      }

      private void UdpDisconnect() {
         if (this.udp != null) {
            this.udp.Close();
            this.udp = null;
            this.tbxRecv.AppendText("<disconnect>\r\n");
            this.btnConnect.Text = "Connect";
         }
      }
      
      private void btnConnect_Click(object sender, EventArgs e) {
         if (this.udp == null) {
            this.UdpConnect();
         } else {
            this.UdpDisconnect();
         }
      }

      private void btnSend_Click(object sender, EventArgs e) {
         this.SendText();
      }

      private void FormMain_Load(object sender, EventArgs e) {
         string historyPath = Application.StartupPath + "\\history.txt";
         if (File.Exists(historyPath)) {
            string[] texts = File.ReadAllLines(historyPath);
            this.lbxSendHistory.Items.AddRange(texts);
         }
      }

      private void FormMain_FormClosing(object sender, FormClosingEventArgs e) {
         this.UdpDisconnect();
         string historyPath = Application.StartupPath + "\\history.txt";
         File.WriteAllLines(historyPath, this.lbxSendHistory.Items.Cast<string>());
      }

      private void lbxSendHistory_DoubleClick(object sender, EventArgs e) {
         if (this.lbxSendHistory.SelectedItem == null)
            return;
         this.tbxSend.Text = this.lbxSendHistory.SelectedItem.ToString();
      }

      private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
         while (lbxSendHistory.SelectedItems.Count > 0) {
            lbxSendHistory.Items.Remove(lbxSendHistory.SelectedItems[0]);
         }
      }

      private void lbxSendHistory_KeyDown(object sender, KeyEventArgs e) {
         if (e.KeyCode != Keys.Delete)
            return;
         while (lbxSendHistory.SelectedItems.Count > 0) {
            lbxSendHistory.Items.Remove(lbxSendHistory.SelectedItems[0]);
         }
      }
   }
}
