using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mgbot
{
    class CommandModule
    {
        // maybe unusued

        private DiscordSocketClient _client;

        public CommandModule(DiscordSocketClient client)
        {
            _client = client;
        }
    }
}
