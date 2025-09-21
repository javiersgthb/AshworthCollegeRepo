using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace RadioGUI
{
    partial class RadioGUI
    {
        private IContainer components = null;

        private GroupBox grpPresets;
        private Button btnPreset1;
        private Button btnPreset2;
        private Button btnPreset3;
        private Button btnPreset4;
        private Button btnPreset5;
        private Button btnPreset6;

        private GroupBox grpSpeakers;
        private CheckBox chkRear;
        private CheckBox chkFront;

        private Button btnPower;

        private GroupBox grpVolume;
        private CheckBox chkMute;
        private TrackBar trkVolume;

        private GroupBox grpTuning;
        private Label lblStation;
        private RadioButton rdoAM;
        private RadioButton rdoFM;

        private PictureBox picNote;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            grpPresets = new GroupBox();
            btnPreset1 = new Button();
            btnPreset2 = new Button();
            btnPreset3 = new Button();
            btnPreset4 = new Button();
            btnPreset5 = new Button();
            btnPreset6 = new Button();
            grpSpeakers = new GroupBox();
            chkRear = new CheckBox();
            chkFront = new CheckBox();
            btnPower = new Button();
            grpVolume = new GroupBox();
            chkMute = new CheckBox();
            trkVolume = new TrackBar();
            grpTuning = new GroupBox();
            lblStation = new Label();
            rdoAM = new RadioButton();
            rdoFM = new RadioButton();
            picNote = new PictureBox();
            grpPresets.SuspendLayout();
            grpSpeakers.SuspendLayout();
            grpVolume.SuspendLayout();
            ((ISupportInitialize)trkVolume).BeginInit();
            grpTuning.SuspendLayout();
            ((ISupportInitialize)picNote).BeginInit();
            SuspendLayout();
            // 
            // grpPresets
            // 
            grpPresets.Controls.Add(btnPreset1);
            grpPresets.Controls.Add(btnPreset2);
            grpPresets.Controls.Add(btnPreset3);
            grpPresets.Controls.Add(btnPreset4);
            grpPresets.Controls.Add(btnPreset5);
            grpPresets.Controls.Add(btnPreset6);
            grpPresets.Location = new Point(9, 9);
            grpPresets.Name = "grpPresets";
            grpPresets.Size = new Size(158, 52);
            grpPresets.TabIndex = 0;
            grpPresets.TabStop = false;
            grpPresets.Text = "Pre-set Stations";
            // 
            // btnPreset1
            // 
            btnPreset1.Location = new Point(9, 19);
            btnPreset1.Name = "btnPreset1";
            btnPreset1.Size = new Size(20, 22);
            btnPreset1.TabIndex = 0;
            btnPreset1.Text = "1";
            btnPreset1.Click += btnPreset_Click;
            // 
            // btnPreset2
            // 
            btnPreset2.Location = new Point(33, 19);
            btnPreset2.Name = "btnPreset2";
            btnPreset2.Size = new Size(20, 22);
            btnPreset2.TabIndex = 1;
            btnPreset2.Text = "2";
            btnPreset2.Click += btnPreset_Click;
            // 
            // btnPreset3
            // 
            btnPreset3.Location = new Point(58, 19);
            btnPreset3.Name = "btnPreset3";
            btnPreset3.Size = new Size(20, 22);
            btnPreset3.TabIndex = 2;
            btnPreset3.Text = "3";
            btnPreset3.Click += btnPreset_Click;
            // 
            // btnPreset4
            // 
            btnPreset4.Location = new Point(82, 19);
            btnPreset4.Name = "btnPreset4";
            btnPreset4.Size = new Size(20, 22);
            btnPreset4.TabIndex = 3;
            btnPreset4.Text = "4";
            btnPreset4.Click += btnPreset_Click;
            // 
            // btnPreset5
            // 
            btnPreset5.Location = new Point(107, 19);
            btnPreset5.Name = "btnPreset5";
            btnPreset5.Size = new Size(20, 22);
            btnPreset5.TabIndex = 4;
            btnPreset5.Text = "5";
            btnPreset5.Click += btnPreset_Click;
            // 
            // btnPreset6
            // 
            btnPreset6.Location = new Point(131, 19);
            btnPreset6.Name = "btnPreset6";
            btnPreset6.Size = new Size(20, 22);
            btnPreset6.TabIndex = 5;
            btnPreset6.Text = "6";
            btnPreset6.Click += btnPreset_Click;
            // 
            // grpSpeakers
            // 
            grpSpeakers.Controls.Add(chkRear);
            grpSpeakers.Controls.Add(chkFront);
            grpSpeakers.Location = new Point(175, 9);
            grpSpeakers.Name = "grpSpeakers";
            grpSpeakers.Size = new Size(126, 52);
            grpSpeakers.TabIndex = 1;
            grpSpeakers.TabStop = false;
            grpSpeakers.Text = "Speakers";
            // 
            // chkRear
            // 
            chkRear.AutoSize = true;
            chkRear.Location = new Point(9, 21);
            chkRear.Name = "chkRear";
            chkRear.Size = new Size(49, 19);
            chkRear.TabIndex = 0;
            chkRear.Text = "Rear";
            // 
            // chkFront
            // 
            chkFront.AutoSize = true;
            chkFront.Location = new Point(62, 21);
            chkFront.Name = "chkFront";
            chkFront.Size = new Size(54, 19);
            chkFront.TabIndex = 1;
            chkFront.Text = "Front";
            // 
            // btnPower
            // 
            btnPower.Location = new Point(307, 9);
            btnPower.Name = "btnPower";
            btnPower.Size = new Size(66, 52);
            btnPower.TabIndex = 2;
            btnPower.Text = "Power On/Off";
            btnPower.Click += btnPower_Click;
            // 
            // grpVolume
            // 
            grpVolume.Controls.Add(chkMute);
            grpVolume.Controls.Add(trkVolume);
            grpVolume.Location = new Point(9, 75);
            grpVolume.Name = "grpVolume";
            grpVolume.Size = new Size(158, 66);
            grpVolume.TabIndex = 3;
            grpVolume.TabStop = false;
            grpVolume.Text = "Volume Control";
            // 
            // chkMute
            // 
            chkMute.AutoSize = true;
            chkMute.Location = new Point(11, 19);
            chkMute.Name = "chkMute";
            chkMute.Size = new Size(54, 19);
            chkMute.TabIndex = 0;
            chkMute.Text = "Mute";
            chkMute.CheckedChanged += chkMute_CheckedChanged;
            // 
            // trkVolume
            // 
            trkVolume.Location = new Point(9, 38);
            trkVolume.Maximum = 100;
            trkVolume.Name = "trkVolume";
            trkVolume.Size = new Size(131, 45);
            trkVolume.TabIndex = 1;
            // 
            // grpTuning
            // 
            grpTuning.Controls.Add(lblStation);
            grpTuning.Controls.Add(rdoAM);
            grpTuning.Controls.Add(rdoFM);
            grpTuning.Location = new Point(175, 75);
            grpTuning.Name = "grpTuning";
            grpTuning.Size = new Size(126, 66);
            grpTuning.TabIndex = 4;
            grpTuning.TabStop = false;
            grpTuning.Text = "Tuning";
            // 
            // lblStation
            // 
            lblStation.BackColor = Color.Black;
            lblStation.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblStation.ForeColor = Color.Silver;
            lblStation.Location = new Point(9, 19);
            lblStation.Name = "lblStation";
            lblStation.Size = new Size(62, 41);
            lblStation.TabIndex = 0;
            lblStation.Text = "92.9";
            lblStation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rdoAM
            // 
            rdoAM.AutoSize = true;
            rdoAM.Location = new Point(77, 19);
            rdoAM.Name = "rdoAM";
            rdoAM.Size = new Size(44, 19);
            rdoAM.TabIndex = 1;
            rdoAM.Text = "AM";
            rdoAM.CheckedChanged += rdoBand_CheckedChanged;
            // 
            // rdoFM
            // 
            rdoFM.AutoSize = true;
            rdoFM.Location = new Point(77, 38);
            rdoFM.Name = "rdoFM";
            rdoFM.Size = new Size(42, 19);
            rdoFM.TabIndex = 2;
            rdoFM.Text = "FM";
            rdoFM.CheckedChanged += rdoBand_CheckedChanged;
            // 
            // picNote
            // 
            picNote.Location = new Point(307, 75);
            picNote.Name = "picNote";
            picNote.Size = new Size(66, 66);
            picNote.SizeMode = PictureBoxSizeMode.StretchImage;
            picNote.TabIndex = 5;
            picNote.TabStop = false;
            // 
            // RadioGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 182);
            Controls.Add(grpPresets);
            Controls.Add(grpSpeakers);
            Controls.Add(btnPower);
            Controls.Add(grpVolume);
            Controls.Add(grpTuning);
            Controls.Add(picNote);
            Name = "RadioGUI";
            Text = "RadioGUI";
            Load += RadioGUI_Load;
            grpPresets.ResumeLayout(false);
            grpSpeakers.ResumeLayout(false);
            grpSpeakers.PerformLayout();
            grpVolume.ResumeLayout(false);
            grpVolume.PerformLayout();
            ((ISupportInitialize)trkVolume).EndInit();
            grpTuning.ResumeLayout(false);
            grpTuning.PerformLayout();
            ((ISupportInitialize)picNote).EndInit();
            ResumeLayout(false);
        }
    }
}
