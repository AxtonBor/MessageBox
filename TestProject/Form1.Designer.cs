namespace TestProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBotonYesNoCancel = new System.Windows.Forms.RadioButton();
            this.radioBotonYesNo = new System.Windows.Forms.RadioButton();
            this.radioBotonOKCancel = new System.Windows.Forms.RadioButton();
            this.radioBotonOK = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioExclamation = new System.Windows.Forms.RadioButton();
            this.radioError = new System.Windows.Forms.RadioButton();
            this.radioAsterisk = new System.Windows.Forms.RadioButton();
            this.radioNone = new System.Windows.Forms.RadioButton();
            this.radioHand = new System.Windows.Forms.RadioButton();
            this.radioWarning = new System.Windows.Forms.RadioButton();
            this.radioStop = new System.Windows.Forms.RadioButton();
            this.radioQuestion = new System.Windows.Forms.RadioButton();
            this.radioInformation = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(219, 20);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(370, 23);
            this.txtTitulo.TabIndex = 1;
            this.txtTitulo.Text = "Titulo";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(315, 400);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(219, 55);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(370, 23);
            this.txtDescripcion.TabIndex = 4;
            this.txtDescripcion.Text = "Esto es una prueba";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBotonYesNoCancel);
            this.groupBox1.Controls.Add(this.radioBotonYesNo);
            this.groupBox1.Controls.Add(this.radioBotonOKCancel);
            this.groupBox1.Controls.Add(this.radioBotonOK);
            this.groupBox1.Location = new System.Drawing.Point(60, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 225);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Botones";
            // 
            // radioBotonYesNoCancel
            // 
            this.radioBotonYesNoCancel.AutoSize = true;
            this.radioBotonYesNoCancel.Location = new System.Drawing.Point(19, 97);
            this.radioBotonYesNoCancel.Name = "radioBotonYesNoCancel";
            this.radioBotonYesNoCancel.Size = new System.Drawing.Size(112, 19);
            this.radioBotonYesNoCancel.TabIndex = 5;
            this.radioBotonYesNoCancel.Tag = "4";
            this.radioBotonYesNoCancel.Text = "Yes, No y Cancel";
            this.radioBotonYesNoCancel.UseVisualStyleBackColor = true;
            // 
            // radioBotonYesNo
            // 
            this.radioBotonYesNo.AutoSize = true;
            this.radioBotonYesNo.Location = new System.Drawing.Point(19, 72);
            this.radioBotonYesNo.Name = "radioBotonYesNo";
            this.radioBotonYesNo.Size = new System.Drawing.Size(70, 19);
            this.radioBotonYesNo.TabIndex = 4;
            this.radioBotonYesNo.Tag = "3";
            this.radioBotonYesNo.Text = "Yes y No";
            this.radioBotonYesNo.UseVisualStyleBackColor = true;
            // 
            // radioBotonOKCancel
            // 
            this.radioBotonOKCancel.AutoSize = true;
            this.radioBotonOKCancel.Location = new System.Drawing.Point(19, 47);
            this.radioBotonOKCancel.Name = "radioBotonOKCancel";
            this.radioBotonOKCancel.Size = new System.Drawing.Size(99, 19);
            this.radioBotonOKCancel.TabIndex = 2;
            this.radioBotonOKCancel.Tag = "2";
            this.radioBotonOKCancel.Text = "OK y Cancelar";
            this.radioBotonOKCancel.UseVisualStyleBackColor = true;
            this.radioBotonOKCancel.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioBotonOK
            // 
            this.radioBotonOK.AutoSize = true;
            this.radioBotonOK.Checked = true;
            this.radioBotonOK.Location = new System.Drawing.Point(19, 22);
            this.radioBotonOK.Name = "radioBotonOK";
            this.radioBotonOK.Size = new System.Drawing.Size(41, 19);
            this.radioBotonOK.TabIndex = 1;
            this.radioBotonOK.TabStop = true;
            this.radioBotonOK.Tag = "1";
            this.radioBotonOK.Text = "OK";
            this.radioBotonOK.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioInformation);
            this.groupBox2.Controls.Add(this.radioQuestion);
            this.groupBox2.Controls.Add(this.radioStop);
            this.groupBox2.Controls.Add(this.radioWarning);
            this.groupBox2.Controls.Add(this.radioHand);
            this.groupBox2.Controls.Add(this.radioExclamation);
            this.groupBox2.Controls.Add(this.radioError);
            this.groupBox2.Controls.Add(this.radioAsterisk);
            this.groupBox2.Controls.Add(this.radioNone);
            this.groupBox2.Location = new System.Drawing.Point(339, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 259);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Iconos";
            // 
            // radioExclamation
            // 
            this.radioExclamation.AutoSize = true;
            this.radioExclamation.Location = new System.Drawing.Point(19, 97);
            this.radioExclamation.Name = "radioExclamation";
            this.radioExclamation.Size = new System.Drawing.Size(90, 19);
            this.radioExclamation.TabIndex = 5;
            this.radioExclamation.Tag = "4";
            this.radioExclamation.Text = "Exclamation";
            this.radioExclamation.UseVisualStyleBackColor = true;
            // 
            // radioError
            // 
            this.radioError.AutoSize = true;
            this.radioError.Location = new System.Drawing.Point(19, 72);
            this.radioError.Name = "radioError";
            this.radioError.Size = new System.Drawing.Size(50, 19);
            this.radioError.TabIndex = 4;
            this.radioError.Tag = "3";
            this.radioError.Text = "Error";
            this.radioError.UseVisualStyleBackColor = true;
            // 
            // radioAsterisk
            // 
            this.radioAsterisk.AutoSize = true;
            this.radioAsterisk.Location = new System.Drawing.Point(19, 47);
            this.radioAsterisk.Name = "radioAsterisk";
            this.radioAsterisk.Size = new System.Drawing.Size(66, 19);
            this.radioAsterisk.TabIndex = 2;
            this.radioAsterisk.Tag = "2";
            this.radioAsterisk.Text = "Asterisk";
            this.radioAsterisk.UseVisualStyleBackColor = true;
            // 
            // radioNone
            // 
            this.radioNone.AutoSize = true;
            this.radioNone.Checked = true;
            this.radioNone.Location = new System.Drawing.Point(19, 22);
            this.radioNone.Name = "radioNone";
            this.radioNone.Size = new System.Drawing.Size(54, 19);
            this.radioNone.TabIndex = 1;
            this.radioNone.TabStop = true;
            this.radioNone.Tag = "1";
            this.radioNone.Text = "None";
            this.radioNone.UseVisualStyleBackColor = true;
            // 
            // radioHand
            // 
            this.radioHand.AutoSize = true;
            this.radioHand.Location = new System.Drawing.Point(19, 149);
            this.radioHand.Name = "radioHand";
            this.radioHand.Size = new System.Drawing.Size(54, 19);
            this.radioHand.TabIndex = 6;
            this.radioHand.Tag = "4";
            this.radioHand.Text = "Hand";
            this.radioHand.UseVisualStyleBackColor = true;
            // 
            // radioWarning
            // 
            this.radioWarning.AutoSize = true;
            this.radioWarning.Location = new System.Drawing.Point(19, 224);
            this.radioWarning.Name = "radioWarning";
            this.radioWarning.Size = new System.Drawing.Size(70, 19);
            this.radioWarning.TabIndex = 7;
            this.radioWarning.Tag = "4";
            this.radioWarning.Text = "Warning";
            this.radioWarning.UseVisualStyleBackColor = true;
            // 
            // radioStop
            // 
            this.radioStop.AutoSize = true;
            this.radioStop.Location = new System.Drawing.Point(19, 199);
            this.radioStop.Name = "radioStop";
            this.radioStop.Size = new System.Drawing.Size(49, 19);
            this.radioStop.TabIndex = 8;
            this.radioStop.Tag = "4";
            this.radioStop.Text = "Stop";
            this.radioStop.UseVisualStyleBackColor = true;
            // 
            // radioQuestion
            // 
            this.radioQuestion.AutoSize = true;
            this.radioQuestion.Location = new System.Drawing.Point(19, 174);
            this.radioQuestion.Name = "radioQuestion";
            this.radioQuestion.Size = new System.Drawing.Size(73, 19);
            this.radioQuestion.TabIndex = 9;
            this.radioQuestion.Tag = "4";
            this.radioQuestion.Text = "Question";
            this.radioQuestion.UseVisualStyleBackColor = true;
            // 
            // radioInformation
            // 
            this.radioInformation.AutoSize = true;
            this.radioInformation.Location = new System.Drawing.Point(19, 122);
            this.radioInformation.Name = "radioInformation";
            this.radioInformation.Size = new System.Drawing.Size(88, 19);
            this.radioInformation.TabIndex = 10;
            this.radioInformation.Tag = "4";
            this.radioInformation.Text = "Information";
            this.radioInformation.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBotonOK;
        private System.Windows.Forms.RadioButton radioBotonOKCancel;
        private System.Windows.Forms.RadioButton radioBotonYesNo;
        private System.Windows.Forms.RadioButton radioBotonYesNoCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioExclamation;
        private System.Windows.Forms.RadioButton radioError;
        private System.Windows.Forms.RadioButton radioAsterisk;
        private System.Windows.Forms.RadioButton radioNone;
        private System.Windows.Forms.RadioButton radioQuestion;
        private System.Windows.Forms.RadioButton radioStop;
        private System.Windows.Forms.RadioButton radioWarning;
        private System.Windows.Forms.RadioButton radioHand;
        private System.Windows.Forms.RadioButton radioInformation;
    }
}
