using EmployeeAPIManagement.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Serialization;

namespace EmployeeAPIManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeAPIController : ControllerBase
    {

        // JSON Response
        [HttpGet("GetJson")]
        public IActionResult GetJsonData()
        {
            var user = new UserModel
            {
                Name = "John Doe",
                Email = "john@example.com",
                Password = "password123"
            };
            return Ok(user); // Returns JSON response
        }

        // XML SOAP Response
        [HttpGet("GetSoapXml")]
        public IActionResult GetSoapXml()
        {
            var response = new SoapEnvelope<UserModel>
            {
                Body = new SoapBody<UserModel>
                {
                    Content = new UserModel
                    {
                        Name = "John Doe",
                        Email = "john@example.com",
                        Password = "password123"
                    }
                }
            };

            var xmlSerializer = new XmlSerializer(typeof(SoapEnvelope<UserModel>));
            using var stringWriter = new StringWriter();
            xmlSerializer.Serialize(stringWriter, response);
            var xmlData = stringWriter.ToString();

            return Content(xmlData, "application/xml");
        }
    }
}
