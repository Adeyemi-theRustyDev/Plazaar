namespace Plazaar.Models;

public class Product
{
    public string Name { get; set; } = string.Empty;
    public string? Category { get; set; }
    public long ID { get; set; }
    public string? Description { get; set; }
    public int Stock { get; set; }
}