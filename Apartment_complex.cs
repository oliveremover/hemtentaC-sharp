using System;
namespace Apartment_application
{
    class Apartment_complex
        {
            public string[] standard = {"door", "window", "bathroom", "kitchen"};
            public string[] uniqe= {"living_room", "sauna", "tumbler lock", "balcony"};
            public string[] additional = {"kitchenisland", "tiles", "wet room carpet"};
            public string[] sizes = {"one_room", "two_room", "three_room", "four_room"};
            public string number_of_windows;
            class one_room {
                string number_of_windows = 1;
            }
            class two_room {
                string number_of_windows = 2;
            }
            class three_room {
                string number_of_windows = 4;
            }
            class four_room {
                string number_of_windows = 6;
            }

        }
}