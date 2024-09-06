namespace TerraVerdeRealEstate._2_UC__Seller_
{
    partial class UC_S_PropertyDocumentation
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.error_pname = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_saveproperty = new System.Windows.Forms.Button();
            this.btn_uploadFiles = new System.Windows.Forms.Button();
            this.txt_documentdescription = new System.Windows.Forms.RichTextBox();
            this.cb_documenttype = new System.Windows.Forms.ComboBox();
            this.lbl_documenttype = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_documentdescription = new System.Windows.Forms.Label();
            this.cb_documentcategory = new System.Windows.Forms.ComboBox();
            this.lbl_documentcategory = new System.Windows.Forms.Label();
            this.lbl_documentupload = new System.Windows.Forms.Label();
            this.lbl_documentfile = new System.Windows.Forms.Label();
            this.pdfViewer1 = new Spire.PdfViewer.Forms.PdfViewer();
            ((System.ComponentModel.ISupportInitialize)(this.error_pname)).BeginInit();
            this.SuspendLayout();
            // 
            // error_pname
            // 
            this.error_pname.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error_pname.ContainerControl = this;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.btn_cancel.Location = new System.Drawing.Point(376, 630);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(313, 44);
            this.btn_cancel.TabIndex = 32;
            this.btn_cancel.TabStop = false;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click_1);
            // 
            // btn_saveproperty
            // 
            this.btn_saveproperty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_saveproperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.btn_saveproperty.Location = new System.Drawing.Point(43, 630);
            this.btn_saveproperty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_saveproperty.Name = "btn_saveproperty";
            this.btn_saveproperty.Size = new System.Drawing.Size(313, 44);
            this.btn_saveproperty.TabIndex = 31;
            this.btn_saveproperty.TabStop = false;
            this.btn_saveproperty.Text = "Save";
            this.btn_saveproperty.UseVisualStyleBackColor = true;
            this.btn_saveproperty.Click += new System.EventHandler(this.btn_saveproperty_Click);
            // 
            // btn_uploadFiles
            // 
            this.btn_uploadFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_uploadFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.btn_uploadFiles.Location = new System.Drawing.Point(47, 438);
            this.btn_uploadFiles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_uploadFiles.Name = "btn_uploadFiles";
            this.btn_uploadFiles.Size = new System.Drawing.Size(259, 44);
            this.btn_uploadFiles.TabIndex = 25;
            this.btn_uploadFiles.TabStop = false;
            this.btn_uploadFiles.Text = "Upload File";
            this.btn_uploadFiles.UseVisualStyleBackColor = true;
            this.btn_uploadFiles.Click += new System.EventHandler(this.btn_uploadFiles_Click);
            // 
            // txt_documentdescription
            // 
            this.txt_documentdescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_documentdescription.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_documentdescription.Location = new System.Drawing.Point(47, 192);
            this.txt_documentdescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_documentdescription.Name = "txt_documentdescription";
            this.txt_documentdescription.Size = new System.Drawing.Size(643, 102);
            this.txt_documentdescription.TabIndex = 87;
            this.txt_documentdescription.Text = "";
            // 
            // cb_documenttype
            // 
            this.cb_documenttype.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_documenttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_documenttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cb_documenttype.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cb_documenttype.FormattingEnabled = true;
            this.cb_documenttype.Items.AddRange(new object[] {
            "Title Deed",
            "Rental Agreement"});
            this.cb_documenttype.Location = new System.Drawing.Point(419, 102);
            this.cb_documenttype.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_documenttype.Name = "cb_documenttype";
            this.cb_documenttype.Size = new System.Drawing.Size(271, 32);
            this.cb_documenttype.TabIndex = 86;
            this.cb_documenttype.TabStop = false;
            // 
            // lbl_documenttype
            // 
            this.lbl_documenttype.AutoSize = true;
            this.lbl_documenttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_documenttype.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_documenttype.Location = new System.Drawing.Point(415, 76);
            this.lbl_documenttype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_documenttype.Name = "lbl_documenttype";
            this.lbl_documenttype.Size = new System.Drawing.Size(164, 24);
            this.lbl_documenttype.TabIndex = 85;
            this.lbl_documenttype.Text = "Document Type:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(41, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 37);
            this.label2.TabIndex = 84;
            this.label2.Text = "Property Documentation";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_documentdescription
            // 
            this.lbl_documentdescription.AutoSize = true;
            this.lbl_documentdescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_documentdescription.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_documentdescription.Location = new System.Drawing.Point(43, 166);
            this.lbl_documentdescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_documentdescription.Name = "lbl_documentdescription";
            this.lbl_documentdescription.Size = new System.Drawing.Size(222, 24);
            this.lbl_documentdescription.TabIndex = 83;
            this.lbl_documentdescription.Text = "Document Description:";
            // 
            // cb_documentcategory
            // 
            this.cb_documentcategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_documentcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_documentcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cb_documentcategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cb_documentcategory.FormattingEnabled = true;
            this.cb_documentcategory.Items.AddRange(new object[] {
            "Legal",
            "Lease"});
            this.cb_documentcategory.Location = new System.Drawing.Point(47, 102);
            this.cb_documentcategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_documentcategory.Name = "cb_documentcategory";
            this.cb_documentcategory.Size = new System.Drawing.Size(271, 32);
            this.cb_documentcategory.TabIndex = 82;
            this.cb_documentcategory.TabStop = false;
            // 
            // lbl_documentcategory
            // 
            this.lbl_documentcategory.AutoSize = true;
            this.lbl_documentcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_documentcategory.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_documentcategory.Location = new System.Drawing.Point(43, 76);
            this.lbl_documentcategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_documentcategory.Name = "lbl_documentcategory";
            this.lbl_documentcategory.Size = new System.Drawing.Size(200, 24);
            this.lbl_documentcategory.TabIndex = 81;
            this.lbl_documentcategory.Text = "Document Category:";
            // 
            // lbl_documentupload
            // 
            this.lbl_documentupload.AutoSize = true;
            this.lbl_documentupload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_documentupload.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_documentupload.Location = new System.Drawing.Point(43, 346);
            this.lbl_documentupload.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_documentupload.Name = "lbl_documentupload";
            this.lbl_documentupload.Size = new System.Drawing.Size(292, 24);
            this.lbl_documentupload.TabIndex = 88;
            this.lbl_documentupload.Text = "Upload necessary documents:";
            // 
            // lbl_documentfile
            // 
            this.lbl_documentfile.AutoSize = true;
            this.lbl_documentfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_documentfile.Location = new System.Drawing.Point(43, 399);
            this.lbl_documentfile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_documentfile.Name = "lbl_documentfile";
            this.lbl_documentfile.Size = new System.Drawing.Size(248, 24);
            this.lbl_documentfile.TabIndex = 91;
            this.lbl_documentfile.Text = "No document file uploaded..";
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.BackColor = System.Drawing.Color.DimGray;
            this.pdfViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pdfViewer1.CanPrint = false;
            this.pdfViewer1.CanSave = false;
            this.pdfViewer1.FindTextHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(153)))), ((int)(((byte)(193)))), ((int)(((byte)(218)))));
            this.pdfViewer1.FormFillEnabled = false;
            this.pdfViewer1.IgnoreCase = false;
            this.pdfViewer1.IsToolBarVisible = false;
            this.pdfViewer1.Location = new System.Drawing.Point(757, 26);
            this.pdfViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pdfViewer1.MultiPagesThreshold = 60;
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.OnRenderPageExceptionEvent = null;
            this.pdfViewer1.Size = new System.Drawing.Size(664, 593);
            this.pdfViewer1.TabIndex = 92;
            this.pdfViewer1.TabStop = false;
            this.pdfViewer1.Text = "pdfViewer1";
            this.pdfViewer1.Threshold = 60;
            this.pdfViewer1.ViewerBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            // 
            // UC_S_PropertyDocumentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.pdfViewer1);
            this.Controls.Add(this.lbl_documentfile);
            this.Controls.Add(this.lbl_documentupload);
            this.Controls.Add(this.txt_documentdescription);
            this.Controls.Add(this.cb_documenttype);
            this.Controls.Add(this.lbl_documenttype);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_documentdescription);
            this.Controls.Add(this.cb_documentcategory);
            this.Controls.Add(this.lbl_documentcategory);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_saveproperty);
            this.Controls.Add(this.btn_uploadFiles);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1467, 711);
            this.MinimumSize = new System.Drawing.Size(1467, 711);
            this.Name = "UC_S_PropertyDocumentation";
            this.Size = new System.Drawing.Size(1467, 711);
            this.Load += new System.EventHandler(this.UC_S_PropertyDocumentation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error_pname)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider error_pname;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_saveproperty;
        private System.Windows.Forms.Button btn_uploadFiles;
        private System.Windows.Forms.RichTextBox txt_documentdescription;
        private System.Windows.Forms.ComboBox cb_documenttype;
        private System.Windows.Forms.Label lbl_documenttype;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_documentdescription;
        private System.Windows.Forms.ComboBox cb_documentcategory;
        private System.Windows.Forms.Label lbl_documentcategory;
        private System.Windows.Forms.Label lbl_documentupload;
        private System.Windows.Forms.Label lbl_documentfile;
        private Spire.PdfViewer.Forms.PdfViewer pdfViewer1;
    }
}
