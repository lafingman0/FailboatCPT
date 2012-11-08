using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FailboatCPT
{
    class Hull { }
    class Crew { }
    class Equipment { }
    class MissionHistory { }
    class ShipCharacteristics { }

    //this is a ship that a player has designed, is either equipped or exists in the harbor
    class PlayerShip
    {
        private string name;
        private Player shipBuilder;
        private int reputation;

        //this includes all allowable (and unallowable) ship upgrades, as well as titles earned
        private ShipCharacteristics shipCharacter;

        //visual design of ship and crew data
        private Hull hullLayout;
        private Crew crew;

        //lists of utilities and upgrade paths therein, as well as a list of things equipped, obviously limited
        //by the previous shipCharacter
        private List<Utilities> utilities;
        private List<Equipment> equipment;

        //this includes a history of all missions completed with this ship, including scores and who the mission was completed with
        private MissionHistory history;

        //design data:
        private PropolsionUtilities propulsionType;
        private int crewRequired;

    }
}
