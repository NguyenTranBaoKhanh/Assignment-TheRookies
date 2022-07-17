using BKShop.Application.Interfaces;
using BKShop.ViewModels.Requests.Review;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BKShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewService _reviewService;
        public ReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAsync()
        {
            var feedbacks = await _reviewService.GetAllAsync();
            if (feedbacks == null)
            {
                return NotFound("Reviews can't be found");
            }
            return Ok(feedbacks);
        }

        [HttpGet("{Id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAsync([FromRoute]int Id)
        {
            var feedbacks = await _reviewService.GetByIdAsync(Id);
            if (feedbacks == null)
            {
                return NotFound("Review can't be found");
            }
            return Ok(feedbacks);
        }


        [HttpGet("product/{Id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetByProductId([FromRoute]int Id)
        {
            var feedbacks = await _reviewService.GetByProductIdAsync(Id);
            if (feedbacks == null)
            {
                return NotFound("Review can't be found");
            }
            return Ok(feedbacks);
        }

        [HttpGet("user/{Id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetByUserId([FromRoute] Guid Id)
        {
            var feedbacks = await _reviewService.GetByUserIdAsync(Id);
            if (feedbacks == null)
            {
                return NotFound("Review can't be found");
            }
            return Ok(feedbacks);
        }

        [HttpPut]
        [AllowAnonymous]
        public async Task<IActionResult> Update([FromBody] ReviewUpdateRequest request)
        {
            var result = await _reviewService.UpdateAsync(request);
            if (result == 0)
            {
                return BadRequest();
            }
            var feedback = await _reviewService.GetByIdAsync(request.Id);
            if (feedback == null)
            {
                return BadRequest();
            }
            return Ok(feedback);
        }

        [HttpGet("AverageStar/{productId}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAverageVote([FromRoute]int productId)
        {
            var avg = await _reviewService.GetAverageStarAsync(productId);
            return Ok(avg);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Create([FromBody] ReviewCreateRequest request)
        {
            var reviewId = await _reviewService.CreateAsync(request);
            if (reviewId == 0)
            {
                return BadRequest();
            }
            var review = await _reviewService.GetByIdAsync(reviewId);
            if (review == null)
            {
                return BadRequest();
            }
            return Ok(review);
        }



    }
}
