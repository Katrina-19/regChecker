using System;
using System.Drawing;
using System.Windows.Forms;

namespace regChecking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbResult.Clear();
            string text = tbText.Text;
            string reg = tbReg.Text;
            char[] arr = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                arr[i] = text[i];
            }

            switch (reg)
            {
                case "[A-Z]":
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (Char.IsUpper(arr[i]))
                        {

                            tbResult.ForeColor = Color.Red;
                            tbResult.Text += arr[i].ToString();
                        }
                    }

                    break;
                }
                case "[a-z]":
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (Char.IsLower(arr[i]))
                        {

                            tbResult.ForeColor = Color.Red;
                            tbResult.Text += arr[i].ToString();
                        }
                    }

                    break;
                }
                case "[A-Za-z]":
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (Char.IsLetter(arr[i]))
                        {
                            tbResult.ForeColor = Color.Red;
                            tbResult.Text += arr[i].ToString();
                        }
                    }

                    break;
                }
                case "[A-Za-z0-9]":
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (Char.IsLetterOrDigit(arr[i]))
                        {
                            tbResult.ForeColor = Color.Red;
                            tbResult.Text += arr[i].ToString();
                        }
                    }

                    break;
                }
                case "[A-Za-z0-9_]":
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (Char.IsLetterOrDigit(arr[i]) || arr[i].ToString() == "_")
                        {
                            tbResult.ForeColor = Color.Red;
                            tbResult.Text += arr[i].ToString();
                        }
                    }

                    break;
                }
                case @"\w":
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (Char.IsLetterOrDigit(arr[i]) || arr[i].ToString() == "_")
                        {
                            tbResult.ForeColor = Color.Red;
                            tbResult.Text += arr[i].ToString();
                        }
                    }

                    break;
                }
                case "[^A-Za-z0-9_]":
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (!Char.IsLetterOrDigit(arr[i]) || arr[i].ToString() != "_")
                        {
                            tbResult.ForeColor = Color.Red;
                            tbResult.Text += arr[i].ToString();
                        }
                    }

                    break;
                }
                case @"\W":
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (!Char.IsLetterOrDigit(arr[i]) || arr[i].ToString() != "_")
                        {
                            tbResult.ForeColor = Color.Red;
                            tbResult.Text += arr[i].ToString();
                        }
                    }

                    break;
                }
                case "[0-9]":
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (Char.IsDigit(arr[i]))
                        {
                            tbResult.ForeColor = Color.Red;
                            tbResult.Text += arr[i].ToString();
                        }
                    }

                    break;
                }
                case @"\d":
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (Char.IsDigit(arr[i]))
                        {
                            tbResult.ForeColor = Color.Red;
                            tbResult.Text += arr[i].ToString();
                        }
                    }

                    break;
                }
                case "[^0-9]":
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (!Char.IsDigit(arr[i]))
                        {
                            tbResult.ForeColor = Color.Red;
                            tbResult.Text += arr[i].ToString();
                        }
                    }

                    break;
                }
                case @"\D":
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (!Char.IsDigit(arr[i]))
                        {
                            tbResult.ForeColor = Color.Red;
                            tbResult.Text += arr[i].ToString();
                        }
                    }

                    break;
                }
                case "[0-9A-Fa-f]":
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (Char.IsNumber(arr[i]))
                        {
                            tbResult.ForeColor = Color.Red;
                            tbResult.Text += arr[i].ToString();
                        }
                    }

                    break;

                }
                case "[.,!?:;...]":
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (Char.IsPunctuation(arr[i]))
                        {
                            tbResult.ForeColor = Color.Red;
                            tbResult.Text += arr[i].ToString();
                        }
                    }

                    break;
                }
                case "[\t]":
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (Char.IsWhiteSpace(arr[i]))
                        {
                            tbResult.ForeColor = Color.Red;
                            tbResult.Text += arr[i].ToString();
                        }
                    }

                    break;
                }
                case "[\t\n\r\f\v]":
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (Char.IsSeparator(arr[i]))
                        {
                            tbResult.ForeColor = Color.Red;
                            tbResult.Text += arr[i].ToString();
                        }
                    }

                    break;
                }
                case @"\s":
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (Char.IsSeparator(arr[i]))
                        {
                            tbResult.ForeColor = Color.Red;
                            tbResult.Text += arr[i].ToString();
                        }
                    }

                    break;
                }
                case "[^\t\n\r\f\v]":
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (!Char.IsSeparator(arr[i]))
                        {
                            tbResult.ForeColor = Color.Red;
                            tbResult.Text += arr[i].ToString();
                        }
                    }

                    break;
                }
                case @"\S":
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (!Char.IsSeparator(arr[i]))
                        {
                            tbResult.ForeColor = Color.Red;
                            tbResult.Text += arr[i].ToString();
                        }
                    }

                    break;
                }
                case "[\x00-\x1F\x7F]":
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (Char.IsControl(arr[i]))
                        {
                            tbResult.ForeColor = Color.Red;
                            tbResult.Text += arr[i].ToString();
                        }
                    }

                    break;
                }
                case "":
                {
                    MessageBox.Show(
                        "Вы ничего не ввели",
                        "Предупреждение",
                        MessageBoxButtons.OK);
                    break;
                }
                default:
                {
                    MessageBox.Show(
                        "Вы ввели не регулярное выражение",
                        "Предупреждение",
                        MessageBoxButtons.OK);
                    break;
                }
            }
            if (tbResult.Text == "")
            {
                MessageBox.Show(
                    "Строка не содержит регулярное выражение",
                    "Предупреждение",
                    MessageBoxButtons.OK);
            }
        }
    }
}
