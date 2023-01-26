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

namespace JeopardyGame.Core.Services.PackService
{
    public class PackService: IPackService
    {
        private readonly IAppDbContext context;
        public IPackService packService;
        private readonly IMapper mapper;

        public PackService(IAppDbContext context, IPackService packService, IMapper mapper)
        {
            this.context = context;
            this.packService = packService;
            this.mapper = mapper;
        }

        public async Task<int> CreateAsync(PackDto pack)
        {
            Pack p = mapper.Map<Pack>(pack);

            context.Packs.Add(p);

            await context.SaveChangesAsync(CancellationToken.None);

            return p.Id;
        }

        public async Task UpdateAsync(PackDto pack)
        {
            Pack p = await context.Packs.FirstOrDefaultAsync(x => x.Id == pack.Id);
            if (p == null)
            {
                throw new NotFoundExeption("Пак не найден");
            }
            p = mapper.Map<Pack>(pack);

            context.SaveChangesAsync(CancellationToken.None);
        }

        public async Task RemoveAsync(int id)
        {
            Pack p = await context.Packs.FirstOrDefaultAsync(x => x.Id == id);
            if (p == null)
            {
                throw new NotFoundExeption("Пак не найден");
            }
            context.Packs.Remove(p);
            context.SaveChangesAsync(CancellationToken.None);
        }

        public async Task<PackDto> GetAsync(int id)
        {
            Pack p = await context.Packs.FirstOrDefaultAsync(x => x.Id == id);
            if (p == null)
            {
                throw new NotFoundExeption("Пак не найден");
            }
            context.Packs.Remove(p);
            return mapper.Map<PackDto>(p);
        }

        public async Task<List<PackDto>> ListAsync()
        {
            List<Pack> packs = context.Packs.ToList();

            List<PackDto> result = packs.Select(_ =>  mapper.Map<PackDto>(_)).ToList();

            return result;
        }
    }
}
