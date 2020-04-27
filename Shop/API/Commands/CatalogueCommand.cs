﻿using Shop.API.Commands.Steps;
using Shop.API.Commands.Steps.CatalogueSteps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Shop.API.Commands
{
    public class CatalogueCommand : MultiStepCommand
    {
        public override string Name => "catalogue";

        public override IStep GetInitialStep(Message chatId) => new InitialCatalogueStep();
    }
}
