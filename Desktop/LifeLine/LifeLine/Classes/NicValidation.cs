using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeLine
{
    public static class NicValidation
    {
        public static bool validate(GunaTextBox nic)
        {
            if(((nic.Text.Count(char.IsDigit) == 9) && (nic.Text.EndsWith("v") || nic.Text.EndsWith("V")) && (nic.Text[2] != '4' && nic.Text[2] != '9')) || (nic.Text.Count(char.IsDigit)==12))
            {
                return true;
            }
            return false;
        }
    }
}
