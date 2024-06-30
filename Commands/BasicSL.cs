using DSharpPlus.Entities;
using DSharpPlus.SlashCommands;

namespace DiscordBotTutorialExampleProject.Commands.Slash
{
    public class BasicSL : ApplicationCommandModule
    {
        [SlashCommand("test", "This is my first slash command")]
        public async Task MyFirstSlashCommand(InteractionContext ctx)
        {
            await ctx.DeferAsync();

            var embedMessage = new DiscordEmbedBuilder
            {
                Color = DiscordColor.Blue,
                Title = "Test Embed"
            };

            await ctx.EditResponseAsync(new DiscordWebhookBuilder().AddEmbed(embedMessage));
        }
    }
}
