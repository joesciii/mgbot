using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using Discord.Commands;

namespace mgbot
{
    class Program
    {
        static void Main(string[] args)
        
         => new Program().StartAsync().GetAwaiter();
        
        
        // bot named _client
        private DiscordSocketClient _client;



        public async Task StartAsync()
        {

            _client = new DiscordSocketClient();

            await _client.LoginAsync(TokenType.Bot, "discord bot token");

            await _client.StartAsync();

            new CommandModule(_client);

            // hook onto ready event
            _client.Ready += Ready;


            async Task Ready()
            {

                //run command module?
                //do stuff in here
              
            }

            await Task.Delay(-1);
        }

        async Task GiveRole(IGuildUser user, string rolename)
        {

        }


    }
}

