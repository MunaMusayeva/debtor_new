namespace ConsoleApp14;

public class Debtor
{
    public Debtor(string fullname, DateTime birthday, string phone, string email, string adress, int debt)
    {
        this.Fullname = fullname;
        this.Birthday = birthday;
        this.Phone = phone;
        this.Email = email;
        this.Adress = adress;
        this.Debt = debt;
    }

    public string Fullname { get; set; }
    public DateTime Birthday { get; set; }

    public string Phone { get; set; }
    public string Email { get; set; }
    public string Adress { get; set; }
    public int Debt { get; set; }
    public override string ToString()
    {
        return $"{this.Fullname} {this.Birthday.ToShortDateString()} {this.Phone} {this.Email} {this.Adress} {this.Debt}";
    }
}
