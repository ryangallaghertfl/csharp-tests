namespace ToDo.Tests
{
  public class ToDoTests
  {

    [Test]
    public void Setup_Test() {
      Assert.Pass();
    }

    [Test]
    public void getTasks_initialised_with_empty_array()
    {
        ToDo todo = new ToDo();
        string[] actual = todo.getTasks();
        string[] expected;
        Assert.AreEqual(actual, expected);

    }

    [Test]

    public void addTask_adds_to_list_of_tasks()
    {
        ToDo todo = new ToDo();
        todo.addTask("correct people who are wrong on the internet");
        todo.addTask("post regretable hot-take online which you need to delete later");
        string[] actual = todo.getTasks();
        string[] expected = {"correct people who are wrong on the internet", "post regretable hot-take online which you need to delete later"};
    }
  }
}