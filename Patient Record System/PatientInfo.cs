using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Patient_Record_System
{
    public partial class PatientInfo : Form
    {
        SqlConnection nCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\saad\Documents\DB.mdf;Integrated Security=True;Connect Timeout=30");

        public PatientInfo()
        {
            InitializeComponent();
        }

        int patientID = 0;
        int visitID = 0;
        //DateTimePicker datePicker;
        //DateTimePicker timePicker;

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                // Master
                int _PaitentID = 0;
                nCon.Open();
                SqlCommand cmd = new SqlCommand("PatientAddOrUpdate", nCon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pID", patientID);
                cmd.Parameters.AddWithValue("@pName", pName.Text);
                cmd.Parameters.AddWithValue("@pContant", pContact.Text);
                cmd.Parameters.AddWithValue("@pGender", pGender.Text);
                cmd.Parameters.AddWithValue("@pEmail", pEmail.Text);
                cmd.Parameters.AddWithValue("@gName", gName.Text);
                cmd.Parameters.AddWithValue("@gContact", gContact.Text);
                cmd.Parameters.AddWithValue("@mStatus", pStatus.Text);
                cmd.Parameters.AddWithValue("@pAge", pAge.Text);
                cmd.Parameters.AddWithValue("@BT", Convert.ToInt32(pBT.SelectedValue));
                _PaitentID = Convert.ToInt32(cmd.ExecuteScalar());
                nCon.Close();

                // Details

                nCon.Open();
                int _visitID = 0;

                SqlCommand nCmd = nCon.CreateCommand();
                nCmd.CommandType = CommandType.Text;
                nCmd.CommandText = "INSERT INTO Visit VALUES ('" + _PaitentID + "', '" + pVisitDate.Value.ToString() + "', '" + pVisitTime.Value.ToString() + "')";
                //nCmd.CommandType = CommandType.StoredProcedure;
                //nCmd.Parameters.AddWithValue("@vID", visitID);
                //nCmd.Parameters.AddWithValue("@pID", _PaitentID);
                //nCmd.Parameters.AddWithValue("@vDate", pVisitDate.Value.ToString());
                //nCmd.Parameters.AddWithValue("@vTime", pVisitTime.Value.ToShortTimeString());
                //_visitID = Convert.ToInt32(nCmd.ExecuteScalar());
                nCmd.ExecuteNonQuery();
                nCon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }


            disp_Visits();
            disp_Patient();

        }

        bool Validation()
        {
            bool isValid = true;
            if (pName.Text.Trim() == "")
            {
                MessageBox.Show("Enter Patient Details");
                isValid = false;
            }

            //add more validations if needed
            return isValid;
        }

        public void disp_Patient()
        {

            nCon.Open();

            SqlCommand cmd = nCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Patient";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvPatient.DataSource = dt;
            nCon.Close();

        }

        public void disp_Visits()
        {
            nCon.Open();

            SqlCommand cmd = nCon.CreateCommand();
            cmd.CommandText = "SELECT * FROM Visit WHERE PatientID=@pID";
            cmd.Parameters.AddWithValue("@pID", patientID);
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvVisits.DataSource = dt;
            nCon.Close();
        }

        private void PatientInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'visitsDataSet.Visit' table. You can move, or remove it, as needed.
            // Date Picker for visit.
            //datePicker = new DateTimePicker
            //{
            //    Format = DateTimePickerFormat.Short,
            //    Visible = false,
            //    Width = 100
            //};
            //dgvVisits.Controls.Add(datePicker);
            //datePicker.ValueChanged += this.dtpVisit_ValueChanged;

            ////// Time picker for visit
            //timePicker = new DateTimePicker
            //{
            //    Format = DateTimePickerFormat.Time,
            //    Visible = false,
            //    Width = 100
            //};
            //dgvVisits.Controls.Add(timePicker);
            //timePicker.ValueChanged += this.dtpVisit1_ValueChanged;
            //dgvVisits.CellBeginEdit += this.dgvVisits_CellBeginEdit;
            //dgvVisits.CellEndEdit += this.dgvVisits_CellEndEdit;
            BloodGroupComboFill();
            disp_Patient();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            Clear();

        }

        public void Clear()
        {
            pName.Text = pContact.Text = pEmail.Text = gName.Text = gContact.Text = pEmail.Text = "";
            pGender.SelectedIndex = pStatus.SelectedIndex = pBT.SelectedIndex = pAge.SelectedIndex = 0;
            if (dgvVisits.DataSource == null)
            {
                dgvVisits.Rows.Clear();
            }
            else
            {
                dgvVisits.DataSource = (dgvVisits.DataSource as DataTable).Clone();
            }
            patientID = 0;
            btnSave.Text = "Save";

        }


        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            nCon.Open();

            SqlCommand cmd = nCon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Patient WHERE patientName LIKE '" + txtNameSearch.Text + "%'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvPatient.DataSource = dt;
            nCon.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            nCon.Open();

            SqlCommand cmd = new SqlCommand("PatientDelete", nCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pID", patientID);
            
            cmd.ExecuteNonQuery();

            nCon.Close();
            Clear();
            disp_Patient();
        }

        void BloodGroupComboFill()
        {
            nCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BloodType", nCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow topItem = dt.NewRow();
            topItem[0] = 0;
            topItem[1] = "-Select-";
            dt.Rows.InsertAt(topItem, 0);
            pBT.ValueMember = "btID";
            pBT.DisplayMember = "Blood Type";
            pBT.DataSource = dt;
            nCon.Close();
        }

        private void dgvPatient_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPatient.CurrentRow.Index != -1)
            {
                DataGridViewRow currentRow = dgvPatient.CurrentRow;
                patientID = Convert.ToInt32(currentRow.Cells[0].Value);
                nCon.Open();
                SqlDataAdapter da = new SqlDataAdapter("PatientViewByID", nCon);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@pID", patientID);
                DataSet ds = new DataSet();
                da.Fill(ds);

                //Master
                DataRow dr = ds.Tables[0].Rows[0];
                pName.Text = dr["patientName"].ToString();
                pContact.Text = dr["patientContact"].ToString();
                pAge.Text = dr["patientAge"].ToString();
                pEmail.Text = dr["Email"].ToString();
                gName.Text = dr["guardianName"].ToString();
                gContact.Text = dr["guardianContact"].ToString();
                pBT.SelectedValue = Convert.ToInt32(dr["btID"].ToString());
                pStatus.Text = dr["Marital Status"].ToString();
                pGender.Text = dr["Gender"].ToString();
                btnSave.Text = "Update";
                tabControl.SelectedIndex = 0;
                nCon.Close();

                disp_Visits();

            }
        }

        private void dgvVisits_UserDeletedRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DataGridViewRow dgvRow = dgvVisits.CurrentRow;
            if(dgvRow.Cells["dgvtxtVistID"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Do you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    nCon.Open();
                    SqlCommand cmd = new SqlCommand("VisitDelete", nCon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@vID", Convert.ToInt32(dgvRow.Cells["dgvtxtVisitID"].Value));
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }


        //    private void dgvVisits_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        //    {
        //        try
        //        {
        //            if ((dgvVisits.Focused) && (dgvVisits.CurrentCell.ColumnIndex == 1))
        //            {
        //                datePicker.Location = dgvVisits.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
        //                datePicker.Visible = true;
        //                if (dgvVisits.CurrentCell.Value != DBNull.Value)
        //                {
        //                    datePicker.Value = (DateTime)dgvVisits.CurrentCell.Value;
        //                }
        //                else
        //                {
        //                    datePicker.Value = DateTime.Today;
        //                }
        //            }
        //            if ((dgvVisits.Focused) && (dgvVisits.CurrentCell.ColumnIndex == 2))
        //            {
        //                timePicker.Location = dgvVisits.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
        //                timePicker.Visible = true;
        //                if (dgvVisits.CurrentCell.Value != DBNull.Value)
        //                {
        //                    timePicker.Value = (DateTime)dgvVisits.CurrentCell.Value;
        //                }
        //                else
        //                {
        //                    timePicker.Value = DateTime.Now;
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {

        //            MessageBox.Show(ex.Message);
        //        }
        //    }

        //    private void dgvVisits_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        //    {
        //        try
        //        {
        //            if ((dgvVisits.Focused) && (dgvVisits.CurrentCell.ColumnIndex == 1))
        //            {
        //                dgvVisits.CurrentCell.Value = datePicker.Value.Date;
        //            }
        //            if ((dgvVisits.Focused) && (dgvVisits.CurrentCell.ColumnIndex == 2))
        //            {
        //                timePicker.Format = DateTimePickerFormat.Time;
        //                timePicker.ShowUpDown = true;
        //            }

        //        }
        //        catch (Exception ex)
        //        {

        //            MessageBox.Show(ex.Message);
        //        }
        //    }

        //    private void dtpVisit_ValueChanged(object sender, EventArgs e)
        //    {
        //        dgvVisits.CurrentCell.Value = datePicker.Text;


        //    }

        //    private void dtpVisit1_ValueChanged(object sender, EventArgs e)
        //    {

        //        dgvVisits.CurrentCell.Value = timePicker.Text;

        //    }
        //}

    }
}
