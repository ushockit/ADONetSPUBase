using AutoMapper;
using Library.BLL.DTO.Database;
using Library.BLL.Exceptions;
using Library.BLL.Helpers.Validation;
using Library.BLL.ModelAutoMapper;
using Library.DAL.Entities;
using Library.DAL.Interfaces;
using Library.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BLL.Services.Database
{
    public class GenresService
    {
        IUnitOfWork uow = new UnitOfWork();
        IMapper mapper = ModelMapper.Instance.Mapper;

        public GenreDTO FindGenreById(int id)
        {
            var srchGenre = uow.GenreRepository.Get(id);
            // TODO: Genre to GenreDTO
            //var dto = new GenreDTO
            //{
            //    Id = srchGenre.Id,
            //    Name = srchGenre.Name
            //};
            return mapper.Map<GenreDTO>(srchGenre);
        }

        public List<GenreDTO> GetAllGenres()
        {
            List<Genre> genres = uow.GenreRepository.GetAll();
            return mapper.Map<List<GenreDTO>>(genres);
        }

        public void CreateGenre(GenreDTO genre)
        {
            // TODO: Validation
            var validationResult = ModelValidationHelper.Validate(genre);

            if (!validationResult.Valid)
            {
                throw new ModelValidationException(String.Join(",", validationResult.Errors));
            }

            uow.GenreRepository.Create(mapper.Map<Genre>(genre));
        }
    }
}
