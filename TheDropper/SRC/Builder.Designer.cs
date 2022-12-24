
namespace TheDropper
{
    partial class Builder
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Builder));
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.comboBoxExtension = new System.Windows.Forms.ComboBox();
            this.buttonBuild = new System.Windows.Forms.Button();
            this.labelFileUrl = new System.Windows.Forms.Label();
            this.labelFileExtension = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(29)))));
            this.textBoxUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUrl.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(150)))), ((int)(((byte)(244)))));
            this.textBoxUrl.Location = new System.Drawing.Point(12, 39);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(579, 32);
            this.textBoxUrl.TabIndex = 0;
            // 
            // comboBoxExtension
            // 
            this.comboBoxExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxExtension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(29)))));
            this.comboBoxExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExtension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxExtension.Font = new System.Drawing.Font("Trebuchet MS", 20.25F);
            this.comboBoxExtension.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(150)))), ((int)(((byte)(244)))));
            this.comboBoxExtension.FormattingEnabled = true;
            this.comboBoxExtension.Items.AddRange(new object[] {
            "exe",
            "scr",
            "pif",
            "com",
            "lnk",
            "bat",
            "cmd",
            "vbs",
            "js"});
            this.comboBoxExtension.Location = new System.Drawing.Point(12, 105);
            this.comboBoxExtension.Name = "comboBoxExtension";
            this.comboBoxExtension.Size = new System.Drawing.Size(579, 43);
            this.comboBoxExtension.TabIndex = 2;
            // 
            // buttonBuild
            // 
            this.buttonBuild.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(29)))));
            this.buttonBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuild.Font = new System.Drawing.Font("Trebuchet MS", 20.25F);
            this.buttonBuild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(150)))), ((int)(((byte)(244)))));
            this.buttonBuild.Location = new System.Drawing.Point(12, 177);
            this.buttonBuild.Name = "buttonBuild";
            this.buttonBuild.Size = new System.Drawing.Size(579, 55);
            this.buttonBuild.TabIndex = 3;
            this.buttonBuild.Text = "Build";
            this.buttonBuild.UseVisualStyleBackColor = false;
            this.buttonBuild.Click += new System.EventHandler(this.buttonBuild_Click);
            // 
            // labelFileUrl
            // 
            this.labelFileUrl.AutoSize = true;
            this.labelFileUrl.ForeColor = System.Drawing.Color.Yellow;
            this.labelFileUrl.Location = new System.Drawing.Point(12, 18);
            this.labelFileUrl.Name = "labelFileUrl";
            this.labelFileUrl.Size = new System.Drawing.Size(122, 13);
            this.labelFileUrl.TabIndex = 5;
            this.labelFileUrl.Text = "ENTER PAYLOAD URL";
            // 
            // labelFileExtension
            // 
            this.labelFileExtension.AutoSize = true;
            this.labelFileExtension.ForeColor = System.Drawing.Color.Yellow;
            this.labelFileExtension.Location = new System.Drawing.Point(9, 89);
            this.labelFileExtension.Name = "labelFileExtension";
            this.labelFileExtension.Size = new System.Drawing.Size(173, 13);
            this.labelFileExtension.TabIndex = 6;
            this.labelFileExtension.Text = "CHOOSE DROPPER EXTENSION";
            // 
            // Builder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(603, 244);
            this.Controls.Add(this.labelFileExtension);
            this.Controls.Add(this.labelFileUrl);
            this.Controls.Add(this.buttonBuild);
            this.Controls.Add(this.comboBoxExtension);
            this.Controls.Add(this.textBoxUrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Builder";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FUD DROPPER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.ComboBox comboBoxExtension;
        private System.Windows.Forms.Button buttonBuild;
        private System.Windows.Forms.Label labelFileUrl;
        private System.Windows.Forms.Label labelFileExtension;
    }
}

