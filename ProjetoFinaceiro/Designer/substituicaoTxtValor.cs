using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ProjetoFinaceiro.Designer
{
    public class substituicaoTxtValor : TextBox
    {

        //protected override void OnGotFocus(EventArgs e)
        //{
        //    base.OnGotFocus(e);
        //    this.BackColor = Color.
        //    this.SelectAll();
        //}
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            BackColor = Color.BurlyWood;
            if (Text == "")
                return;
            try
            {
                double valor = Convert.ToDouble(Text.Replace("R$ ", ""));
                Convert.ToDouble(Text);
                Text = string.Format("{0:c}", valor);
            }
            catch
            {
                Text = "";
                MessageBox.Show("Valor Invalido");
            }
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Escape)
            {
                Text = "";
                e.SuppressKeyPress = true;
            }
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            TextAlign = HorizontalAlignment.Right;
        }

    }
}
