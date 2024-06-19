using JediApi.Models;
using JediApi.Repositories;
using JediApi.Services;
using Moq;

namespace JediApi.Tests.Services
{
    public class JediServiceTests
    {
        // não mexer
        private readonly JediService _service;
        private readonly Mock<IJediRepository> _repositoryMock;

        public JediServiceTests()
        {
            // não mexer
            _repositoryMock = new Mock<IJediRepository>();
            _service = new JediService(_repositoryMock.Object);
        }

        [Fact]
        public async Task GetById_Success()
        {
            // Arrange
            int jediId = 1;
            var expectedJedi = new Jedi { Id = jediId, Name = "Obi-Wan Kenobi" };
            _mockJediRepository.Setup(repo => repo.GetByIdAsync(jediId))
                               .ReturnsAsync(expectedJedi);

            // Act
            var result = await _jediService.GetByIdAsync(jediId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedJedi.Id, result.Id);
            Assert.Equal(expectedJedi.Name, result.Name);
        }

        [Fact]
        public async Task GetById_Success()
        {
            
            int jediId = 1;
            var expectedJedi = new Jedi { Id = jediId, Name = "Obi-Wan Kenobi" };
            _mockJediRepository.Setup(repo => repo.GetByIdAsync(jediId))
                               .ReturnsAsync(expectedJedi);

            
            var result = await _jediService.GetByIdAsync(jediId);

            
            Assert.NotNull(result);
            Assert.Equal(expectedJedi.Id, result.Id);
            Assert.Equal(expectedJedi.Name, result.Name);
        }

        [Fact]
        public async Task GetById_NotFound()
        {
           
            int jediId = 999; 
            _mockJediRepository.Setup(repo => repo.GetByIdAsync(jediId))
                               .ReturnsAsync(() => null);

           
            var result = await _jediService.GetByIdAsync(jediId);

            
            Assert.Null(result);
        }

        [Fact]
        public async Task GetAll()
        {
            
            var expectedJedis = new List<Jedi>
        {
            new Jedi { Id = 1, Name = "Luke Skywalker" },
            new Jedi { Id = 2, Name = "Yoda" },
            new Jedi { Id = 3, Name = "Mace Windu" }
        };
            _mockJediRepository.Setup(repo => repo.GetAllAsync())
                               .ReturnsAsync(expectedJedis);

            
            var results = await _jediService.GetAllAsync();

            
            Asser
        }
    } 
}
