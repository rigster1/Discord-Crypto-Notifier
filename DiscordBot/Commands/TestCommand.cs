using System.Threading.Tasks;
using BinanceApi;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;

namespace Discord_Bot222.Commands
{
    public class TestCommand : BaseCommandModule
    {
        [Command("test")]
        public async Task Test(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Hello World").ConfigureAwait(false);
            BinanceData.Subscribe("BTCUSDT");
        }
    }
}