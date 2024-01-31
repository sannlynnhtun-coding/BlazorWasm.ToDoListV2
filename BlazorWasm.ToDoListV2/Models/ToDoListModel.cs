namespace BlazorWasm.ToDoListV2.Models
{
    public class ToDoListModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("N");
        public bool IsCompleted { get; set; }
        public string TaskName { get; set; }
    }
}
