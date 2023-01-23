using Domain.Models;

namespace Api;

public class DataSource
{
    public List<Hotel> Hotels { get; set; }
    
    public DataSource()
    {
        Hotels = GetHotels();
    }

    private List<Hotel> GetHotels()
    {
        return new List<Hotel>{
            new Hotel {
                HotelId = 1,
                Name = "Mariott",
                Stars = 3,
                Country = "Jamaica",
                City = "Kingston"
            },

            new Hotel {
                HotelId = 2,
                Name = "Pegasus",
                Stars = 4,
                Country = "USA",
                City = "Seattle"
            }
        };
    }
}