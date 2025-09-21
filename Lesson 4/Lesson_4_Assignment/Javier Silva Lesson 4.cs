using System;
using System.Drawing;
using System.Windows.Forms;

namespace RadioGUI
{
    public class RadioForm : Form
    {
        public RadioForm()
        {
            // Form properties
            this.Text = "Radio";
            this.Size = new Size(427, 194);
            this.Font = new Font("Segoe UI", 9);

            // --- Pre-set Stations GroupBox ---
            GroupBox presetGroup = new GroupBox();
            presetGroup.Text = "Pre-set Stations";
            presetGroup.Size = new Size(180, 55);
            presetGroup.Location = new Point(10, 10);

            for (int i = 0; i < 6; i++)
            {
                Button presetBtn = new Button();
                presetBtn.Text = (i + 1).ToString();
                presetBtn.Size = new Size(23, 23);
                presetBtn.Location = new Point(10 + (i * 28), 20);
                presetGroup.Controls.Add(presetBtn);
            }
            this.Controls.Add(presetGroup);

            // --- Speakers GroupBox ---
            GroupBox speakersGroup = new GroupBox();
            speakersGroup.Text = "Speakers";
            speakersGroup.Size = new Size(120, 55);
            speakersGroup.Location = new Point(200, 10);

            CheckBox rearChk = new CheckBox();
            rearChk.Text = "Rear";
            rearChk.Location = new Point(10, 20);
            speakersGroup.Controls.Add(rearChk);

            CheckBox frontChk = new CheckBox();
            frontChk.Text = "Front";
            frontChk.Location = new Point(60, 20);
            speakersGroup.Controls.Add(frontChk);

            this.Controls.Add(speakersGroup);

            // --- Power On/Off Button ---
            Button powerBtn = new Button();
            powerBtn.Text = "Power On/Off";
            powerBtn.Size = new Size(75, 55);
            powerBtn.Location = new Point(330, 10);
            this.Controls.Add(powerBtn);

            // --- Volume Control GroupBox ---
            GroupBox volumeGroup = new GroupBox();
            volumeGroup.Text = "Volume Control";
            volumeGroup.Size = new Size(180, 70);
            volumeGroup.Location = new Point(10, 80);

            CheckBox muteChk = new CheckBox();
            muteChk.Text = "Mute";
            muteChk.Location = new Point(10, 20);
            volumeGroup.Controls.Add(muteChk);

            TrackBar volumeTrack = new TrackBar();
            volumeTrack.Location = new Point(10, 40);
            volumeTrack.Width = 150;
            volumeGroup.Controls.Add(volumeTrack);

            this.Controls.Add(volumeGroup);

            // --- Tuning GroupBox ---
            GroupBox tuningGroup = new GroupBox();
            tuningGroup.Text = "Tuning";
            tuningGroup.Size = new Size(120, 70);
            tuningGroup.Location = new Point(200, 80);

            Label stationLbl = new Label();
            stationLbl.Text = "92.9";
            stationLbl.Size = new Size(50, 44);
            stationLbl.Location = new Point(10, 20);
            stationLbl.BackColor = Color.Black;
            stationLbl.ForeColor = Color.Silver;
            stationLbl.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            stationLbl.TextAlign = ContentAlignment.MiddleCenter;
            tuningGroup.Controls.Add(stationLbl);

            RadioButton amBtn = new RadioButton();
            amBtn.Text = "AM";
            amBtn.Location = new Point(70, 20);
            tuningGroup.Controls.Add(amBtn);

            RadioButton fmBtn = new RadioButton();
            fmBtn.Text = "FM";
            fmBtn.Location = new Point(70, 40);
            tuningGroup.Controls.Add(fmBtn);

            this.Controls.Add(tuningGroup);

            // --- PictureBox (Music Note) ---
            PictureBox picture = new PictureBox();
            picture.Size = new Size(55, 70);
            picture.Location = new Point(330, 80);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;

            // Replace with your actual path to MusicNote.gif
            picture.Image = Image.FromFile("MusicNote.gif");

            this.Controls.Add(picture);
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new RadioForm());
        }
    }
}
