using AutoMapper;
using JeopardyGame.Domain.DTO;
using JeopardyGame.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeopardyGame.Core.Common.Mapper
{
    public class MapperConfiguration: Profile
    {
        public MapperConfiguration()
        {
            this.CreateMap<Question, QuestionDTO>()
            .ForMember(_ => _.Text, opt => opt.MapFrom(i => i.Text))
            .ForMember(_ => _.Id, opt => opt.MapFrom(i => i.Id))
            .ForMember(_ => _.Price, opt => opt.MapFrom(i => i.Price))
            .ForMember(_ => _.QuestionType, opt => opt.MapFrom(i => i.QuestionType))
            .ForMember(_ => _.DataContent, opt => opt.MapFrom(i => i.DataContent));

            this.CreateMap<Theme, ThemeDTO>()
            .ForMember(_ => _.Title, opt => opt.MapFrom(i => i.Title))
            .ForMember(_ => _.Id, opt => opt.MapFrom(i => i.Id))
            .ForMember(_ => _.Questions, opt => opt.MapFrom(i => i.Questions));

            this.CreateMap<Round, RoundDTO>()
            .ForMember(_ => _.Order, opt => opt.MapFrom(i => i.Order))
            .ForMember(_ => _.Id, opt => opt.MapFrom(i => i.Id))
            .ForMember(_ => _.Themes, opt => opt.MapFrom(i => i.Themes));

            this.CreateMap<Pack, PackDTO>()
            .ForMember(_ => _.Title, opt => opt.MapFrom(i => i.Title))
            .ForMember(_ => _.Id, opt => opt.MapFrom(i => i.Id))
            .ForMember(_ => _.Author, opt => opt.MapFrom(i => i.Author))
            .ForMember(_ => _.Rounds, opt => opt.MapFrom(i => i.Rounds));
        }
    }
}
