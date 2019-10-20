using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BlazorState;
using MediatR;
using TourOfHeroes.Data;
using TourOfHeroes.Web.Shared;

namespace TourOfHeroes.Web.Pages.Heroes.Feature
{
    public partial class HeroesState
    {
        public class HandleRetrieveMany : BaseHandler<HeroesState.RetrieveManyAction>
        {
            public HandleRetrieveMany(IStore store) : base(store) { }

            public override Task<Unit> Handle(HeroesState.RetrieveManyAction aAction, CancellationToken aCancellationToken)
            {
                // TODO: Make service call.
                var heroes = new List<Hero>
                {
                    new Hero{ Id = 11, Name = "Dr Nice" },
                    new Hero{ Id = 12, Name = "Narco" },
                    new Hero{ Id = 13, Name = "Bombasto" },
                    new Hero{ Id = 14, Name = "Celeritas" },
                    new Hero{ Id = 15, Name = "Magneta" },
                    new Hero{ Id = 16, Name = "RubberMan" },
                    new Hero{ Id = 17, Name = "Dynama" },
                    new Hero{ Id = 18, Name = "Dr IQ" },
                    new Hero{ Id = 19, Name = "Magma" },
                    new Hero{ Id = 20, Name = "Tornado" },
                };

                _heroesState.Heroes.AddRange(heroes);

                return Unit.Task;
            }
        }
    }
}