﻿using Mediator.Request;

namespace Mediator
{
    internal class CalendarMediator : IMediator
    {
        private CoffeePot _coffeePot;
        private Sprinkler _sprinkler;

        public CalendarMediator(CoffeePot coffeePot, Sprinkler sprinkler)
        {
            _coffeePot = coffeePot ?? throw new ArgumentNullException(nameof(coffeePot));
            _sprinkler = sprinkler ?? throw new ArgumentNullException(nameof(sprinkler));
        }

        public void Execute(IRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            if (request is CalendarRequest calendarRequest)
            {
                _coffeePot.Check(calendarRequest);
                _sprinkler.Check(calendarRequest);
            }
        }
    }
}