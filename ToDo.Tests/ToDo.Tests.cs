using NUnit.Framework;
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
        ToDoList todo = new ToDoList();
        List<string> actual = todo.getTasks();
        List<string> expected;
        Assert.AreEqual(actual, expected);

    }

    [Test]

    public void addTask_adds_to_list_of_tasks()
    {
        ToDoList todo = new ToDoList();
        todo.addTask("correct people who are wrong on the internet");
        todo.addTask("post regretable hot-take online which you need to delete later");
        string[] actual = todo.getTasks();
        string[] expected = {"correct people who are wrong on the internet", "post regretable hot-take online which you need to delete later"};
    }
  }
}