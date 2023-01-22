using JeopardyGame.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeopardyGame.Core.Services.RoundServise
{
    public interface IRoundService
    {
        Task Create(RoundDTO round);
        Task Update(RoundDTO round);
        Task Remove(int id);
        Task<RoundDTO> Get(int id);
    }
}
