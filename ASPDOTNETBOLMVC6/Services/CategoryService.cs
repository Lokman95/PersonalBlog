using ASPDOTNETBOLMVC6.Data;
using ASPDOTNETBOLMVC6.Models;
using ASPDOTNETBOLMVC6.Repository.Base;
using ASPDOTNETBOLMVC6.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace ASPDOTNETBOLMVC6.Services
{
    public class CategoryService :Repository<Category>, ICategoryService
    {
        public CategoryService(AppDbContext db) : base(db) { }

    }
}
