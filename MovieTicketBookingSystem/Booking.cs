namespace MovieTicketBookingSystem;

public class Booking
{
    public int BookingId {get; set;}
    public Member Member {get; set;}
    public Showtime Showtime {get; set;}
    public int SeatNumber {get; set;}

    public Booking(int bookingId, Member member, Showtime showtime, int seatNumber)
    {
        BookingId = bookingId;
        Member = member;
        Showtime = showtime;
        SeatNumber = seatNumber;
    }    
}
