namespace MouseClick_sound_ProVersion
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.interactiveIcon = new System.Windows.Forms.Panel();
            this.switch1 = new System.Windows.Forms.Panel();
            this.switch2 = new System.Windows.Forms.Panel();
            this.mouseSoundSelection = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.notifyicon = new System.Windows.Forms.NotifyIcon(this.components);
            this.stayOntopCheckbox = new System.Windows.Forms.CheckBox();
            this.keyboardSoundSelection = new System.Windows.Forms.ComboBox();
            this.tryMouseSound = new System.Windows.Forms.Button();
            this.tryKeyboardSound = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.HelpButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(78, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mouse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(386, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Keyboard";
            // 
            // interactiveIcon
            // 
            this.interactiveIcon.BackgroundImage = global::MouseClick_sound_ProVersion.Properties.Resources.logo1;
            this.interactiveIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.interactiveIcon.Location = new System.Drawing.Point(238, 18);
            this.interactiveIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.interactiveIcon.Name = "interactiveIcon";
            this.interactiveIcon.Size = new System.Drawing.Size(106, 103);
            this.interactiveIcon.TabIndex = 2;
            // 
            // switch1
            // 
            this.switch1.BackgroundImage = global::MouseClick_sound_ProVersion.Properties.Resources.off;
            this.switch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.switch1.Location = new System.Drawing.Point(18, 83);
            this.switch1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.switch1.Name = "switch1";
            this.switch1.Size = new System.Drawing.Size(212, 123);
            this.switch1.TabIndex = 3;
            this.switch1.Click += new System.EventHandler(this.switch1_Click);
            this.switch1.DoubleClick += new System.EventHandler(this.switch1_DoubleClick);
            // 
            // switch2
            // 
            this.switch2.BackgroundImage = global::MouseClick_sound_ProVersion.Properties.Resources.off;
            this.switch2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.switch2.Location = new System.Drawing.Point(354, 83);
            this.switch2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.switch2.Name = "switch2";
            this.switch2.Size = new System.Drawing.Size(212, 123);
            this.switch2.TabIndex = 4;
            this.switch2.Click += new System.EventHandler(this.switch2_Click);
            this.switch2.DoubleClick += new System.EventHandler(this.switch2_DoubleClick);
            // 
            // mouseSoundSelection
            // 
            this.mouseSoundSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mouseSoundSelection.FormattingEnabled = true;
            this.mouseSoundSelection.Items.AddRange(new object[] {
            "sound 1 (release/press)",
            "sound 2",
            "sound 3",
            "sound 4",
            "custom sound (must be .wav)"});
            this.mouseSoundSelection.Location = new System.Drawing.Point(18, 231);
            this.mouseSoundSelection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mouseSoundSelection.Name = "mouseSoundSelection";
            this.mouseSoundSelection.Size = new System.Drawing.Size(210, 28);
            this.mouseSoundSelection.TabIndex = 5;
            this.mouseSoundSelection.DropDownClosed += new System.EventHandler(this.mouseSoundSelection_DropDownClosed);
            // 
            // notifyicon
            // 
            this.notifyicon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyicon.BalloonTipText = "MouseClick sound enabled";
            this.notifyicon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyicon.Icon")));
            this.notifyicon.Text = "notifyIcon1";
            this.notifyicon.Visible = true;
            // 
            // stayOntopCheckbox
            // 
            this.stayOntopCheckbox.AutoSize = true;
            this.stayOntopCheckbox.Location = new System.Drawing.Point(12, 376);
            this.stayOntopCheckbox.Name = "stayOntopCheckbox";
            this.stayOntopCheckbox.Size = new System.Drawing.Size(113, 24);
            this.stayOntopCheckbox.TabIndex = 0;
            this.stayOntopCheckbox.Text = "stay on top";
            this.stayOntopCheckbox.UseVisualStyleBackColor = true;
            this.stayOntopCheckbox.CheckedChanged += new System.EventHandler(this.stayOntopCheckbox_CheckedChanged);
            // 
            // keyboardSoundSelection
            // 
            this.keyboardSoundSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.keyboardSoundSelection.FormattingEnabled = true;
            this.keyboardSoundSelection.Items.AddRange(new object[] {
            "sound 1",
            "sound 2",
            "sound 3",
            "sound 4",
            "sound 5",
            "random sound",
            "custom sound (must be .wav)"});
            this.keyboardSoundSelection.Location = new System.Drawing.Point(354, 231);
            this.keyboardSoundSelection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.keyboardSoundSelection.Name = "keyboardSoundSelection";
            this.keyboardSoundSelection.Size = new System.Drawing.Size(210, 28);
            this.keyboardSoundSelection.TabIndex = 6;
            this.keyboardSoundSelection.DropDownClosed += new System.EventHandler(this.keyboardSoundSelection_DropDownClosed);
            // 
            // tryMouseSound
            // 
            this.tryMouseSound.Location = new System.Drawing.Point(18, 272);
            this.tryMouseSound.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tryMouseSound.Name = "tryMouseSound";
            this.tryMouseSound.Size = new System.Drawing.Size(212, 43);
            this.tryMouseSound.TabIndex = 7;
            this.tryMouseSound.Text = "try sound";
            this.tryMouseSound.UseVisualStyleBackColor = true;
            this.tryMouseSound.Click += new System.EventHandler(this.tryMouseSound_Click);
            // 
            // tryKeyboardSound
            // 
            this.tryKeyboardSound.Location = new System.Drawing.Point(354, 272);
            this.tryKeyboardSound.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tryKeyboardSound.Name = "tryKeyboardSound";
            this.tryKeyboardSound.Size = new System.Drawing.Size(212, 43);
            this.tryKeyboardSound.TabIndex = 8;
            this.tryKeyboardSound.Text = "try sound";
            this.tryKeyboardSound.UseVisualStyleBackColor = true;
            this.tryKeyboardSound.Click += new System.EventHandler(this.tryKeyboardSound_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "wav";
            this.openFileDialog.Filter = "audio wave file| *.wav";
            this.openFileDialog.Title = "Select .wav file";
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(374, 370);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(190, 34);
            this.HelpButton.TabIndex = 9;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(356, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "antek gzara animations 2022";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 444);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.tryKeyboardSound);
            this.Controls.Add(this.tryMouseSound);
            this.Controls.Add(this.keyboardSoundSelection);
            this.Controls.Add(this.stayOntopCheckbox);
            this.Controls.Add(this.mouseSoundSelection);
            this.Controls.Add(this.switch2);
            this.Controls.Add(this.switch1);
            this.Controls.Add(this.interactiveIcon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MouseClick Sound (Pro)";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel interactiveIcon;
        private System.Windows.Forms.Panel switch1;
        private System.Windows.Forms.Panel switch2;
        private System.Windows.Forms.ComboBox mouseSoundSelection;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NotifyIcon notifyicon;
        private System.Windows.Forms.CheckBox stayOntopCheckbox;
        private System.Windows.Forms.ComboBox keyboardSoundSelection;
        private System.Windows.Forms.Button tryMouseSound;
        private System.Windows.Forms.Button tryKeyboardSound;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Label label3;
    }
}

