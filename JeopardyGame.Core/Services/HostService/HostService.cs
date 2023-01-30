using AutoMapper;
using JeopardyGame.Core.Common.Interfaces;
using JeopardyGame.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeopardyGame.Core.Services.HostService
{
    public class HostService: IHostService
    {
        private readonly IAppDbContext context;
        public IHostService hostService;
        private readonly IMapper mapper;

        public HostService(IAppDbContext context, IHostService hostService, IMapper mapper)
        {
            this.context = context;
            this.hostService = hostService;
            this.mapper = mapper;
        }

        
        public async Task EnrollPoints(int questionId, int playerId, bool answerCheck)
        {
            Player player = context.Players.FirstOrDefault(_ => _.Id == playerId);

            Question question = context.Questions.FirstOrDefault(_ => _.Id == questionId);

            if (answerCheck)
            {
                player.Score += question.Price;             
                                
            }

            else 
            {
                player.Score -= question.Price;
            }            

            await context.SaveChangesAsync(CancellationToken.None);

            return;
        }
    }
}
