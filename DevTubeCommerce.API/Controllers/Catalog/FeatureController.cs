using DevTubeCommerce.Application.Contract.Dto.Catalog;
using DevTubeCommerce.Application.Contract.Interfaces.Catalog;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevTubeCommerce.API.Controllers.Catalog
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureService featureService;

        public FeatureController(IFeatureService featureService)
        {
            this.featureService = featureService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(FeatureDto model)
        {
            await featureService.Add(model);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await featureService.GetById(id);
            return Ok(result);
        }
    }
}
