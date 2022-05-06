using System;
namespace Apartment_application
{
    class Apartment_complex
        {
            public string[] standard = {"door", "window", "bathroom", "kitchen"};
            public string[] uniqe= {"living_room", "sauna", "tumbler lock", "balcony"};
            public string[] additional = {"kitchenisland", "tiles", "wet_room_carpet"};
            public string[] sizes = {"1 room", " 2 room", "3 room", "4 room"};
            public string[] kitchen_island_type = {"Granite_Black", " Granite_White", "Laminate_Black", "Laminate_White"};

            public Dictionary<string, string> viewer_have_choosen =
                new Dictionary<string, string>();


 
        }
}