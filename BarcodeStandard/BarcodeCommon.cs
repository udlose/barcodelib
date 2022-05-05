using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BarcodeLib
{
    abstract class BarcodeCommon
    {
        protected string Raw_Data = "";
        protected List<string> _Errors = new List<string>();
        private static readonly Regex _NumericOnlyRegex = new Regex(@"^\d+$", RegexOptions.Compiled);

        public string RawData
        {
            get { return this.Raw_Data; }
        }

        public List<string> Errors
        {
            get { return this._Errors; }
        }

        public void Error(string errorMessage)
        {
            this._Errors.Add(errorMessage);
            throw new Exception(errorMessage);
        }

        internal static bool CheckNumericOnly(string data)
        {
            return _NumericOnlyRegex.IsMatch(data);
        }
    }//BarcodeVariables abstract class
}//namespace
