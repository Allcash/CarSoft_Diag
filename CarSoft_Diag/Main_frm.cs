using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarSoft_Diag
{
    public partial class Main_frm : Form
    {
        public Main_frm()
        {
            InitializeComponent();
        }

        public class XMLSetting
        {
            public string Resolution;
            public string ButtonSize;
            public bool UseOnline;
            public List<Software> Software;
        }

        public class Menu
        {
            public string Title;
        }

        public class Path
        {
            public string FileName;
            public string WindowStyle;
            public string CreateNoWindow;
            public string UseShellExecute;
            public string Verb;
        }

        public  class Software
        {
            public string Title;
            public string Type;
            public string Path;
            public string Description;
            public string Icon;
            public bool isFolder;
            public bool isEnable;
            public bool isVisible;
            public int Position_X;
            public int Position_Y;
            public List<Software> program;
            public List<Menu> menu;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Main_TabControl.ItemSize = new Size(0, 1);
            Main_TabControl.SizeMode = TabSizeMode.Fixed;
            Main_TabControl.TabStop = false;
            back_btn.Visible = false;

            //XMLSetting XMLSetting = new XMLSetting();
            //XMLSetting.Resolution = "FullScreen";
            //XMLSetting.ButtonSize = "30x30";
            //XMLSetting.UseOnline = false;

            //var BMW_catalog = new Software{Title = "BMW",Icon = @"D:\BMW.png", Description = "BMW",isEnable = true, isVisible = true, isFolder = true};
            //var BMW_ISTA_D = new Software { Description = "ISTA-D", Path = @"d:\CarSoft\Rheingold\TesterGUI\bin\ISTA.exe",isEnable = true, isVisible = true, isFolder = false };
            //var BMW_ISTA_P = new Software { Description = "ISTA-P", Path = @"d:\CarSoft\ISTAP\TesterGUI\bin\ISTA.exe", isEnable = true, isVisible = true, isFolder = false };
            //var BMW_Coding_tools = new Software { Description = "ISTA-P", Path = @"d:\CarSoft\ISTAP\TesterGUI\bin\ISTA.exe", isEnable = true, isVisible = true, isFolder = false };
            //var BMW_INPA = new Software { Description = "INPA", Path = @"d:\CarSoft\ISTAP\TesterGUI\bin\ISTA.exe", isEnable = true, isVisible = true, isFolder = false };
            //var BMW_NCSExpert = new Software { Description = "INPA", Path = @"d:\CarSoft\ISTAP\TesterGUI\bin\ISTA.exe", isEnable = true, isVisible = true, isFolder = false };
            //var BMW_NCSDummy = new Software { Description = "INPA", Path = @"d:\CarSoft\ISTAP\TesterGUI\bin\ISTA.exe", isEnable = true, isVisible = true, isFolder = false };
            //var BMW_WinKFP = new Software { Description = "INPA", Path = @"d:\CarSoft\ISTAP\TesterGUI\bin\ISTA.exe", isEnable = true, isVisible = true, isFolder = false };
            //var BMW_iTools = new Software { Description = "INPA", Path = @"d:\CarSoft\ISTAP\TesterGUI\bin\ISTA.exe", isEnable = true, isVisible = true, isFolder = false };

            //var BMW_DIS = new Software { Description = "INPA", Path = @"d:\CarSoft\ISTAP\TesterGUI\bin\ISTA.exe", isEnable = true, isVisible = true, isFolder = false };

            //XMLSetting.Software = new List<Software>();
            //XMLSetting.Software.Add(BMW_catalog);
            //XMLSetting.Software[0].program = new List<Software>();
            //XMLSetting.Software[0].program.Add(BMW_ISTA_D);
            //XMLSetting.Software[0].program.Add(BMW_ISTA_P);


            //XmlSerializer formatter = new XmlSerializer(typeof(XMLSetting));

            //using (FileStream fs = new FileStream(@"d:\1.xml", FileMode.OpenOrCreate))
            //{
            //    formatter.Serialize(fs, XMLSetting);
            //}
        }

        private void PSA_btn_Click(object sender, EventArgs e)
        {            
            Main_TabControl.SelectedTab = PSA_Tab;
            back_btn.Visible = true;
            
        }

        private void Bosch_btn_Click(object sender, EventArgs e)
        {
            Main_TabControl.SelectedTab = Bosch_Tab;
            back_btn.Visible = true;
        }

        private void Honda_btn_Click(object sender, EventArgs e)
        {
            Main_TabControl.SelectedTab = Honda_Tab;
            back_btn.Visible = true;
        }

        private void Renault_btn_Click(object sender, EventArgs e)
        {
            Main_TabControl.SelectedTab = Renault_Tab;
            back_btn.Visible = true;
        }

        private void Toyota_btn_Click(object sender, EventArgs e)
        {
            Main_TabControl.SelectedTab = Toyota_Tab;
            back_btn.Visible = true;
        }

        private void VAG_btn_Click(object sender, EventArgs e)
        {
            Main_TabControl.SelectedTab = VW_Tab;
            back_btn.Visible = true;
        }

        private void diagbox_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WindowStyle = ProcessWindowStyle.Normal;
            proc.FileName = @"C:\AWRoot\bin\launcher\LctPOLUX.exe";
            proc.WorkingDirectory = @"C:\AWRoot\bin\launcher\";
            proc.CreateNoWindow = false;
            proc.UseShellExecute = false;
            proc.Verb = "runas";
            Process.Start(proc);
        }


        private void esitronic_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WindowStyle = ProcessWindowStyle.Normal;
            proc.FileName = @"C:\Program Files\Bosch\ESItronic\Esi2.exe";
            proc.WorkingDirectory = @"C:\Program Files\Bosch\ESItronic\";
            proc.CreateNoWindow = false;
            proc.UseShellExecute = false;
            proc.Verb = "runas";
            Process.Start(proc);
        }

        private void pp2000_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WindowStyle = ProcessWindowStyle.Normal;
            proc.FileName = @"C:\APP\PPM\PPM.exe";
            proc.WorkingDirectory = @"C:\APP\PPM\";
            proc.CreateNoWindow = false;
            proc.UseShellExecute = false;
            proc.Verb = "runas";
            Process.Start(proc);
        }

        private void lexia_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WindowStyle = ProcessWindowStyle.Normal;
            proc.FileName = @"C:\APP\LEXIA\EXE\winlex.exe";
            proc.WorkingDirectory = @"C:\APP\LEXIA\EXE\";
            proc.CreateNoWindow = false;
            proc.UseShellExecute = false;
            proc.Verb = "runas";
            Process.Start(proc);
        }

        private void kts_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WindowStyle = ProcessWindowStyle.Normal;
            proc.FileName = @"C:\Program Files\Bosch\ESItronic\KTS500\kts500_32.exe";
            proc.WorkingDirectory = @"C:\Program Files\Bosch\ESItronic\KTS500\";
            proc.CreateNoWindow = false;
            proc.UseShellExecute = false;
            proc.Verb = "runas";
            Process.Start(proc);
        }

        private void hds_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WindowStyle = ProcessWindowStyle.Normal;
            proc.FileName = @"C:\GenRad\DiagSystem\Launcher\Launcher.exe";
            proc.Arguments = @"/p=1 /c=0";
            proc.WorkingDirectory = @"C:\GenRad\DiagSystem\Launcher\";
            proc.CreateNoWindow = false;
            proc.UseShellExecute = false;
            proc.Verb = "runas";
            Process.Start(proc);
        }

        private void clip_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.FileName = @"C:\CLIP_X91\Lib\Application\ClipLauncher_X91.exe";
            proc.Arguments = @"C:\CLIP_X91\Config\configClip.xml";
            proc.WorkingDirectory = @"C:\CLIP_X91\Lib\Application";
            Process.Start(proc);
            //            
        }

        private void techstream_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WindowStyle = ProcessWindowStyle.Normal;
            proc.FileName = @"C:\Program Files\Toyota Diagnostics\Techstream\bin\MainMenu.exe";
            proc.WorkingDirectory = @"C:\Program Files\Toyota Diagnostics\Techstream\bin\";
            proc.CreateNoWindow = false;
            proc.UseShellExecute = false;
            proc.Verb = "runas";
            Process.Start(proc);
        }

        private void vaspc_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WindowStyle = ProcessWindowStyle.Normal;
            proc.FileName = @"C:\SIDIS\VAS_base\VASSTART.BAT";
            proc.CreateNoWindow = false;
            proc.UseShellExecute = false;
            proc.Verb = "runas";
            Process.Start(proc);
        }

        private void odis_d_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Данное приложение не работает с Вашим сканером из-за отсутсвия в нем OKI чипа и UDS модуля");
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WindowStyle = ProcessWindowStyle.Normal;
            proc.FileName = @"C:\Program Files\Offboard_Diagnostic_Information_System_Service\OffboardDiagLauncher.exe";
            proc.WorkingDirectory = @"C:\Program Files\Offboard_Diagnostic_Information_System_Service";
            proc.CreateNoWindow = false;
            proc.UseShellExecute = false;
            proc.Verb = "runas";
            Process.Start(proc);
        }

        private void odis_e_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Данное приложение не работает с Вашим сканером из-за отсутсвия в нем OKI чипа и UDS модуля");
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WindowStyle = ProcessWindowStyle.Normal;
            proc.FileName = @"C:\Program Files\Offboard_Diagnostic_Information_System_Engineering\OffboardDiagLauncher.exe";
            proc.WorkingDirectory = @"C:\Program Files\Offboard_Diagnostic_Information_System_Engineering";
            proc.CreateNoWindow = false;
            proc.UseShellExecute = false;
            proc.Verb = "runas";
            Process.Start(proc);
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            back_btn.Visible = false;
            Main_TabControl.SelectedTab = Main_Tab;

        }

        private void VCS_Button_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WindowStyle = ProcessWindowStyle.Normal;
            proc.FileName = @"C:\VCS\PC-VCS.exe";
            proc.WorkingDirectory = @"C:\VCS";
            proc.CreateNoWindow = false;
            proc.UseShellExecute = false;
            proc.Verb = "runas";
            Process.Start(proc);
        }

        private void VCSstart_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WindowStyle = ProcessWindowStyle.Normal;
            proc.FileName = @"C:\VCS\PC-VCS.exe";
            proc.WorkingDirectory = @"C:\VCS";
            proc.CreateNoWindow = false;
            proc.UseShellExecute = false;
            proc.Verb = "runas";
            Process.Start(proc);
        }

        private void BMW_btn_Click(object sender, EventArgs e)
        {
            Main_TabControl.SelectedTab = BMW_Tab;
            back_btn.Visible = true;
        }

        private void Ford_btn_Click(object sender, EventArgs e)
        {
            Main_TabControl.SelectedTab = Ford_Tab;
            back_btn.Visible = true;
        }

        private void Mazda_btn_Click(object sender, EventArgs e)
        {
            Main_TabControl.SelectedTab = Mazda_Tab;
            back_btn.Visible = true;
        }

        private void Nissan_btn_Click(object sender, EventArgs e)
        {
            Main_TabControl.SelectedTab = Nissan_Tab;
            back_btn.Visible = true;
        }

        private void Rheingold_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WindowStyle = ProcessWindowStyle.Normal;
            proc.FileName = @"C:\Carsoft\Rheingold\TesterGUI\bin\Release\ISTAGUI.exe";
            proc.WorkingDirectory = @"C:\Carsoft\Rheingold\TesterGUI\bin\Release";
            proc.CreateNoWindow = false;
            proc.UseShellExecute = false;
            proc.Verb = "runas";
            Process.Start(proc);
        }

        private void DIS_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WindowStyle = ProcessWindowStyle.Normal;
            proc.FileName = @"C:\Program Files (x86)\VMware\VMware Workstation\vmware.exe";
            proc.WorkingDirectory = @"C:\Program Files (x86)\VMware\VMware Workstation";
            proc.Arguments = @"-f C:\Carsoft\DIS\Other.vmx";
            proc.CreateNoWindow = false;
            proc.UseShellExecute = false;
            proc.Verb = "runas";
            Process.Start(proc);
        }

        private void iToolsRadar_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WindowStyle = ProcessWindowStyle.Normal;
            proc.FileName = @"C:\Program Files\ITool Radar\IToolRadar.exe";
            proc.WorkingDirectory = @"C:\Program Files\ITool Radar";
            proc.CreateNoWindow = false;
            proc.UseShellExecute = false;
            proc.Verb = "runas";
            Process.Start(proc);
        }

        private void CodingTools_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WindowStyle = ProcessWindowStyle.Normal;
            proc.FileName = @"C:\BMW Coding Tool v250\BMW Coding Tool.exe";
            proc.WorkingDirectory = @"C:\BMW Coding Tool v250";
            proc.CreateNoWindow = false;
            proc.UseShellExecute = false;
            proc.Verb = "runas";
            Process.Start(proc);
        }

        private void INPA_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WindowStyle = ProcessWindowStyle.Normal;
            proc.FileName = @"C:\EC-APPS\INPA\BIN\INPALOAD.exe";
            proc.WorkingDirectory = @"C:\EC-APPS\INPA\BIN";
            proc.CreateNoWindow = false;
            proc.UseShellExecute = false;
            proc.Verb = "runas";
            Process.Start(proc);
        }

        private void NCSExpert_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WindowStyle = ProcessWindowStyle.Normal;
            proc.FileName = @"C:\NCSEXPER\BIN\NCSEXPER.exe";
            proc.WorkingDirectory = @"C:\NCSEXPER\BIN";
            proc.CreateNoWindow = false;
            proc.UseShellExecute = false;
            proc.Verb = "runas";
            Process.Start(proc);
        }

        private void WinKFP_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WindowStyle = ProcessWindowStyle.Normal;
            proc.FileName = @"C:\EC-APPS\NFS\BIN\winkfpt.exe";
            proc.WorkingDirectory = @"C:\EC-APPS\NFS\BIN";
            proc.CreateNoWindow = false;
            proc.UseShellExecute = false;
            proc.Verb = "runas";
            Process.Start(proc);
        }

        private void NCSDummy_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WindowStyle = ProcessWindowStyle.Normal;
            proc.FileName = @"C:\Carsoft\ncsdummy\NcsDummy.exe";
            proc.WorkingDirectory = @"C:\Carsoft\ncsdummy";
            proc.CreateNoWindow = false;
            proc.UseShellExecute = false;
            proc.Verb = "runas";
            Process.Start(proc);
        }

        private void FordIDS_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WindowStyle = ProcessWindowStyle.Normal;
            proc.FileName = @"C:\Program Files (x86)\VMware\VMware Workstation\vmware.exe";
            proc.WorkingDirectory = @"C:\Program Files (x86)\VMware\VMware Workstation";
            proc.Arguments = @"-f C:\Carsoft\Ford_75\Ford.vmx";
            proc.CreateNoWindow = false;
            proc.UseShellExecute = false;
            proc.Verb = "runas";
            Process.Start(proc);
        }

        private void MazdaIDS_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WindowStyle = ProcessWindowStyle.Normal;
            proc.FileName = @"C:\Program Files (x86)\VMware\VMware Workstation\vmware.exe";
            proc.WorkingDirectory = @"C:\Program Files (x86)\VMware\VMware Workstation";
            proc.Arguments = @"-f C:\Carsoft\Mazda\92_04\XP_RUS_Mod.vmx";
            proc.CreateNoWindow = false;
            proc.UseShellExecute = false;
            proc.Verb = "runas";
            Process.Start(proc);
        }

        private void NissanConsult_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WindowStyle = ProcessWindowStyle.Normal;
            proc.FileName = @"C:\Program Files\VMware\VMware Workstation\vmware.exe";
            proc.WorkingDirectory = @"C:\Program Files\VMware\VMware Workstation";
            proc.Arguments = @"-f C:\Consult\9.21.0\Consult.vmx";
            proc.CreateNoWindow = false;
            proc.UseShellExecute = false;
            proc.Verb = "runas";
            Process.Start(proc);
        }

        private void Mitshubishi_btn_Click(object sender, EventArgs e)
        {
            Main_TabControl.SelectedTab = Mitsubishi_Tab;
            back_btn.Visible = true;
        }

        private void Opel_btn_Click(object sender, EventArgs e)
        {
            Main_TabControl.SelectedTab = Opel_Tab;
            back_btn.Visible = true;
        }

        private void FIAT_btn_Click(object sender, EventArgs e)
        {
            Main_TabControl.SelectedTab = FIAT_tab;
            back_btn.Visible = true;
        }

        private void MUT3_1_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WindowStyle = ProcessWindowStyle.Normal;
            proc.FileName = @"C:\Windows\System32\wscript.exe";
            proc.Arguments = @"C:\MUTSW\MUT3\MENU\SCRIPT\start.js";
            //proc.WorkingDirectory = @"C:\Program Files\VMware\VMware Workstation";
            proc.CreateNoWindow = false;
            proc.UseShellExecute = false;
            proc.Verb = "runas";
            Process.Start(proc);
        }

        private void MUT3_2_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WindowStyle = ProcessWindowStyle.Normal;
            proc.FileName = @"C:\MUTSW_SE\MUT3_SE\System\Common\MUT3_SE.exe";
            proc.WorkingDirectory = @"C:\MUTSW_SE\MUT3_SE\System\Common";
            proc.CreateNoWindow = false;
            proc.UseShellExecute = false;
            proc.Verb = "runas";
            Process.Start(proc);
        }

        private void TIS2000_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WindowStyle = ProcessWindowStyle.Normal;
            proc.FileName = @"C:\Program Files\cosids\bin\frontend.exe";
            proc.WorkingDirectory = @"C:\Program Files\cosids\bin";
            proc.CreateNoWindow = false;
            proc.UseShellExecute = false;
            proc.Verb = "runas";
            Process.Start(proc);
        }

        private void opcom_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WindowStyle = ProcessWindowStyle.Normal;
            proc.FileName = @"C:\OP_COM_08_2010_rus\op-com.exe";
            proc.WorkingDirectory = @"C:\OP_COM_08_2010_rus";
            proc.CreateNoWindow = false;
            proc.UseShellExecute = false;
            proc.Verb = "runas";
            Process.Start(proc);
        }

        private void autocom_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WindowStyle = ProcessWindowStyle.Normal;
            proc.FileName = @"C:\Program Files\Autocom\Cars CDP\Main.exe";
            proc.WorkingDirectory = @"C:\Program Files\Autocom\Cars CDP";
            proc.CreateNoWindow = false;
            proc.UseShellExecute = false;
            proc.Verb = "runas";
            Process.Start(proc);
        }

        private void elm_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WindowStyle = ProcessWindowStyle.Normal;
            proc.FileName = @"C:\Program Files\WGSoft\ScanMaster-ELM\ScanMasterELM.exe";
            proc.WorkingDirectory = @"C:\Program Files\WGSoft\ScanMaster-ELM";
            proc.CreateNoWindow = false;
            proc.UseShellExecute = false;
            proc.Verb = "runas";
            Process.Start(proc);
        }

        private void VCDS_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WindowStyle = ProcessWindowStyle.Normal;
            proc.FileName = @"C:\ВАСЯ диагност 16.9\vd.exe";
            proc.WorkingDirectory = @"C:\ВАСЯ диагност 16.9\";
            proc.CreateNoWindow = false;
            proc.UseShellExecute = false;
            proc.Verb = "runas";
            Process.Start(proc);
        }

        private void EcuScan_btn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.WindowStyle = ProcessWindowStyle.Normal;
            proc.FileName = @"C:\Program Files\FiatECUScan\FiatECUScan2.exe";
            proc.WorkingDirectory = @"C:\Program Files\FiatECUScan";
            proc.CreateNoWindow = false;
            proc.UseShellExecute = false;
            proc.Verb = "runas";
            Process.Start(proc);
        }
    }
}
