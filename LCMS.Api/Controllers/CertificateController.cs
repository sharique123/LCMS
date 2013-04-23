using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;
using System.Xml;
using LCMS.Core;
using LCMS.Core.ReadyTraining;

namespace LCMS.Api.Controllers
{
  public class CertificateController : ApiController
  {
    // GET api/<controller>/5
    public XmlDocument Get() {
      Settings.ApplicationPath = "C:/Users/sxraza/Documents/Vault/ReadyTraining/";
      Settings.ModulePath = "C:/Users/sxraza/Documents/Vault/ReadyTraining/modules/antibribery/";
      Settings.ConfigXml = XmlManager.GetXmlDocument(Settings.ApplicationPath + "/modules/antibribery/config_en.xml");
      Settings.LanguageSelected = "en";
      //var certificate = new Certificate(Settings.ModulePath, Settings.LanguageSelected);
      //Certificate.GetCertificate(Settings.ModulePath, Settings.LanguageSelected);
      var certificate= XmlManager.GetXmlObject<Certificate>(Settings.ModulePath+"Certificate_en.xml");
      //var bcg = new Cdata("ttghfgfgf");
      //certificate.Background = bcg;
      var a =XmlManager.GetXmlFromObject<Certificate>(certificate);
      return a;
    }

  
  }
}