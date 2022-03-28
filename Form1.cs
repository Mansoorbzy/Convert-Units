using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_1
{
    public partial class Form1 : Form
    {
        private Label label1;
        private TextBox textBox1;
        private Button Finished;
        private ComboBox ComboAll;
        private CheckBox Kilometers;
        private CheckBox Inches;
        private CheckBox Feet;
        private CheckBox Meters;
        private CheckBox Centimeters;
        private CheckBox Yard;
        private Label label2;
        private ListBox listBox1;
        private Button Calculate;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.Finished = new System.Windows.Forms.Button();
            this.ComboAll = new System.Windows.Forms.ComboBox();
            this.Kilometers = new System.Windows.Forms.CheckBox();
            this.Inches = new System.Windows.Forms.CheckBox();
            this.Feet = new System.Windows.Forms.CheckBox();
            this.Meters = new System.Windows.Forms.CheckBox();
            this.Centimeters = new System.Windows.Forms.CheckBox();
            this.Yard = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(124, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Value :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(237, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 27);
            this.textBox1.TabIndex = 2;
            // 
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.Color.SeaShell;
            this.Calculate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Calculate.BackgroundImage")));
            this.Calculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Calculate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calculate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Calculate.Location = new System.Drawing.Point(237, 377);
            this.Calculate.Name = "Calculate";
            this.Calculate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Calculate.Size = new System.Drawing.Size(85, 28);
            this.Calculate.TabIndex = 3;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // Finished
            // 
            this.Finished.BackColor = System.Drawing.Color.SeaShell;
            this.Finished.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Finished.BackgroundImage")));
            this.Finished.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Finished.Cursor = System.Windows.Forms.Cursors.Default;
            this.Finished.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Finished.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Finished.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Finished.Location = new System.Drawing.Point(436, 377);
            this.Finished.Name = "Finished";
            this.Finished.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Finished.Size = new System.Drawing.Size(85, 28);
            this.Finished.TabIndex = 4;
            this.Finished.Text = "Finished";
            this.Finished.UseVisualStyleBackColor = false;
            this.Finished.Click += new System.EventHandler(this.Finished_Click);
            // 
            // ComboAll
            // 
            this.ComboAll.AllowDrop = true;
            this.ComboAll.BackColor = System.Drawing.SystemColors.Control;
            this.ComboAll.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboAll.FormattingEnabled = true;
            this.ComboAll.Items.AddRange(new object[] {
            "Centimeters",
            "Inches",
            "Feet",
            "Yards",
            "Meters",
            "Kilometers"});
            this.ComboAll.Location = new System.Drawing.Point(446, 57);
            this.ComboAll.Name = "ComboAll";
            this.ComboAll.Size = new System.Drawing.Size(174, 21);
            this.ComboAll.TabIndex = 5;
            this.ComboAll.SelectedIndexChanged += new System.EventHandler(this.ComboAll_SelectedIndexChanged);
            // 
            // Kilometers
            // 
            this.Kilometers.AutoSize = true;
            this.Kilometers.BackColor = System.Drawing.Color.Transparent;
            this.Kilometers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Kilometers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kilometers.Location = new System.Drawing.Point(248, 300);
            this.Kilometers.Name = "Kilometers";
            this.Kilometers.Size = new System.Drawing.Size(97, 23);
            this.Kilometers.TabIndex = 6;
            this.Kilometers.Text = "Kilometers";
            this.Kilometers.UseVisualStyleBackColor = false;
            // 
            // Inches
            // 
            this.Inches.AutoSize = true;
            this.Inches.BackColor = System.Drawing.Color.Transparent;
            this.Inches.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Inches.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inches.Location = new System.Drawing.Point(248, 184);
            this.Inches.Name = "Inches";
            this.Inches.Size = new System.Drawing.Size(70, 23);
            this.Inches.TabIndex = 7;
            this.Inches.Text = "Inches";
            this.Inches.UseVisualStyleBackColor = false;
            // 
            // Feet
            // 
            this.Feet.AutoSize = true;
            this.Feet.BackColor = System.Drawing.Color.Transparent;
            this.Feet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Feet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Feet.Location = new System.Drawing.Point(248, 213);
            this.Feet.Name = "Feet";
            this.Feet.Size = new System.Drawing.Size(56, 23);
            this.Feet.TabIndex = 8;
            this.Feet.Text = "Feet";
            this.Feet.UseVisualStyleBackColor = false;
            // 
            // Meters
            // 
            this.Meters.AutoSize = true;
            this.Meters.BackColor = System.Drawing.Color.Transparent;
            this.Meters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Meters.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meters.Location = new System.Drawing.Point(248, 271);
            this.Meters.Name = "Meters";
            this.Meters.Size = new System.Drawing.Size(74, 23);
            this.Meters.TabIndex = 10;
            this.Meters.Text = "Meters";
            this.Meters.UseVisualStyleBackColor = false;
            // 
            // Centimeters
            // 
            this.Centimeters.AutoSize = true;
            this.Centimeters.BackColor = System.Drawing.Color.Transparent;
            this.Centimeters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Centimeters.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Centimeters.Location = new System.Drawing.Point(248, 155);
            this.Centimeters.Name = "Centimeters";
            this.Centimeters.Size = new System.Drawing.Size(107, 23);
            this.Centimeters.TabIndex = 11;
            this.Centimeters.Text = "Centimeters";
            this.Centimeters.UseVisualStyleBackColor = false;
            // 
            // Yard
            // 
            this.Yard.AutoSize = true;
            this.Yard.BackColor = System.Drawing.Color.Transparent;
            this.Yard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Yard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yard.Location = new System.Drawing.Point(248, 242);
            this.Yard.Name = "Yard";
            this.Yard.Size = new System.Drawing.Size(63, 23);
            this.Yard.TabIndex = 12;
            this.Yard.Text = "Yards";
            this.Yard.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Convert to ";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(426, 155);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(194, 154);
            this.listBox1.TabIndex = 15;
            // 
            // Form1
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 466);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Yard);
            this.Controls.Add(this.Centimeters);
            this.Controls.Add(this.Meters);
            this.Controls.Add(this.Feet);
            this.Controls.Add(this.Inches);
            this.Controls.Add(this.Kilometers);
            this.Controls.Add(this.ComboAll);
            this.Controls.Add(this.Finished);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int Input = Convert.ToInt32(textBox1.Text);

                listBox1.Items.Clear();

                int Inches1 = Convert.ToInt32(Math.Round(ConvertToInches(Input)));

                CheckCkeckBox(Inches1, Input);
            }
            catch (Exception)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Please enter a Value.");
            }

        }
        private void Finished_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
        private void ConvertToFeet(int Inches1)
        {
            int Feet = Inches1 / 12;
            int FeetInches = Inches1 % 12;
            listBox1.Items.Add(Feet + " ft " +  FeetInches + "\"");
        }

        private void ConvertToMeter(double Inches1)
        {
            double Meter = Math.Round(Inches1 / 39.37, 2, MidpointRounding.ToEven);
            listBox1.Items.Add(Meter + " m");
        }
        private void ConvertToYard(int Inches1)
        {
            int Yard = Inches1 / 36;
            int YardInches = Inches1 % 36;
            listBox1.Items.Add(Yard + " yd " + YardInches + "\"");
        }
        private void ConvertToCentimeters(double Inches1)
        {
            double Centimeters = Inches1 * 2.54;

            listBox1.Items.Add(Centimeters + " cm");
        }
        private void ConvertToKilometers(double Inches1)
        {
            double Kilometers = Math.Round(Inches1 / 39370, 6, MidpointRounding.ToEven);

            listBox1.Items.Add(Kilometers + " km");
        }
        private double ConvertToInches(int Input1)
        {

            string GetUnit = ComboAll.SelectedItem.ToString();
            double Inches = 0;
            if (GetUnit == "Inches")
            {
                Inches = Input1;
            }
            else if (GetUnit == "Centimeters")
            {
                Inches = Math.Round(Input1 / 2.54, 2, MidpointRounding.ToEven);
            }
            else if (GetUnit == "Meters")
            {
                Inches = Math.Round(Input1 * 39.37, 2, MidpointRounding.ToEven);
            }
            else if (GetUnit == "Kilometers")
            {
                Inches = Input1 * 39370;
            }
            else if (GetUnit == "Yards")
            {
                Inches = Input1 * 36;
            }
            else if (GetUnit == "Feet")
            {
                Inches = Input1 * 12;
            }
            
            return Inches;
        }
        private void ComboAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void ConvertToInches2(int Value)
        {
            ConvertToInches(Value);
            
            listBox1.Items.Add(ConvertToInches(Value) + "\"");
        }

        private void CheckCkeckBox(int CheckValue, int InputValue)
        {
            if (Centimeters.Checked)
            {
                ConvertToCentimeters(CheckValue);
            }
            if (Inches.Checked)
            {
                ConvertToInches2(InputValue);
            }
            if (Feet.Checked)
            {
                ConvertToFeet(CheckValue);
            }
            if (Yard.Checked)
            {
                ConvertToYard(CheckValue);
            }
            if (Meters.Checked)
            {
                ConvertToMeter(CheckValue);
            }
            if (Kilometers.Checked)
            {
                ConvertToKilometers(CheckValue);
            }
        }
    }
}
