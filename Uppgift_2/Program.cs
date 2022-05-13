using System;
namespace Cinema_application
{
    public class Booking
    {
        static void Main(string[] args)
        {


            Movies movie1 = new Movies("The Unbearable Weight of Massive Talent", "Unfulfilled and facing financial ruin, actor Nick Cage accepts a $1 million offer to attend a wealthy fan's birthday party. Things take a wildly unexpected turn when a CIA operative recruits Cage for an unusual mission. Taking on the role of a lifetime, he soon finds himself channeling his most iconic and beloved characters to save himself and his loved ones.",
                                        106);
            Movies movie2 = new Movies("Fantastiska vidunder: Dumbledores hemligheter","Professor Albus Dumbledore knows the powerful, dark wizard Gellert Grindelwald is moving to seize control of the wizarding world. Unable to stop him alone, he entrusts magizoologist Newt Scamander to lead an intrepid team of wizards and witches. They soon encounter an array of old and new beasts as they clash with Grindelwald's growing legion of followers.",143);

            movie1.create_seat_map();
            movie2.create_seat_map();
            bool start_program = true;
            movie1.Update_seat("1", "3");
            movie1.Update_seat("1", "5");
            movie1.Update_seat("1", "9");
            movie1.Update_seat("5", "7");
            while(start_program == true){
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Welcome to the Cinema!");
                Console.WriteLine("These are the movies we have on display:");
                // Create an instance of WorkItem by using the constructor in the
                // base class that takes three arguments.

                Console.WriteLine(movie1.ToString());
                Console.WriteLine(movie2.ToString());

                Console.WriteLine("Please choose the movie you wanna watch:");
                string movie_to_watch = Console.ReadLine();



                Console.WriteLine(" ");
                Console.WriteLine(" ");
                if (movie_to_watch == "1"){
                    movie1.show_seat_map();
                }
                else if (movie_to_watch == "2"){
                    movie2.show_seat_map();
                }
                else if (movie_to_watch == "stop"){
                    start_program = false;
                }
                


                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("What seats do you want: ");
                Console.WriteLine("Row:");
                string row_choosen = Console.ReadLine();
                Console.WriteLine("Seats: (ex. 1 2 3 4) Max: 5");
                string seats_choosen = Console.ReadLine();
                if (movie_to_watch == "1"){
                movie1.Update_seat(row_choosen, seats_choosen);
                }
                else if (movie_to_watch == "2"){
                    movie2.Update_seat(row_choosen, seats_choosen);
                }
                else if (movie_to_watch == "stop"){
                    start_program = false;
                }
            }
        }

    }
}