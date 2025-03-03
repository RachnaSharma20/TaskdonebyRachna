using System.Xml.Serialization;

namespace EmployeeAPIManagement.Model
{
    
    [XmlRoot("Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class SoapEnvelope<T>
    {
        [XmlElement("Body")]
        public SoapBody<T> Body { get; set; }
    }

    public class SoapBody<T>
    {
        [XmlElement("Response")]
        public T Content { get; set; }
    }

}
