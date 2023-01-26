using AutoMapper;
using JeopardyGame.Core.Common.Exceptions;
using JeopardyGame.Core.Common.Interfaces;
using JeopardyGame.Core.Models;
using JeopardyGame.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeopardyGame.Core.Services.ThemeService
{
    public class ThemeService: IThemeService
    {
        private readonly IAppDbContext context;
        public IThemeService themeService;
        private readonly IMapper mapper;

        public ThemeService(IAppDbContext context, IThemeService themeService, IMapper mapper)
        {
            this.context = context;
            this.themeService = themeService;
            this.mapper = mapper;
        }

        public async Task<int> Create(ThemeDto theme)
        {
            Theme t = mapper.Map<Theme>(theme);

            context.Themes.Add(t);

            await context.SaveChangesAsync(CancellationToken.None);

            return t.Id;
        }

        public async Task Update(ThemeDto theme)
        {
            Theme t = await context.Themes.FirstOrDefaultAsync(x => x.Id == theme.Id);
            if (t == null)
            {
                throw new NotFoundExeption("Тема не найдена");
            }
            t = mapper.Map<Theme>(theme);

            context.SaveChangesAsync(CancellationToken.None);
        }

        public async Task Remove(int id)
        {
            Theme t = await context.Themes.FirstOrDefaultAsync(x => x.Id == id);
            if (t == null)
            {
                throw new NotFoundExeption("Тема не найдена");
            }
            context.Themes.Remove(t);

            context.SaveChangesAsync(CancellationToken.None);
        }

        public async Task<ThemeDto> Get(int id)
        {
            Theme t = await context.Themes.FirstOrDefaultAsync(x => x.Id == id);
            if (t == null)
            {
                throw new NotFoundExeption("Тема не найдена");
            }
            return mapper.Map<ThemeDto>(t);
        }
    }
}
