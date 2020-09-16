using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Bookingapi.Controllers
{
    [Route("events")]
    [ApiController]
    public class PostEventController : ControllerBase
    {
        IEventFactory _eventFactory;
        IInvitationFactory _invitationFactory;

        public PostEventController(IEventFactory eventFactory, IInvitationFactory invitationFactory)
        {
            _eventFactory = eventFactory;
            _invitationFactory = invitationFactory;
        }
        [HttpGet]
        public string Get(Guid id)
        {
            return "tjolahoppsansa";
        }

        [HttpPost]
        public ActionResult Post(EventDTO eventDto)
        {
            if (eventDto != null)
            {
                DTOConverter dTOConverter = new DTOConverter(_eventFactory, _invitationFactory);
                IEvent @event = dTOConverter.DTOToEvent(eventDto);
                return StatusCode(200);
            }
            else
            {
                return StatusCode(500);
            }
        }
    }
}
