using DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SapXepGianHang
{
    public partial class frmSapXepGianHang : Form
    {
        public frmSapXepGianHang()
        {
            InitializeComponent();
            lbSupport.Text = string.Format("Support {0}", tbSupport.Value + 1);
        }
        string FileName = string.Empty;

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Filter = "Text|*.txt";
            if (dialog.ShowDialog() != DialogResult.OK) return;
            FileName = dialog.FileName;
            tbSupport.Enabled = true;
            DoThingThread();
            btnReFresh.Enabled = true;
        }

        private void DoThings()
        {
            int Support = 2;
            if (tbSupport.InvokeRequired)
                tbSupport.Invoke(new MethodInvoker(delegate
                {
                    Support = tbSupport.Value + 1;
                    tbSupport.Enabled = false;
                }
                ));
            if (flpLabel.InvokeRequired)
                flpLabel.Invoke(new MethodInvoker(delegate
                {
                    flpLabel.Controls.Clear();
                    flpLabel.Controls.Add(new TableUserControl(File.ReadAllLines(FileName).ToList()));
                }
                ));
            DLL.Apriori apriori = new DLL.Apriori(FileName);
            int k = 1;
            List<DLL.ItemSet> ItemSets = new List<DLL.ItemSet>();
            bool next;
            do
            {
                next = false;
                var L = apriori.GetItemSet(k, Support, IsFirstItemList: k == 1);
                if (L.Count > 0)
                {
                    List<AssociationRule> rules = new List<AssociationRule>();
                    if (k != 1)
                        rules = apriori.GetRules(L);
                    TableUserControl tableL = new TableUserControl(L, rules);
                    next = true;
                    k++;
                    ItemSets.Add(L);
                    if (flpLabel.InvokeRequired)
                        flpLabel.Invoke(new MethodInvoker(delegate
                        {
                            flpLabel.Controls.Add(tableL);
                            flpLabel.VerticalScroll.Value = flpLabel.VerticalScroll.Maximum;
                        }
                        ));
                }
            } while (next);

            if (tbSupport.InvokeRequired)
                tbSupport.Invoke(new MethodInvoker(delegate
                {
                    tbSupport.Enabled = true;
                }
                ));
        }

        private void tbSupport_Scroll(object sender, EventArgs e)
        {
            lbSupport.Text = string.Format("Support {0}", tbSupport.Value + 1);
            DoThingThread();
        }
        List<Thread> threads = new List<Thread>();

        private void btnReFresh_Click(object sender, EventArgs e)
        {
            AbortThread();
            DoThingThread();
        }

        private void AbortThread()
        {
            foreach (var thread in threads)
            {
                thread.Abort();
            }
            threads.Clear();
        }

        private void DoThingThread()
        {
            Thread t = new Thread(delegate ()
            {
                pbLogo.Invoke(new MethodInvoker(delegate
                {
                    pbLogo.Show();
                }));
                DoThings();
                pbLogo.Invoke(new MethodInvoker(delegate
                {
                    pbLogo.Hide();
                }));
            })
            { Name = "DoThings" };
            threads.Add(t);
            t.Start();
        }

        private void frmSapXepGianHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            AbortThread();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
