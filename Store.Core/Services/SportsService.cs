using Store.Core.Base;
using Store.Core.Entities.Sports;
using Store.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Core.Services
{
    public class SportsService : BaseService
    {
        private IEntityContextRepository<IEntityContext> _repository;

        public SportsService(IEnumerable<IEntityContextRepository<IEntityContext>> entityContextRepositories)
            : base(entityContextRepositories)
        {
            _repository = entityContextRepositories.Single(s => s.Name == ContextNames.Catelog);
        }

        public Sport CreateSport(Sport sport)
        {
            _repository.Insert<Sport>(sport);
            _repository.SaveChanges();
            return sport;
        }
        public SportType CreateSportType(SportType type)
        {
            _repository.Insert<SportType>(type);
            _repository.SaveChanges();
            return type;
        }
        public Club CreateClub(Club club)
        {
            _repository.Insert<Club>(club);
            _repository.SaveChanges();
            return club;
        }

        public ClubType CreateClubType(ClubType type)
        {
            _repository.Insert<ClubType>(type);
            _repository.SaveChanges();
            return type;
        }

        public Image CreateImage(Image image)
        {
            _repository.Insert<Image>(image);
            _repository.SaveChanges();
            return image;
        }

        public League CreateLeague(League league)
        {
            _repository.Insert<League>(league);
            _repository.SaveChanges();
            return league;
        }
        public Player CreatePlayer(Player player)
        {
            _repository.Insert<Player>(player);
            _repository.SaveChanges();
            return player;
        }

        public PlayerProfile CreatePlayerProfile(PlayerProfile playerProfile)
        {
            _repository.Insert<PlayerProfile>(playerProfile);
            _repository.SaveChanges();
            return playerProfile;
        }
        public Team CreateTeam(Team team)
        {
            _repository.Insert<Team>(team);
            _repository.SaveChanges();
            return team;
        }

        public TeamLeague CreateTeamLeague(TeamLeague teamLeague)
        {
            _repository.Insert<TeamLeague>(teamLeague);
            _repository.SaveChanges();
            return teamLeague;
        }
        public TeamPlayer CreateTeamPlayer(TeamPlayer teamPlayer)
        {
            _repository.Insert<TeamPlayer>(teamPlayer);
            _repository.SaveChanges();
            return teamPlayer;
        }
    }
}
