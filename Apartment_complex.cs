using System;
namespace Apartment_application
{
    class Apartment_complex
        {
            public string[] standard = {"door", "window", "bathroom", "kitchen"};
            public string[] uniqe= {"living_room", "sauna", "tumbler lock", "balcony"};
            public string[] additional = {"kitchenisland", "tiles", "wet room carpet"};
            public string[] sizes = {"1 room", " 2 room", "3 room", "4 room"};
            public string[] kitchen_island_type = {"Granite Black", " Granite White", "Laminate Black", "Laminate White"};

            public Dictionary<string, string> viewer_have_choosen =
                new Dictionary<string, string>();
            string standard_string = string.Join(" : ", standard);
            public void Run(string size_chosen){
                viewer_have_choosen.Add("Size", size_chosen);
                viewer_have_choosen.Add("Standard", standard_string);
            }

 
        }
}