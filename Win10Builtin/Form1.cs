using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Win10Builtin
{
    public partial class Form1:Form
    {
        string u3DBuilder = "Get-AppxPackage *3DBuilder* ^| Remove-AppxPackage";
        string u3DViewer = "Get-AppxPackage *Microsoft3DViewer* ^| Remove-AppxPackage";
        string uAlarms = "Get - AppxPackage * WindowsAlarms * ^| Remove - AppxPackage";
        string uAppConnector = "Get-AppxPackage* AppConnector* ^| Remove-AppxPackage";
        string uCalculator = "Get-AppxPackage* WindowsCalculator* ^| Remove-AppxPackage";
        string uCommunications = "Get-AppxPackage* windowscommunicationsapps* ^| Remove-AppxPackage";
        string uCamera = "Get-AppxPackage* WindowsCamera* ^| Remove-AppxPackage";
        string uCandyCrush = "Get-AppxPackage* CandyCrushSodaSaga* ^| Remove-AppxPackage";
        string uContactSupport = "Get-AppxPackage* ContactSupport* ^| Remove-AppxPackage";
        string uDrawboardPDF = "Get-AppxPackage* DrawboardPDF* ^| Remove-AppxPackage";
        string uFeedbackHub = "Get-AppxPackage* WindowsFeedbackHub* ^| Remove-AppxPackage";
        string uOfficeHub = "Get-AppxPackage* MicrosoftOfficeHub* ^| Remove-AppxPackage";
        string uGetStarted = "Get-AppxPackage* GetStarted* ^| Remove-AppxPackage";
        string uZuneMusic = "Get-AppxPackage* ZuneMusic* ^| Remove-AppxPackage";
        string uCommunicationsapps = "Get-AppxPackage* windowscommunicationsapps* ^| Remove-AppxPackage";
        string uMaps = "Get-AppxPackage* WindowsMaps* ^| Remove-AppxPackage";
        string uMessaging = "Get-AppxPackage* Messaging* ^| Remove-AppxPackage";
        string uSolitaire = "Get-AppxPackage* MicrosoftSolitaireCollection* ^| Remove-AppxPackage";
        string uStore = "Get-AppxPackage* WindowsStore* ^| Remove-AppxPackage";
        string uWhiteboard = "Get-AppxPackage* Microsoft.Whiteboard* ^| Remove-AppxPackage";
        string uMixedReality = "Get-AppxPackage* Microsoft.MixedReality.Portal* ^| Remove-AppxPackage";
        string uBingFinance = "Get-AppxPackage* BingFinance* ^| Remove-AppxPackage";
        string uZuneVideo = "Get-AppxPackage* ZuneVideo* ^| Remove-AppxPackage";
        string uBingNews = "Get-AppxPackage* BingNews* ^| Remove-AppxPackage";
        string uOneDrive = "Get-AppxPackage* microsoft.microsoftskydrive* ^| Remove-AppxPackage";
        string uOneNote = "Get-AppxPackage* Office.OneNote* ^| Remove-AppxPackage";
        string uMSPaint = "Get-AppxPackage* MSPaint* ^| Remove-AppxPackage";
        string uPhone = "Get-AppxPackage* CommsPhone* ^| Remove-AppxPackage";
        string uWindowsPhone = "Get-AppxPackage* WindowsPhone* ^| Remove-AppxPackage";
        string uPhotos = "Get-AppxPackage* Photos* ^| Remove-AppxPackage";
        string uSkype = "Get-AppxPackage* SkypeApp* ^| Remove-AppxPackage";
        string uScreenSketch = "Get-AppxPackage* Microsoft.ScreenSketch* ^| Remove-AppxPackage";
        string uBingSports = "Get-AppxPackage* BingSports* ^| Remove-AppxPackage";
        string uStickyNotes = "Get-AppxPackage* MicrosoftStickyNotes* ^| Remove-AppxPackage";
        string uSway = "Get-AppxPackage* Office.Sway* ^| Remove-AppxPackage";
        string uTips = "Get-AppxPackage* Microsoft.Getstarted* ^| Remove-AppxPackage";
        string uTwitter = "Get-AppxPackage* Twitter* ^| Remove-AppxPackage";
        string uSoundRecorder = "Get-AppxPackage* WindowsSoundRecorder* ^| Remove-AppxPackage";
        string uWeather = "Get-AppxPackage* BingWeather* ^| Remove-AppxPackage";
        string uXboxApp = "Get-AppxPackage* XboxApp* ^| Remove-AppxPackage";
        string uXboxGamingOverlay = "Get-AppxPackage* Microsoft.XboxGamingOverlay* ^| Remove-AppxPackage";
        string uXboxOneSmartGlass = "Get-AppxPackage* XboxOneSmartGlass* ^| Remove-AppxPackage";
        string uYourPhone = "Get-AppxPackage* Microsoft.YourPhone* ^| Remove-AppxPackage";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            savePSFile.ShowDialog();
            if(savePSFile.FileName!="")
            {
                string path = savePSFile.FileName;
                if(!File.Exists(path))
                {
                    using(StreamWriter sw = File.CreateText(path))
                    {
                        if(checkBox1.Checked)
                        {
                            sw.WriteLine(u3DBuilder);
                        }
                        if(checkBox2.Checked)
                        {
                            sw.WriteLine(u3DViewer);
                        }
                        if(checkBox3.Checked)
                        {
                            sw.WriteLine(uAlarms);
                        }
                        if(checkBox4.Checked)
                        {
                            sw.WriteLine(uAppConnector);
                        }
                        if(checkBox5.Checked)
                        {
                            sw.WriteLine(uCalculator);
                        }
                        if(checkBox6.Checked)
                        {
                            sw.WriteLine(uCommunications);
                        }
                        if(checkBox7.Checked)
                        {
                            sw.WriteLine(uCamera);
                        }
                        if(checkBox8.Checked)
                        {
                            sw.WriteLine(uCandyCrush);
                        }
                        if(checkBox9.Checked)
                        {
                            sw.WriteLine(uContactSupport);
                        }
                        if(checkBox10.Checked)
                        {
                            sw.WriteLine(uDrawboardPDF);
                        }
                        if(checkBox11.Checked)
                        {
                            sw.WriteLine(uFeedbackHub);
                        }
                        if(checkBox12.Checked)
                        {
                            sw.WriteLine(uOfficeHub);
                        }
                        if(checkBox13.Checked)
                        {
                            sw.WriteLine(uGetStarted);
                        }
                        if(checkBox14.Checked)
                        {
                            sw.WriteLine(uZuneMusic);
                        }
                        if(checkBox15.Checked)
                        {
                            sw.WriteLine(uCommunicationsapps);
                        }
                        if(checkBox16.Checked)
                        {
                            sw.WriteLine(uMaps);
                        }
                        if(checkBox17.Checked)
                        {
                            sw.WriteLine(uMessaging);
                        }
                        if(checkBox18.Checked)
                        {
                            sw.WriteLine(uSolitaire);
                        }
                        if(checkBox19.Checked)
                        {
                            sw.WriteLine(uStore);
                        }
                        if(checkBox20.Checked)
                        {
                            sw.WriteLine(uWhiteboard);
                        }
                        if(checkBox21.Checked)
                        {
                            sw.WriteLine(uMixedReality);
                        }
                        if(checkBox22.Checked)
                        {
                            sw.WriteLine(uBingFinance);
                        }
                        if(checkBox23.Checked)
                        {
                            sw.WriteLine(uZuneVideo);
                        }
                        if(checkBox24.Checked)
                        {
                            sw.WriteLine(uBingNews);
                        }
                        if(checkBox25.Checked)
                        {
                            sw.WriteLine(uOneDrive);
                        }
                        if(checkBox26.Checked)
                        {
                            sw.WriteLine(uOneNote);
                        }
                        if(checkBox27.Checked)
                        {
                            sw.WriteLine(uMSPaint);
                        }
                        if(checkBox28.Checked)
                        {
                            sw.WriteLine(uPhone);
                        }
                        if(checkBox29.Checked)
                        {
                            sw.WriteLine(uWindowsPhone);
                        }
                        if(checkBox30.Checked)
                        {
                            sw.WriteLine(uPhotos);
                        }
                        if(checkBox31.Checked)
                        {
                            sw.WriteLine(uSkype);
                        }
                        if(checkBox32.Checked)
                        {
                            sw.WriteLine(uScreenSketch);
                        }
                        if(checkBox33.Checked)
                        {
                            sw.WriteLine(uBingSports);
                        }
                        if(checkBox34.Checked)
                        {
                            sw.WriteLine(uStickyNotes);
                        }
                        if(checkBox35.Checked)
                        {
                            sw.WriteLine(uSway);
                        }
                        if(checkBox36.Checked)
                        {
                            sw.WriteLine(uTips);
                        }
                        if(checkBox37.Checked)
                        {
                            sw.WriteLine(uTwitter);
                        }
                        if(checkBox38.Checked)
                        {
                            sw.WriteLine(uSoundRecorder);
                        }
                        if(checkBox39.Checked)
                        {
                            sw.WriteLine(uWeather);
                        }
                        if(checkBox40.Checked)
                        {
                            sw.WriteLine(uXboxApp);
                        }
                        if(checkBox41.Checked)
                        {
                            sw.WriteLine(uXboxGamingOverlay);
                        }
                        if(checkBox42.Checked)
                        {
                            sw.WriteLine(uXboxOneSmartGlass);
                        }
                        if(checkBox43.Checked)
                        {
                            sw.WriteLine(uYourPhone);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("File already exists, please provide a different filename!");
                }
            }
        }
    }
}
