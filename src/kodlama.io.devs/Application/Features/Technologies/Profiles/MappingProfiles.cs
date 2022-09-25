using Application.Features.Technologies.Commands.CreateTechnology;
using Application.Features.Technologies.Commands.DeleteTechnology;
using Application.Features.Technologies.Commands.UpdateTechnology;
using Application.Features.Technologies.Dtos;
using Application.Features.Tecnologies.Dtos;
using Application.Features.Tecnologies.Models;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Tecnologies.Profiles
{
    internal class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            CreateMap<Technology, TechnologyListDto>().ForMember(c => c.LanguageName, opt => opt.MapFrom(c => c.Language.Name)).ReverseMap();
            CreateMap<IPaginate<Technology>, TechnologyListModel>().ReverseMap();
            CreateMap<Technology, CreatedTechnologyDto>().ReverseMap();
            CreateMap<Technology, CreateTechnologyCommand>().ReverseMap();
            CreateMap<Technology, DeletedTechnologyDto>().ReverseMap();
            CreateMap<Technology, DeleteTechnologyCommand>().ReverseMap();
            CreateMap<Technology, UpdatedTechnologyDto>().ReverseMap();
            CreateMap<Technology, UpdateTechnologyCommand>().ReverseMap();
        }
    }
}
