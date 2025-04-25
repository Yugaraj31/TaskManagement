using Moq;
using NUnit.Framework;
using TaskManagementAPI;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace TaskTest
{
    public class TaskServiceTests
    {
        private AppDbContext _dbContext;
        private TaskService _taskService;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDb")
                .Options;

            _dbContext = new AppDbContext(options);
            _taskService = new TaskService(_dbContext);
        }

        [TearDown]
        public void TearDown()
        {
            _dbContext.Dispose();
        }

        [Test]
        public async Task CreateTaskAsync_ShouldAddTask()
        {
            var task = new TaskItems { Title = "Test Task", AssignedUserId = 1 };
            var result = await _taskService.CreateTaskAsync(task);

            Assert.NotNull(result);
            Assert.AreEqual("Test Task", result.Title);
        }
    }
}
