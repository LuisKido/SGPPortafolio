using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPermisos.Controladores
{
    public class clsValidator
    {
        public static void KeyPress_Solo_Letras(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"^[a-zA-Z ]+$") && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void KeyPress_Solo_Letras_Numeros(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"^[a-zA-Z0-9 ]+$") && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void KeyPress_Solo_Letras_Numeros_Sin_Espacio(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"^[a-zA-Z0-9]+$") && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void KeyPress_Solo_Numeros(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"^[0-9]+$") && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void KeyPress_Solo_Numeros_K(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"^(\d{1,3}(\.?\d{3}){2})\-?([\dkK])$") && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //public bool Valida_Email(TextBox email)
        //{
        //    try
        //    {
        //        if (email.Text.Trim() != string.Empty)
        //        {
        //            var test = new System.ComponentModel.DataAnnotations.EmailAddressAttribute();
        //            if (test.IsValid(email.Text))
        //            {
        //                return true;
        //            }
        //            else
        //            {
        //                return false;
        //            }
        //        }
        //        else
        //        {
        //            return false;
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}

        public static bool Validar_Email(string emailaddress)
        {
            try
            {
                Regex rx = new Regex(
            @"^[-!#$%&'*+/0-9=?A-Z^_a-z{|}~](\.?[-!#$%&'*+/0-9=?A-Z^_a-z{|}~])*@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)+$");
                return rx.IsMatch(emailaddress);
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static bool Valida_Vacios(List<TextBox> tboxs)
        {
            bool valido = false;
            foreach (TextBox tbox in tboxs)
            {

                if (tbox.Text.Trim() != string.Empty)
                {
                    valido = true;
                }
                else
                {
                    valido = false;
                    return valido;
                }
            }
            return valido;
        }

        public static bool Valida_Fecha_Nacimiento(DateTimePicker dtPicker)
        {

            bool valido = false;

            DateTime dt1 = dtPicker.Value;
            DateTime dt2 = DateTime.Now;

            if (dt1 > dt2)
            {
                valido = false;
            }
            else
            {
                valido = true;
            }

            return valido;
        }

        public static string formatearRut(string rut)
        {
            int cont = 0;
            string format;
            if (rut.Length == 0)
            {
                return "";
            }
            else
            {
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                format = "-" + rut.Substring(rut.Length - 1);
                for (int i = rut.Length - 2; i >= 0; i--)
                {
                    format = rut.Substring(i, 1) + format;
                    cont++;
                    if (cont == 3 && i != 0)
                    {
                        format = "." + format;
                        cont = 0;
                    }
                }
                return format;
            }
        }

        public static bool validarRut(string rut)
        {

            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = Convert.ToInt32(rut.Substring(0, rut.Length - 1));

                char dv = Convert.ToChar(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {
            }
            return validacion;
        }
    }
}
