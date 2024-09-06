using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Spire.PdfViewer.Forms;
using TerraVerdeRealEstate.UC__Client_;
using TerraVerdeRealEstate.UC__Seller_;

namespace TerraVerdeRealEstate._2_UC__Seller_
{

    public partial class UC_S_PropertyDocumentation : UserControl
    {
        public string UploadedPDFFilePath { get; private set; }
        public UC_S_PropertyDocumentation()
        {
            InitializeComponent();
        }

        #region Validation

        private void document_category_Validating(object sender, CancelEventArgs e)
        {
            if (cb_documentcategory.Text == "") { e.Cancel = true; cb_documentcategory.Focus(); error_pname.SetError(lbl_documentcategory, "This field is required!"); }
            else { e.Cancel = true; error_pname.SetError(lbl_documentcategory, null); }
        }
        private void document_type_Validating(object sender, CancelEventArgs e)
        {
            if (cb_documenttype.Text == "") { e.Cancel = true; cb_documenttype.Focus(); error_pname.SetError(lbl_documenttype, "This field is required!"); }
            else { e.Cancel = true; error_pname.SetError(lbl_documenttype, null); }
        }
        private void document_description_Validating(object sender, CancelEventArgs e)
        {
            if (txt_documentdescription.Text == "") { e.Cancel = true; txt_documentdescription.Focus(); error_pname.SetError(lbl_documentdescription, "This field is required!"); }
            else { e.Cancel = true; error_pname.SetError(lbl_documentdescription, null); }
        }
        private void document_file_Validating(object sender, CancelEventArgs e)
        {
            if (lbl_documentfile.Text == "No document file uploaded..") { e.Cancel = true; lbl_documentfile.Focus(); error_pname.SetError(lbl_documentfile, "Please upload the necessary property document"); }
            else { e.Cancel = true; error_pname.SetError(lbl_documentfile, null); }
        }
        private void resettxt()
        {
            if (string.IsNullOrWhiteSpace(cb_documentcategory.Text)) { cb_documentcategory.Text = ""; }
            if (string.IsNullOrWhiteSpace(cb_documenttype.Text)) { cb_documenttype.Text = ""; }
            if (string.IsNullOrWhiteSpace(txt_documentdescription.Text)) { txt_documentdescription.Text = ""; }
        }

        #endregion


        private void btn_saveproperty_Click(object sender, EventArgs e)
        {
            resettxt();
            ValidateChildren(ValidationConstraints.Enabled);
            UploadPDFToDatabase();
            UC_C_Properties.passBuyOrRent = "";
            UC_S_Properties.sell = "";
        }

        private void btn_uploadFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "PDF Files|*.pdf";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                UploadedPDFFilePath = openFileDialog1.FileName;
                pdfViewer1.LoadFromFile(UploadedPDFFilePath);

