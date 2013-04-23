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
  public class TopicController : ApiController
  {
    public XmlDocument Get() {
      Settings.ApplicationPath = "C:/Users/sxraza/Documents/Vault/ReadyTraining/";
      Settings.ModulePath = "C:/Users/sxraza/Documents/Vault/ReadyTraining/modules/antibribery/";
      Settings.ConfigXml = XmlManager.GetXmlDocument(Settings.ApplicationPath + "/modules/antibribery/config_en.xml");
      Settings.LanguageSelected = "en";
      //var certificate = new Certificate(Settings.ModulePath, Settings.LanguageSelected);
      //Certificate.GetCertificate(Settings.ModulePath, Settings.LanguageSelected);
      var topic = XmlManager.GetXmlObject<ScreenTopic>(Settings.ModulePath + "/03/Topic_en.xml");
     
      var a = XmlManager.GetXmlFromObject<ScreenTopic>(topic);
      return a;
    }

    // GET api/<controller>/5
    public string Get(int id) {
      return "value";
    }

    // POST api/<controller>
    public void Post([FromBody]string value) {
    }

    // PUT api/<controller>/5
    public void Put(int id, [FromBody]string value) {
    }

    // DELETE api/<controller>/5
    public void Delete(int id) {
    }
  }
}