namespace NightConvert
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Input = new System.Windows.Forms.RichTextBox();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.InputSize = new System.Windows.Forms.Label();
            this.OutputSize = new System.Windows.Forms.Label();
            this.NightConvertLabel = new System.Windows.Forms.Label();
            this.Base64Decode = new System.Windows.Forms.Button();
            this.URLEncode = new System.Windows.Forms.Button();
            this.URLDecode = new System.Windows.Forms.Button();
            this.HexEncode = new System.Windows.Forms.Button();
            this.HexDecode = new System.Windows.Forms.Button();
            this.SHA1 = new System.Windows.Forms.Button();
            this.MD5 = new System.Windows.Forms.Button();
            this.Lowercase = new System.Windows.Forms.Button();
            this.Uppercase = new System.Windows.Forms.Button();
            this.HtmlDecode = new System.Windows.Forms.Button();
            this.HtmlEncode = new System.Windows.Forms.Button();
            this.Encrypt = new System.Windows.Forms.Button();
            this.Decrypt = new System.Windows.Forms.Button();
            this.Base64Encode = new System.Windows.Forms.Button();
            this.Reverse = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.AseLabel = new System.Windows.Forms.Label();
            this.EncryptKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Input.Dock = System.Windows.Forms.DockStyle.Top;
            this.Input.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input.Location = new System.Drawing.Point(0, 0);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(574, 160);
            this.Input.TabIndex = 0;
            this.Input.Text = "";
            this.Input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // Output
            // 
            this.Output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Output.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Output.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(0, 423);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(574, 187);
            this.Output.TabIndex = 1;
            this.Output.Text = "";
            this.Output.TextChanged += new System.EventHandler(this.Output_TextChanged);
            // 
            // InputSize
            // 
            this.InputSize.AutoSize = true;
            this.InputSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InputSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputSize.Location = new System.Drawing.Point(4, 166);
            this.InputSize.Name = "InputSize";
            this.InputSize.Size = new System.Drawing.Size(14, 15);
            this.InputSize.TabIndex = 2;
            this.InputSize.Text = "0";
            this.InputSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OutputSize
            // 
            this.OutputSize.AutoSize = true;
            this.OutputSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OutputSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputSize.Location = new System.Drawing.Point(4, 402);
            this.OutputSize.Name = "OutputSize";
            this.OutputSize.Size = new System.Drawing.Size(14, 15);
            this.OutputSize.TabIndex = 3;
            this.OutputSize.Text = "0";
            this.OutputSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NightConvertLabel
            // 
            this.NightConvertLabel.AutoSize = true;
            this.NightConvertLabel.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NightConvertLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(64)))), ((int)(((byte)(46)))));
            this.NightConvertLabel.Location = new System.Drawing.Point(1, 272);
            this.NightConvertLabel.Name = "NightConvertLabel";
            this.NightConvertLabel.Size = new System.Drawing.Size(161, 34);
            this.NightConvertLabel.TabIndex = 4;
            this.NightConvertLabel.Text = "NightConvert";
            this.NightConvertLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Base64Decode
            // 
            this.Base64Decode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(64)))), ((int)(((byte)(46)))));
            this.Base64Decode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Base64Decode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Base64Decode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Base64Decode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Base64Decode.Location = new System.Drawing.Point(179, 208);
            this.Base64Decode.Name = "Base64Decode";
            this.Base64Decode.Size = new System.Drawing.Size(117, 37);
            this.Base64Decode.TabIndex = 5;
            this.Base64Decode.Text = "Base64 Decode";
            this.Base64Decode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Base64Decode.UseVisualStyleBackColor = false;
            this.Base64Decode.Click += new System.EventHandler(this.Base64Decode_Click);
            // 
            // URLEncode
            // 
            this.URLEncode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(64)))), ((int)(((byte)(46)))));
            this.URLEncode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.URLEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.URLEncode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLEncode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.URLEncode.Location = new System.Drawing.Point(179, 251);
            this.URLEncode.Name = "URLEncode";
            this.URLEncode.Size = new System.Drawing.Size(117, 37);
            this.URLEncode.TabIndex = 6;
            this.URLEncode.Text = "URL Encode";
            this.URLEncode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.URLEncode.UseVisualStyleBackColor = false;
            this.URLEncode.Click += new System.EventHandler(this.URLEncode_Click);
            // 
            // URLDecode
            // 
            this.URLDecode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(64)))), ((int)(((byte)(46)))));
            this.URLDecode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.URLDecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.URLDecode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLDecode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.URLDecode.Location = new System.Drawing.Point(179, 294);
            this.URLDecode.Name = "URLDecode";
            this.URLDecode.Size = new System.Drawing.Size(117, 37);
            this.URLDecode.TabIndex = 7;
            this.URLDecode.Text = "URL Decode";
            this.URLDecode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.URLDecode.UseVisualStyleBackColor = false;
            this.URLDecode.Click += new System.EventHandler(this.URLDecode_Click);
            // 
            // HexEncode
            // 
            this.HexEncode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(64)))), ((int)(((byte)(46)))));
            this.HexEncode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.HexEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HexEncode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HexEncode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HexEncode.Location = new System.Drawing.Point(179, 337);
            this.HexEncode.Name = "HexEncode";
            this.HexEncode.Size = new System.Drawing.Size(117, 37);
            this.HexEncode.TabIndex = 8;
            this.HexEncode.Text = "Hex Encode";
            this.HexEncode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HexEncode.UseVisualStyleBackColor = false;
            this.HexEncode.Click += new System.EventHandler(this.HexEncode_Click);
            // 
            // HexDecode
            // 
            this.HexDecode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(64)))), ((int)(((byte)(46)))));
            this.HexDecode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.HexDecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HexDecode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HexDecode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HexDecode.Location = new System.Drawing.Point(179, 380);
            this.HexDecode.Name = "HexDecode";
            this.HexDecode.Size = new System.Drawing.Size(117, 37);
            this.HexDecode.TabIndex = 9;
            this.HexDecode.Text = "Hex Decode";
            this.HexDecode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HexDecode.UseVisualStyleBackColor = false;
            this.HexDecode.Click += new System.EventHandler(this.HexDecode_Click);
            // 
            // SHA1
            // 
            this.SHA1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(64)))), ((int)(((byte)(46)))));
            this.SHA1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SHA1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SHA1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHA1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SHA1.Location = new System.Drawing.Point(314, 380);
            this.SHA1.Name = "SHA1";
            this.SHA1.Size = new System.Drawing.Size(117, 37);
            this.SHA1.TabIndex = 14;
            this.SHA1.Text = "SHA1";
            this.SHA1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SHA1.UseVisualStyleBackColor = false;
            this.SHA1.Click += new System.EventHandler(this.SHA1_Click);
            // 
            // MD5
            // 
            this.MD5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(64)))), ((int)(((byte)(46)))));
            this.MD5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MD5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MD5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MD5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MD5.Location = new System.Drawing.Point(314, 337);
            this.MD5.Name = "MD5";
            this.MD5.Size = new System.Drawing.Size(117, 37);
            this.MD5.TabIndex = 13;
            this.MD5.Text = "MD5";
            this.MD5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MD5.UseVisualStyleBackColor = false;
            this.MD5.Click += new System.EventHandler(this.MD5_Click);
            // 
            // Lowercase
            // 
            this.Lowercase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(64)))), ((int)(((byte)(46)))));
            this.Lowercase.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Lowercase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lowercase.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lowercase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lowercase.Location = new System.Drawing.Point(314, 294);
            this.Lowercase.Name = "Lowercase";
            this.Lowercase.Size = new System.Drawing.Size(117, 37);
            this.Lowercase.TabIndex = 12;
            this.Lowercase.Text = "Lowercase";
            this.Lowercase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lowercase.UseVisualStyleBackColor = false;
            this.Lowercase.Click += new System.EventHandler(this.Lowercase_Click);
            // 
            // Uppercase
            // 
            this.Uppercase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(64)))), ((int)(((byte)(46)))));
            this.Uppercase.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Uppercase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Uppercase.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uppercase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Uppercase.Location = new System.Drawing.Point(314, 251);
            this.Uppercase.Name = "Uppercase";
            this.Uppercase.Size = new System.Drawing.Size(117, 37);
            this.Uppercase.TabIndex = 11;
            this.Uppercase.Text = "Uppercase";
            this.Uppercase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Uppercase.UseVisualStyleBackColor = false;
            this.Uppercase.Click += new System.EventHandler(this.Uppercase_Click);
            // 
            // HtmlDecode
            // 
            this.HtmlDecode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(64)))), ((int)(((byte)(46)))));
            this.HtmlDecode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.HtmlDecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HtmlDecode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HtmlDecode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HtmlDecode.Location = new System.Drawing.Point(314, 208);
            this.HtmlDecode.Name = "HtmlDecode";
            this.HtmlDecode.Size = new System.Drawing.Size(117, 37);
            this.HtmlDecode.TabIndex = 10;
            this.HtmlDecode.Text = "Html Decode";
            this.HtmlDecode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HtmlDecode.UseVisualStyleBackColor = false;
            this.HtmlDecode.Click += new System.EventHandler(this.HtmlDecode_Click);
            // 
            // HtmlEncode
            // 
            this.HtmlEncode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(64)))), ((int)(((byte)(46)))));
            this.HtmlEncode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.HtmlEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HtmlEncode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HtmlEncode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HtmlEncode.Location = new System.Drawing.Point(314, 166);
            this.HtmlEncode.Name = "HtmlEncode";
            this.HtmlEncode.Size = new System.Drawing.Size(117, 37);
            this.HtmlEncode.TabIndex = 15;
            this.HtmlEncode.Text = "Html Encode";
            this.HtmlEncode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HtmlEncode.UseVisualStyleBackColor = false;
            this.HtmlEncode.Click += new System.EventHandler(this.HtmlEncode_Click);
            // 
            // Encrypt
            // 
            this.Encrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(64)))), ((int)(((byte)(46)))));
            this.Encrypt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Encrypt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encrypt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Encrypt.Location = new System.Drawing.Point(450, 294);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(117, 37);
            this.Encrypt.TabIndex = 16;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Encrypt.UseVisualStyleBackColor = false;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(64)))), ((int)(((byte)(46)))));
            this.Decrypt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Decrypt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decrypt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Decrypt.Location = new System.Drawing.Point(450, 337);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(117, 37);
            this.Decrypt.TabIndex = 17;
            this.Decrypt.Text = "Decrypt";
            this.Decrypt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Decrypt.UseVisualStyleBackColor = false;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // Base64Encode
            // 
            this.Base64Encode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(64)))), ((int)(((byte)(46)))));
            this.Base64Encode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Base64Encode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Base64Encode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Base64Encode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Base64Encode.Location = new System.Drawing.Point(179, 166);
            this.Base64Encode.Name = "Base64Encode";
            this.Base64Encode.Size = new System.Drawing.Size(117, 37);
            this.Base64Encode.TabIndex = 18;
            this.Base64Encode.Text = "Base64 Encode";
            this.Base64Encode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Base64Encode.UseVisualStyleBackColor = false;
            this.Base64Encode.Click += new System.EventHandler(this.Base64Encode_Click);
            // 
            // Reverse
            // 
            this.Reverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(64)))), ((int)(((byte)(46)))));
            this.Reverse.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Reverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reverse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reverse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Reverse.Location = new System.Drawing.Point(450, 166);
            this.Reverse.Name = "Reverse";
            this.Reverse.Size = new System.Drawing.Size(117, 37);
            this.Reverse.TabIndex = 19;
            this.Reverse.Text = "Reverse";
            this.Reverse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reverse.UseVisualStyleBackColor = false;
            this.Reverse.Click += new System.EventHandler(this.Reverse_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(64)))), ((int)(((byte)(46)))));
            this.Clear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clear.Location = new System.Drawing.Point(450, 380);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(117, 37);
            this.Clear.TabIndex = 20;
            this.Clear.Text = "Clear";
            this.Clear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // AseLabel
            // 
            this.AseLabel.AutoSize = true;
            this.AseLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AseLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AseLabel.Location = new System.Drawing.Point(460, 218);
            this.AseLabel.Name = "AseLabel";
            this.AseLabel.Size = new System.Drawing.Size(94, 20);
            this.AseLabel.TabIndex = 21;
            this.AseLabel.Text = "AES Encrypt";
            this.AseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EncryptKey
            // 
            this.EncryptKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptKey.Location = new System.Drawing.Point(450, 256);
            this.EncryptKey.Name = "EncryptKey";
            this.EncryptKey.Size = new System.Drawing.Size(117, 26);
            this.EncryptKey.TabIndex = 22;
            this.EncryptKey.Text = "Key";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 610);
            this.Controls.Add(this.EncryptKey);
            this.Controls.Add(this.AseLabel);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Reverse);
            this.Controls.Add(this.Base64Encode);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.HtmlEncode);
            this.Controls.Add(this.SHA1);
            this.Controls.Add(this.MD5);
            this.Controls.Add(this.Lowercase);
            this.Controls.Add(this.Uppercase);
            this.Controls.Add(this.HtmlDecode);
            this.Controls.Add(this.HexDecode);
            this.Controls.Add(this.HexEncode);
            this.Controls.Add(this.URLDecode);
            this.Controls.Add(this.URLEncode);
            this.Controls.Add(this.Base64Decode);
            this.Controls.Add(this.NightConvertLabel);
            this.Controls.Add(this.OutputSize);
            this.Controls.Add(this.InputSize);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NightConvert ~ Github.com/inightsword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.Label InputSize;
        private System.Windows.Forms.Label OutputSize;
        private System.Windows.Forms.Label NightConvertLabel;
        private System.Windows.Forms.Button Base64Decode;
        private System.Windows.Forms.Button URLEncode;
        private System.Windows.Forms.Button URLDecode;
        private System.Windows.Forms.Button HexEncode;
        private System.Windows.Forms.Button HexDecode;
        private System.Windows.Forms.Button SHA1;
        private System.Windows.Forms.Button MD5;
        private System.Windows.Forms.Button Lowercase;
        private System.Windows.Forms.Button Uppercase;
        private System.Windows.Forms.Button HtmlDecode;
        private System.Windows.Forms.Button HtmlEncode;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.Button Base64Encode;
        private System.Windows.Forms.Button Reverse;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label AseLabel;
        private System.Windows.Forms.TextBox EncryptKey;
    }
}

