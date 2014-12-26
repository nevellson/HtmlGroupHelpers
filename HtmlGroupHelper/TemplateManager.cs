using System;
using System.IO;
using System.Web;
using System.Web.Configuration;


namespace HtmlGroupHelper
{
    internal class TemplateManager
    {
        internal TemplateManager()
        {
            string defaultAdress = WebConfigurationManager.AppSettings["DefaultTemplate"];

            if (defaultAdress==null)
            {
                throw new ArgumentNullException("DefaultTemplate", "DefaultTemplate can'not be null please add DefaultTemplate key to  web.config");
            }

            this.DefaultTemplateAdress = HttpContext.Current.Server.MapPath(defaultAdress);
        }
        internal string DefaultTemplateAdress;
        internal string GetTemplate(string name)
        {
            StreamReader reader = new StreamReader(GetTemplateAdressByName(name));
            string template = reader.ReadToEnd();
            reader.Dispose();
            return template;
        }
        private string GetTemplateAdressByName(string name)
        {
            string adress = WebConfigurationManager.AppSettings[name];
            string phsycalAdress = HttpContext.Current.Server.MapPath(adress);
            return File.Exists(phsycalAdress) ? phsycalAdress : DefaultTemplateAdress;
        }
    }
}
