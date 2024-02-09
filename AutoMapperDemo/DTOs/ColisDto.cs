namespace AutoMapperDemo.DTOs;

public class ColisDto
{
    public int Id { get; set; }
    public string? SenderInfos { get; set; }
    public string? ReceiverInfos { get; set; }
    public int DeliveryAddressStreetNumber { get; set; }
    public string? DeliveryAddressStreetName { get; set; }
    public string? DeliveryAddressCity { get; set; }
    public string? DeliveryAddressPostalCode { get; set; }
    public double PathLength {get; set; }
}

public class AddressDto 
{
    public int StreetNumber { get; set; }
    public string? StreetName { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    public string? PostalCode { get; set; }
}