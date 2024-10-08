namespace AdvancedRPC
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.clientIDTextBox = new System.Windows.Forms.TextBox();
            this.largeImg = new System.Windows.Forms.TextBox();
            this.smallImg = new System.Windows.Forms.TextBox();
            this.deviceDetail = new System.Windows.Forms.CheckBox();
            this.presenceUpdate = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.partyCheckBox = new System.Windows.Forms.CheckBox();
            this.partyLabel = new System.Windows.Forms.Label();
            this.partyOf = new System.Windows.Forms.Label();
            this.partyInputMessage = new System.Windows.Forms.TextBox();
            this.partyMessage = new System.Windows.Forms.Label();
            this.partyMax = new System.Windows.Forms.NumericUpDown();
            this.partySize = new System.Windows.Forms.NumericUpDown();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.smallImgText = new System.Windows.Forms.TextBox();
            this.largeImgText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.smallTex = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonText = new System.Windows.Forms.TextBox();
            this.buttonLink = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.partyMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partySize)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Blueberry Days", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(397, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Blueberry Days", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(397, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Image Key:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Blueberry Days", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightCoral;
            this.label3.Location = new System.Drawing.Point(397, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Text Image:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Blueberry Days", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightCoral;
            this.label4.Location = new System.Drawing.Point(397, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Other Settings:";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Transparent;
            this.save.Font = new System.Drawing.Font("Blueberry Days", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.LightCoral;
            this.save.Image = global::AdvancedRPC.Properties.Resources.rpc_bg;
            this.save.Location = new System.Drawing.Point(462, 358);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(213, 30);
            this.save.TabIndex = 5;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // clientIDTextBox
            // 
            this.clientIDTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.clientIDTextBox.Font = new System.Drawing.Font("Aileron Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientIDTextBox.Location = new System.Drawing.Point(512, 23);
            this.clientIDTextBox.MaxLength = 25;
            this.clientIDTextBox.Name = "clientIDTextBox";
            this.clientIDTextBox.Size = new System.Drawing.Size(176, 23);
            this.clientIDTextBox.TabIndex = 6;
            this.clientIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clientIDTextBox.TextChanged += new System.EventHandler(this.clientIDTextBox_TextChanged);
            // 
            // largeImg
            // 
            this.largeImg.BackColor = System.Drawing.SystemColors.Window;
            this.largeImg.Font = new System.Drawing.Font("Aileron Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largeImg.Location = new System.Drawing.Point(512, 77);
            this.largeImg.MaxLength = 15;
            this.largeImg.Name = "largeImg";
            this.largeImg.Size = new System.Drawing.Size(80, 23);
            this.largeImg.TabIndex = 7;
            this.largeImg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // smallImg
            // 
            this.smallImg.BackColor = System.Drawing.SystemColors.Window;
            this.smallImg.Font = new System.Drawing.Font("Aileron Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallImg.Location = new System.Drawing.Point(607, 77);
            this.smallImg.MaxLength = 15;
            this.smallImg.Name = "smallImg";
            this.smallImg.Size = new System.Drawing.Size(80, 23);
            this.smallImg.TabIndex = 8;
            this.smallImg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.smallImg.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // deviceDetail
            // 
            this.deviceDetail.AutoSize = true;
            this.deviceDetail.BackColor = System.Drawing.Color.Transparent;
            this.deviceDetail.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceDetail.ForeColor = System.Drawing.Color.Teal;
            this.deviceDetail.Location = new System.Drawing.Point(534, 246);
            this.deviceDetail.Name = "deviceDetail";
            this.deviceDetail.Size = new System.Drawing.Size(169, 21);
            this.deviceDetail.TabIndex = 10;
            this.deviceDetail.Text = "Turn Off Device Detail";
            this.deviceDetail.UseVisualStyleBackColor = false;
            this.deviceDetail.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // presenceUpdate
            // 
            this.presenceUpdate.AutoSize = true;
            this.presenceUpdate.BackColor = System.Drawing.Color.Transparent;
            this.presenceUpdate.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presenceUpdate.ForeColor = System.Drawing.Color.Teal;
            this.presenceUpdate.Location = new System.Drawing.Point(534, 269);
            this.presenceUpdate.Name = "presenceUpdate";
            this.presenceUpdate.Size = new System.Drawing.Size(164, 21);
            this.presenceUpdate.TabIndex = 11;
            this.presenceUpdate.Text = "Stop Update Presence";
            this.presenceUpdate.UseVisualStyleBackColor = false;
            this.presenceUpdate.CheckedChanged += new System.EventHandler(this.presenceUpdate_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(694, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "⚠ Important";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // partyCheckBox
            // 
            this.partyCheckBox.AutoSize = true;
            this.partyCheckBox.Font = new System.Drawing.Font("Blueberry Days", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partyCheckBox.ForeColor = System.Drawing.Color.LightCoral;
            this.partyCheckBox.Location = new System.Drawing.Point(401, 167);
            this.partyCheckBox.Name = "partyCheckBox";
            this.partyCheckBox.Size = new System.Drawing.Size(128, 26);
            this.partyCheckBox.TabIndex = 14;
            this.partyCheckBox.Text = "Enable Party";
            this.partyCheckBox.UseVisualStyleBackColor = true;
            this.partyCheckBox.CheckedChanged += new System.EventHandler(this.partyCheckBox_CheckedChanged);
            // 
            // partyLabel
            // 
            this.partyLabel.AutoSize = true;
            this.partyLabel.BackColor = System.Drawing.Color.Transparent;
            this.partyLabel.Font = new System.Drawing.Font("Blueberry Days", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partyLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.partyLabel.Location = new System.Drawing.Point(524, 196);
            this.partyLabel.Name = "partyLabel";
            this.partyLabel.Size = new System.Drawing.Size(45, 18);
            this.partyLabel.TabIndex = 17;
            this.partyLabel.Text = "Party";
            // 
            // partyOf
            // 
            this.partyOf.AutoSize = true;
            this.partyOf.BackColor = System.Drawing.Color.Transparent;
            this.partyOf.Font = new System.Drawing.Font("Blueberry Days", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partyOf.ForeColor = System.Drawing.SystemColors.Highlight;
            this.partyOf.Location = new System.Drawing.Point(624, 196);
            this.partyOf.Name = "partyOf";
            this.partyOf.Size = new System.Drawing.Size(22, 18);
            this.partyOf.TabIndex = 18;
            this.partyOf.Text = "of";
            // 
            // partyInputMessage
            // 
            this.partyInputMessage.Location = new System.Drawing.Point(590, 223);
            this.partyInputMessage.MaxLength = 50;
            this.partyInputMessage.Name = "partyInputMessage";
            this.partyInputMessage.Size = new System.Drawing.Size(98, 20);
            this.partyInputMessage.TabIndex = 19;
            this.partyInputMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // partyMessage
            // 
            this.partyMessage.AutoSize = true;
            this.partyMessage.BackColor = System.Drawing.Color.Transparent;
            this.partyMessage.Font = new System.Drawing.Font("Blueberry Days", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partyMessage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.partyMessage.Location = new System.Drawing.Point(524, 225);
            this.partyMessage.Name = "partyMessage";
            this.partyMessage.Size = new System.Drawing.Size(63, 18);
            this.partyMessage.TabIndex = 20;
            this.partyMessage.Text = "Message";
            // 
            // partyMax
            // 
            this.partyMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.partyMax.Location = new System.Drawing.Point(647, 197);
            this.partyMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.partyMax.Name = "partyMax";
            this.partyMax.Size = new System.Drawing.Size(41, 20);
            this.partyMax.TabIndex = 21;
            this.partyMax.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // partySize
            // 
            this.partySize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.partySize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.partySize.Location = new System.Drawing.Point(575, 197);
            this.partySize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.partySize.Name = "partySize";
            this.partySize.Size = new System.Drawing.Size(43, 20);
            this.partySize.TabIndex = 22;
            this.partySize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.partySize.ValueChanged += new System.EventHandler(this.partySize_ValueChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Location = new System.Drawing.Point(778, 382);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(51, 13);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = " Iseizuu";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Blueberry Days", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(509, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 18);
            this.label8.TabIndex = 26;
            this.label8.Text = "Large key";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Blueberry Days", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(604, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 18);
            this.label9.TabIndex = 27;
            this.label9.Text = "Small key";
            // 
            // smallImgText
            // 
            this.smallImgText.BackColor = System.Drawing.SystemColors.Window;
            this.smallImgText.Font = new System.Drawing.Font("Aileron Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallImgText.Location = new System.Drawing.Point(512, 138);
            this.smallImgText.MaxLength = 50;
            this.smallImgText.Name = "smallImgText";
            this.smallImgText.Size = new System.Drawing.Size(176, 23);
            this.smallImgText.TabIndex = 29;
            this.smallImgText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // largeImgText
            // 
            this.largeImgText.BackColor = System.Drawing.SystemColors.Window;
            this.largeImgText.Font = new System.Drawing.Font("Aileron Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largeImgText.Location = new System.Drawing.Point(512, 109);
            this.largeImgText.MaxLength = 50;
            this.largeImgText.Name = "largeImgText";
            this.largeImgText.Size = new System.Drawing.Size(175, 23);
            this.largeImgText.TabIndex = 28;
            this.largeImgText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(694, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "⚠ Large image text";
            // 
            // smallTex
            // 
            this.smallTex.AutoSize = true;
            this.smallTex.BackColor = System.Drawing.Color.Transparent;
            this.smallTex.Font = new System.Drawing.Font("Microsoft Tai Le", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallTex.ForeColor = System.Drawing.Color.Red;
            this.smallTex.Location = new System.Drawing.Point(694, 144);
            this.smallTex.Name = "smallTex";
            this.smallTex.Size = new System.Drawing.Size(95, 13);
            this.smallTex.TabIndex = 31;
            this.smallTex.Text = "⚠ Small image text";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(694, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 26);
            this.label7.TabIndex = 32;
            this.label7.Text = "⚠ also used, when \r\n\'turn off device detail\' is enable.";
            // 
            // buttonCheck
            // 
            this.buttonCheck.AutoSize = true;
            this.buttonCheck.Font = new System.Drawing.Font("Blueberry Days", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheck.ForeColor = System.Drawing.Color.LightCoral;
            this.buttonCheck.Location = new System.Drawing.Point(401, 292);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(87, 26);
            this.buttonCheck.TabIndex = 33;
            this.buttonCheck.Text = "Button";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Blueberry Days", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(524, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 18);
            this.label10.TabIndex = 34;
            this.label10.Text = "Text";
            // 
            // buttonText
            // 
            this.buttonText.BackColor = System.Drawing.SystemColors.Window;
            this.buttonText.Font = new System.Drawing.Font("Aileron Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonText.Location = new System.Drawing.Point(559, 294);
            this.buttonText.MaxLength = 32;
            this.buttonText.Name = "buttonText";
            this.buttonText.Size = new System.Drawing.Size(128, 23);
            this.buttonText.TabIndex = 35;
            this.buttonText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonText.TextChanged += new System.EventHandler(this.buttonText_TextChanged);
            // 
            // buttonLink
            // 
            this.buttonLink.BackColor = System.Drawing.SystemColors.Window;
            this.buttonLink.Font = new System.Drawing.Font("Aileron Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLink.Location = new System.Drawing.Point(559, 322);
            this.buttonLink.MaxLength = 50;
            this.buttonLink.Name = "buttonLink";
            this.buttonLink.Size = new System.Drawing.Size(128, 23);
            this.buttonLink.TabIndex = 37;
            this.buttonLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Blueberry Days", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(524, 324);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 18);
            this.label11.TabIndex = 36;
            this.label11.Text = "Url";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AdvancedRPC.Properties.Resources.rpc_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(841, 404);
            this.Controls.Add(this.buttonLink);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonText);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.smallTex);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.smallImgText);
            this.Controls.Add(this.largeImgText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.partySize);
            this.Controls.Add(this.partyMax);
            this.Controls.Add(this.partyMessage);
            this.Controls.Add(this.partyInputMessage);
            this.Controls.Add(this.partyOf);
            this.Controls.Add(this.partyLabel);
            this.Controls.Add(this.partyCheckBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.presenceUpdate);
            this.Controls.Add(this.deviceDetail);
            this.Controls.Add(this.smallImg);
            this.Controls.Add(this.largeImg);
            this.Controls.Add(this.clientIDTextBox);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPC Settings";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partyMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partySize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox clientIDTextBox;
        private System.Windows.Forms.TextBox largeImg;
        private System.Windows.Forms.TextBox smallImg;
        private System.Windows.Forms.CheckBox deviceDetail;
        private System.Windows.Forms.CheckBox presenceUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox partyCheckBox;
        private System.Windows.Forms.Label partyLabel;
        private System.Windows.Forms.Label partyOf;
        private System.Windows.Forms.TextBox partyInputMessage;
        private System.Windows.Forms.Label partyMessage;
        private System.Windows.Forms.NumericUpDown partyMax;
        private System.Windows.Forms.NumericUpDown partySize;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox smallImgText;
        private System.Windows.Forms.TextBox largeImgText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label smallTex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox buttonCheck;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox buttonText;
        private System.Windows.Forms.TextBox buttonLink;
        private System.Windows.Forms.Label label11;
    }
}

