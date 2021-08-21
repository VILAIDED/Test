using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using codeFirstOnThi.DTO;
using codeFirstOnThi.BLL;
namespace codeFirstOnThi.GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void SetCBBLop()
        {
            cbb_lop.Items.Add(new CBBItems
            {
                Value = 0,
                Text = "ALL"
            });
            cbb_lop.Items.AddRange(BLL_QLSV.Instance.GetCBBItems_BLL().ToArray());
            cbb_lop.SelectedIndex = 0;
        }
        private void Show(string nameSV)
        {
            CBBItems cb = (CBBItems)cbb_lop.SelectedItem;
            dataGridView1.DataSource = BLL_QLSV.Instance.GetListSV_BLL(nameSV, cb.Value).Select(sv => new { sv.MSSV, sv.NameSV, sv.Gender, sv.NS, sv.LSHs.NameLop }).ToList();
        }
        private void btn_show_Click(object sender, EventArgs e)
        {
            Show("");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            SVForm svForm = new SVForm();
            svForm.sender("");
            svForm.refresh += HandleCloseForm;
            svForm.Show();
        }
        private void HandleCloseForm()
        {
            btn_show.PerformClick();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 1)
            {
                string mssv = (string)dataGridView1.CurrentRow.Cells["MSSV"].Value.ToString();
                SVForm svForm = new SVForm();
                svForm.sender(mssv);
                svForm.refresh += HandleCloseForm;
                svForm.Show();
            }
        }
        private void btn_del_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                List<String> mssvList = new List<String>();
                String mssv = "";
                foreach(DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    mssv = row.Cells["MSSV"].Value.ToString();
                    mssvList.Add(mssv);
                }
                BLL_QLSV.Instance.DelSV_BLL(mssvList);
                btn_show.PerformClick();
            }
        }
        private void SetCBBSort()
        {
            cbb_sort.Items.AddRange(new string[]{
                "MSSV",
                "NS",
                "HoTen",
                "MaLop"
            });
            cbb_sort.SelectedIndex = 0;
        }
        private void btn_sort_Click(object sender, EventArgs e)
        {
            string sortBy = cbb_sort.SelectedItem.ToString();
            CBBItems cb = (CBBItems)cbb_lop.SelectedItem;
            dataGridView1.DataSource = BLL_QLSV.Instance.SortListSV(cb.Value, "", sortBy).Select(sv=> new { sv.MSSV, sv.NameSV, sv.Gender, sv.NS, sv.LSHs.NameLop }).ToList();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Show(txt_search.Text);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            SetCBBLop();
            SetCBBSort();
        }
    }
}
