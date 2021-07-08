using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using odin.Models;
using odin.Data;
using Serilog;

namespace odin.Controllers
{
    /*
    [ApiController]
    [Route("[controller]")]
    public class ActivityCardsController : ControllerBase
    {
        private readonly IActivityCardRepository _activityCardRepository;
        public ActivityCardsController(IActivityCardRepository activityCardRepository)
        {
            _activityCardRepository = activityCardRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ActivityCard>>> GetActivityCards()
        {
            var activityCards = await _activityCardRepository.GetAll();
            return Ok(activityCards);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ActivityCard>> GetActivityCard(int id)
        {
            var activityCard = await _activityCardRepository.Get(id);
            if (activityCard == null)
                return NotFound();

            return Ok(activityCard);
        }

        [HttpPost]
        public async Task<ActionResult> CreateActivityCard(CreateActivityCardDto createActivityCardDto)
        {
            ActivityCard activityCard = new()
            {
                Name = createActivityCardDto.Name,
                Price = createActivityCardDto.Price,
                DateCreated = DateTime.Now
            };

            await _activityCardRepository.Add(activityCard);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteActivityCard(int id)
        {
            await _activityCardRepository.Delete(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateActivityCard(int id, UpdateActivityCardDto updateActivityCardDto)
        {
            ActivityCard activityCard = new()
            {
                ActivityCardId = id,
                Name = updateActivityCardDto.Name,
                Price = updateActivityCardDto.Price
            };

            await _activityCardRepository.Update(activityCard);
            return Ok();
        }
    */

    [ApiController]
    [Route("[controller]")]
    public class ActivityCardController : ControllerBase
    {
        private static readonly string[] Categories = new[]
        {
            "Food", "Drinks", "Movies - In", "Movies - Out", "TV", "Hiking", "Outdoors", "Camping", "BBQ", "Scorching"
        };

        private readonly IDataContext _context;
        public ActivityCardController(IDataContext context)
        {
            _context = context;
            Log.Information("ActivityCard constructor has been called.");
        }

        [HttpGet]
        public IEnumerable<ActivityCard> Get()
        {
            Log.Debug("ActivityCard Get() called.");
            var rng = new Random();
            var arr = Enumerable.Range(1, 5).Select(index => new ActivityCard
            {
                Category = Categories[rng.Next(Categories.Length)],
                Description = "See Category",
                Duration = 60,
                Location = "PLZCEW"
            })
            .ToArray();
            this._context.ActivityCards.Add(arr[0]);
            this._context.SaveChanges();
            return arr;
        }
    }
    
}
