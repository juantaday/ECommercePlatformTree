using MultiColumnComboSuggestionBox.Class;
using System.Reflection;
using Microsoft.VisualBasic;
using System;

namespace MultiColumnComboSuggestionBox.Funtions
{
    public static class GetSpliter
    {
        public static ResponseSpliter GenerateSpliter(string myFindText, bool isPreparatedStatement = false)
        {
            ResponseSpliter _responseSpliter = new ResponseSpliter();
            //si no ha dada
            myFindText = myFindText.Trim();
            if (myFindText.ToString().Length == 0 || string.IsNullOrWhiteSpace(myFindText))
            {
                return _responseSpliter;
            }
            //preparamos el texto
            bool isSpace = false;
            string sql = string.Empty;
            foreach (var item in myFindText)
            {
                if (!isSpace)
                {
                    sql += item;
                    isSpace = false;
                }

                if (string.IsNullOrWhiteSpace(item.ToString()))
                {
                    isSpace = true;
                }
                else
                {
                    if (isSpace)
                    {
                        sql += item;
                    }
                    isSpace = false;
                }


            }

            myFindText = sql;

            //rebisamos si no es codigo munerico entonces es barra de codigo
            bool isnumric=true;
            foreach (var texto in myFindText)
            {
                if (Strings.InStr("0123456789", texto.ToString()) == 0)
                {
                    isnumric = false;
                    break;
                }
            }

            if (isnumric)
            {
                _responseSpliter = new ResponseSpliter
                {
                    IsSucces = true,
                    IsNumeric = isnumric,
                    Spliter = myFindText.Split(' ')
                };
                goto Salida;
            }

            _responseSpliter = new ResponseSpliter
            {
                IsSucces = true,
                Spliter = myFindText.Split(' ')
            };



            Salida:
            if (isPreparatedStatement)
            {

            }
            return _responseSpliter;
        }
    }
}

