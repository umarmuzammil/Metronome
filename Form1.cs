using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;
using System.Media;
using NAudio.Wave;
using NAudio.CoreAudioApi;


namespace Metronome
{
    public partial class Form1 : Form
    {


        int NumOFBeats = 4;        
        int duration = 0;

        static string Path = @"c:\Windows\Media\ding.wav";

        SoundPlayer BeatSound = new SoundPlayer(Path);

        private AudioFileReader wave = null;      
        private WasapiOut output;        

        Color PColor = Color.Black;
        Color SColor = Color.DarkTurquoise;     
        

         public Form1()
         {
             InitializeComponent();
             BeatNum.TabStop = false;
             trackBar1.Value = 60;
             MenuItems();
             DisplayBeatColor("Green");
         }

         public IEnumerable<ToolStripMenuItem> GetItems(ToolStripMenuItem item)
         {
             foreach (ToolStripMenuItem dropDownItem in item.DropDownItems)
             {
                 if (dropDownItem.HasDropDownItems)
                 {
                     foreach (ToolStripMenuItem subItem in GetItems(dropDownItem))
                     {                         
                         yield return subItem;                     
                     }                         
                 }
                 yield return dropDownItem;                 
             }             
         }

         IEnumerable<ToolStripMenuItem> MenuItems() 
         {
             List<ToolStripMenuItem>SubItems = new List<ToolStripMenuItem>();
             List<ToolStripItem> allItems = new List<ToolStripItem>();
             foreach (ToolStripMenuItem toolItem in menuStrip1.Items)
             {
                 allItems.Add(toolItem);
                 //allItems.AddRange(GetItems(toolItem));               
             }
             foreach (ToolStripMenuItem T in allItems)
             {
                 foreach (ToolStripMenuItem dropDown in T.DropDownItems)
                 {
                     SubItems.Add(dropDown);                      
                  }                 
             }
             return SubItems;
         }

        

        private void timer1_Tick(object sender, EventArgs e)
        {

           AudioClientShareMode shareMode = AudioClientShareMode.Shared;
            wave = new AudioFileReader(Path);
            output = new WasapiOut(shareMode, 20);
            

            label2.Text = duration.ToString();
            duration++;


            int CurrentBeat = int.Parse(BeatNum.Text);
            if (CurrentBeat >= NumOFBeats)
            {
                wave.Volume = 1f;
                BeatNum.Text = "1";
                BeatNum.BackColor = SColor;
            }
            else
            {
                wave.Volume = 15f;                
                CurrentBeat += 1;
                BeatNum.Text = CurrentBeat.ToString();
                BeatNum.BackColor = PColor;              
            }

            output.Init(wave);
            output.Play();
         
            
        }       

        void StopMetronome()
        {            
            timer1.Stop();
            Reset();
        }

        void Reset()
        {
            BeatNum.Text = "1";
            duration = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Start")
            {
                timer1.Start();                
                button1.Text = "Stop";                
            }
            else
            {
                button1.Text = "Start";
                StopMetronome();
            }            
        }

        private void primaryColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                SColor = colorDialog1.Color;               
            }
        }

        private void accentColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                PColor = colorDialog2.Color;                 
            }

        }

        private void chooseSoundToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string FilePath = "";
            // Set filter options and filter index.
            openFileDialog1.Filter = "All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                FilePath = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
            }

            Path = FilePath;
            if (Path != "" || Path != null)
                BeatSound = new SoundPlayer(FilePath);

        }

        private void default1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BeatSound = new SoundPlayer(@"c:\Windows\Media\ding.wav");
        }

        private void default2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BeatSound = new SoundPlayer(@"c:\Windows\Media\Chimes.wav");
        }

        private void default3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BeatSound = new SoundPlayer(@"c:\Windows\Media\Windows Balloon.wav");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.Show();
        }
        
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString() + " Beats Per Minute";          
            
            float Ticks = (60f/trackBar1.Value)*1000f;
            int bpm = Convert.ToInt32(Ticks);
   
            timer1.Interval = bpm;       

        }

        void DisplayBeatColor(String S)
        {

            List<ToolStripMenuItem> Items = new List<ToolStripMenuItem>();
            Items.AddRange(MenuItems());
            if (S == "Green")
            {
                foreach (ToolStripMenuItem T in Items)
                {
                    if (T.Text == "Display Beat Count")
                        T.BackColor = System.Drawing.Color.Chartreuse;
                }
            }
            else
            {
                foreach (ToolStripMenuItem T in Items)
                {
                    if (T.Text == "Display Beat Count")
                        T.BackColor = SystemColors.Control;
                }
            }
            

 
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<ToolStripMenuItem> Items = new List<ToolStripMenuItem>();
            Items.AddRange(MenuItems());



            if (label2.Visible == true)
            {
                DisplayBeatColor("Black");
                label2.Visible = false;
            }

            else
            {
                DisplayBeatColor("Green");
                label2.Visible = true;            
            }
                
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            NumOFBeats = trackBar2.Value;
            label3.Text = trackBar2.Value.ToString() + " Beats Per Cycle";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
