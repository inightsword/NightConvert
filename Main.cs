using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NightConvert
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
            InputSize.Text = Input.TextLength.ToString();
        }

        private void Output_TextChanged(object sender, EventArgs e)
        {
            OutputSize.Text = Output.TextLength.ToString();
        }

        private void Base64Encode_Click(object sender, EventArgs e)
        {
            Output.Text = Converts.Base64Encode(Input.Text);
        }

        private void Base64Decode_Click(object sender, EventArgs e)
        {
            try
            {
                Output.Text = Converts.Base64Decode(Input.Text);
            }
            catch (Exception ex) { 
                Output.Text = "Error !";
            }
        }

        private void URLEncode_Click(object sender, EventArgs e)
        {
            Output.Text = Converts.UrlEncode(Input.Text);

        }

        private void URLDecode_Click(object sender, EventArgs e)
        {
            try
            {
                Output.Text = Converts.UrlDecode(Input.Text);
            }
            catch (Exception ex)
            {
                Output.Text = "Error !";
            }
        }

        private void HexEncode_Click(object sender, EventArgs e)
        {
            Output.Text = Converts.HexEncode(Input.Text);

        }

        private void HexDecode_Click(object sender, EventArgs e)
        {
            try
            {
                Output.Text = Converts.HexDecode(Input.Text);
            }
            catch (Exception ex)
            {
                Output.Text = "Error !";
            }
        }

        private void HtmlEncode_Click(object sender, EventArgs e)
        {
            Output.Text = Converts.HtmlEncode(Input.Text);

        }

        private void HtmlDecode_Click(object sender, EventArgs e)
        {
            try
            {
                Output.Text = Converts.HtmlDecode(Input.Text);
            }
            catch (Exception ex)
            {
                Output.Text = "Error !";
            }
        }

        private void Uppercase_Click(object sender, EventArgs e)
        {
            Output.Text =Input.Text.ToUpper();

        }

        private void Lowercase_Click(object sender, EventArgs e)
        {
            Output.Text = Input.Text.ToLower();

        }

        private void MD5_Click(object sender, EventArgs e)
        {
            Output.Text = Converts.ComputeMd5Hash(Input.Text);

        }

        private void SHA1_Click(object sender, EventArgs e)
        {
            Output.Text = Converts.ComputeSha1Hash(Input.Text);

        }

        private void Reverse_Click(object sender, EventArgs e)
        {
            Output.Text = Converts.ReverseString(Input.Text);

        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            Output.Text = Converts.EncryptString(Input.Text, EncryptKey.Text, "abcdef0123456789");

        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            try
            {
                Output.Text = Converts.DecryptString(Input.Text, EncryptKey.Text, "abcdef0123456789");
            }
            catch (Exception ex)
            {
                Output.Text = "Error !";
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Input.Text = "";
            Output.Text = "";
        }
    }
}
