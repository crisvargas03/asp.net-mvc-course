using Portafolio.Models;

namespace Portafolio.Services
{
    public interface IProjectsRepository
    {
        List<ProjectViewModel> GetProjets();
    }
    public class ProjectsRepository : IProjectsRepository
    {
        public List<ProjectViewModel> GetProjets()
        {
            return new List<ProjectViewModel>() { new ProjectViewModel {
                Title = "Amazon",
                Description = "E-commerce builded with ASP.NET Core",
                Link = "http://amazon.com",
                ImageURL = "/img/amazon.png"
            },
            new ProjectViewModel {
                Title = "New York Times",
                Description = "Digital News Paper with React",
                Link = "http://nytimes.com",
                ImageURL = "/img/nyt.png"
            },
            new ProjectViewModel {
                Title = "Reddit",
                Description = "Social media for comunities shares",
                Link = "http://reddit.com",
                ImageURL = "/img/reddit.png"
            },
            new ProjectViewModel {
                Title = "Steam",
                Description = "Video games Stores",
                Link = "http://store.streampowered.com",
                ImageURL = "/img/steam.png"
            },
            };
        }
    }
}
