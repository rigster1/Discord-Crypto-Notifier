using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BinanceApi;
using Data;
using Database;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using Newtonsoft.Json;

namespace DiscordBot.Commands
{
    public class TestCommand : BaseCommandModule
    {
        [Command("test")]
        public async Task Test(CommandContext ctx)
        {
            var test = new User()
            {
                UserId = 100,
                ChannelId = 100,
                Alerts = new List<Alert>()
                {
                    new Alert()
                    {
                        Price = 50,
                        Condition = Condition.Above,
                        CreatedAt = DateTime.Now
                    }
                }
            };

            UserService.Insert(test);

            var users = UserService.Find();
            var usersStr = JsonConvert.SerializeObject(users, Formatting.Indented);
            
            await ctx.Channel.SendMessageAsync(usersStr).ConfigureAwait(false);
        }
    }
}