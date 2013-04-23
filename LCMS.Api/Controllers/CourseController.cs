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
  public class CourseController : ApiController
  {
    public XmlDocument Get() {
      Settings.ApplicationPath = "C:/Users/sxraza/Documents/Vault/ReadyTraining/";
      Settings.ModulePath = "C:/Users/sxraza/Documents/Vault/ReadyTraining/modules/antibribery/";
      Settings.ConfigXml = XmlManager.GetXmlDocument(Settings.ApplicationPath + "/modules/antibribery/config_en.xml");
      Settings.LanguageSelected = "en";

      var course = XmlManager.GetXmlObject<Course>(Settings.ApplicationPath + "Course_en.xml");

      var a = XmlManager.GetXmlFromObject<Course>(course);
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