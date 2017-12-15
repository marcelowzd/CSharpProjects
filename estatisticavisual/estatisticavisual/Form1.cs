 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace EstatisticaVisual
{
    public partial class Form1 : Form
    {

        string sAcumulaIntervalo = null;
        string sAcumulaQuantidade = null;

        int iContador = 0;

        String[] sIntervalo, sQuantidade;
        int[,] iIntervalo; int[] iQuantidade;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sBox = txtNumero.Text;

            if (String.IsNullOrEmpty(sBox))
            {
                MessageBox.Show("Digite valores válidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                txtNumero.Text = null;
                txtQuantidade.Text = null;
            }
            else
            {
                if (!sBox.Contains(";"))
                {
                    MessageBox.Show("Digite valores válidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtNumero.Text = null;
                    txtQuantidade.Text = null;
                }
                else
                {
                    int iSize = sBox.Length;

                    bool b = true;

                    for (int i = 0; i < iSize; i++)
                    {
                        if (!IsNumber(sBox[i]) && !IsDot(sBox[i]))
                        {
                            b = false;

                            break;
                        }
                    }

                    if (b == false)
                    {
                        MessageBox.Show("Digite valores válidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        txtNumero.Text = null;
                        txtQuantidade.Text = null;
                    }
                    else
                    {
                        string[] sValue = new string[2]; int pos = 0;

                        for (int i = 0; i < iSize; i++)
                        {
                            if (IsNumber(sBox[i]))
                                sValue[pos] = sValue[pos] + sBox[i];
                            else if (IsDot(sBox[i]))
                                pos++;
                        }

                        int[] iValue = new int[2];

                        iValue[0] = int.Parse(sValue[0]);
                        iValue[1] = int.Parse(sValue[1]);

                        if (iValue[0] >= iValue[1])
                        {
                            MessageBox.Show("Digite valores válidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            txtNumero.Text = null;
                            txtQuantidade.Text = null;
                        }
                        else
                        {
                            String sQtd = txtQuantidade.Text; b = true;

                            for (int i = 0; i < sQtd.Length; i++)
                                if (!IsNumber(sQtd[i]))
                                    b = false;

                            if (!b)
                            {
                                MessageBox.Show("Digite valores válidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                txtNumero.Text = null;
                                txtQuantidade.Text = null;
                            }
                            else
                            {
                                int iQtd = int.Parse(sQtd);

                                if (iQtd <= 0)
                                {
                                    MessageBox.Show("Digite valores válidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    txtNumero.Text = null;
                                    txtQuantidade.Text = null;
                                }
                                else
                                {
                                    sAcumulaIntervalo = sAcumulaIntervalo + sBox + "/";
                                    sAcumulaQuantidade = sAcumulaQuantidade + sQtd + "/";
                                    iContador++;

                                    txtNumero.Text = null;
                                    txtQuantidade.Text = null;
                                }
                            }

                            if (iContador >= 2)
                                btnCalcular.Enabled = true;
                        }
                    }
                }
            }
        }

        private bool IsNumber(char c)
        {
            bool b = false;

            try
            {
                int i = int.Parse(c.ToString());

                b = true;
            }
            catch (FormatException)
            {
                b = false;
            }

            return b;
        }

        private bool IsDot(char c)
        {
            if (Equals(c, ';'))
                return true;

            return false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            sIntervalo = sAcumulaIntervalo.Split('/');
            sQuantidade = sAcumulaQuantidade.Split('/');

            int iStrLen = sIntervalo.Length - 1;

            iIntervalo = new int[2, iStrLen];
            iQuantidade = new int[iStrLen];

            int iPos, iStringSize = 0;
            String sToConvert;
            String[] sConverted = new String[2];

            for (int i = 0; i < iStrLen; i++)
            {
                sConverted[0] = sConverted[1] = null;
                iPos = 0;

                iStringSize = sIntervalo[i].Length;

                for (int j = 0; j < iStringSize; j++)
                {
                    sToConvert = sIntervalo[i].Substring(j, 1);

                    if (IsNumber(char.Parse(sToConvert)))
                        sConverted[iPos] += sToConvert;
                    else if (IsDot(char.Parse(sToConvert)))
                        iPos++;
                }

                iIntervalo[0, i] = int.Parse(sConverted[0]);
                iIntervalo[1, i] = int.Parse(sConverted[1]);
                iQuantidade[i] = int.Parse(sQuantidade[i]);
            }

            Resultados x = new Resultados(sIntervalo, iQuantidade, iIntervalo);
            x.Show();

            for(int i = 0; i < iQuantidade.Length; i++)
            {
                iIntervalo[0, i] = 0;
                iIntervalo[1, i] = 0;
                iQuantidade[i] = 0;
                sIntervalo[i] = null;
                sQuantidade[i] = null;
            }

            sAcumulaIntervalo = null;
            sAcumulaQuantidade = null;
            iContador = 0;

            btnCalcular.Enabled = false;
        }
    }
}
