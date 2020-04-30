using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CSCore;
using CSCore.Codecs;
using CSCore.DSP;
using CSCore.SoundOut;
using CSCore.SoundIn;
using CSCore.Streams;
using CSCore.Streams.Effects;
using WinformsVisualization.Visualization;
using System.Diagnostics;

namespace RedragonVisualizer
{
    public partial class Form1 : Form
    {
        private WasapiCapture _soundIn;
        private ISoundOut _soundOut;
        private IWaveSource _source;
        private PitchShifter _pitchShifter;
        private LineSpectrum _lineSpectrum;
        private bool Running = false;
        private Color Vis_Color = Color.Red;
        private bool isMouseDown = false;
        private Point mouseOffset;

        [DllImport("Redragon RGB SDK.dll")]
        public static extern bool InitializeDevice();
        [DllImport("Redragon RGB SDK.dll")]
        public static extern bool RedragonSetColor(int R, int G, int B, int Level);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Stop();
            _soundIn = new WasapiLoopbackCapture();
            _soundIn.Initialize();

            var soundInSource = new SoundInSource(_soundIn);
            ISampleSource source = soundInSource.ToSampleSource().AppendSource(x => new PitchShifter(x), out _pitchShifter);
            SetupSampleSource(source);

            byte[] buffer = new byte[_source.WaveFormat.BytesPerSecond / 2];
            soundInSource.DataAvailable += (s, aEvent) =>
            {
                int read;
                while ((read = _source.Read(buffer, 0, buffer.Length)) > 0) ;
            };

            _soundIn.Start();
        }
        private void SetupSampleSource(ISampleSource aSampleSource)
        {
            const FftSize fftSize = FftSize.Fft128;
            var spectrumProvider = new BasicSpectrumProvider(aSampleSource.WaveFormat.Channels,
                aSampleSource.WaveFormat.SampleRate, fftSize);
            _lineSpectrum = new LineSpectrum(fftSize)
            {
                SpectrumProvider = spectrumProvider,
                UseAverage = true,
                BarCount = 50,
                BarSpacing = 2,
                IsXLogScale = true,
                ScalingStrategy = ScalingStrategy.Linear
            };
            var notificationSource = new SingleBlockNotificationStream(aSampleSource);
            notificationSource.SingleBlockRead += (s, a) => spectrumProvider.Add(a.Left, a.Right);
            _source = notificationSource.ToWaveSource(16);

        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            Stop();
        }
        private void Stop()
        {
            if (_soundOut != null)
            {
                _soundOut.Stop();
                _soundOut.Dispose();
                _soundOut = null;
            }
            if (_soundIn != null)
            {
                _soundIn.Stop();
                _soundIn.Dispose();
                _soundIn = null;
            }
            if (_source != null)
            {
                _source.Dispose();
                _source = null;
            }
        }

        private void VisualizerSync_DoWork(object sender, DoWorkEventArgs e)
        {
            while (Running) {
                var fftBuffer = new float[(int)FftSize.Fft128];
                if (_lineSpectrum.SpectrumProvider.GetFftData(fftBuffer, this))
                {
                    double bass = 0.0;
                    for (int z = 0; z < 8; z++)
                    {
                        bass += (fftBuffer[z] * 4);
                    }
                    bass -= 0.5;
                    if (bass > 1.0)
                    {
                        bass = 1.0;
                    }
                    else if (bass < 0.0)
                    {
                        bass = 0.0;
                    }

                    // Customize Color

                    int R, G, B;
                    R = Convert.ToInt32(Convert.ToDouble(Vis_Color.R) * bass);
                    G = Convert.ToInt32(Convert.ToDouble(Vis_Color.G) * bass);
                    B = Convert.ToInt32(Convert.ToDouble(Vis_Color.B) * bass);

                    MousePic.BackColor = Color.FromArgb(R, G, B);

                    if (!RedragonSetColor(R, G, B, 3))
                    {
                        Running = false;
                        MessageBox.Show("Device not connected");
                    }
                    else {
                        System.Threading.Thread.Sleep(50);
                    }
                }
            }
        }

        private void Start_VisualizerBTN_Click(object sender, EventArgs e)
        {
            if (Start_VisualizerBTN.Text == "Start")
            {
                if (InitializeDevice())
                {
                    Running = true;
                    VisualizerSync.RunWorkerAsync();
                    Start_VisualizerBTN.Text = "Stop";
                }
                else
                {
                    MessageBox.Show("Device not connected");
                }
            }
            else {
                Running = false;
                VisualizerSync.CancelAsync();
                Start_VisualizerBTN.Text = "Start";
            }
        }

        private void ColorBox_Click(object sender, EventArgs e)
        {
            if (ColorPicker.ShowDialog() == DialogResult.OK) {
                Vis_Color = ColorPicker.Color;
                ColorBox.BackColor = Vis_Color;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/d4rkTT");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void APPcontrolbar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOffset = new Point(-e.X, -e.Y);
                isMouseDown = true;
            }
        }

        private void APPcontrolbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point Mpos = Control.MousePosition;
                Mpos.Offset(mouseOffset.X, mouseOffset.Y);
                this.Location = Mpos;
            }
        }

        private void APPcontrolbar_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
    }
}
