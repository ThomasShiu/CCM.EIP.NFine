/*******************************************************************************
 * Copyright © 2016 CCM.Framework 版权所有
 * Author: CCM
 * Description: CCM快速开发平台
 * Website：http://www.CCM.cn
*********************************************************************************/
using System;
using System.Security.Cryptography;
using System.Text;

namespace CCM.Code
{
    /// <summary>
    /// MD5加密
    /// </summary>
    public class Md5
    {
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="str">加密字符</param>
        /// <param name="code">加密位数16/32</param>
        /// <returns></returns>
        public static string md5(string str, int code)
        {
            string strEncrypt = string.Empty;
            if (code == 16)
            {
                strEncrypt = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(str, "MD5").Substring(8, 16);

                //MD5 md5 = MD5.Create();
                //strEncrypt = BitConverter.ToString(md5.ComputeHash(Encoding.UTF8.GetBytes(str))).Replace("-","").Substring(8, 16);
            }

            if (code == 32)
            {
                strEncrypt = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(str, "MD5");

                //MD5 md5 = MD5.Create();
                //strEncrypt = BitConverter.ToString(md5.ComputeHash(Encoding.UTF8.GetBytes(str))).Replace("-", "");
            }

            return strEncrypt;
        }
    }
}
