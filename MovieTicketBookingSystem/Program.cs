namespace MovieTicketBookingSystem;

public class Program
{
    public static void Main()
    {
        MovieTicketBookingSystem bookingSystem = new MovieTicketBookingSystem();

        // menambahkan film
        Movie movie1 = new Movie { MovieId = 1, Title = "The Shawshank Redemption", Duration = 142 };
        Movie movie2 = new Movie { MovieId = 2, Title = "The Godfather", Duration = 175 };

        bookingSystem.AddMovie(movie1);
        bookingSystem.AddMovie(movie2);

        // menambahkan showtime
        DateTime showTime1Start = new DateTime(2021, 10, 1, 10, 0, 0);
        DateTime showTime2Start = new DateTime(2021, 10, 1, 13, 0, 0);
        Showtime showtime1 = new Showtime(1, movie1, showTime1Start, 100);
        Showtime showtime2 = new Showtime(2, movie2, showTime2Start, 100);
        bookingSystem.ScheduleShowtime(showtime1);
        bookingSystem.ScheduleShowtime(showtime2);

        // menambahkan member
        Member member1 = new Member(1, "John Doe");
        Member member2 = new Member(2, "Jane Doe");
        bookingSystem.RegisterMember(member1);
        bookingSystem.RegisterMember(member2);

        // membuat booking
        bool bookingSuccess1 = bookingSystem.BookTicket(1, 1, 10);
        bool bookingSuccess2 = bookingSystem.BookTicket(2, 2, 21);
        bool bookingSuccess3 = bookingSystem.BookTicket(2, 1, 20);


        // Menampilkan hasil booking
        if (bookingSuccess1)
        {
            Console.WriteLine("Booking berhasil untuk John Doe di seat 10 untuk film Inception.");
        }
        else
        {
            Console.WriteLine("Booking gagal untuk John Doe.");
        }

        if (bookingSuccess2)
        {
            Console.WriteLine("Booking berhasil untuk Jane Smith di seat 20 untuk film The Matrix.");
        }
        else
        {
            Console.WriteLine("Booking gagal untuk Jane Smith.");
        }

        if (bookingSuccess3)
        {
            Console.WriteLine("Booking berhasil untuk John Doe di seat 20 untuk film The Matrix.");
        }
        else
        {
            Console.WriteLine("Booking gagal untuk John Doe.");
        }

        // Menampilkan semua booking yang dilakukan oleh member 1
        List<Booking> johnBookings = bookingSystem.GetBookingsByMember(1);
        Console.WriteLine("\nBookings yang dilakukan oleh John Doe:");

        foreach (var booking in johnBookings)
        {
            Console.WriteLine($"Booking ID: {booking.BookingId}, Film: {booking.Showtime.Movie.Title}, Seat: {booking.SeatNumber}");
        }
    }
}