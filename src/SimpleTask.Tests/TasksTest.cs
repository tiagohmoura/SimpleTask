namespace SimpleTask.Tests;
using MyTask = SimpleTask.Domain.Entities.Task;
using Xunit;

public class TaskTests
{
    [Fact]
    public void Task_Constructor_Should_Set_Properties()
    {
        //Arrange
        var id = Guid.NewGuid();
        var title = "Test Task";
        var description = "This is a test task";

        // // Act
        var task = new MyTask(id, title, description);

        // // Assert
        Assert.Equal(id, task.Id);
        Assert.Equal(title, task.Title);
        Assert.Equal(description, task.Description);
    }

    [Fact]
    public void Task_Update_Should_Change_Title_And_Description(){
        //Arange
        var task = new MyTask(Guid.NewGuid(), "Old Title", "Old Description");
        var newTitle = "New Title";
        var NewDescription = "New Description";

        //act
        task.Update(newTitle, NewDescription);

        //Assert
        Assert.Equal(newTitle, task.Title);
        Assert.Equal(NewDescription, task.Description);
    }
}
