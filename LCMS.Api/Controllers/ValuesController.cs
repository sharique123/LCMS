using System.Collections.Generic;
using System.Web.Http;
using LCMS.Core;
using LCMS.Core.ReadyTraining;

namespace LCMS.Api.Controllers
{
  public class ValuesController : ApiController
  {
    // GET api/values
    public IEnumerable<string> Get() {
      return new string[] { "value1", "value2" };
    }

    // GET api/values/5
    public Course Get(int id)
    {
      Settings.ApplicationPath = "C:/Users/sxraza/Documents/Vault/ReadyTraining";
      Settings.ModulePath = "C:/Users/sxraza/Documents/Vault/ReadyTraining/modules/antibribery";
      Settings.ConfigXml = XmlManager.GetXmlDocument(Settings.ApplicationPath + "/modules/antibribery/config_en.xml");
      Settings.LanguageSelected = "en";
      //var doc = new XmlDocument();
      //doc.LoadXml(CreateJson.ConvertXmlToJson(Settings.ApplicationPath + "/modules/antibribery", "config_en.xml", true));
      //return doc;
      //var language = new LanguageSupported(Settings.ModulePath);
      //return language;
      //var language = new LanguageSupported(Settings.ModulePath);
      //return language;
      var course = new Course();
      return course;
    }

    // POST api/values
    public void Post([FromBody]string value) {
    }

    // PUT api/values/5
    public void Put(int id, [FromBody]string value) {
    }

    // DELETE api/values/5
    public void Delete(int id) {
    }
  }
}