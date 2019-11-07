using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PipesCalculator
{
    public class TextBoxInputHendler
    {
        private const string PeriodDecimalDelimiter = ".";
        private const string CommaDecimalDelimiter = ",";

        private bool IsNumericInput(KeyEventArgs e)
        {
            if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
            {
                if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
                {
                    return false;
                }
            }

            return true;
        }

        private bool IsDecimalPoint(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Decimal)
            {
                return true;
            }

            return false;
        }

        private bool IsDeleteInput(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                return true;
            }

            return false;
        }

        private bool IsArrowInput(KeyEventArgs e)
        {
            if (e.KeyCode < Keys.Left || e.KeyCode > Keys.Down)
            {
                return false;
            }

            return true;
        }

        public bool KeysInputHendler(TextBox textBox, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Shift)
            {
                return false;
            }

            if (IsNumericInput(e) || IsDecimalPoint(e) || IsArrowInput(e) || IsDeleteInput(e))
            {
                if (IsDecimalPoint(e))
                {
                    return textBox.Text.ToString().Contains(PeriodDecimalDelimiter)
                           || textBox.Text.ToString().Contains(CommaDecimalDelimiter) ? false : true;
                }

                return true;
            }

            return false;
        }

        public double FloatNumbersInputHendler(TextBox textBox)
        {
            string floatNumber = textBox.Text.ToString();
            string systemSeparator = null;
            double parsingResult = 0.00;

            if (!string.IsNullOrEmpty(floatNumber))
            {
                systemSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

                if (!floatNumber.Contains(systemSeparator))
                {
                    Regex reg = new Regex("[.,]");

                    string currentNumberSeparator = reg.Match(floatNumber).Value;

                    if (!string.IsNullOrEmpty(currentNumberSeparator))
                    {
                        floatNumber = floatNumber.Replace(currentNumberSeparator, systemSeparator);
                    }

                    if (Double.TryParse(floatNumber, out parsingResult))
                    {
                        return parsingResult;
                    }
                }
                else
                {
                    if (Double.TryParse(floatNumber, out parsingResult))
                    {
                        return parsingResult;
                    }
                }
            }

            return default;
        }
    }
}
