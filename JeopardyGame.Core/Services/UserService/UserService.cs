using AutoMapper;
using JeopardyGame.Core.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeopardyGame.Core.Services.UserService
{
    public class UserService:IUserService
    {
        private readonly IAppDbContext context;
        public IUserService userService;
        private readonly IMapper mapper;

        public UserService(IAppDbContext context, IUserService userService, IMapper mapper)
        {
            this.context = context;
            this.userService = userService;
            this.mapper = mapper;
        }

        public Task StartDisput()
        {
            throw new NotImplementedException("Начато оспаривание");
        }
    }
}
