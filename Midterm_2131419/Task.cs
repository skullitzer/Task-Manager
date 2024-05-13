using SQLite;
using System.Drawing;

public class Task
{
    [PrimaryKey, AutoIncrement]
    public int ID { get; set; }
    public string Name { get; set; }
    public string Priority { get; set; }
    public Color PriorityColor { get; internal set; }
}