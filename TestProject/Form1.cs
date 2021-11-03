using MessageBoxEx.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private Information.MessageBoxButtonEx hallarBotones()
        {
            if (radioBotonOK.Checked)
            {
                return Information.MessageBoxButtonEx.OK;
            }
            if (radioBotonOKCancel.Checked)
            {
                return Information.MessageBoxButtonEx.OKCancel;
            }
            if (radioBotonYesNo.Checked)
            {
                return Information.MessageBoxButtonEx.YesNo;
            }
            if (radioBotonYesNoCancel.Checked)
            {
                return Information.MessageBoxButtonEx.YesNoCancel;
            }
            return Information.MessageBoxButtonEx.OK;
        }

        private Information.MessageBoxImageEx hallarIcono()
        {
            if (radioAsterisk.Checked)
            {
                return Information.MessageBoxImageEx.Asterisk;
            }
            if (radioError.Checked)
            {
                return Information.MessageBoxImageEx.Error;
            }
            if (radioExclamation.Checked)
            {
                return Information.MessageBoxImageEx.Exclamation;
            }
            if (radioHand.Checked)
            {
                return Information.MessageBoxImageEx.Hand;
            }
            if (radioInformation.Checked)
            {
                return Information.MessageBoxImageEx.Information;
            }
            if (radioNone.Checked)
            {
                return Information.MessageBoxImageEx.None;
            }
            if (radioQuestion.Checked)
            {
                return Information.MessageBoxImageEx.Question;
            }
            if (radioStop.Checked)
            {
                return Information.MessageBoxImageEx.Stop;
            }
            if (radioWarning.Checked)
            {
                return Information.MessageBoxImageEx.Warning;
            }
            return Information.MessageBoxImageEx.None;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {  
            new Information { BarraDeTitulo = txtTitulo.Text, TextoAMostrar = txtDescripcion.Text , Botones = hallarBotones(), Iconos = hallarIcono()}.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
