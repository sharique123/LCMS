using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml;
using LCMS.Core;
using LCMS.Core.ReadyTraining;


namespace LCMS.Api.Controllers
{
  public class HotlineController : ApiController
  {
    //
    // GET: /Hotline/

    public XmlDocument Get() {
      Settings.ApplicationPath = "C:/Users/sxraza/Documents/Vault/ReadyTraining/";
      Settings.ModulePath = "C:/Users/sxraza/Documents/Vault/Clients/visa_fy13/readytraining/";
      Settings.ConfigXml = XmlManager.GetXmlDocument(Settings.ApplicationPath + "/modules/antibribery/config_en.xml");
      Settings.LanguageSelected = "en";

      var hotline = XmlManager.GetXmlObject<Hotline>(Settings.ModulePath + "Hotline_en.xml");

      var a = XmlManager.GetXmlFromObject<Hotline>(hotline);
      return a;
    }

  }
}