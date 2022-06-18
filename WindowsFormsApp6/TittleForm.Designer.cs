namespace WindowsFormsApp6
{
    partial class TittleForm
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btSettings = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.gbServer = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btOpenDir = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.tbDB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.gbServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(247, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(657, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Деский Развлекательный Клуб";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(765, 160);
            this.btExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(168, 48);
            this.btExit.TabIndex = 1;
            this.btExit.Text = "Выход";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click_1);
            // 
            // btSettings
            // 
            this.btSettings.Location = new System.Drawing.Point(603, 160);
            this.btSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSettings.Name = "btSettings";
            this.btSettings.Size = new System.Drawing.Size(155, 47);
            this.btSettings.TabIndex = 2;
            this.btSettings.Text = "Настройки подключения";
            this.btSettings.UseVisualStyleBackColor = true;
            this.btSettings.Click += new System.EventHandler(this.btSettings_Click_1);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(449, 160);
            this.btStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(145, 46);
            this.btStart.TabIndex = 3;
            this.btStart.Text = "Авторизация";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // gbServer
            // 
            this.gbServer.Controls.Add(this.label6);
            this.gbServer.Controls.Add(this.btClear);
            this.gbServer.Controls.Add(this.tbPassword);
            this.gbServer.Controls.Add(this.btOpenDir);
            this.gbServer.Controls.Add(this.btLoad);
            this.gbServer.Controls.Add(this.btSave);
            this.gbServer.Controls.Add(this.tbDB);
            this.gbServer.Controls.Add(this.label4);
            this.gbServer.Controls.Add(this.label3);
            this.gbServer.Controls.Add(this.label2);
            this.gbServer.Controls.Add(this.tbPort);
            this.gbServer.Controls.Add(this.tbServer);
            this.gbServer.Location = new System.Drawing.Point(16, 215);
            this.gbServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbServer.Name = "gbServer";
            this.gbServer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbServer.Size = new System.Drawing.Size(935, 132);
            this.gbServer.TabIndex = 4;
            this.gbServer.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Пароль";
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(336, 85);
            this.btClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(287, 25);
            this.btClear.TabIndex = 8;
            this.btClear.Text = "По умолчанию";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(403, 53);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(219, 22);
            this.tbPassword.TabIndex = 7;
            // 
            // btOpenDir
            // 
            this.btOpenDir.Location = new System.Drawing.Point(631, 85);
            this.btOpenDir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btOpenDir.Name = "btOpenDir";
            this.btOpenDir.Size = new System.Drawing.Size(287, 25);
            this.btOpenDir.TabIndex = 8;
            this.btOpenDir.Text = "Открыть папку";
            this.btOpenDir.UseVisualStyleBackColor = true;
            this.btOpenDir.Click += new System.EventHandler(this.btOpenDir_Click_1);
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(631, 53);
            this.btLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(287, 25);
            this.btLoad.TabIndex = 7;
            this.btLoad.Text = "Загрузить";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click_1);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(631, 21);
            this.btSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(287, 25);
            this.btSave.TabIndex = 5;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // tbDB
            // 
            this.tbDB.Location = new System.Drawing.Point(113, 84);
            this.tbDB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDB.Name = "tbDB";
            this.tbDB.Size = new System.Drawing.Size(213, 22);
            this.tbDB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "База данных";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Порт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Сервер";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(76, 53);
            this.tbPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(251, 22);
            this.tbPort.TabIndex = 1;
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(76, 21);
            this.tbServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(251, 22);
            this.tbServer.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 240);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Логин";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(419, 236);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(219, 22);
            this.tbLogin.TabIndex = 5;
            // 
            // TittleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 358);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.gbServer);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.btSettings);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TittleForm";
            this.Text = "Детский развлекатьный клуб";
            this.Load += new System.EventHandler(this.TittleForm_Load);
            this.gbServer.ResumeLayout(false);
            this.gbServer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btSettings;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.GroupBox gbServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btOpenDir;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox tbDB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLogin;
    }
}

