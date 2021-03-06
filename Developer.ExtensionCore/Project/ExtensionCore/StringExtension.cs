using ExtensionCore.Enums;
using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ExtensionCore
{
    public static class StringExtension
    {
        /// <summary>
        /// Retorna a data no formato informado, por padrão irá retornar a data e hora do Brasil "dd/MM/yyyy HH:mm:ss".
        /// Caso ocorra algum erro, irá retornar string.Empty;
        /// </summary>
        /// <param name="val"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static string ToDateFormat(this DateTime val, string format = "dd/MM/yyyy HH:mm:ss")
        {
            string result;

            try
            {
                result = val.ToString(format);
            }
            catch
            {
                result = string.Empty;
            }

            return result;
        }

        /// <summary>
        /// Retorna a data no formato da cultura informada.
        /// Caso ocorra algum erro, irá retornar string.Empty;
        /// </summary>
        /// <param name="val"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public static string ToDateCulture(this DateTime val, string culture)
        {
            string result;

            try
            {
                result = val.ToString(CultureInfo.CreateSpecificCulture(culture));
            }
            catch
            {
                result = string.Empty;
            }

            return result;
        }

        /// <summary>
        /// Retorna a data no formato da cultura informada.
        /// Caso ocorra algum erro, irá retornar string.Empty;
        /// </summary>
        /// <param name="val"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public static string ToDateCulture(this DateTime val, EnumCountryCulture culture)
        {
            string result;

            try
            {
                string description = culture.GetDescription();
                result = val.ToString(CultureInfo.CreateSpecificCulture(description));
            }
            catch
            {
                result = string.Empty;
            }

            return result;
        }

        /// <summary>
        /// Caso tenha um texto maior do que o máximo de caracteres informado, o texto será reduzido para o máximo de caracteres informado.
        /// Caso ocorra algum erro, irá retornar string.Empty;
        /// </summary>
        /// <param name="val"></param>
        /// <param name="maxCaracteres"></param>
        /// <returns></returns>
        public static string ReduceText(this string val, int maxCaracteres, bool ellipsis)
        {
            string result;

            try
            {
                if (!val.IsNullOrEmptyOrWhiteSpace() && val.Length > maxCaracteres)
                {
                    if (ellipsis == false)
                    {
                        result = $"{val.Substring(0, maxCaracteres).Trim()}";
                    }
                    else
                    {
                        result = $"{val.Substring(0, maxCaracteres).Trim()}...";
                    }
                }
                else
                {
                    result = val;
                }
            }
            catch
            {
                result = string.Empty;
            }

            return result;
        }

        /// <summary>
        /// Retorna a data por extenso, Exemplo: Terça, 07 de Setembro de 2021
        /// Culturas aceitas: pt-BR
        /// </summary>
        /// <param name="val"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public static string ToDateExtensive1(this DateTime val, string culture)
        {
            string result = string.Empty;

            try
            {
                if (culture.Equals("pt-BR", StringComparison.OrdinalIgnoreCase))
                {
                    CultureInfo cultureInfo = new CultureInfo(culture);
                    DateTimeFormatInfo dif = cultureInfo.DateTimeFormat;

                    string day = val.Day.ToString();
                    string year = val.Year.ToString();
                    string month = cultureInfo.TextInfo.ToTitleCase(dif.GetMonthName(val.Month));
                    string weekday = cultureInfo.TextInfo.ToTitleCase(dif.GetDayName(val.DayOfWeek));

                    result = $"{weekday}, {day} de {month} de {year}";
                }
            }
            catch
            {
                result = string.Empty;
            }

            return result;
        }

        /// <summary>
        /// Retorna a data por extenso, Exemplo: Terça, 07 de Setembro de 2021
        /// Culturas aceitas: pt-BR
        /// </summary>
        /// <param name="val"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public static string ToDateExtensive1(this DateTime val, EnumCountryCulture culture)
        {
            string result = string.Empty;

            try
            {
                string description = culture.GetDescription();

                if (description.Equals("pt-BR", StringComparison.OrdinalIgnoreCase))
                {
                    CultureInfo cultureInfo = new CultureInfo(description);
                    DateTimeFormatInfo dif = cultureInfo.DateTimeFormat;

                    string day = val.Day.ToString();
                    string year = val.Year.ToString();
                    string month = cultureInfo.TextInfo.ToTitleCase(dif.GetMonthName(val.Month));
                    string weekday = cultureInfo.TextInfo.ToTitleCase(dif.GetDayName(val.DayOfWeek));

                    result = $"{weekday}, {day} de {month} de {year}";
                }
            }
            catch
            {
                result = string.Empty;
            }

            return result;
        }

        /// <summary>
        /// Retorna a data por extenso, Exemplo: 07 de Setembro de 2021
        /// Culturas aceitas: pt-BR
        /// </summary>
        /// <param name="val"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public static string ToDateExtensive2(this DateTime val, string culture)
        {
            string result = string.Empty;

            try
            {
                if (culture.Equals("pt-BR", StringComparison.OrdinalIgnoreCase))
                {
                    CultureInfo cultureInfo = new CultureInfo(culture);
                    DateTimeFormatInfo dif = cultureInfo.DateTimeFormat;

                    string day = val.Day.ToString();
                    string year = val.Year.ToString();
                    string month = cultureInfo.TextInfo.ToTitleCase(dif.GetMonthName(val.Month));

                    result = $"{day} de {month} de {year}";
                }
            }
            catch
            {
                result = string.Empty;
            }

            return result;
        }

        /// <summary>
        /// Retorna a data por extenso, Exemplo: 07 de Setembro de 2021
        /// Culturas aceitas: pt-BR
        /// </summary>
        /// <param name="val"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public static string ToDateExtensive2(this DateTime val, EnumCountryCulture culture)
        {
            string result = string.Empty;

            try
            {
                string description = culture.GetDescription();

                if (description.Equals("pt-BR", StringComparison.OrdinalIgnoreCase))
                {
                    CultureInfo cultureInfo = new CultureInfo(description);
                    DateTimeFormatInfo dif = cultureInfo.DateTimeFormat;

                    string day = val.Day.ToString();
                    string year = val.Year.ToString();
                    string month = cultureInfo.TextInfo.ToTitleCase(dif.GetMonthName(val.Month));

                    result = $"{day} de {month} de {year}";
                }
            }
            catch
            {
                result = string.Empty;
            }

            return result;
        }

        /// <summary>
        /// Elimina qualquer caracter que não seja número;
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string OnlyNumbers(this string val)
        {
            string result = val;

            try
            {
                if (!val.IsNullOrEmptyOrWhiteSpace())
                {
                    Regex regex = new Regex(@"[^\d]");
                    result = regex.Replace(val, "");
                }
            }
            catch
            {
                result = val;
            }

            return result;
        }

        /// <summary>
        /// Converte um array de bytes em Base64String
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string BytesToBase64String(this byte[] value)
        {
            return Convert.ToBase64String(value, 0, value.Length);
        }

        /// <summary>
        /// Troca os caracteres acentuados por não acentuados;
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string RemoveAccents(this string val)
        {
            string original = val;
            string result = val;

            try
            {
                if (!val.IsNullOrEmptyOrWhiteSpace())
                {
                    string[] accents = new string[] { "ç", "Ç", "á", "é", "í", "ó", "ú", "ý", "Á", "É", "Í", "Ó", "Ú", "Ý", "à", "è", "ì", "ò", "ù", "À", "È", "Ì", "Ò", "Ù", "ã", "õ", "ñ", "ä", "ë", "ï", "ö", "ü", "ÿ", "Ä", "Ë", "Ï", "Ö", "Ü", "Ã", "Õ", "Ñ", "â", "ê", "î", "ô", "û", "Â", "Ê", "Î", "Ô", "Û" };
                    string[] noAccents = new string[] { "c", "C", "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "Y", "a", "e", "i", "o", "u", "A", "E", "I", "O", "U", "a", "o", "n", "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "A", "O", "N", "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };

                    for (int i = 0; i < accents.Length; i++)
                    {
                        val = val.Replace(accents[i], noAccents[i]);
                    }

                    result = val;
                }
            }
            catch
            {
                result = original;
            }

            return result;
        }

    }
}
