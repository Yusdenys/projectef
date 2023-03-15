using Microsoft.EntityFrameworkCore;
using projectef.Models;
using Task = projectef.Models.Task;

namespace projectef
{
    public class TaskContext: DbContext
    {       
        public DbSet<Category> Categories { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public TaskContext(DbContextOptions<TaskContext> options) : base(options) { } 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Category> categoryInit = new List<Category>();
            categoryInit.Add(new Category() { CategoryId = Guid.Parse("d93a7c12-af4b-433a-ab44-8a94e2135bca"), Name = "Actividades pendientes", Weight = 20 });
            categoryInit.Add(new Category() { CategoryId = Guid.Parse("d4946f70-bfa7-41ea-b33b-8447b9d1f8dc"), Name = "Actividades personales", Weight = 50 });
            categoryInit.Add(new Category() { CategoryId = Guid.Parse("d4946f70-bfa7-41ea-b33b-8447b9d1f8de"), Name = "Actividades de terceros", Weight = 5 });


            modelBuilder.Entity<Category>(category =>
            {
                category.ToTable("Category");
                category.HasKey(p => p.CategoryId);
                category.Property(p => p.Name).IsRequired().HasMaxLength(150);
                category.Property(p => p.Description);
                category.Property(p => p.Weight);

                category.HasData(categoryInit);
            });

            List<Task> tasksInit = new List<Task>();
            tasksInit.Add(new Task() { TaskId = Guid.Parse("6d996402-9beb-4490-b50f-5a170c21c6b3"), CategoryId = Guid.Parse("d93a7c12-af4b-433a-ab44-8a94e2135bca"), PriorityTask = Priority.Medium, Title = "Pago servicios publicos", CreateDate = DateTime.Now, Owner = "Yusdenys Perez" });
            tasksInit.Add(new Task() { TaskId = Guid.Parse("d1555e02-9d28-4d87-834a-c2d9c9a2c2c4"), CategoryId = Guid.Parse("d4946f70-bfa7-41ea-b33b-8447b9d1f8dc"), PriorityTask = Priority.High, Title = "Pago servicios privados", CreateDate = DateTime.Now, Owner = "Yusdenys Perez" });
            tasksInit.Add(new Task() { TaskId = Guid.Parse("d1555e02-9d28-4d87-834a-c2d9c9a2c2c5"), CategoryId = Guid.Parse("d4946f70-bfa7-41ea-b33b-8447b9d1f8de"), PriorityTask = Priority.Low, Title = "Llamar telefono", CreateDate = DateTime.Now, Owner = "Yusdenys Perez" });

            modelBuilder.Entity<Task>(task =>
            {
                task.ToTable("Task");
                task.HasKey(p => p.TaskId);
                task.HasOne(p => p.Category).WithMany(p => p.Tasks).HasForeignKey(p => p.CategoryId);
                task.Property(p => p.Title).IsRequired().HasMaxLength(200);
                task.Property(p => p.Description);
                task.Property(p => p.PriorityTask);
                task.Property(p => p.CreateDate);
                task.Ignore(p => p.Resume);
                task.Property(p => p.Owner).IsRequired();

                task.HasData(tasksInit);
            });
        }
    }
}
