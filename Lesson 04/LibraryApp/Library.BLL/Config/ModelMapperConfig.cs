using AutoMapper;
using Library.BLL.DTO.Database;
using Library.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BLL.Config
{
    public class ModelMapperConfig
    {
        private static ModelMapperConfig instance;
        public static ModelMapperConfig Instance => instance ?? (new ModelMapperConfig());
        public MapperConfiguration Config
        {
            get
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Genre, GenreDTO>();
                    cfg.CreateMap<GenreDTO, Genre>();
                });
                return config;
            }
        }
        private ModelMapperConfig() { }
    }
}
