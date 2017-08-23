using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unicode_To_ST7920C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbxInput_TextChanged(object sender, EventArgs e)
        {
            if (tbxInput.Text.Length <= 0)
            {
                tbxOutput.Text = "";
                return;
            }

            StringBuilder errorList = new StringBuilder();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < tbxInput.Text.Length; i++)
            {
                int ch = tbxInput.Text[i];
                int uv = -1;

                if(ch >= 128)
                {
                    int lb = 0, ub = ST7920C_UnicodeMapping.table.GetLength(0);
                    int mid = 0;

                    while (lb < ub)
                    {
                        mid = (lb + ub) / 2;
                        if (ch == ST7920C_UnicodeMapping.table[mid, 0])
                        {
                            uv = ST7920C_UnicodeMapping.table[mid, 1];
                            break;
                        }
                        else if (ch > ST7920C_UnicodeMapping.table[mid, 0])
                        {
                            lb = mid + 1;
                        }
                        else
                        {
                            ub = mid;
                        }
                    }
                }
                else
                {
                    uv = ch;
                }

                if (uv >= 0 && uv < ushort.MaxValue)
                {
                    if (rdbStringStyle.Checked)
                    {
                        if (uv >= 0x20 && uv < 127 && uv != '\\')
                        {
                            result.Append((char) uv);
                        }
                        else
                        {
                            result.Append("\\x");
                            if (uv >= 256)
                            {
                                result.Append(((uv >> 8) & 0xFF).ToString("X"));
                                result.Append("\\x");
                            }
                            result.Append((uv & 0xFF).ToString("X"));
                        }
                    }
                    else if (rdbArrayStyle.Checked)
                    {
                        if (result.Length > 0) result.Append(", ");
                        result.Append("0x");
                        if(uv >= 256)
                        {
                            result.Append(((uv >> 8) & 0xFF).ToString("X"));
                            result.Append(", 0x");
                        }
                        result.Append((uv & 0xFF).ToString("X"));
                    }
                    else
                    {
                        result.Clear();
                        result.Append("你到底是字串還是陣列搞得我好亂啊");
                        break;
                    }
                }
                else
                {
                    if (errorList.Length == 0) errorList.Append("轉換錯誤：");
                    errorList.Append(string.Format("{0}(0x{1}) ", i, ch.ToString("X")));
                }
            }

            tbxOutput.Text = result.ToString();
            statusMessage.Text = errorList.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            statusMessage.Text = "字庫大小：" + ST7920C_UnicodeMapping.table.GetLength(0).ToString();
        }

        private void tbxOutput_MouseClick(object sender, MouseEventArgs e)
        {
            tbxOutput.SelectAll();
        }
    }
}
