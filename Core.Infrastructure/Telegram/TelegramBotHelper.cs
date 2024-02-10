using Core.Application.ViewModels.BotTelegram;
using Core.Infrastructure.Telegram.Models;
using Core.Utilities.Constants;
using System.Collections.Generic;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Core.Infrastructure.Telegram

{
    public class TelegramBotHelper
    {

        public static List<TelegramBotQueueModel> Bots => new()
        {
            new TelegramBotQueueModel
            {
                BotClient = new TelegramBotClient(BotToken3),
            },
            new TelegramBotQueueModel
            {
                BotClient = new TelegramBotClient(BotToken4),
            },

            new TelegramBotQueueModel
            {
                BotClient = new TelegramBotClient(BotToken5),
            },
            new TelegramBotQueueModel
            {
                BotClient = new TelegramBotClient(BotToken6),
            },
            new TelegramBotQueueModel
            {
                BotClient = new TelegramBotClient(BotToken7),
            },
        };

    }
}
