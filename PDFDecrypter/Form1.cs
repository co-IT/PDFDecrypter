
using Spire.Pdf;
using Spire.Pdf.Security;

namespace coIT.Tools.PDFDecrypter
{
    public partial class Form1 : Form
    {
        private string _sourceDirectory;
        private string _destinationDirectory;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenDirectory_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                var result = folderDialog.ShowDialog();
                if (result == DialogResult.OK
                    && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    _sourceDirectory = folderDialog.SelectedPath;
                    _destinationDirectory = _sourceDirectory;
                    ctrl_SourceDirectory.Text = _sourceDirectory;
                    ctrl_SourceDirectory.Visible = true;
                    ctrl_SourceDirectory.Enabled = false;
                }
            }
        }

        private void chkOverwriteFiles_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOverwriteFiles.Checked)
            {
                chkOverwriteFiles.Text = "Ja";
                ctrl_DestinationDirectory.Visible = false;
                _destinationDirectory = _sourceDirectory;
                return;
            }

            using (var folderDialog = new FolderBrowserDialog())
            {
                var result = folderDialog.ShowDialog();
                if (result == DialogResult.OK
                    && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    _destinationDirectory = folderDialog.SelectedPath;
                    ctrl_DestinationDirectory.Text = _destinationDirectory;
                    chkOverwriteFiles.Text = "Nein";
                    ctrl_DestinationDirectory.Visible = true;
                    ctrl_DestinationDirectory.Enabled = false;
                }
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            btnDecrypt.Enabled = false;
            ctrl_Files.Items.Clear();

            var files = Directory.GetFiles(_sourceDirectory, "*.pdf", SearchOption.TopDirectoryOnly);
            if (!files.Any())
            {
                ctrl_Files.Items.Add("Keine Dateien im ausgewählten Verzeichnis gefunden.");
                ctrl_Files.Refresh();

                return;
            }

            foreach (var file in files)
            {
                DecryptFile(file);
            }

            btnDecrypt.Enabled = true;
        }

        private void DecryptFile(string file)
        {
            try
            {
                var pdf = new PdfDocument();
                pdf.LoadFromFile(file, ctrl_DecryptPassword.Text);

                if (!pdf.IsEncrypted)
                {
                    ctrl_Files.Items.Add($"{file} war nicht verschlüsselt und wird übersprungen.");
                    return;
                }

                // Passwort auf leeren String setzen
                pdf.Security.Encrypt(string.Empty, string.Empty, PdfPermissionsFlags.Default, PdfEncryptionKeySize.Key128Bit, ctrl_DecryptPassword.Text);

                string destinationFile = file;
                if (!chkOverwriteFiles.Checked)
                {
                    destinationFile = Path.Combine(_destinationDirectory, Path.GetFileName(file));
                }

                if (File.Exists(destinationFile))
                {
                    File.Delete(destinationFile);
                }

                pdf.SaveToFile(destinationFile, FileFormat.PDF);

                ctrl_Files.Items.Add($"Datei entschlüsselt: {destinationFile}");
            }
            catch (Exception ex)
            {
                ctrl_Files.Items.Add($"Fehler in Datei {file}");
                ctrl_Files.Items.Add(ex.Message);
            }
        }
    }
}