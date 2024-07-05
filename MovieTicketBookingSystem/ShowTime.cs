namespace MovieTicketBookingSystem;

public class Showtime
{
    public int ShowtimeId { get; set; }
    public Movie Movie { get; set; }
    public DateTime StartTime { get; set; }
    private Dictionary<int, bool> seats;

    public Showtime(int showtimeId, Movie movie, DateTime startTime, int numberOfSeats)
    {
        ShowtimeId = showtimeId;
        Movie = movie;
        StartTime = startTime;
        seats = new Dictionary<int, bool>();
        for (int i = 1; i <= numberOfSeats; i++)
        {
            seats[i] = true; // True indicates the seat is available
        }
    }

    public bool BookSeat(int seatNumber)
    {
        if (seats.ContainsKey(seatNumber) && seats[seatNumber])
        {
            seats[seatNumber] = false; // Mark the seat as booked
            return true;
        }
        return false;
    }

    public int AvailableSeats()
    {
        int count = 0;
        foreach (var seat in seats.Values)
        {
            if (seat) count++;
        }
        return count;
    }
}