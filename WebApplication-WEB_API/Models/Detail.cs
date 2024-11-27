using System.Xml.Serialization;

namespace WebApplication_WEB_API.Models
{
    [XmlRoot("Detail")]
    public class Detail
    {
        [XmlElement("Id")]
        public int Id { get; set; }

        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Address")]
        public string? Address { get; set; }

        [XmlElement("Salary")]
        public double Salary { get; set; }
    }

    // Wrapper class for the collection of Detail objects
    [XmlRoot("ArrayOfDetail")]
    public class DetailList
    {
        [XmlElement("Detail")]
        public List<Detail> Details { get; set; }
    }
}
