using JeopardyGame.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeopardyGame.Core.Services.PackService
{
    public interface IPackService
    {
        Task CreateAsync(PackDTO pack);
        Task UpdateAsync(PackDTO pack);
        Task RemoveAsync(int id);
        Task<PackDTO> GetAsync(int id);
        Task<List<PackDTO>> ListAsync();
    }
}
