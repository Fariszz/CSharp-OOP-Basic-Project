namespace MovieTicketBookingSystem;

public class MovieTicketBookingSystem
{
    private Dictionary<int, Movie> movies = new Dictionary<int, Movie>();
    private Dictionary<int, Showtime> showtimes = new Dictionary<int, Showtime>();
    private Dictionary<int, Member> members = new Dictionary<int, Member>();
    private Dictionary<int, Booking> bookings = new Dictionary<int, Booking>();
    private int nextBookingId = 1;

    public void AddMovie(Movie movie)
    {
        movies[movie.MovieId] = movie;
    }

    public void ScheduleShowtime(Showtime showtime)
    {
        showtimes[showtime.ShowtimeId] = showtime;
    }

    public void RegisterMember(Member member)
    {
        members[member.MemberId] = member;
    }

    public bool BookTicket(int showtimeId, int memberId, int seatNumber)
    {
        if (showtimes.ContainsKey(showtimeId) && members.ContainsKey(memberId))
        {
            Showtime showtime = showtimes[showtimeId];
            if (showtime.BookSeat(seatNumber))
            {
                bookings[nextBookingId] = new Booking(nextBookingId, members[memberId], showtime, seatNumber);
                nextBookingId++;
                return true;
            }
        }
        return false;
    }

    public List<Booking> GetBookingsByMember(int memberId)
    {
        List<Booking> memberBookings = new List<Booking>();
        foreach (var booking in bookings.Values)
        {
            if (booking.Member.MemberId == memberId)
            {
                memberBookings.Add(booking);
            }
        }
        return memberBookings;
    }

    public List<Movie> GetMovies()
    {
        return movies.Values.ToList();
    }
}
