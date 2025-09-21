using System;
using System.Windows.Forms;

namespace RadioGUI
{
    public partial class RadioGUI : Form
    {
        // --- Simple “radio” state ---
        private bool _isFm = true;                  // current band
        private readonly int[] _am = { 530, 700, 820, 1010, 1210, 1530 };           // kHz
        private readonly double[] _fm = { 88.7, 92.9, 96.3, 99.5, 104.7, 107.9 };   // MHz

        public RadioGUI()
        {
            InitializeComponent();
            this.Load += RadioGUI_Load;  // hook up load event
        }

        private void RadioGUI_Load(object sender, EventArgs e)
        {
            // Set default checked radio button
            rdoFM.Checked = true;

            // Try to load MusicNote.gif at runtime
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MusicNote.gif");
            if (File.Exists(path))
            {
                picNote.Image = Image.FromFile(path);
            }
            else
            {
                // Optional: fallback text or leave blank
                picNote.BackColor = Color.LightGray;
            }
        }


        // ---------------------------
        // Power
        // ---------------------------
        private void btnPower_Click(object sender, EventArgs e)
        {
            // Toggle the form enabled/disabled just to simulate power
            this.Enabled = !this.Enabled;
        }

        // ---------------------------
        // Presets
        // ---------------------------
        private void btnPreset_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn?.Tag == null) return;

            if (_isFm)
            {
                // Tag holds a double for FM
                double freq = Convert.ToDouble(btn.Tag);
                lblStation.Text = freq.ToString("0.0");   // e.g., 92.9
            }
            else
            {
                // Tag holds an int for AM
                int freq = Convert.ToInt32(btn.Tag);
                lblStation.Text = freq.ToString("0");     // e.g., 700
            }
        }

        // ---------------------------
        // Mute / Volume
        // ---------------------------
        private void chkMute_CheckedChanged(object sender, EventArgs e)
        {
            trkVolume.Enabled = !chkMute.Checked;
        }

        // ---------------------------
        // Band switching
        // ---------------------------
        private void rdoBand_CheckedChanged(object sender, EventArgs e)
        {
            // Only react when the button is being turned on
            var rb = sender as RadioButton;
            if (rb == null || !rb.Checked) return;

            _isFm = rb == rdoFM;

            // Apply the current band's preset values onto the preset buttons' Tags
            ApplyBandPresets();

            // Show the first preset for the chosen band
            if (_isFm)
                lblStation.Text = _fm[1].ToString("0.0");  // 92.9 (second slot)
            else
                lblStation.Text = _am[1].ToString("0");    // 700  (second slot)
        }

        private void ApplyBandPresets()
        {
            // Put the band-specific values into each preset button's Tag
            // (buttons already exist from Designer)
            if (_isFm)
            {
                btnPreset1.Tag = _fm[0];
                btnPreset2.Tag = _fm[1];
                btnPreset3.Tag = _fm[2];
                btnPreset4.Tag = _fm[3];
                btnPreset5.Tag = _fm[4];
                btnPreset6.Tag = _fm[5];
            }
            else
            {
                btnPreset1.Tag = _am[0];
                btnPreset2.Tag = _am[1];
                btnPreset3.Tag = _am[2];
                btnPreset4.Tag = _am[3];
                btnPreset5.Tag = _am[4];
                btnPreset6.Tag = _am[5];
            }
        }
    }
}
