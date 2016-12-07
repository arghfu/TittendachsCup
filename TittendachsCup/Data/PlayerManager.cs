using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Appointments.AppointmentsProvider;

namespace TittendachsCup.Data
{
    public class PlayerManager
    {
        private List<Player> players;

        public PlayerManager()
        {
            players = new List<Player>();
        }

        public void Add(string name)
        {
            players.Add(new Player(name));
        }

        public void Del(string name)
        {
            throw new NotImplementedException();
        }
    }
}