using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace AutoLicense
{
    public partial class MainForm : Form
    {
        class Comment
        {
            public string Begin;
            public string End;

            public Comment(string b, string e)
            {
                Begin = b;
                End = e;
            }
        }

        private Dictionary<string, Comment> CommentDic = new Dictionary<string,Comment>();

        private void Log(string msg)
        {
            textBox_Log.AppendText(msg + "\r\n");
        }

        private void Core()
        {
            Invoke((MethodInvoker)delegate()
            {
                comboBox_Encoding.Enabled = button_Choice.Enabled = button_ChoiceFiles.Enabled = button_Clear.Enabled = 
                button_Start.Enabled = false;

                List<string> license = new List<string>();

                try
                {
                    StreamReader license_reader = new StreamReader(textBox_FilePath.Text, true);

                    while (license_reader.EndOfStream == false)
                    {
                        license.Add(license_reader.ReadLine());
                    }
                    license_reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not load license file\n" + ex.Message);
                    return;
                }

                Encoding enco = ((Encoding)comboBox_Encoding.SelectedItem);

                progressBar.Maximum = listBox_Files.Items.Count;
                progressBar.Value = 0;

                int successed = 0, failed = 0;
                foreach (string path in listBox_Files.Items)
                {
                    string fullname = path.Substring(path.LastIndexOf('\\') + 1);
                    //string name = fullname.Substring(0, fullname.LastIndexOf('.'));

                    int idx = fullname.LastIndexOf('.');
                    string ext = idx > 0 ? fullname.Substring(idx) : "";

                    try
                    {
                        progressBar.Value++;
                        Comment cmt;

                        // For Makefile
                        if (ext == "" && fullname == "makefile")
                            cmt = new Comment("#", "");
                        else
                            cmt = CommentDic[ext];

                        StreamReader reader = new StreamReader(path, enco);
                        string temp = reader.ReadToEnd();
                        reader.Close();

                        StreamWriter writer = new StreamWriter(path, false, enco);
                        foreach (string s in license)
                        {
                            writer.WriteLine(cmt.Begin + ' ' + s + ' ' + cmt.End);
                        }
                        writer.WriteLine();

                        writer.Write(temp);
                        writer.Close();

                        successed++;
                        Log("Wrote license into the source " + path);
                    }
                    catch (KeyNotFoundException)
                    {
                        Log("Could not write license into " + path + "\r\n" +
                            "Extension \"" + ext + "\" is not supported yet");
                        failed++;
                    }
                    catch (Exception ex)
                    {
                        Log("Could not write license into " + path + "\r\n" + ex.Message);
                        failed++;
                    }
                }

                Log(string.Format("Successed = {0}, Failed = {1}", successed, failed));
                Log("=== AutoLicense has finished ===");

                button_Choice.Enabled = button_ChoiceFiles.Enabled = button_Clear.Enabled = comboBox_Encoding.Enabled =
                    button_Start.Enabled = true;
            });
        }

        public MainForm()
        {
            InitializeComponent();

            comboBox_Encoding.Items.Add(Encoding.ASCII);
            comboBox_Encoding.Items.Add(Encoding.UTF7);
            comboBox_Encoding.Items.Add(Encoding.UTF8);
            comboBox_Encoding.Items.Add(Encoding.Unicode);
            comboBox_Encoding.Items.Add(Encoding.BigEndianUnicode);
            comboBox_Encoding.Items.Add(Encoding.UTF32);

            CommentDic.Add(".c", new Comment("//", ""));
            CommentDic.Add(".cpp", new Comment("//", ""));
            CommentDic.Add(".h", new Comment("//", ""));
            CommentDic.Add(".hpp", new Comment("//", ""));
            CommentDic.Add("inl", new Comment("//", ""));
            CommentDic.Add(".cs", new Comment("//", ""));
            CommentDic.Add(".fs", new Comment("//", ""));
            CommentDic.Add(".asm", new Comment(";", ""));
            CommentDic.Add(".vb", new Comment("'", ""));
            CommentDic.Add(".java", new Comment("//", ""));
            CommentDic.Add(".xaml", new Comment("<!--", "-->"));
            CommentDic.Add(".html", new Comment("<!--", "-->"));
            CommentDic.Add(".htm", new Comment("<!--", "-->"));
            CommentDic.Add(".js", new Comment("//", ""));
            CommentDic.Add(".bat", new Comment("::", ""));
            CommentDic.Add(".m", new Comment("//", ""));
            CommentDic.Add(".d", new Comment("//", ""));
            CommentDic.Add(".sql", new Comment("--", ""));
            CommentDic.Add(".py", new Comment("#", ""));
        }

        private void button_Choice_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = ".";
            dialog.Filter = "LICENSE file (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox_FilePath.Text = dialog.FileName;
                button_ChoiceFiles.Enabled = true;
                button_Clear.Enabled = true;
            }
        }

        private void button_ChoiceFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = ".";
            dialog.Filter = "All source files (*.*)|*.*";
            dialog.Multiselect = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var path in dialog.FileNames)
                {
                    listBox_Files.Items.Add(path);
                }

                button_Start.Enabled = true;
                comboBox_Encoding.Enabled = true;
                comboBox_Encoding.SelectedItem = Encoding.UTF8;
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            listBox_Files.Items.Clear();
            button_Start.Enabled = false;
            comboBox_Encoding.Enabled = false;
            progressBar.Value = 0;
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(Core));
            t.Start();
        }
    }
}
