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

namespace JeopardyGame.Core.Services.RoundService
{
    public class RoundService: IRoundService
    {
        private readonly IAppDbContext context;
        public IRoundService roundService;
        private readonly IMapper mapper;

        public RoundService(IAppDbContext context, IRoundService roundService, IMapper mapper)
        {
            this.context = context;
            this.roundService = roundService;
            this.mapper = mapper;
        }

        public async Task<int> Create(RoundDto round)
        {
            Round r = mapper.Map<Round>(round);

            context.Rounds.Add(r);

            await context.SaveChangesAsync(CancellationToken.None);

            return r.Id;
        }

        public async Task Update(RoundDto round)
        {
            Round r = await context.Rounds.FirstOrDefaultAsync(x => x.Id == round.Id);
            if (r == null)
            {
                throw new NotFoundExeption("Раунд не найден");
            }
            r = mapper.Map<Round>(round);

            context.SaveChangesAsync(CancellationToken.None);
        }

        public async Task Remove(int id)
        {
            Round r = await context.Rounds.FirstOrDefaultAsync(x => x.Id == id);
            if (r == null)
            {
                throw new NotFoundExeption("Раунд не найден");
            }
            context.Rounds.Remove(r);
            context.SaveChangesAsync(CancellationToken.None);
        }

        public async Task<RoundDto> Get(int id)
        {
            Round r = await context.Rounds.FirstOrDefaultAsync(x => x.Id == id);
            if (r == null)
            {
                throw new NotFoundExeption("Раунд не найден");
            }
            return mapper.Map<RoundDto>(r);
        }
    }
}
