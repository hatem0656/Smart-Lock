namespace SmartLock_GUI
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            this.State = new System.Windows.Forms.Label();
            this.Disconnect_Button = new System.Windows.Forms.Button();
            this.Refresh_Button = new System.Windows.Forms.Button();
            this.Connect_Button = new System.Windows.Forms.Button();
            this.Ports = new System.Windows.Forms.ComboBox();
            this.Screen = new System.Windows.Forms.TextBox();
            this.One = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LockState = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.MediumPurple;
            label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            label1.Location = new System.Drawing.Point(94, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(187, 26);
            label1.TabIndex = 11;
            label1.Text = "Enter Password:";
            // 
            // State
            // 
            this.State.AutoSize = true;
            this.State.BackColor = System.Drawing.Color.Red;
            this.State.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.State.ForeColor = System.Drawing.Color.White;
            this.State.Location = new System.Drawing.Point(531, 244);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(94, 15);
            this.State.TabIndex = 10;
            this.State.Text = "Disconnected";
            // 
            // Disconnect_Button
            // 
            this.Disconnect_Button.Location = new System.Drawing.Point(613, 302);
            this.Disconnect_Button.Name = "Disconnect_Button";
            this.Disconnect_Button.Size = new System.Drawing.Size(72, 22);
            this.Disconnect_Button.TabIndex = 9;
            this.Disconnect_Button.Text = "Discoonect";
            this.Disconnect_Button.UseVisualStyleBackColor = true;
            this.Disconnect_Button.Click += new System.EventHandler(this.Disconnect_Button_Click);
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.Location = new System.Drawing.Point(451, 302);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(77, 22);
            this.Refresh_Button.TabIndex = 8;
            this.Refresh_Button.Text = "Refresh";
            this.Refresh_Button.UseVisualStyleBackColor = true;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // Connect_Button
            // 
            this.Connect_Button.Location = new System.Drawing.Point(534, 302);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.Size = new System.Drawing.Size(73, 22);
            this.Connect_Button.TabIndex = 7;
            this.Connect_Button.Text = "Connect ";
            this.Connect_Button.UseVisualStyleBackColor = true;
            this.Connect_Button.Click += new System.EventHandler(this.Connect_Button_Click);
            // 
            // Ports
            // 
            this.Ports.FormattingEnabled = true;
            this.Ports.Location = new System.Drawing.Point(461, 262);
            this.Ports.Name = "Ports";
            this.Ports.Size = new System.Drawing.Size(224, 21);
            this.Ports.TabIndex = 6;
            // 
            // Screen
            // 
            this.Screen.BackColor = System.Drawing.Color.LightGray;
            this.Screen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Screen.Location = new System.Drawing.Point(287, 22);
            this.Screen.MaxLength = 4;
            this.Screen.Name = "Screen";
            this.Screen.ReadOnly = true;
            this.Screen.Size = new System.Drawing.Size(231, 30);
            this.Screen.TabIndex = 12;
            this.Screen.UseSystemPasswordChar = true;
            // 
            // One
            // 
            this.One.BackColor = System.Drawing.Color.CadetBlue;
            this.One.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.One.ForeColor = System.Drawing.Color.White;
            this.One.Location = new System.Drawing.Point(14, 12);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(100, 40);
            this.One.TabIndex = 13;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = false;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Two
            // 
            this.Two.BackColor = System.Drawing.Color.CadetBlue;
            this.Two.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Two.ForeColor = System.Drawing.Color.White;
            this.Two.Location = new System.Drawing.Point(120, 12);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(100, 40);
            this.Two.TabIndex = 14;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = false;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // Three
            // 
            this.Three.BackColor = System.Drawing.Color.CadetBlue;
            this.Three.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Three.ForeColor = System.Drawing.Color.White;
            this.Three.Location = new System.Drawing.Point(226, 12);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(100, 40);
            this.Three.TabIndex = 15;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = false;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Four
            // 
            this.Four.BackColor = System.Drawing.Color.CadetBlue;
            this.Four.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Four.ForeColor = System.Drawing.Color.White;
            this.Four.Location = new System.Drawing.Point(14, 58);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(100, 40);
            this.Four.TabIndex = 16;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = false;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Five
            // 
            this.Five.BackColor = System.Drawing.Color.CadetBlue;
            this.Five.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Five.ForeColor = System.Drawing.Color.White;
            this.Five.Location = new System.Drawing.Point(120, 58);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(100, 40);
            this.Five.TabIndex = 17;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = false;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Six
            // 
            this.Six.BackColor = System.Drawing.Color.CadetBlue;
            this.Six.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Six.ForeColor = System.Drawing.Color.White;
            this.Six.Location = new System.Drawing.Point(226, 58);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(100, 40);
            this.Six.TabIndex = 18;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = false;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // Nine
            // 
            this.Nine.BackColor = System.Drawing.Color.CadetBlue;
            this.Nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nine.ForeColor = System.Drawing.Color.White;
            this.Nine.Location = new System.Drawing.Point(226, 104);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(100, 40);
            this.Nine.TabIndex = 21;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = false;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Eight
            // 
            this.Eight.BackColor = System.Drawing.Color.CadetBlue;
            this.Eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eight.ForeColor = System.Drawing.Color.White;
            this.Eight.Location = new System.Drawing.Point(120, 104);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(100, 40);
            this.Eight.TabIndex = 20;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = false;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // Seven
            // 
            this.Seven.BackColor = System.Drawing.Color.CadetBlue;
            this.Seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seven.ForeColor = System.Drawing.Color.White;
            this.Seven.Location = new System.Drawing.Point(14, 104);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(100, 40);
            this.Seven.TabIndex = 19;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = false;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.Nine);
            this.panel1.Controls.Add(this.Three);
            this.panel1.Controls.Add(this.Four);
            this.panel1.Controls.Add(this.Two);
            this.panel1.Controls.Add(this.Five);
            this.panel1.Controls.Add(this.One);
            this.panel1.Controls.Add(this.Six);
            this.panel1.Controls.Add(this.Seven);
            this.panel1.Controls.Add(this.Eight);
            this.panel1.Location = new System.Drawing.Point(232, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 155);
            this.panel1.TabIndex = 22;
            // 
            // LockState
            // 
            this.LockState.AutoSize = true;
            this.LockState.BackColor = System.Drawing.Color.Tomato;
            this.LockState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LockState.ForeColor = System.Drawing.Color.White;
            this.LockState.Location = new System.Drawing.Point(531, 30);
            this.LockState.Name = "LockState";
            this.LockState.Size = new System.Drawing.Size(41, 18);
            this.LockState.TabIndex = 23;
            this.LockState.Text = "OFF";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(591, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 38);
            this.button1.TabIndex = 24;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 241);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 25;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(246, 282);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 26;
            this.textBox2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 361);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LockState);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Screen);
            this.Controls.Add(label1);
            this.Controls.Add(this.State);
            this.Controls.Add(this.Disconnect_Button);
            this.Controls.Add(this.Refresh_Button);
            this.Controls.Add(this.Connect_Button);
            this.Controls.Add(this.Ports);
            this.Name = "Form1";
            this.Text = "Smart Lock";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label State;
        private System.Windows.Forms.Button Disconnect_Button;
        private System.Windows.Forms.Button Refresh_Button;
        private System.Windows.Forms.Button Connect_Button;
        private System.Windows.Forms.ComboBox Ports;
        private System.Windows.Forms.TextBox Screen;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LockState;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

