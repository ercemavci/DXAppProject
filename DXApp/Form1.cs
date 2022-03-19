using DevExpress.XtraGrid.Views.Base;
using DXApp.Data;
using DXApp.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<HR_Employees> gridList = new List<HR_Employees>(); 
            Engine.Engine Lists = new Engine.Engine();
            var source = new BindingSource();
            gridList = Lists.getList();
            source.DataSource = gridList;
            gridControl1.DataSource = source;
            setGridStyle();
        }
        public void refleshGrid()
        {
            List<HR_Employees> gridList = new List<HR_Employees>();
            Engine.Engine Lists = new Engine.Engine();
            var source = new BindingSource();
            gridList = Lists.getList();
            source.DataSource = gridList;
            gridControl1.DataSource = source;
        }
        public void setGridStyle() 
        {
            gridView1.HorzScrollVisibility = ScrollVisibility.Always;
            for (int i = 0; i < gridView1.Columns.Count; i++)
            {
                gridView1.Columns[i].MinWidth = 70;
            }
            gridView1.Columns[0].Visible = false;
            gridView1.Columns["RegisterNo"].OptionsColumn.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<CounterClass> count = new List<CounterClass>();
            Engine.Engine RowInsert = new Engine.Engine();
            HR_Employees items = new HR_Employees();
            count = RowInsert.getCounter();
            items.RegisterNo = count[0].Prefix + RowInsert.generate(Convert.ToInt16(count[0].Length), Convert.ToInt16(count[0].Counter), gridView1.RowCount);
            try { items.Name = gridView1.GetFocusedRowCellValue("Name").ToString(); } catch { items.Name = ""; }
            try { items.Surname = gridView1.GetFocusedRowCellValue("Surname").ToString(); } catch { items.Surname = ""; }
            try { items.Name2 = gridView1.GetFocusedRowCellValue("Name2").ToString(); } catch { items.Name2 = ""; }
            try { items.Surname2 = gridView1.GetFocusedRowCellValue("Surname2").ToString(); } catch { items.Surname2 = ""; }
            try { items.FatherName2 = gridView1.GetFocusedRowCellValue("FatherName2").ToString(); } catch { items.FatherName2 = ""; }
            try { items.CountryOfBirth = gridView1.GetFocusedRowCellValue("CountryOfBirth").ToString(); } catch { items.CountryOfBirth = ""; }
            try { items.Gender = gridView1.GetFocusedRowCellValue("Gender").ToString(); } catch { items.Gender = ""; }
            try { items.EmployeesPhotoId = gridView1.GetFocusedRowCellValue("EmployeesPhotoId").ToString(); } catch { items.EmployeesPhotoId = ""; }
            try { items.Email = gridView1.GetFocusedRowCellValue("Email").ToString(); } catch { items.Email = ""; }
            try { items.PassportNo = gridView1.GetFocusedRowCellValue("PassportNo").ToString(); } catch { items.PassportNo = ""; }
            try { items.Phone1 = gridView1.GetFocusedRowCellValue("Phone1").ToString(); } catch { items.Phone1 = ""; }
            try { items.IsLeft = gridView1.GetFocusedRowCellValue("IsLeft").ToString(); } catch { items.IsLeft = ""; }
            try { items.NotBack = gridView1.GetFocusedRowCellValue("NotBack").ToString(); } catch { items.NotBack = ""; }
            try { items.CreatedBy = gridView1.GetFocusedRowCellValue("CreatedBy").ToString(); } catch { items.CreatedBy = ""; }
            try { items.UpdatedBy = gridView1.GetFocusedRowCellValue("UpdatedBy").ToString(); } catch { items.UpdatedBy = ""; }
            if (gridView1.GetFocusedRowCellValue("RegisterNo") == null)
            {
                RowInsert.RowEkle(items);
                int row = gridView1.GetFocusedDataSourceRowIndex();
                refleshGrid();
                gridControl1.Refresh();
                gridView1.FocusedRowHandle = row;
            }
            else
            {
                MessageBox.Show("Lütfen Önce Yeni Kayıt Oluşturun");
            }
        }

        private void gridView1_RowUpdated_1(object sender, RowObjectEventArgs e)
        {
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            gridView1.AddNewRow();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Engine.Engine Row = new Engine.Engine();
            HR_Employees items = new HR_Employees();
            try { items.RegisterNo = gridView1.GetFocusedRowCellValue("RegisterNo").ToString(); } catch { items.RegisterNo = ""; }
            try { items.Name = gridView1.GetFocusedRowCellValue("Name").ToString(); } catch { items.Name = ""; }
            try { items.Surname = gridView1.GetFocusedRowCellValue("Surname").ToString(); } catch { items.Surname = ""; }
            try { items.Name2 = gridView1.GetFocusedRowCellValue("Name2").ToString(); } catch { items.Name2 = ""; }
            try { items.Surname2 = gridView1.GetFocusedRowCellValue("Surname2").ToString(); } catch { items.Surname2 = ""; }
            try { items.FatherName2 = gridView1.GetFocusedRowCellValue("FatherName2").ToString(); } catch { items.FatherName2 = ""; }
            try { items.CountryOfBirth = gridView1.GetFocusedRowCellValue("CountryOfBirth").ToString(); } catch { items.CountryOfBirth = ""; }
            try { items.Gender = gridView1.GetFocusedRowCellValue("Gender").ToString(); } catch { items.Gender = ""; }
            try { items.EmployeesPhotoId = gridView1.GetFocusedRowCellValue("EmployeesPhotoId").ToString(); } catch { items.EmployeesPhotoId = ""; }
            try { items.Email = gridView1.GetFocusedRowCellValue("Email").ToString(); } catch { items.Email = ""; }
            try { items.PassportNo = gridView1.GetFocusedRowCellValue("PassportNo").ToString(); } catch { items.PassportNo = ""; }
            try { items.Phone1 = gridView1.GetFocusedRowCellValue("Phone1").ToString(); } catch { items.Phone1 = ""; }
            try { items.IsLeft = gridView1.GetFocusedRowCellValue("IsLeft").ToString(); } catch { items.IsLeft = ""; }
            try { items.NotBack = gridView1.GetFocusedRowCellValue("NotBack").ToString(); } catch { items.NotBack = ""; }
            try { items.CreatedBy = gridView1.GetFocusedRowCellValue("CreatedBy").ToString(); } catch { items.CreatedBy = ""; }
            try { items.UpdatedBy = gridView1.GetFocusedRowCellValue("UpdatedBy").ToString(); } catch { items.UpdatedBy = ""; }
            if (gridView1.GetFocusedRowCellValue("RegisterNo") != null)
            {
                Row.RowGuncelle(items);
                int row = gridView1.GetFocusedDataSourceRowIndex();
                refleshGrid();
                gridControl1.Refresh();
                gridView1.FocusedRowHandle = row;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Engine.Engine Row = new Engine.Engine();
            string registerNo = ""; 
             try { registerNo = gridView1.GetFocusedRowCellValue("RegisterNo").ToString(); } catch { registerNo = ""; };
            Row.RowSil(registerNo);
            int row = gridView1.GetFocusedDataSourceRowIndex() - 1;
            refleshGrid();
            gridControl1.Refresh();
            gridView1.FocusedRowHandle = row;
        }
    }
}
