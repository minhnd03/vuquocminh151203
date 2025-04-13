using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;  // Đảm bảo bạn thêm dòng này để truy cập lớp Movie

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        // Constructor duy nhất
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        // DbSet cho Movie
        public DbSet<Movie> Movies { get; set; }
    }
}
