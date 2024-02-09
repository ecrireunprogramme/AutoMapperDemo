namespace AutoMapperDemo.Entities;

public class Colis
{
    public int Id { get; set; }
    public string? SenderName { get; set; }
    public string? SenderPhone { get; set; }
    public string? ReceiverName { get; set; }
    public string? ReceiverPhone { get; set; }
    public string? CreatedBy { get; set; }
    public Address? DeliveryAddress { get; set; }

        
    public string GetSenderInfos()
    {
        return $"Get - {SenderName} - {SenderPhone}";
    }
}

public class Address 
{
    public int StreetNumber { get; set; }
    public string? StreetName { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    public string? PostalCode { get; set; }
}
