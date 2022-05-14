using System;
namespace Apartment_application
{
    /// <summary>
    /// Contains data of whats avalible when creating an apartment.
    /// Also conatins the data of what the user have choosen.
    /// </summary>
    class Apartment_complex
        {
            public string[] standard = {"door", "window", "bathroom", "kitchen"};
            public string[] uniqe= {"living_room", "sauna", "tumbler_lock", "balcony"};
            public string[] additional = {"kitchenisland", "tiles", "wet_room_carpet"};
            public string[] sizes = {"1 room", " 2 room", "3 room", "4 room"};
            public string[] kitchen_island_type = {"Granite_Black", "Granite_White", "Laminate_Black", "Laminate_White"};
            /// <summary>
            /// Contains the data of what the user have choosen.
            /// </summary>
            /// <typeparam name="string">What choosen</typeparam>
            /// <typeparam name="string">How many choosen</typeparam>
            public Dictionary<string, string> viewer_have_choosen =
                new Dictionary<string, string>();


 
        }
}