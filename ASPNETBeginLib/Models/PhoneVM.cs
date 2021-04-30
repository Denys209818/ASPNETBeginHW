using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ASPNETBeginLib.Models
{
    public enum ColorPhone { Red, Greed , Black, Silver }; 
    [DataContract]
    public class PhoneVM
    {
        [DataMember]
        public string brand { get; set; }
        [DataMember]
        public string model { get; set; }
        [DataMember]
        public decimal price { get; set; }
        [DataMember]
        public ColorPhone color { get; set; }
        [DataMember]
        public string image { get; set; }
    }
}
