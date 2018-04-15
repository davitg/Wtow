using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wtow.Domain;
using Wtow.Grabber.Domain;

namespace Wtow.Grabber.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<OmdbTitle, Title>()
                 .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Title))
                 .ForMember(dest => dest.Year, opt => opt.MapFrom(src => int.Parse(src.Year)))
                 .ForMember(dest => dest.Released, opt => opt.MapFrom(src => src.Released.ToDateTime()))
                 .ForMember(dest => dest.Metascore, opt => opt.MapFrom(src => src.Metascore.ToFloat()))
                 .ForMember(dest => dest.ImdbRating, opt => opt.MapFrom(src => src.imdbRating.ToFloat()))
                 .ForMember(dest => dest.ImdbVotes, opt => opt.MapFrom(src => src.imdbVotes))
                 .ForMember(dest => dest.ImdbId, opt => opt.MapFrom(src => src.imdbID))
                 .ForMember(dest => dest.TitleType, opt => opt.MapFrom(src => src.Type.ToTitleType()))
                 .ForMember(dest => dest.DVD, opt => opt.MapFrom(src => src.DVD.ToDateTime()));

            CreateMap<Domain.Rating, Wtow.Domain.Rating>()
                .ForMember(dest => dest.RatingId, opt => opt.MapFrom(src => 0));
        }
    }
}
