using DesignPatterns.FlyWeight.Implementations;
using DesignPatterns.FlyWeight.Interfaces;

namespace DesignPatterns.FlyWeight
{
    public class Factory
    {
        Dictionary<string, IPlayer> _players = new();

        public int GetNumberOfInstance()
        {
            return _players.Count;
        }

        public IPlayer GetPlayer(string playerType)
        {
            IPlayer player = null;

            if (_players.ContainsKey(playerType))
            {
                player = _players[playerType];
            }
            else
            {
                switch (playerType)
                {
                    case "Terrorist":
                        player = new Terrorist();
                        break;
                    case "CounterTerrorist":
                        player = new CounterTerrorist();
                        break;
                    default:
                        throw new Exception("Factory cannot create the object specified");
                }

                _players.Add(playerType, player);
            }

            return player;
        }
    }
}
