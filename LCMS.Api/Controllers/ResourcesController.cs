using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Xml;
using LCMS.Core;
using LCMS.Core.ReadyTraining;

namespace LCMS.Api.Controllers
{
    public class ResourcesController : ApiController
    {
        //
        // GET: /Resources/

      public XmlDocument Get() {
        Settings.ApplicationPath = "C:/Users/sxraza/Documents/Vault/ReadyTraining/";
        Settings.ModulePath = "C:/Users/sxraza/Documents/Vault/Clients/Worthington_expanded/readytraining/modules/expandedcode/";
        Settings.ConfigXml = XmlManager.GetXmlDocument(Settings.ApplicationPath + "/modules/antibribery/config_en.xml");
        Settings.LanguageSelected = "en";
        
        var resources = XmlManager.GetXmlObject<Resources>(Settings.ModulePath + "Resources_en.xml");

        var a = XmlManager.GetXmlFromObject<Resources>(resources);
        return a;
      }

    }
}
