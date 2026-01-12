using Project5_DapperNorthWind.Dtos;
using Project5_DapperNorthWind.Dtos.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5_DapperNorthWind.Repositories.CategoryRepositories
{
    public interface ICategoryRepositories
    {
        Task<ResultCategoryDtos> GetAllCategoryAsync();

        Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);
        Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
        Task DeleteCategoryAsync(int id);
        Task<GetByIdCategoryDto> CreateCategoryAsync(int id);
    }
}
