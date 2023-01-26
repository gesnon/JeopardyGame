using AutoMapper;
using JeopardyGame.Core.Models;
using JeopardyGame.Domain.Entities;

namespace JeopardyGame.Core.Common.Mapper
{
    public class MapperConfiguration: Profile
    {
        public MapperConfiguration()
        {
            this.CreateMap<Question, QuestionDto>()
            .ForMember(_ => _.Text, opt => opt.MapFrom(i => i.Text))
            .ForMember(_ => _.Id, opt => opt.MapFrom(i => i.Id))
            .ForMember(_ => _.Price, opt => opt.MapFrom(i => i.Price))
            .ForMember(_ => _.QuestionType, opt => opt.MapFrom(i => i.QuestionType))
            .ForMember(_ => _.DataContent, opt => opt.MapFrom(i => i.DataContent));

            this.CreateMap<QuestionDto, Question>()
            .ForMember(_ => _.Text, opt => opt.MapFrom(i => i.Text))
            .ForMember(_ => _.Id, opt => opt.MapFrom(i => i.Id))
            .ForMember(_ => _.Price, opt => opt.MapFrom(i => i.Price))
            .ForMember(_ => _.QuestionType, opt => opt.MapFrom(i => i.QuestionType))
            .ForMember(_ => _.DataContent, opt => opt.MapFrom(i => i.DataContent));

            this.CreateMap<Theme, ThemeDto>()
            .ForMember(_ => _.Title, opt => opt.MapFrom(i => i.Title))
            .ForMember(_ => _.Id, opt => opt.MapFrom(i => i.Id))
            .ForMember(_ => _.Questions, opt => opt.MapFrom(i => i.Questions));

            this.CreateMap<ThemeDto, Theme>()
            .ForMember(_ => _.Title, opt => opt.MapFrom(i => i.Title))
            .ForMember(_ => _.Id, opt => opt.MapFrom(i => i.Id))
            .ForMember(_ => _.Questions, opt => opt.MapFrom(i => i.Questions));

            this.CreateMap<Round, RoundDto>()
            .ForMember(_ => _.Order, opt => opt.MapFrom(i => i.Order))
            .ForMember(_ => _.Id, opt => opt.MapFrom(i => i.Id))
            .ForMember(_ => _.Themes, opt => opt.MapFrom(i => i.Themes));

            this.CreateMap<RoundDto, Round>()
            .ForMember(_ => _.Order, opt => opt.MapFrom(i => i.Order))
            .ForMember(_ => _.Id, opt => opt.MapFrom(i => i.Id))
            .ForMember(_ => _.Themes, opt => opt.MapFrom(i => i.Themes));

            this.CreateMap<Pack, PackDto>()
            .ForMember(_ => _.Title, opt => opt.MapFrom(i => i.Title))
            .ForMember(_ => _.Id, opt => opt.MapFrom(i => i.Id))
            .ForMember(_ => _.Author, opt => opt.MapFrom(i => i.Author))
            .ForMember(_ => _.Rounds, opt => opt.MapFrom(i => i.Rounds));

            this.CreateMap<PackDto, Pack>()
            .ForMember(_ => _.Title, opt => opt.MapFrom(i => i.Title))
            .ForMember(_ => _.Id, opt => opt.MapFrom(i => i.Id))
            .ForMember(_ => _.Author, opt => opt.MapFrom(i => i.Author))
            .ForMember(_ => _.Rounds, opt => opt.MapFrom(i => i.Rounds));
        }
    }
}
