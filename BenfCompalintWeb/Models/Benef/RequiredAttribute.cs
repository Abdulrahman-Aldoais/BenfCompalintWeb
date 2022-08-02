using System;

namespace BenfCompalintWeb.Models.Benef
{
    internal class RequiredAttribute : Attribute
    {
        public string ErrorMessage { get; set; }
    }
}