namespace ToDo
{
    public class ToDoList
    {
        
        public List<string> todolist = new List<string>();

        public void addTask(string task)
        {
            todolist.Add(task);
        }

        public List<string> getTasks()
        {
            return todolist;
        }

    }
}