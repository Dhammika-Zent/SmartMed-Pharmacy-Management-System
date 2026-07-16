using System;
using System.Windows.Forms;
using SmartMed.Helpers;   // ValidationHelper

namespace SmartMed.Forms
{
    public partial class PrescriptionUploadForm : Form
    {
        // =====================================================
        // Public property to retrieve the validated file path
        // =====================================================
        public string PrescriptionFilePath { get; private set; }

        // =====================================================
        // Constructor
        // =====================================================
        public PrescriptionUploadForm()
        {
            InitializeComponent();

            // Set up the form to work as a modal dialog (overrides designer settings)
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new System.Drawing.Size(500, 260);   // Compact dialog size

            // Repurpose the existing buttons
            btnSubmit.Text = "Upload";
            btnSubmit.Click += BtnUpload_Click;

            btnRemove.Text = "Cancel";
            btnRemove.Click += (s, e) =>
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            };

            // File browse button
            btnBrowse.Click += BtnBrowse_Click;

            // Hide the order combo box (not needed for checkout upload)
            lblOrder.Visible = false;
            cmbOrder.Visible = false;

            // Notes are optional; keep them but not mandatory
            lblNotes.Text = "Notes (optional):";
        }

        // =====================================================
        // Event Handlers
        // =====================================================

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "Prescription Files|*.pdf;*.jpg;*.jpeg;*.png";
                openFile.Title = "Select a Prescription File";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    txtPrescriptionFile.Text = openFile.FileName;
                }
            }
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            string filePath = txtPrescriptionFile.Text;

            // Use the shared validation helper (no business logic here)
            string error = ValidationHelper.ValidatePrescriptionFile(filePath);
            if (error != null)
            {
                MessageBox.Show(error, "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Store the path and close with OK
            PrescriptionFilePath = filePath;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}