using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS.Folder;
using Model.Folder;

namespace Employee.GUI
{
    public partial class Form1 : Form
    {
        CustomBUS cusBUS = new CustomBUS();
        EmploBUS EmBUS = new EmploBUS();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvHR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            List<CustomBEL> IstCus = cusBUS.ReadEmployee();
            foreach (CustomBEL cus in IstCus)
            {
                dgvHR.Rows.Add(cus.IdE, cus.Name, cus.Db, cus.Gd, cus.Pb, cus.IdD);
            }
            List<EmploBEL> IstArea = EmBUS.ReadEmployeeList();
        }

        private void dgvHR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHR_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            DataGridViewRow row = dgvHR.Rows[idx];
            if (row.Cells[0].Value != null)
            {
                tbIdE.Text = row.Cells[0].Value.ToString();
                tbName.Text = row.Cells[1].Value.ToString();
                tbDb.Text = row.Cells[2].Value.ToString();
                tbGd.Text = row.Cells[3].Value.ToString();
                tbPb.Text = row.Cells[4].Value.ToString();
                cbDepartment.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            CustomBEL cus = new CustomBEL();
            cus.IdE = int.Parse(tbIdE.Text);
            cus.Name = tbName.Text;
            cus.Db = DateTime.Parse(tbDb.Text);
            cus.Gd = bool.Parse(tbGd.Text);
            cus.Pb = tbPb.Text;
            cus.IdD = cbDepartment.Text;

            cusBUS.NewEmployee(cus);

            dgvHR.Rows.Add(cus.IdE, cus.Name, cus.Db, cus.Gd, cus.Pb, cus.IdD);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            CustomBEL cus = new CustomBEL();
            cus.IdE = int.Parse(tbIdE.Text);
            cus.Name = tbName.Text;

            cusBUS.DeleteEmployee(cus);

            int idx = dgvHR.CurrentCell.RowIndex;
            dgvHR.Rows.RemoveAt(idx);
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvHR.CurrentRow;
            if (row != null)
            {
                CustomBEL cus = new CustomBEL();
                cus.IdE = int.Parse(tbIdE.Text);
                cus.Name = tbName.Text;
                cus.Db = DateTime.Parse(tbDb.Text);
                cus.Gd = bool.Parse(tbGd.Text);
                cus.Pb = tbPb.Text;
                cus.IdD = cbDepartment.Text;
                cusBUS.EditEmployee(cus);

                int idx = dgvHR.CurrentCell.RowIndex;

                dgvHR.Rows[idx].Cells[0].Value = cus.IdE;
                dgvHR.Rows[idx].Cells[1].Value = cus.Name;
                dgvHR.Rows[idx].Cells[2].Value = cus.Db;
                dgvHR.Rows[idx].Cells[3].Value = cus.Gd;
                dgvHR.Rows[idx].Cells[4].Value = cus.Pb;
                dgvHR.Rows[idx].Cells[5].Value = cus.IdD;

            }
        }
    }
}
