using AutoMapper;
using AutoMapperApp.API.DTOs;
using AutoMapperApp.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperApp.API.Controllers
{
    public class ProjectionController : Controller
    {
        private readonly IMapper _mapper;

        public ProjectionController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(EventDateDto eventDateDto)
        {
            var eventDate = _mapper.Map<EventDate>(eventDateDto);

            ViewBag.date = eventDate.Date.ToShortDateString();
            return View();
        }
    }
}