                // Extract the file name from the path and assign it to lbl_documentfile
                lbl_documentfile.Text = Path.GetFileName(UploadedPDFFilePath);
            }
        }

        public void UploadPDFToDatabase()
        {
            if (!string.IsNullOrEmpty(UploadedPDFFilePath))
            {
                // Read the content of the PDF file
                byte[] pdfBytes = File.ReadAllBytes(UploadedPDFFilePath);

                // Your MySQL connection string
                string connstr = "server=localhost;user=root;password='';database=terraverde_db";

                // SQL command to get the latest PROPERTY_ID from the property table
                string getLatestPropertyIdSql = "SELECT PROPERTY_ID FROM property ORDER BY PROPERTY_ID DESC LIMIT 1";

                using (MySqlConnection connection = new MySqlConnection(connstr))
                {
                    connection.Open();

                    // Fetch the latest PROPERTY_ID
                    int latestPropertyId = 0;
                    using (MySqlCommand getLatestPropertyIdCommand = new MySqlCommand(getLatestPropertyIdSql, connection))
                    {
                        object result = getLatestPropertyIdCommand.ExecuteScalar();
                        if (result != null)
                        {
                            latestPropertyId = Convert.ToInt32(result);
                        }
                    }

                    // SQL command to insert the PDF content and additional fields into the database
                    string sql = "INSERT INTO property_documents (PROPERTY_ID, DOCUMENT_FILE, DOCUMENT_CATEGORY, DOCUMENT_TYPE, DOCUMENT_DESCRIPTION, DOCUMENT_STATUS, UPLOADED_DATE) VALUES (@PropertyId, @DocumentContent, @DocumentCategory, @DocumentType, @DocumentDescription, @DocumentStatus, @UploadedDate)";

                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        // Add the PROPERTY_ID as a parameter
                        command.Parameters.AddWithValue("@PropertyId", latestPropertyId);
                        // Add the PDF content as a parameter
                        command.Parameters.AddWithValue("@DocumentContent", pdfBytes);
                        // Add the additional fields as parameters
                        command.Parameters.AddWithValue("@DocumentCategory", cb_documentcategory.Text);
                        command.Parameters.AddWithValue("@DocumentType", cb_documenttype.Text);
                        command.Parameters.AddWithValue("@DocumentDescription", txt_documentdescription.Text);
                        // Add DOCUMENT_STATUS as "Pending"
                        command.Parameters.AddWithValue("@DocumentStatus", "Pending");
                        // Add UPLOADED_DATE as today's date
                        command.Parameters.AddWithValue("@UploadedDate", DateTime.Now);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("PDF file and additional information uploaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BacktoProperty();
            }
            else
            {
                MessageBox.Show("No PDF file has been uploaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        public void BacktoProperty()
        {
            UC_S_Properties uc = new UC_S_Properties();
            uc.Dock = DockStyle.Fill;
            var panelcontainerParent = this.Parent as Panel;
            var formParent = panelcontainerParent.TopLevelControl as Form;
            ((Panel)formParent.Controls.Find("panelmain_seller", true)[0]).Controls.Clear();
            ((Panel)formParent.Controls.Find("panelmain_seller", true)[0]).Controls.Add(uc);
            uc.BringToFront();

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

            
        }

        private int GetLatestPropertyId()
        {
            string connstr = "server=localhost;user=root;password='';database=terraverde_db";
            string getLatestPropertyIdSql = "SELECT PROPERTY_ID FROM property ORDER BY PROPERTY_ID DESC LIMIT 1";
            using (MySqlConnection connection = new MySqlConnection(connstr))
            {
                connection.Open();
                using (MySqlCommand getLatestPropertyIdCommand = new MySqlCommand(getLatestPropertyIdSql, connection))
                {
                    object result = getLatestPropertyIdCommand.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                }
            }
            return 0; // Return 0 if no property exists
        }

        private void ExecuteSqlCommand(string sql)
        {
            string connstr = "server=localhost;user=root;password='';database=terraverde_db";
            using (MySqlConnection connection = new MySqlConnection(connstr))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        private void UC_S_PropertyDocumentation_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            string deleteLastPropertySql = "DELETE FROM property WHERE PROPERTY_ID = (SELECT MAX(PROPERTY_ID) FROM property)";
            ExecuteSqlCommand(deleteLastPropertySql);

            int latestPropertyId = GetLatestPropertyId();

            string resetAutoIncrementSql = $"ALTER TABLE property AUTO_INCREMENT = {latestPropertyId + 1}";
            ExecuteSqlCommand(resetAutoIncrementSql);

            UC_S_SellingProperty uc = new UC_S_SellingProperty();
            uc.Dock = DockStyle.Fill;
            var panelcontainerParent = this.Parent as Panel;
            var formParent = panelcontainerParent.TopLevelControl as Form;
            ((Panel)formParent.Controls.Find("panelmain_seller", true)[0]).Controls.Clear();
            ((Panel)formParent.Controls.Find("panelmain_seller", true)[0]).Controls.Add(uc);
            uc.BringToFront();
        }
    }
}