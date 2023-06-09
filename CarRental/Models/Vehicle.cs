using CarRental.Data;

namespace CarRental.Models;

public class Vehicle
{
    public int Id { get; set; }
    public string Registration { get; set; }
    public EngineType EngineType { get; set; }
    public VehicleType VehicleType { get; set; }
    public string Model { get; set; }
    public decimal PricePerDay { get; set; }
    
    public ICollection<Rental> Rentals { get; set; }
}