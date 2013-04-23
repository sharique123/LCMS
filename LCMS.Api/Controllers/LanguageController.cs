using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using LCMS.Core;
using LCMS.Core.ReadyTraining;

namespace LCMS.Api.Controllers
{
  public class LanguageController : ApiController
    {
        //
        // GET: /Language/

    public LanguageSupported Get()
        {
          Settings.ApplicationPath = "C:/Users/sxraza/Documents/Vault/ReadyTraining";
          Settings.ModulePath = "C:/Users/sxraza/Documents/Vault/ReadyTraining/modules/antibribery";
          Settings.ConfigXml = XmlManager.GetXmlDocument(Settings.ApplicationPath + "/modules/antibribery/config_en.xml");
          Settings.LanguageSelected = "en";
          var language = new LanguageSupported(Settings.ModulePath);
          return language;
        }

    }
}
