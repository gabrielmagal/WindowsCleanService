using Carteira_de_Senhas;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace WindowsCleanService
{
    public partial class FormMain : Form
    {
        private IniFile iniFile = new IniFile();

        public FormMain()
        {
            InitializeComponent();

            cbTemp.Checked = iniFile.Read("temp", "configuracoes").Equals("True");
            cbPrefetch.Checked = iniFile.Read("prefetch", "configuracoes").Equals("True");
            cbInstallerTemp.Checked = iniFile.Read("installertemp", "configuracoes").Equals("True");
            cbDownloadTemp.Checked = iniFile.Read("softwaredistribution", "configuracoes").Equals("True");
            cbWindowsLogs.Checked = iniFile.Read("windowslogs", "configuracoes").Equals("True");
            cbRecycleBin.Checked = iniFile.Read("recyclebin", "configuracoes").Equals("True");
            cbUserTemp.Checked = iniFile.Read("usertemp", "configuracoes").Equals("True");
            cbWindowsTemp.Checked = iniFile.Read("windowstemp", "configuracoes").Equals("True");
            cbWindowsErrorReports.Checked = iniFile.Read("windowserros", "configuracoes").Equals("True");
            cbCleanMgr.Checked = iniFile.Read("cleanmgr", "configuracoes").Equals("True");
        }

        private void btn_execute_Click(object sender, EventArgs e)
        {
            long totalSize = 0;
            listBoxLogs.Items.Clear();
            iniFile.Write("temp", cbTemp.Checked.ToString(), "configuracoes");
            iniFile.Write("prefetch", cbPrefetch.Checked.ToString(), "configuracoes");
            iniFile.Write("installertemp", cbInstallerTemp.Checked.ToString(), "configuracoes");
            iniFile.Write("softwaredistribution", cbDownloadTemp.Checked.ToString(), "configuracoes");
            iniFile.Write("windowslogs", cbWindowsLogs.Checked.ToString(), "configuracoes");
            iniFile.Write("recyclebin", cbRecycleBin.Checked.ToString(), "configuracoes");
            iniFile.Write("usertemp", cbUserTemp.Checked.ToString(), "configuracoes");
            iniFile.Write("windowstemp", cbWindowsTemp.Checked.ToString(), "configuracoes");
            iniFile.Write("windowserros", cbWindowsErrorReports.Checked.ToString(), "configuracoes");
            iniFile.Write("cleanmgr", cbCleanMgr.Checked.ToString(), "configuracoes");

            string current_partition = Path.GetPathRoot(Environment.CurrentDirectory);

            if (cbTemp.Checked)
                totalSize += ClearFolder(Path.GetTempPath());

            if (cbPrefetch.Checked)
                totalSize += ClearFolder(Path.Combine(current_partition, "Windows", "Prefetch"));

            if (cbInstallerTemp.Checked)
                totalSize += ClearFolder(Path.Combine(current_partition, "Windows", "Installer"));

            if (cbDownloadTemp.Checked)
                totalSize += ClearFolder(Path.Combine(current_partition, "Windows", "SoftwareDistribution", "Download"));

            if (cbWindowsLogs.Checked)
                totalSize += ClearFolder(Path.Combine(current_partition, "Windows", "Logs"));

            if (cbRecycleBin.Checked)
                totalSize += ClearFolder(Path.Combine(current_partition, "$Recycle.Bin"));

            if (cbUserTemp.Checked)
                totalSize += ClearFolder(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Temp"));

            if (cbWindowsTemp.Checked)
                totalSize += ClearFolder(Path.Combine(current_partition, "Windows", "Temp"));

            if (cbWindowsErrorReports.Checked)
                totalSize += ClearFolder(Path.Combine(current_partition, "ProgramData", "Microsoft", "Windows", "WER", "ReportQueue"));

            if (cbCleanMgr.Checked)
                Process.Start(current_partition + @"\Windows\system32\cleanmgr.exe");

            MessageBox.Show($"Limpeza concluída com sucesso! {totalSize} bytes removidos.");
        }

        private long ClearFolder(string FolderName)
        {
            long totalSize = 0;
            DirectoryInfo dir = new DirectoryInfo(FolderName);
            foreach (FileInfo fi in dir.GetFiles())
            {
                try
                {
                    listBoxLogs.Items.Add(fi.Length + " bytes - " + fi.FullName);
                    totalSize += fi.Length;
                    Application.DoEvents();
                    fi.Delete();
                }
                catch (Exception) { }
            }

            foreach (DirectoryInfo di in dir.GetDirectories())
            {
                totalSize += ClearFolder(di.FullName);
                try
                {
                    listBoxLogs.Items.Add(di.FullName);
                    Application.DoEvents();
                    di.Delete();
                }
                catch (Exception) { }
            }
            return totalSize;
        }
    }
}
