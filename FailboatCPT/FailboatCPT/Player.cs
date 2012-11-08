using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FailboatCPT
{

    class PlayerInfo 
    {
        private List<string> friends;
        public string playerName;
        private string privacyLevel;
        private MissionHistory missionHistory;
        private string shippingGuild;
    }

    class Player
    {
        private PlayerShip equippedShip;
        private PlayerInfo info;

    }
}
