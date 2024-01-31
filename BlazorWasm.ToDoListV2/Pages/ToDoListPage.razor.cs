using BlazorWasm.ToDoListV2.Models;

namespace BlazorWasm.ToDoListV2.Pages
{
    public partial class ToDoListPage
    {
        private static List<ToDoListModel> data = new List<ToDoListModel>();
        private ToDoListModel reqModel { get; set; } = new ToDoListModel();

        private void Add()
        {
            data.Add(reqModel);
            reqModel = new ToDoListModel();
        }

        private void Cancel()
        {
            reqModel = new ToDoListModel();
        }

        private void ToggleTask(ToDoListModel item)
        {
            int index = data.FindIndex(x => x.Id == item.Id);
            data[index].IsCompleted = !data[index].IsCompleted;
            Console.WriteLine(data[index].IsCompleted);
        }

        private void Delete(string id)
        {
            data = data.Where(x => x.Id != id).ToList();
        }
    }
}
