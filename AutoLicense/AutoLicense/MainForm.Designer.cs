namespace AutoLicense
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Step1 = new System.Windows.Forms.Label();
            this.button_Choice = new System.Windows.Forms.Button();
            this.textBox_FilePath = new System.Windows.Forms.TextBox();
            this.label_Step2 = new System.Windows.Forms.Label();
            this.button_ChoiceFiles = new System.Windows.Forms.Button();
            this.listBox_Files = new System.Windows.Forms.ListBox();
            this.label_Step3 = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.button_Clear = new System.Windows.Forms.Button();
            this.comboBox_Encoding = new System.Windows.Forms.ComboBox();
            this.textBox_Log = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_Step1
            // 
            this.label_Step1.AutoSize = true;
            this.label_Step1.Location = new System.Drawing.Point(13, 13);
            this.label_Step1.Name = "label_Step1";
            this.label_Step1.Size = new System.Drawing.Size(186, 13);
            this.label_Step1.TabIndex = 0;
            this.label_Step1.Text = "Step 1: Please choice your license file";
            // 
            // button_Choice
            // 
            this.button_Choice.Location = new System.Drawing.Point(201, 8);
            this.button_Choice.Name = "button_Choice";
            this.button_Choice.Size = new System.Drawing.Size(263, 23);
            this.button_Choice.TabIndex = 1;
            this.button_Choice.Text = "Choice";
            this.button_Choice.UseVisualStyleBackColor = true;
            this.button_Choice.Click += new System.EventHandler(this.button_Choice_Click);
            // 
            // textBox_FilePath
            // 
            this.textBox_FilePath.Location = new System.Drawing.Point(16, 32);
            this.textBox_FilePath.Name = "textBox_FilePath";
            this.textBox_FilePath.ReadOnly = true;
            this.textBox_FilePath.Size = new System.Drawing.Size(448, 20);
            this.textBox_FilePath.TabIndex = 2;
            // 
            // label_Step2
            // 
            this.label_Step2.AutoSize = true;
            this.label_Step2.Location = new System.Drawing.Point(13, 63);
            this.label_Step2.Name = "label_Step2";
            this.label_Step2.Size = new System.Drawing.Size(186, 13);
            this.label_Step2.TabIndex = 4;
            this.label_Step2.Text = "Step 2: Please select your source files";
            // 
            // button_ChoiceFiles
            // 
            this.button_ChoiceFiles.Enabled = false;
            this.button_ChoiceFiles.Location = new System.Drawing.Point(201, 57);
            this.button_ChoiceFiles.Name = "button_ChoiceFiles";
            this.button_ChoiceFiles.Size = new System.Drawing.Size(170, 23);
            this.button_ChoiceFiles.TabIndex = 5;
            this.button_ChoiceFiles.Text = "Select";
            this.button_ChoiceFiles.UseVisualStyleBackColor = true;
            this.button_ChoiceFiles.Click += new System.EventHandler(this.button_ChoiceFiles_Click);
            // 
            // listBox_Files
            // 
            this.listBox_Files.FormattingEnabled = true;
            this.listBox_Files.HorizontalScrollbar = true;
            this.listBox_Files.Location = new System.Drawing.Point(16, 83);
            this.listBox_Files.Name = "listBox_Files";
            this.listBox_Files.ScrollAlwaysVisible = true;
            this.listBox_Files.Size = new System.Drawing.Size(448, 95);
            this.listBox_Files.TabIndex = 6;
            // 
            // label_Step3
            // 
            this.label_Step3.AutoSize = true;
            this.label_Step3.Location = new System.Drawing.Point(13, 192);
            this.label_Step3.Name = "label_Step3";
            this.label_Step3.Size = new System.Drawing.Size(157, 13);
            this.label_Step3.TabIndex = 7;
            this.label_Step3.Text = "Step 3: Set encoding, and start!";
            // 
            // button_Start
            // 
            this.button_Start.Enabled = false;
            this.button_Start.Location = new System.Drawing.Point(377, 188);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(87, 23);
            this.button_Start.TabIndex = 8;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(16, 226);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(448, 23);
            this.progressBar.TabIndex = 9;
            // 
            // button_Clear
            // 
            this.button_Clear.Enabled = false;
            this.button_Clear.Location = new System.Drawing.Point(377, 57);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(87, 23);
            this.button_Clear.TabIndex = 10;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // comboBox_Encoding
            // 
            this.comboBox_Encoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Encoding.Enabled = false;
            this.comboBox_Encoding.FormattingEnabled = true;
            this.comboBox_Encoding.Location = new System.Drawing.Point(200, 189);
            this.comboBox_Encoding.Name = "comboBox_Encoding";
            this.comboBox_Encoding.Size = new System.Drawing.Size(170, 21);
            this.comboBox_Encoding.TabIndex = 11;
            // 
            // textBox_Log
            // 
            this.textBox_Log.ForeColor = System.Drawing.Color.White;
            this.textBox_Log.Location = new System.Drawing.Point(16, 256);
            this.textBox_Log.Multiline = true;
            this.textBox_Log.Name = "textBox_Log";
            this.textBox_Log.ReadOnly = true;
            this.textBox_Log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Log.Size = new System.Drawing.Size(448, 107);
            this.textBox_Log.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(476, 375);
            this.Controls.Add(this.textBox_Log);
            this.Controls.Add(this.comboBox_Encoding);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.label_Step3);
            this.Controls.Add(this.listBox_Files);
            this.Controls.Add(this.button_ChoiceFiles);
            this.Controls.Add(this.label_Step2);
            this.Controls.Add(this.textBox_FilePath);
            this.Controls.Add(this.button_Choice);
            this.Controls.Add(this.label_Step1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "AutoLicense - mady by Lee (jhlcooky@gmail.com)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Step1;
        private System.Windows.Forms.Button button_Choice;
        private System.Windows.Forms.TextBox textBox_FilePath;
        private System.Windows.Forms.Label label_Step2;
        private System.Windows.Forms.Button button_ChoiceFiles;
        private System.Windows.Forms.ListBox listBox_Files;
        private System.Windows.Forms.Label label_Step3;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.ComboBox comboBox_Encoding;
        private System.Windows.Forms.TextBox textBox_Log;
    }
}

