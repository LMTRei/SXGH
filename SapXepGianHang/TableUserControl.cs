using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLL;

namespace SapXepGianHang
{
    public partial class TableUserControl : UserControl
    {
        public TableUserControl(ItemSet itemSet, List<AssociationRule> rules)
        {
            InitializeComponent();
            ItemSetLabel.Text = itemSet.Label;
            foreach (var item in itemSet)
            {
                dgvItemSets.Rows.Add(item.Key.ToDisplay(), item.Value);
                if (item.Value < itemSet.Support)
                    dgvItemSets.Rows[dgvItemSets.Rows.Count - 1].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            }
            if (rules.Count == 0)
            {
                dgvItemSets.Height = 342;
                dgvRules.Hide();
            }
            else
            {
                foreach (var item in rules)
                {
                    dgvRules.Rows.Add(item.Label, item.Confidance.ToPercentString(), item.Support.ToPercentString());
                }
            }
        }

        public TableUserControl(List<string> Values)
        {
            InitializeComponent();
            ItemSetLabel.Text = "Transactions";
            dgvItemSets.Columns[0].Name = "TransactionID";
            dgvItemSets.Columns[1].Name = "Items";
            for (int i = 0; i < Values.Count; i++)
            {
                dgvItemSets.Rows.Add(i, Values[i]);
            }
            dgvItemSets.Height = 342;
            dgvRules.Hide();
        }

        private void dgvItemSets_SelectionChanged(object sender, EventArgs e)
        {
            dgvItemSets.ClearSelection();
        }
    }
}
