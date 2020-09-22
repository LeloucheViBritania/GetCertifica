using ApiMe.DTOs;
using ApiMe.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiMe.App_Start
{
    public class MappingProfil : Profile
    {
        public MappingProfil()
        {
            Mapper.CreateMap<Tag, TagDTO>();
            Mapper.CreateMap<TagDTO, Tag>();   
            Mapper.CreateMap<CommentsDTO, Comment>();
            Mapper.CreateMap<Comment, CommentsDTO>();



            Mapper.CreateMap<Post, PostDTOs>()
                    .ForMember(dto => dto.TagDTO, opt => opt.MapFrom(x => x.Tag))
                    .ForMember(dto => dto.CommentsDTOs, opt => opt.MapFrom(x => x.Comments));
        }

    }
}