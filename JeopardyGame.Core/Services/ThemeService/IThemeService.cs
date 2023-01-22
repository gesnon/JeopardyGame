using JeopardyGame.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeopardyGame.Core.Services.ThemeService
{
    public  interface IThemeService
    {
        Task Create(ThemeDTO theme);
        Task Update(ThemeDTO theme);
        Task Remove(int id);
        Task<ThemeDTO> Get(int id);
    }
}
