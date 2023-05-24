namespace UserService.Models;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Sex { get; set; }
    public double Weight { get; set; }
    public double DesiredWeight { get; set; }
    public double Height { get; set; }
    public double WeightLossPerWeek { get; set; }
}