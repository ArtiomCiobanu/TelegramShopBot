﻿using ShopBot.API_V2.Commands.Steps;
using ShopBot.API_V2.Commands.Steps.Catalogue;
using ShopBot.API_V2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace ShopBot.API_V2.Commands
{
    public class CatalogueCommand : MultiStepCommand
    {
        public override string Name => "catalogue";

        public override IStep GetInitialStep(BotUpdate update, IBotClient client) => new InitialCatalogueStep(update.ChatId, client);

        public CatalogueCommand(List<IStep> stepPool) : base(stepPool)
        {
        }
    }
}
