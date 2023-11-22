namespace FsToDoApi.Models
{
  public class ToDo
  {
    public int ToDoId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool Completed { get; set; }
  }
}