using System;
using System.Drawing;
using System.Windows.Forms;


namespace AppModelo.View.Windows.Helpers
{
    internal static partial class Componentes
    {
        
        internal static void FormatarCamposObrigatorios(Form frm)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    switch (control)
                    {
                        case TextBox box:
                            {
                                if (box.Tag == "Obrigatorio")
                                {
                                    box.BackColor = Color.Gold;
                                }
                                break;
                            }
                        case MaskedTextBox box:
                            {
                                if (box.Tag == "Obrigatorio")
                                {
                                    box.BackColor = Color.Gold;
                                }
                                break;
                            }
                        case ComboBox box:
                            {
                                if (box.Tag == "Obrigatorio")
                                {
                                    box.BackColor = Color.Gold;
                                }
                                break;
                            }

                        default:
                            func(control.Controls);
                            break;
                    }

                }
            };
            func(frm.Controls);
        }
    }
}
