using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelMarket.Core
{
    public enum ServiceType
    {
        [Description("Автобусный тур")]
        BusTrip = 0,
        [Description("Железнодорожный тур")]
        TrainTrip = 1,
        [Description("Авиа перелет")]
        Flight = 2,
        [Description("Размещение в отеле")]
        Accommodation = 3,
        [Description("Экскурсии. Достопримечательности")]
        Sightseeing = 4,
        [Description("Комплексный тур")]
        ComplexTour = 5
    }
    public enum UserRole
    {
        Client = 0,
        Organizer = 1
    }

}
