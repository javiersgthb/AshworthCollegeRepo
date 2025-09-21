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
            components = new Container();

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

            ((ISupportInitialize)(trkVolume)).BeginInit();
            ((ISupportInitialize)(picNote)).BeginInit();

            SuspendLayout();

            // --------- grpPresets ---------
            grpPresets.Text = "Pre-set Stations";
            grpPresets.Location = new Point(10, 10);
            grpPresets.Size = new Size(180, 55);

            btnPreset1.Text = "1";
            btnPreset1.Location = new Point(10, 20);
            btnPreset1.Size = new Size(23, 23);
            btnPreset1.Click += new System.EventHandler(btnPreset_Click);

            btnPreset2.Text = "2";
            btnPreset2.Location = new Point(38, 20);
            btnPreset2.Size = new Size(23, 23);
            btnPreset2.Click += new System.EventHandler(btnPreset_Click);

            btnPreset3.Text = "3";
            btnPreset3.Location = new Point(66, 20);
            btnPreset3.Size = new Size(23, 23);
            btnPreset3.Click += new System.EventHandler(btnPreset_Click);

            btnPreset4.Text = "4";
            btnPreset4.Location = new Point(94, 20);
            btnPreset4.Size = new Size(23, 23);
            btnPreset4.Click += new System.EventHandler(btnPreset_Click);

            btnPreset5.Text = "5";
            btnPreset5.Location = new Point(122, 20);
            btnPreset5.Size = new Size(23, 23);
            btnPreset5.Click += new System.EventHandler(btnPreset_Click);

            btnPreset6.Text = "6";
            btnPreset6.Location = new Point(150, 20);
            btnPreset6.Size = new Size(23, 23);
            btnPreset6.Click += new System.EventHandler(btnPreset_Click);

            grpPresets.Controls.AddRange(new Control[] {
                btnPreset1, btnPreset2, btnPreset3, btnPreset4, btnPreset5, btnPreset6
            });

            // --------- grpSpeakers ---------
            grpSpeakers.Text = "Speakers";
            grpSpeakers.Location = new Point(200, 10);
            grpSpeakers.Size = new Size(120, 55);

            chkRear.Text = "Rear";
            chkRear.Location = new Point(10, 22);
            chkRear.AutoSize = true;

            chkFront.Text = "Front";
            chkFront.Location = new Point(60, 22);
            chkFront.AutoSize = true;

            grpSpeakers.Controls.AddRange(new Control[] { chkRear, chkFront });

            // --------- btnPower ---------
            btnPower.Text = "Power On/Off";
            btnPower.Location = new Point(330, 10);
            btnPower.Size = new Size(75, 55);
            btnPower.Click += new System.EventHandler(btnPower_Click);

            // --------- grpVolume ---------
            grpVolume.Text = "Volume Control";
            grpVolume.Location = new Point(10, 80);
            grpVolume.Size = new Size(180, 70);

            chkMute.Text = "Mute";
            chkMute.Location = new Point(10, 20);
            chkMute.AutoSize = true;
            chkMute.CheckedChanged += new System.EventHandler(chkMute_CheckedChanged);

            trkVolume.Location = new Point(10, 40);
            trkVolume.Width = 150;
            trkVolume.Minimum = 0;
            trkVolume.Maximum = 100;

            grpVolume.Controls.AddRange(new Control[] { chkMute, trkVolume });

            // --------- grpTuning ---------
            grpTuning.Text = "Tuning";
            grpTuning.Location = new Point(200, 80);
            grpTuning.Size = new Size(120, 70);

            lblStation.Text = "92.9";
            lblStation.Location = new Point(10, 20);
            lblStation.Size = new Size(50, 44);
            lblStation.BackColor = Color.Black;
            lblStation.ForeColor = Color.Silver;
            lblStation.TextAlign = ContentAlignment.MiddleCenter;
            lblStation.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            rdoAM.Text = "AM";
            rdoAM.Location = new Point(70, 20);
            rdoAM.AutoSize = true;
            rdoAM.CheckedChanged += new System.EventHandler(rdoBand_CheckedChanged);

            rdoFM.Text = "FM";
            rdoFM.Location = new Point(70, 40);
            rdoFM.AutoSize = true;
            rdoFM.CheckedChanged += new System.EventHandler(rdoBand_CheckedChanged);

            grpTuning.Controls.AddRange(new Control[] { lblStation, rdoAM, rdoFM });

            // --------- picNote ---------
            picNote.Location = new Point(330, 80);
            picNote.Size = new Size(55, 70);
            picNote.SizeMode = PictureBoxSizeMode.StretchImage;
            // DO NOT set Image here in Designer

            // --------- Form ---------
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 194);
            Name = "RadioGUI";
            Text = "RadioGUI";
            Load += new System.EventHandler(RadioGUI_Load);

            Controls.AddRange(new Control[] {
                grpPresets, grpSpeakers, btnPower, grpVolume, grpTuning, picNote
            });

            ((ISupportInitialize)(trkVolume)).EndInit();
            ((ISupportInitialize)(picNote)).EndInit();
            ResumeLayout(false);
        }
    }
}
