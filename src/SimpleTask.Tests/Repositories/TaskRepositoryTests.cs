using SimpleTask.Domain.Entities;
using SimpleTask.Infrastructure.Repositories;
using Xunit;
using MyTask = SimpleTask.Domain.Entities.Task;


namespace SimpleTask.Domain.Tests.Repositories
{
    public class TaskRepositoryTests
    {
        private readonly TaskRepository _taskRepository;

        [Fact]
        public async void AddAsync_Should_Add_Task()
        {
            //Arange
            var task = new MyTask(Guid.NewGuid(), "Task", "Description");

            //Act
            await _taskRepository.AddAsync(task);
            var result = await _taskRepository.GetByIdAsync(task.Id);

            //Assert
            Assert.Equal(task, result);
        }
    }
}