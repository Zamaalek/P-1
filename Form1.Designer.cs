namespace P_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl = new TabControl();
            tabPage_trojkat = new TabPage();
            pictureBox2 = new PictureBox();
            label_wynik_trojkat = new Label();
            button_oblicz_trojkat = new Button();
            textBox_trojkat_wysokosc = new TextBox();
            label5 = new Label();
            textBox_trojkat_podstawa = new TextBox();
            label4 = new Label();
            label1 = new Label();
            tabPage_kolo = new TabPage();
            pictureBox1 = new PictureBox();
            label_wynik_kolo = new Label();
            button2 = new Button();
            textBox_kolo_promien = new TextBox();
            label3 = new Label();
            label2 = new Label();
            tabControl.SuspendLayout();
            tabPage_trojkat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabPage_kolo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl.Controls.Add(tabPage_trojkat);
            tabControl.Controls.Add(tabPage_kolo);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl1";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(800, 450);
            tabControl.TabIndex = 0;
            tabControl.Selected += TabControl_Selected;
            // 
            // tabPage_trojkat
            // 
            tabPage_trojkat.BackColor = Color.PaleTurquoise;
            tabPage_trojkat.Controls.Add(pictureBox2);
            tabPage_trojkat.Controls.Add(label_wynik_trojkat);
            tabPage_trojkat.Controls.Add(button_oblicz_trojkat);
            tabPage_trojkat.Controls.Add(textBox_trojkat_wysokosc);
            tabPage_trojkat.Controls.Add(label5);
            tabPage_trojkat.Controls.Add(textBox_trojkat_podstawa);
            tabPage_trojkat.Controls.Add(label4);
            tabPage_trojkat.Controls.Add(label1);
            tabPage_trojkat.Location = new Point(4, 24);
            tabPage_trojkat.Name = "tabPage_trojkat";
            tabPage_trojkat.Padding = new Padding(3);
            tabPage_trojkat.Size = new Size(792, 422);
            tabPage_trojkat.TabIndex = 0;
            tabPage_trojkat.Text = "Trójkąt";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(490, 170);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(225, 225);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // label_wynik_trojkat
            // 
            label_wynik_trojkat.AutoSize = true;
            label_wynik_trojkat.BackColor = Color.MistyRose;
            label_wynik_trojkat.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label_wynik_trojkat.ForeColor = Color.Red;
            label_wynik_trojkat.Location = new Point(370, 100);
            label_wynik_trojkat.Name = "label_wynik_trojkat";
            label_wynik_trojkat.Size = new Size(36, 25);
            label_wynik_trojkat.TabIndex = 11;
            label_wynik_trojkat.Text = "???";
            // 
            // button_oblicz_trojkat
            // 
            button_oblicz_trojkat.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button_oblicz_trojkat.Location = new Point(222, 341);
            button_oblicz_trojkat.Name = "button_oblicz_trojkat";
            button_oblicz_trojkat.Size = new Size(87, 35);
            button_oblicz_trojkat.TabIndex = 8;
            button_oblicz_trojkat.Text = "oblicz";
            button_oblicz_trojkat.UseVisualStyleBackColor = true;
            button_oblicz_trojkat.Click += Button_oblicz_trojkat_Click;
            // 
            // textBox_trojkat_wysokosc
            // 
            textBox_trojkat_wysokosc.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBox_trojkat_wysokosc.ForeColor = Color.Navy;
            textBox_trojkat_wysokosc.Location = new Point(72, 282);
            textBox_trojkat_wysokosc.Name = "textBox_trojkat_wysokosc";
            textBox_trojkat_wysokosc.Size = new Size(100, 29);
            textBox_trojkat_wysokosc.TabIndex = 7;
            textBox_trojkat_wysokosc.TextChanged += TextBox_TextChanged;
            textBox_trojkat_wysokosc.Enter += TextBox_Enter;
            textBox_trojkat_wysokosc.Leave += TextBox_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(72, 248);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 6;
            label5.Text = "wysokość";
            // 
            // textBox_trojkat_podstawa
            // 
            textBox_trojkat_podstawa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBox_trojkat_podstawa.ForeColor = Color.Navy;
            textBox_trojkat_podstawa.Location = new Point(72, 172);
            textBox_trojkat_podstawa.Name = "textBox_trojkat_podstawa";
            textBox_trojkat_podstawa.Size = new Size(100, 29);
            textBox_trojkat_podstawa.TabIndex = 0;
            textBox_trojkat_podstawa.TextChanged += TextBox_TextChanged;
            textBox_trojkat_podstawa.Enter += TextBox_Enter;
            textBox_trojkat_podstawa.Leave += TextBox_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(72, 138);
            label4.Name = "label4";
            label4.Size = new Size(84, 21);
            label4.TabIndex = 4;
            label4.Text = "podstawa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightGreen;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(55, 31);
            label1.Name = "label1";
            label1.Size = new Size(145, 30);
            label1.TabIndex = 100;
            label1.Text = "Pole trójkąta";
            // 
            // tabPage_kolo
            // 
            tabPage_kolo.BackColor = Color.Thistle;
            tabPage_kolo.Controls.Add(pictureBox1);
            tabPage_kolo.Controls.Add(label_wynik_kolo);
            tabPage_kolo.Controls.Add(button2);
            tabPage_kolo.Controls.Add(textBox_kolo_promien);
            tabPage_kolo.Controls.Add(label3);
            tabPage_kolo.Controls.Add(label2);
            tabPage_kolo.Location = new Point(4, 24);
            tabPage_kolo.Name = "tabPage_kolo";
            tabPage_kolo.Padding = new Padding(3);
            tabPage_kolo.Size = new Size(792, 422);
            tabPage_kolo.TabIndex = 1;
            tabPage_kolo.Text = "Koło";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(490, 170);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label_wynik_kolo
            // 
            label_wynik_kolo.AutoSize = true;
            label_wynik_kolo.BackColor = Color.GreenYellow;
            label_wynik_kolo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label_wynik_kolo.ForeColor = Color.Green;
            label_wynik_kolo.Location = new Point(370, 100);
            label_wynik_kolo.Name = "label_wynik_kolo";
            label_wynik_kolo.Size = new Size(36, 25);
            label_wynik_kolo.TabIndex = 10;
            label_wynik_kolo.Text = "???";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button2.Location = new Point(222, 341);
            button2.Name = "button2";
            button2.Size = new Size(87, 35);
            button2.TabIndex = 9;
            button2.Text = "oblicz";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button_oblicz_kolo_Click;
            // 
            // textBox_kolo_promien
            // 
            textBox_kolo_promien.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBox_kolo_promien.ForeColor = Color.Navy;
            textBox_kolo_promien.Location = new Point(72, 172);
            textBox_kolo_promien.Name = "textBox_kolo_promien";
            textBox_kolo_promien.Size = new Size(100, 29);
            textBox_kolo_promien.TabIndex = 0;
            textBox_kolo_promien.TextChanged += TextBox_TextChanged;
            textBox_kolo_promien.Enter += TextBox_Enter;
            textBox_kolo_promien.Leave += TextBox_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(72, 138);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 2;
            label3.Text = "promień";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Orange;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.Location = new Point(55, 31);
            label2.Name = "label2";
            label2.Size = new Size(107, 30);
            label2.TabIndex = 1;
            label2.Text = "Pole koła";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "P-1";
            Shown += Form_Shown;
            tabControl.ResumeLayout(false);
            tabPage_trojkat.ResumeLayout(false);
            tabPage_trojkat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabPage_kolo.ResumeLayout(false);
            tabPage_kolo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage_trojkat;
        private TabPage tabPage_kolo;
        private Label label1;
        private Label label2;
        private TextBox textBox_kolo_promien;
        private Label label3;
        private TextBox textBox_trojkat_podstawa;
        private Label label4;
        private TextBox textBox_trojkat_wysokosc;
        private Label label5;
        private Button button_oblicz_trojkat;
        private Button button2;
        private Label label_wynik_kolo;
        private Label label_wynik_trojkat;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
