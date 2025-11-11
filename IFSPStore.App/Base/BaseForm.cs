using Mysqlx.Crud;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFSPStore.App.Base
{
    public partial class BaseForm : MaterialForm
    {
        #region Variables
        bool isEditMode = false;
        #endregion

        #region Constructor Method

        public BaseForm()
        {
            InitializeComponent();
        }

        #endregion

        #region events

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel?", @"IFSP Store", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClearFields();
                tabControlRegister.SelectedIndex = 1;
            }
        }

        #endregion

        #region Methods

        private void ClearFields()
        {
            isEditMode = false;
            foreach (var control in tabPageRegister.Controls)
            {
                if (control is MaterialTextBoxEdit textBox)
                    textBox.Clear();
                if (control is MaterialMaskedTextBox maskedTextBox)
                    maskedTextBox.Clear();
            }
        }

        protected virtual void New()
        {
            ClearFields();
            tabControlRegister.SelectedIndex = 0;
            tabPageRegister.Focus();
        }

        protected virtual void Save()
        {

        }

        protected virtual void Delete(int id)
        {

        }

        protected virtual void Edit()
        {
            if (dataGridViewList.SelectedRows.Count > 0)
            {
                isEditMode = true;
                var record = dataGridViewList.SelectedRows[0];
                GridToForm(record);
                tabControlRegister.SelectedIndex = 0;
                tabPageRegister.Focus();
            }
            else
            {
                MessageBox.Show("Please select a record to edit.", "IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected virtual void GridToForm(DataGridViewRow? record)
        {
        }

        protected virtual void PopulateGrid()
        {
        }

        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            New();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dataGridViewList.SelectedRows.Count > 0) { 
                if (MessageBox.Show("Are you sure you want to delete this record?", @"IFSP Store", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var id = (int)dataGridViewList.SelectedRows[0].Cells["Id"].Value;
                    Delete(id);
                    PopulateGrid();
                }
            }
            else
            {
                               MessageBox.Show("Please select a record to delete.", "IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Enter()
        {

        }
    }
}
