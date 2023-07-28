using DbbForTurboAz.Model;

public class Car
{
    public int Id { get; set; }
    public string Make { get; set; }
    public string Model { get; set; } 
    public int Year { get; set; } 
    public int Price { get; set; }
    public string VIN { get; set; }
    public int ShowRoomId { get; set; }
    public int BodyTypeId { get; set; }
    public int Mileage { get; set; }
    public int CityId { get; set; }
    public int ColorId { get; set; }
    public int EngineVolume { get; set; }
    public int WheelDriveTypeId { get; set; }
    public int FuelTypeId { get; set; }
    public int TransmissionTypeId { get; set; }
    public int HorsePower { get; set; }
    public int PassengerCount { get; set; }
    public string PhoneNumber { get; set; }

    public virtual ShowRoom ShowRoom { get; set; }
    public virtual BodyType BodyType { get; set; }
    public virtual City City { get; set; }
    public virtual Color Color { get; set; }
    public virtual WheelDriveType WheelDriveType { get; set; }
    public virtual FuelType FuelType { get; set; }
    public virtual TransmissionType TransmissionType { get; set; }
}
