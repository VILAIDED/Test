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
    public partial class SVForm : Form
    {
        public delegate void PassMSSV(string mssv);
        private SV sv;
        public PassMSSV sender;
        public delegate void RefreshForm();
        public RefreshForm refresh;
        public void getSV(string mssv)
        {
            if ("".Equals(mssv))
            {
                sv = new SV();
            }
            else{
                sv = BLL_QLSV.Instance.GetSvByMSSV_BLL(mssv);
            }
            
        }
        public SVForm()
        {
            InitializeComponent();
            sender = new PassMSSV(getSV);
        }
        private void SetData()
        {
            sv.MSSV = txt_mssv.Text;
            sv.NameSV = txt_name.Text;
            sv.NS = picker_ns.Value;
            CBBItems cb = (CBBItems)cbb_lop.SelectedItem;
            sv.IdLop = cb.Value;
        }
        private void SetCBB()
        {
            cbb_lop.Items.AddRange(BLL_QLSV.Instance.GetCBBItems_BLL().ToArray());
            if(sv.MSSV == null)
            {
                cbb_lop.SelectedIndex = 0;
            }
            else
            {
                CBBItems cb = new CBBItems();
               for(int i = 0; i < cbb_lop.Items.Count; i++)
                {
                    cb = (CBBItems)cbb_lop.Items[i];
                    if(cb.Value == sv.IdLop)
                    {
                        cbb_lop.SelectedIndex = i;
                        break;
                    }
                }
            }
        }
        private void SVForm_Load(object sender, EventArgs e)
        {
            
                if (sv.MSSV != null) txt_mssv.ReadOnly = true;
                txt_mssv.Text = sv.MSSV;
                txt_name.Text = sv.NameSV;
                picker_ns.Value = sv.NS;
                if (sv.Gender) radio_nu.Checked = true;
                else radio_nam.Checked = true;
            
            
            SetCBB();
        }
        private bool Validation()
        {
            bool check = false;
        
            if("".Equals(txt_mssv.Text) || "".Equals(txt_name.Text))
            {
                MessageBox.Show("Ban hay dieu thong tin day du");
            }else if(!(int.TryParse(txt_mssv.Text,out int p)))
            {
                MessageBox.Show("Mssv chi la so thoi");
            }
            else
            {
                check = true;
            }
            return check;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                SetData();
                BLL_QLSV.Instance.ExecuteSV(sv);
                refresh();
                this.Close();
            }
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radio_nam_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_nam.Checked)
            {
                sv.Gender = false;
            }
        }

        private void radio_nu_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_nu.Checked)
            {
                sv.Gender = true;
            }
        }
    }
}
