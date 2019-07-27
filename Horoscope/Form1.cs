using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horoscope
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Sign> zodiac = new Dictionary<string, Sign>();
        private Sign signSelected;
        private static readonly Random rd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            zodiac["aries"] = new Sign()
            {
                name = "ARIES",
                period = "March 21 - April 20",
                image = "aries.jpg",
                predictions = new List<string> { "aries prediction 1", "aries prediction 2", "aries prediction 3" }
            };
            zodiac["taurus"] = new Sign()
            {
                name = "TAURUS",
                period = "Apr 21 - May 21",
                image = "taurus.jpg",
                predictions = new List<string> { "taurus prediction 1", "taurus prediction 2", "taurus prediction 3" }
            };
            zodiac["gemini"] = new Sign()
            {
                name = "GEMINI",
                period = "May 22 - Jun 21",
                image = "gemini.jpg",
                predictions = new List<string> { "gemini prediction 1", "gemini prediction 2", "gemini prediction 3" }
            };
            zodiac["cancer"] = new Sign()
            {
                name = "CANCER",
                period = "Jun 22 - Jul 23",
                image = "cancer.jpg",
                predictions = new List<string> { "cancer prediction 1", "cancer prediction 2", "cancer prediction 3" }
            };
            zodiac["leo"] = new Sign()
            {
                name = "LEO",
                period = "Jul 24 - Aug 23",
                image = "leo.jpg",
                predictions = new List<string> { "leo prediction 1", "leo prediction 2", "leo prediction 3" }
            };
            zodiac["virgo"] = new Sign()
            {
                name = "VIRGO",
                period = "Aug 24 - Sep 23",
                image = "virgo.jpg",
                predictions = new List<string> { "virgo prediction 1", "virgo prediction 2", "virgo prediction 3" }
            };
            zodiac["libra"] = new Sign()
            {
                name = "LIBRA",
                period = "Sep 24 - Oct 23",
                image = "libra.jpg",
                predictions = new List<string> { "libra prediction 1", "libra prediction 2", "libra prediction 3" }
            };
            zodiac["scorpio"] = new Sign()
            {
                name = "SCORPIO",
                period = "Oct 24 - Nov 22",
                image = "scorpio.jpg",
                predictions = new List<string> { "scorpio prediction 1", "scorpio prediction 2", "scorpio prediction 3" }
            };
            zodiac["scorpio"] = new Sign()
            {
                name = "SCORPIO",
                period = "Oct 24 - Nov 22",
                image = "scorpio.jpg",
                predictions = new List<string> { "scorpio prediction 1", "scorpio prediction 2", "scorpio prediction 3" }
            };
            zodiac["sagittarius"] = new Sign()
            {
                name = "SAGITTARIUS",
                period = "Nov 23 - Dec 21",
                image = "sagittarius.jpg",
                predictions = new List<string> { "sagittarius prediction 1", "sagittarius prediction 2", "sagittarius prediction 3" }
            };
            zodiac["capricorn"] = new Sign()
            {
                name = "CAPRICORN",
                period = "Dec 22 - Jan 20",
                image = "capricorn.jpg",
                predictions = new List<string> { "capricorn prediction 1", "capricorn prediction 2", "capricorn prediction 3" }
            };
            zodiac["aquarius"] = new Sign()
            {
                name = "AQUARIUS",
                period = "Jan 21 - Feb 19",
                image = "aquarius.jpg",
                predictions = new List<string> { "aquarius prediction 1", "aquarius prediction 2", "aquarius prediction 3" }
            };
            zodiac["pisces"] = new Sign()
            {
                name = "PISCES",
                period = "Feb 20 - Mar 20",
                image = "pisces.jpg",
                predictions = new List<string> { "pisces prediction 1", "pisces prediction 2", "pisces prediction 3" }
        };
            cmbZodiac.DataSource = new BindingSource(zodiac.Values, null);
        }

        private void cmbZodiac_SelectedIndexChanged(object sender, EventArgs e)
        {
           signSelected = (Sign)cmbZodiac.SelectedValue; // selected value is a Sign
            clearFields(); // clear predictions field

            loadPredictions(signSelected);
            loadImage(signSelected);
        }

        // Add new prediction to selected Sign
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nextPrediction = tbAddPrediction.Text.ToString();
            if (nextPrediction == null || nextPrediction == "")
                return;

            string key = signSelected.name.ToLower(); // sign key on Dictionary

            if (signSelected != null)
            {
                if (zodiac[key].predictions == null)
                    zodiac[key].predictions = new List<string>();

                zodiac[key].predictions.Add(nextPrediction);
                loadPredictions(signSelected); // refresh prediction list
            }
        }

        private void clearFields()
        {
            tbPredictions.Text = "";
        }

        // This event will format combobox presentation
        private void cmbZodiac_Format(object sender, ListControlConvertEventArgs e)
        {
            string name = ((Sign)e.ListItem).name;
            string period = ((Sign)e.ListItem).period;
            e.Value = name + " - ( " + period + " )";
        }

        // Load predictions based on sign selected
        private void loadPredictions(Sign sign)
        {
            tbPredictions.Text = "";
            tbRandom.Text = "";
            tbAddPrediction.Text = "Enter additional precition";

            if (sign.predictions == null)
                return;

            // We only will go through this block if sign.predictions ! = null
            foreach (string p in sign.predictions)
            {
                tbPredictions.Text = tbPredictions.Text + p + " ";
                tbPredictions.AppendText(Environment.NewLine);
            }
        }

        private void loadImage(Sign sign)
        {
            pbImages.Image = (sign.image == null) ? null : Image.FromFile(Environment.CurrentDirectory + "\\images\\" + sign.image);
            pbImages.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        // Get a random predictions from selected sign
        private void btnSeeNow_Click(object sender, EventArgs e)
        {
            tbRandom.Text = getRandomPrediction(signSelected);
        }


        private void btnEntire_Click(object sender, EventArgs e)
        {
            string horoscopeText = "";

            // Generate a text with all signs + random prediction (entire horoscope)

            foreach (KeyValuePair<string, Sign> s in zodiac)
            {
                Sign tempSign = s.Value;
                string tempRandomPrediction = getRandomPrediction(tempSign);

                horoscopeText += (tempSign.name + " => " + tempRandomPrediction);
                horoscopeText += Environment.NewLine;
                horoscopeText += Environment.NewLine;
            }

            Form2 f2 = new Form2();
            f2.text = horoscopeText;
            f2.Show();
        }



        // Get prediction randomly based on sign
        private string getRandomPrediction(Sign sign)
        {
            string randomPrediction = "";
            if (sign.predictions != null)
            {
                int randomIndex = rd.Next(sign.predictions.Count);
                randomPrediction = sign.predictions[randomIndex];
            }

            return randomPrediction;
        }

    }
}
