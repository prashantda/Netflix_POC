using AutoFixture;
using AutoMapper;
using Bfl.Netflix.Core.Configurations;
using Bfl.Netflix.Core.Domain.Entities;
using Bfl.Netflix.Core.Domain.RepositoryContracts;
using Bfl.Netflix.Core.ServiceContracts;
using Bfl.Netflix.Core.Services;
using Bfl.Netflix_Service1.Core.DTO.Movies;
using FluentAssertions;
using Moq;

namespace Bfl.Netflix_Movies.Core.Tests
{
    public class MoviesServiceTests
    {
        private readonly Fixture _fixture;
        private readonly IMoviesService _moviesService;

        private readonly Mock<IMoviesRepository> _moviesRepositoryMock;
        private readonly IMoviesRepository _moviesRepository;

        private readonly Mock<IMovieCastsRepository> _moviesCastRepositoryMock;
        private readonly IMovieCastsRepository _moviesCastRepository;

        private readonly Mock<IMovieCategoriesRepository> _moviesCategoriesRepositoryMock;
        private readonly IMovieCategoriesRepository _moviesCategoriesRepository;

        private readonly Mock<ICategoriesRepository> _categoriesRepositoryMock;
        private readonly ICategoriesRepository _categoriesRepository;

        private readonly Mock<ICastsRepository> _castsRepositoryMock;
        private readonly ICastsRepository _castsRepository;

        private readonly Mock<IMapper> _mapperMock;
        private readonly IMapper _mapper;

        public MoviesServiceTests()
        {
            _fixture = new Fixture();

            _moviesRepositoryMock= new Mock<IMoviesRepository>();
            _moviesRepository=_moviesRepositoryMock.Object;

            var mapperConfig = new MapperConfiguration(c => c.AddProfile<AutoMapperConfiguration>());
            _mapper = mapperConfig.CreateMapper();

            _moviesCastRepositoryMock = new Mock<IMovieCastsRepository>();
            _moviesCastRepository=_moviesCastRepositoryMock.Object;

            _moviesCategoriesRepositoryMock=new Mock<IMovieCategoriesRepository>();
            _moviesCategoriesRepository = _moviesCategoriesRepositoryMock.Object;

            _categoriesRepositoryMock=new Mock<ICategoriesRepository>();
            _categoriesRepository= _categoriesRepositoryMock.Object;

            _castsRepositoryMock=new Mock<ICastsRepository>();
            _castsRepository= _castsRepositoryMock.Object;

           
            _moviesService = new MoviesService(_moviesRepository, _mapper, _moviesCastRepository,
                _moviesCategoriesRepository, _categoriesRepository, _castsRepository);

        }
        [Fact]
        public async void AddMovie_ValidObject_ToBeSuccessfull_()
        {
            //Arrange
            MoviesAddRequest mar=_fixture.Build<MoviesAddRequest>().
                With(t=>t.Casts,new Guid[] {Guid.Parse("5DA44770-40CE-450B-B3DF-0255DDB9A299"),Guid.Parse("8CF650C8-77FC-45BC-ACB4-0A306923A5E9") } ).
                 With(t => t.Categories, new Guid[] { Guid.Parse("2A6D3738-9DEF-43AC-9279-0310EDC7CECA"), Guid.Parse("56BF46A4-02B8-4693-A0F5-0A95E2218BDC") }).
                Create();
            _moviesRepositoryMock.Setup(t => t.AddAsync(It.IsAny<Movie>())).ReturnsAsync((Movie movie) =>
            {
                return movie;
            });


            //Act
          var result=await  _moviesService.AddMovie(mar);
            //Assertions

            result.Should().NotBeNull();
            result.Should().BeOfType<MoviesResponse>();


        }
    }
}