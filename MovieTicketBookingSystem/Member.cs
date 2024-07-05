namespace MovieTicketBookingSystem;

public class Member
{
    public int MemberId { get; set; }
    public string Name { get; set; }

    public Member(int memberId, string name)
    {
        MemberId = memberId;
        Name = name;
    }
}
