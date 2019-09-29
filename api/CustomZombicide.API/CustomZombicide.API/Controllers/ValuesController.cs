using CustomZombicide.API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CustomZombicide.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private ZombicideContext _db = new ZombicideContext();

        [HttpGet]
        public ActionResult<IEnumerable<Board>> Get()
        {
            var boards = _db.Board.ToList();
            if (boards.Count == 0)
            {
                return NotFound();
            }
            else
            {
                return boards;
            }
        }

        [HttpGet]
        public ActionResult<Board> GetBoardTileByBoardId(int id)
        {
            var board = _db.Board.FirstOrDefault(b => b.BoardId == id);
            if (board == null)
            {
                return NotFound();
            }
            else
            {
                return board;
            }
            //also return tiles?
            //return a BoardTile instead?
        }
    }
}
