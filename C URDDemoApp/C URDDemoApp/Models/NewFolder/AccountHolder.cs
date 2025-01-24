
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;




public class AccountHolder
{
    //[Key]
    public int Account_Holder_ID { get; set; }
    public string Mobilenumber { get; set; }
    public string POAType { get; set; }
    public string POA { get; set; }
    public string POIType { get; set; }
    public string POI { get; set; }
    public string Name { get; set; }
    public string KYCStatus { get; set; }
    public string Poiemail { get; set; }
    public string Account_Holder_Address { get; set; }
    public DateTime RegDate { get; set; }
}

