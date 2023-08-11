namespace Mitarbeiterverwaltung
{
   partial class Form1
   {
      /// <summary>
      /// Erforderliche Designervariable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Verwendete Ressourcen bereinigen.
      /// </summary>
      /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Vom Windows Form-Designer generierter Code

      /// <summary>
      /// Erforderliche Methode für die Designerunterstützung.
      /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
      /// </summary>
      private void InitializeComponent()
      {
            this.lb_Ausgabe = new System.Windows.Forms.Label();
            this.btn_Ausgeben = new System.Windows.Forms.Button();
            this.btn_GehaltErhoehen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox_Position = new System.Windows.Forms.ComboBox();
            this.textBox_Gehalt = new System.Windows.Forms.TextBox();
            this.textBox_Nachname = new System.Windows.Forms.TextBox();
            this.textBox_Vorname = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Ausgabe
            // 
            this.lb_Ausgabe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Ausgabe.Location = new System.Drawing.Point(6, 19);
            this.lb_Ausgabe.Name = "lb_Ausgabe";
            this.lb_Ausgabe.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_Ausgabe.Size = new System.Drawing.Size(452, 322);
            this.lb_Ausgabe.TabIndex = 1;
            this.lb_Ausgabe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Ausgeben
            // 
            this.btn_Ausgeben.Location = new System.Drawing.Point(7, 241);
            this.btn_Ausgeben.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Ausgeben.Name = "btn_Ausgeben";
            this.btn_Ausgeben.Size = new System.Drawing.Size(186, 33);
            this.btn_Ausgeben.TabIndex = 0;
            this.btn_Ausgeben.Text = "Alle anzeigen";
            this.btn_Ausgeben.UseVisualStyleBackColor = true;
            this.btn_Ausgeben.Click += new System.EventHandler(this.btn_Ausgeben_Click);
            // 
            // btn_GehaltErhoehen
            // 
            this.btn_GehaltErhoehen.Location = new System.Drawing.Point(7, 189);
            this.btn_GehaltErhoehen.Name = "btn_GehaltErhoehen";
            this.btn_GehaltErhoehen.Size = new System.Drawing.Size(187, 33);
            this.btn_GehaltErhoehen.TabIndex = 2;
            this.btn_GehaltErhoehen.Text = "Gehälter erhöhen";
            this.btn_GehaltErhoehen.UseVisualStyleBackColor = true;
            this.btn_GehaltErhoehen.Click += new System.EventHandler(this.btn_GehaltErhoehen_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Vor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Anlegen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 33);
            this.button3.TabIndex = 5;
            this.button3.Text = "Zurück";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.comboBox_Position);
            this.groupBox1.Controls.Add(this.textBox_Gehalt);
            this.groupBox1.Controls.Add(this.textBox_Nachname);
            this.groupBox1.Controls.Add(this.textBox_Vorname);
            this.groupBox1.Controls.Add(this.textBox_ID);
            this.groupBox1.Location = new System.Drawing.Point(13, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 344);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mitarbeiter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gehalt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nachname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Vorname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 300);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 21);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Bestanden";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox_Position
            // 
            this.comboBox_Position.FormattingEnabled = true;
            this.comboBox_Position.Location = new System.Drawing.Point(7, 246);
            this.comboBox_Position.Name = "comboBox_Position";
            this.comboBox_Position.Size = new System.Drawing.Size(149, 24);
            this.comboBox_Position.TabIndex = 4;
            this.comboBox_Position.SelectedIndexChanged += new System.EventHandler(this.comboBox_Position_SelectedIndexChanged);
            // 
            // textBox_Gehalt
            // 
            this.textBox_Gehalt.Location = new System.Drawing.Point(7, 194);
            this.textBox_Gehalt.Name = "textBox_Gehalt";
            this.textBox_Gehalt.Size = new System.Drawing.Size(149, 23);
            this.textBox_Gehalt.TabIndex = 3;
            // 
            // textBox_Nachname
            // 
            this.textBox_Nachname.Location = new System.Drawing.Point(7, 147);
            this.textBox_Nachname.Name = "textBox_Nachname";
            this.textBox_Nachname.Size = new System.Drawing.Size(149, 23);
            this.textBox_Nachname.TabIndex = 2;
            // 
            // textBox_Vorname
            // 
            this.textBox_Vorname.Location = new System.Drawing.Point(7, 94);
            this.textBox_Vorname.Name = "textBox_Vorname";
            this.textBox_Vorname.Size = new System.Drawing.Size(149, 23);
            this.textBox_Vorname.TabIndex = 1;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(7, 39);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(149, 23);
            this.textBox_ID.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btn_Ausgeben);
            this.groupBox2.Controls.Add(this.btn_GehaltErhoehen);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(187, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 344);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datensatz";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_Ausgabe);
            this.groupBox3.Location = new System.Drawing.Point(393, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(464, 344);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ausgabe";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 471);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Mitarbeiterverwaltung";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button btn_Ausgeben;
      private System.Windows.Forms.Label lb_Ausgabe;
      private System.Windows.Forms.Button btn_GehaltErhoehen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox_Position;
        private System.Windows.Forms.TextBox textBox_Gehalt;
        private System.Windows.Forms.TextBox textBox_Nachname;
        private System.Windows.Forms.TextBox textBox_Vorname;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

