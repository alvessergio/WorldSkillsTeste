using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelCetafet
{
    public static class Msg
    {
       public static DialogResult sucesso(string mensagem, string titulo = "Mensagem")
       {
            return MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
       }

        public static DialogResult erro(string mensagem, string titulo = "Erro")
        {
            return MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult atencao(string mensagem, string titulo = "Atenção")
        {
            return MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult simNao(string mensagem, string titulo = "Atenção")
        {
            return MessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }


        public static DialogResult simNaoCancel(string mensagem, string titulo = "Atenção")
        {
            return MessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }
    }
}
