using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ProjetoFinaceiro.Services
{
    public class substituicaoTxtValor:TextBox
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
            this.BackColor= Color.BurlyWood;
            if (this.Text == "")
                return;
            try
            {
                double valor = Convert.ToDouble(this.Text.Replace("R$ ", "" ));
                Convert.ToDouble(this.Text);
                this.Text = String.Format("{0:c}", valor);
            }
            catch
            {
                this.Text = "";
                MessageBox.Show("Valor Invalido");
            }
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Escape)
            {
                this.Text = "";
                e.SuppressKeyPress = true;
            }
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.TextAlign = HorizontalAlignment.Right;
        }
       
    }
}
