using Project5_DapperNorthWind.Dtos;
using Project5_DapperNorthWind.Dtos.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5_DapperNorthWind.Repositories.CategoryRepositories
{
    internal class CategoryRepository : ICategoryRepositories
    {
        public Task CreateCategoryAsync(CreateCategoryDto createCategoryDto)
        {
            throw new NotImplementedException();
        }

        public Task<GetByIdCategoryDto> CreateCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResultCategoryDtos> GetAllCategoryAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto)
        {
            throw new NotImplementedException();
        }
    }
}
