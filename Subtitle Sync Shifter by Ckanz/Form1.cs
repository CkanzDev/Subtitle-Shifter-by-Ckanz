using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Subtitle_Sync_Shifter_by_Ckanz
{
    public partial class Form1 : Form
    {
        public double miliseconds;
        public List<String> line = new List<string>();
        public List<String> newLine = new List<string>();
        public TimeSpan time = TimeSpan.FromMilliseconds(0);
        string text = "";
        static Dictionary<string, string> values = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
            textBox4.KeyPress += new KeyPressEventHandler(keypressed);
        }

        private void loadclik_Click_1(object sender, EventArgs e)
        {
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            newLine.Clear();
            line.Clear();
            values.Clear();
            foreach (String f in openfiledialog.FileNames)
            {
                text = File.ReadAllText(f);
                //textBox1.Text += f + "\r\n";
                foreach (string l in File.ReadAllLines(f))
                {
                    if (Regex.IsMatch(l, " --> "))
                    {
                        string[] determites = { " --> ", "-->" };
                        string[] i = l.Split(determites, StringSplitOptions.RemoveEmptyEntries);
                        line.Add(i[i.Count() - 2]);
                        line.Add(i[i.Count() - 1]);
                    }
                }
                //foreach (var line in File.ReadLines(f))
                //{
                //if (Regex.IsMatch(line, " --> "))
                //{
                //Console.Write("Ketemu" + line.Length);
                //string[] determites = { " --> ", "-->" };
                //lines = line.Split(determites, StringSplitOptions.RemoveEmptyEntries);
                //int result = Int32.Parse(lines[0]);
                //textBox1.Text += "Jumlah:" + lines.Count() + " Ketemu : " + lines[lines.Count() - 1] + "\r\n";
                //}
                //textBox3.Text += text;
            }
            //foreach (string l in line) textBox3.Text += l + "\r\n";
            label1.Text = "Done! Fill Miliseconds textbox and click button sync decrese or increse";
        }

        private void increaseclick_Click(object sender, EventArgs e)
        {
            if (miliseconds <= 0 || textBox4.Text == null || textBox4.Text == "") label1.Text = "miliseconds cant null or less than 1";
            label1.Text = "Wait...";
            textBox3.Text = "";
            foreach (string l in line)
            {
                //string newText = "";

                if (l.ToCharArray().Count() <= 12)
                {
                    string oldText = (0 + Convert.ToInt32(l[l.Count() - 12].ToString())).ToString() + (0 + Convert.ToInt32(l[l.Count() - 11].ToString())).ToString() + ":"
                    + (0 + Convert.ToInt32(l[l.Count() - 9].ToString())).ToString() + (0 + Convert.ToInt32(l[l.Count() - 8].ToString())).ToString() + ":"
                    + (0 + Convert.ToInt32(l[l.Count() - 6].ToString())).ToString() + (0 + Convert.ToInt32(l[l.Count() - 5].ToString())).ToString() + "."
                    + (0 + Convert.ToInt32(l[l.Count() - 3].ToString())).ToString() + (0 + Convert.ToInt32(l[l.Count() - 2].ToString())).ToString() + (0 + Convert.ToInt32(l[l.Count() - 1].ToString())).ToString();

                    //string oint = (Convert.ToInt32(oldText) + miliseconds).ToString();
                    TimeSpan ointTime = TimeSpan.Parse(oldText);
                    TimeSpan times = TimeSpan.FromMilliseconds(miliseconds);
                    TimeSpan oTime = ointTime.Add(times);
                    string oint = oTime.ToString();
                    char[] charsToTrim = { ':', '.' };
                    string oints = oint.Replace(".", ",").Remove(oint.Length - 4).ToString();
                    //textBox3.Text += oints + "\r\n";
                    //textBox3.Text += oint[oint.Count() - 1] + "\r\n";
                    //textBox3.Text += oint + "\r\n";
                    //textBox3.Text += oint.ToCharArray().Count() + "\r\n";
                    //textBox3.Text += "9" + "\r\n";
                    //newText = (0 + Convert.ToInt32(oint[oint.Count() - 9].ToString())).ToString() + (0 + Convert.ToInt32(oint[oint.Count() - 8].ToString())).ToString() + ":"
                    //+ (0 + Convert.ToInt32(oint[oint.Count() - 7].ToString())).ToString() + (0 + Convert.ToInt32(oint[oint.Count() - 6].ToString())).ToString() + ":"
                    //+ (0 + Convert.ToInt32(oint[oint.Count() - 5].ToString())).ToString() + (0 + Convert.ToInt32(oint[oint.Count() - 4].ToString())).ToString() + ","
                    //+ (0 + Convert.ToInt32(oint[oint.Count() - 3].ToString())).ToString() + (0 + Convert.ToInt32(oint[oint.Count() - 2].ToString())).ToString() + (0 + Convert.ToInt32(l[l.Count() - 1].ToString())).ToString();
                    //newText = (0 + Convert.ToInt32(oints[0])).ToString() + (0 + Convert.ToInt32(oints[1])).ToString() + ":"
                    //+ (0 + Convert.ToInt32(oints[2])).ToString() + (0 + Convert.ToInt32(oints[3])).ToString() + ":"
                    //+ (0 + Convert.ToInt32(oints[4])).ToString() + (0 + Convert.ToInt32(oints[5])).ToString() + ","
                    //+ (0 + Convert.ToInt32(oints[6])).ToString() + (0 + Convert.ToInt32(oints[7])).ToString() + (0 + Convert.ToInt32(oints[8])).ToString();
                    newLine.Add(oints);
                    for (var v = 0; v < newLine.Count() - 1; v++)
                    {
                        if(!values.ContainsKey(newLine[v]) || !values.ContainsKey(newLine[v]))
                        {
                            values.Add(newLine[v], line[v]);
                        }
                    }


                    //textBox3.Text += oints + "\r\n";
                    label1.Text = "Done! click save";

                }
            }
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);
                
            }
           
        }

        private void keypressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
                
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void syncdecreases_Click(object sender, EventArgs e)
        {
            if (miliseconds <= 0 || textBox4.Text == null || textBox4.Text == "") label1.Text = "miliseconds cant null or less than 1";
            label1.Text = "Wait...";
            textBox3.Text = "";
            foreach (string l in line)
            {
                //string newText = "";

                if (l.ToCharArray().Count() <= 12)
                {
                    string oldText = (0 + Convert.ToInt32(l[l.Count() - 12].ToString())).ToString() + (0 + Convert.ToInt32(l[l.Count() - 11].ToString())).ToString() + ":"
                    + (0 + Convert.ToInt32(l[l.Count() - 9].ToString())).ToString() + (0 + Convert.ToInt32(l[l.Count() - 8].ToString())).ToString() + ":"
                    + (0 + Convert.ToInt32(l[l.Count() - 6].ToString())).ToString() + (0 + Convert.ToInt32(l[l.Count() - 5].ToString())).ToString() + "."
                    + (0 + Convert.ToInt32(l[l.Count() - 3].ToString())).ToString() + (0 + Convert.ToInt32(l[l.Count() - 2].ToString())).ToString() + (0 + Convert.ToInt32(l[l.Count() - 1].ToString())).ToString();

                    //string oint = (Convert.ToInt32(oldText) + miliseconds).ToString();
                    TimeSpan ointTime = TimeSpan.Parse(oldText);
                    TimeSpan times = TimeSpan.FromMilliseconds(miliseconds);
                    TimeSpan oTime = ointTime.Subtract(times);
                    string oint = oTime.ToString();
                    char[] charsToTrim = { ':', '.' };
                    string oints = oint.Replace(".",",").Remove(oint.Length - 4).ToString();
                    //textBox3.Text += oints + "\r\n";
                    //textBox3.Text += oint[oint.Count() - 1] + "\r\n";
                    //textBox3.Text += oint + "\r\n";
                    //textBox3.Text += oint.ToCharArray().Count() + "\r\n";
                    //textBox3.Text += "9" + "\r\n";
                    //newText = (0 + Convert.ToInt32(oint[oint.Count() - 9].ToString())).ToString() + (0 + Convert.ToInt32(oint[oint.Count() - 8].ToString())).ToString() + ":"
                    //+ (0 + Convert.ToInt32(oint[oint.Count() - 7].ToString())).ToString() + (0 + Convert.ToInt32(oint[oint.Count() - 6].ToString())).ToString() + ":"
                    //+ (0 + Convert.ToInt32(oint[oint.Count() - 5].ToString())).ToString() + (0 + Convert.ToInt32(oint[oint.Count() - 4].ToString())).ToString() + ","
                    //+ (0 + Convert.ToInt32(oint[oint.Count() - 3].ToString())).ToString() + (0 + Convert.ToInt32(oint[oint.Count() - 2].ToString())).ToString() + (0 + Convert.ToInt32(l[l.Count() - 1].ToString())).ToString();
                    //newText = (0 + Convert.ToInt32(oints[0])).ToString() + (0 + Convert.ToInt32(oints[1])).ToString() + ":"
                    //+ (0 + Convert.ToInt32(oints[2])).ToString() + (0 + Convert.ToInt32(oints[3])).ToString() + ":"
                    //+ (0 + Convert.ToInt32(oints[4])).ToString() + (0 + Convert.ToInt32(oints[5])).ToString() + ","
                    //+ (0 + Convert.ToInt32(oints[6])).ToString() + (0 + Convert.ToInt32(oints[7])).ToString() + (0 + Convert.ToInt32(oints[8])).ToString();
                    newLine.Add(oints);
                    for (var v = 0; v < newLine.Count() - 1; v++)
                    {
                        if (!values.ContainsKey(newLine[v]) || !values.ContainsKey(newLine[v]))
                        {
                            values.Add(newLine[v], line[v]);
                        }
                    }

                    //textBox3.Text += ls + "\r\n";
                    label1.Text = "Done! click save";

                }
            }
        }

        private void Saveclicks_Click(object sender, EventArgs e)
        {
                foreach (String f in openfiledialog.FileNames)
                {
                //textBox1.Text += f + "\r\n";

                //StreamReader streamReader = new StreamReader(f, Encoding.UTF8);
                //string text = streamReader.ReadToEnd();
                string fs = Path.Combine("C:\\scraped.txt");
                string results = text;
                StringBuilder sv = new StringBuilder(text);
                //foreach (string l in File.ReadAllLines(f))
                //{
                 //for (int i = 0; i < newLine.Count(); i++)
                   //{
                     //Regex.Replace(text, line[i], newLine[i], RegexOptions.IgnoreCase);
                     //sv = sv.Replace(line[i], newLine[i]);
                     //results = sv.ToString();
                    //}
                 //}
                foreach (string k in values.Keys)
                {
                    text.Replace(k, values[k]);
                }
                //const int BufferSize = 65536;
                //StreamWriter sw = new StreamWriter(fs, true, Encoding.UTF8, BufferSize);
                //TextWriter w = new StreamWriter(new BufferedStream(new FileStream(fs, FileMode.Create)));
                //w.WriteLine(results);
                using (var stream = new FileStream(
    fs, FileMode.Create, FileAccess.Write, FileShare.Write, 4096))
                {
                    var bytes = Encoding.UTF8.GetBytes(results);
                    stream.Write(bytes, 0, bytes.Length);
                }
                //w.Write(results);
                //File.WriteAllText(fs, results);
                label1.Text = "Done File In : " + fs.ToString();

                results = "";
                sv.Clear();
                text = "";
                newLine.Clear();
                line.Clear();
                values.Clear();

            }
            
            
        }

        private void testbutton_Click(object sender, EventArgs e)
        {
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This Application Still In Development, many bugs and slow");
        }

        private void openfiledialog_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
    }
