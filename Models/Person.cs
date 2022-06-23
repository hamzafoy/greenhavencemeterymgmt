namespace GreenhavenMgmt.Models;

public class Person
{
    public int id { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public int birthYear { get; set; }
    public int deathYear { get; set; }
    public int plot_id { get; set; }
}

public class plot
{
    public int plot_id { get; set; }
}