
namespace SupervisorFuzzyMicro
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.portaSerial = new System.IO.Ports.SerialPort(this.components);
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.btnMon = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.listaDadosPic = new System.Windows.Forms.ListBox();
            this.pnlLateral.SuspendLayout();
            this.pnlCentro.SuspendLayout();
            this.SuspendLayout();
            // 
            // portaSerial
            // 
            this.portaSerial.BaudRate = 115200;
            this.portaSerial.PortName = "COM5";
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlLateral.Controls.Add(this.btnMon);
            this.pnlLateral.Controls.Add(this.button11);
            this.pnlLateral.Controls.Add(this.button10);
            this.pnlLateral.Controls.Add(this.button9);
            this.pnlLateral.Controls.Add(this.button8);
            this.pnlLateral.Controls.Add(this.button7);
            this.pnlLateral.Controls.Add(this.button6);
            this.pnlLateral.Controls.Add(this.button5);
            this.pnlLateral.Controls.Add(this.button4);
            this.pnlLateral.Controls.Add(this.button3);
            this.pnlLateral.Controls.Add(this.button2);
            this.pnlLateral.Controls.Add(this.button1);
            this.pnlLateral.Controls.Add(this.btnInicio);
            this.pnlLateral.Location = new System.Drawing.Point(12, 23);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(175, 415);
            this.pnlLateral.TabIndex = 0;
            // 
            // btnMon
            // 
            this.btnMon.Location = new System.Drawing.Point(4, 4);
            this.btnMon.Name = "btnMon";
            this.btnMon.Size = new System.Drawing.Size(164, 31);
            this.btnMon.TabIndex = 12;
            this.btnMon.Text = "Monitorar";
            this.btnMon.UseVisualStyleBackColor = true;
            this.btnMon.Click += new System.EventHandler(this.btnMon_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(3, 359);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(165, 33);
            this.button11.TabIndex = 11;
            this.button11.Text = "Parar";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(95, 310);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(73, 37);
            this.button10.TabIndex = 10;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(3, 310);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(73, 37);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(95, 258);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(73, 37);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 258);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(73, 37);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(95, 211);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(73, 37);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 211);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(73, 37);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(95, 159);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 37);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(3, 50);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(165, 33);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Iniciar";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // pnlCentro
            // 
            this.pnlCentro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlCentro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlCentro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCentro.BackgroundImage")));
            this.pnlCentro.Controls.Add(this.btnSet);
            this.pnlCentro.Controls.Add(this.btnRes);
            this.pnlCentro.Controls.Add(this.listaDadosPic);
            this.pnlCentro.Location = new System.Drawing.Point(193, 23);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(595, 347);
            this.pnlCentro.TabIndex = 1;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(45, 155);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 3;
            this.btnSet.Text = "Set-";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnRes
            // 
            this.btnRes.Location = new System.Drawing.Point(45, 83);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(75, 23);
            this.btnRes.TabIndex = 2;
            this.btnRes.Text = "Res+";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // listaDadosPic
            // 
            this.listaDadosPic.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listaDadosPic.FormattingEnabled = true;
            this.listaDadosPic.Items.AddRange(new object[] {
            "Lista dos dados recebidos"});
            this.listaDadosPic.Location = new System.Drawing.Point(297, 7);
            this.listaDadosPic.Name = "listaDadosPic";
            this.listaDadosPic.Size = new System.Drawing.Size(296, 225);
            this.listaDadosPic.TabIndex = 0;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlCentro);
            this.Controls.Add(this.pnlLateral);
            this.Name = "Form";
            this.Text = "Form1";
            this.pnlLateral.ResumeLayout(false);
            this.pnlCentro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort portaSerial;
        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel pnlCentro;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ListBox listaDadosPic;
        private System.Windows.Forms.Button btnMon;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnRes;
    }
}

