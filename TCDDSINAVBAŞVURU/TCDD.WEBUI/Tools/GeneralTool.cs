using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TCDD.WEBUI.Tools
{
    public class GeneralTool
    {
        public static string URLConvert(string _text)
        {
            return _text.ToLower().Replace(" ", "-").Replace("ö", "o").Replace("ü", "u").Replace("ç", "ç").Replace("ı", "i").Replace("ğ", "g").Replace("ş", "s");
        }

       
       

        public static string getMD5(string _text)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(_text));
                return BitConverter.ToString(hash).Replace("-", "");
            }
        }
    }
}
