using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using kanban.Extensions;
using kanban.Resources;
using Microsoft.AspNetCore.Mvc;

namespace kanban.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class KanbanBoardController : ControllerBase
    {
        ApiDbContext _ctx;
        private IKanbanBoardService _kanbanBoardService;
        private readonly IMapper _mapper;

        public KanbanBoardController(IKanbanBoardService kanbanBoardService, IMapper mapper)
        {
            _kanbanBoardService = kanbanBoardService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<kanbanBoardResource>> Get()
        {
            var kanbanBoards = await _kanbanBoardService.ListAsync();
            var resources = _mapper.Map<IEnumerable<kanbanBoard>, IEnumerable<kanbanBoardResource>>(kanbanBoards);
            return resources;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveKanbanBoardResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());
            
            var category = _mapper.Map<SaveKanbanBoardResource, kanbanBoard>(resource);
            var result = await _kanbanBoardService.SaveAsync(category);
            
            if (!result.Success)
                return BadRequest(result.Message);

            var categoryResource = _mapper.Map<kanbanBoard, kanbanBoardResource>(result.kanbanBoard);
            return Ok(categoryResource);
        }
    }
}