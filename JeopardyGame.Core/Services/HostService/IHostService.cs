using JeopardyGame.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeopardyGame.Core.Services.HostService
{
    public interface IHostService
    {        
        Task EnrollPoints(int questionId, int playerId, bool answerCheck);
    }
}
