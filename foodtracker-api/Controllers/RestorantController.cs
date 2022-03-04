using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using foodtracker_db.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace foodtracker_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestorantController : ControllerBase
    {
        //Database Context
        private readonly FoodtrackerDbContext _context;
        //Mapper for Create-Update
        private readonly IMapper _mapper;
        public RestorantController(FoodtrackerDbContext context,IMapper mapper)
        {//DI
            _context = context;
            _mapper= mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
           var restorantList = _context.Restorants.Include(r=>r.Comments).ToList<Restorant>();
           return Ok(restorantList);
        }
        [HttpPost]
        public IActionResult CreateRestorant([FromBody] CreateRestorantModel newRestorant)
        {
            var restorantExists = _context.Restorants.Where(r=>r.Name==newRestorant.Name).FirstOrDefault();
            
            if (restorantExists is null)
            {
                _context.Add(_mapper.Map<Restorant>(newRestorant));
                _context.SaveChanges();
                return Ok(true);
            }
            return Ok(false);
            

        }
        [HttpDelete]
        public IActionResult DeleteRestorant([FromQuery] string restorantName)
        {
            var restorantExists = _context.Restorants.Where(r=>r.Name==restorantName).FirstOrDefault();
            if (restorantExists is null)
            {
                return Ok(false);
            }
            _context.Restorants.Remove(restorantExists);
            _context.SaveChanges();
            return Ok(true);            
        }
        [HttpPut]
        public IActionResult UpdateRestorant([FromQuery]string restorantName,[FromBody] CreateRestorantModel updatedRestorant)
        {
            var restorant = _context.Restorants.Where(r=>r.Name == restorantName).FirstOrDefault();
            if (restorant is null)
            {
                return Ok(false);
            }
            if (_context.Restorants.Where(r=>r.Name==updatedRestorant.Name).FirstOrDefault() is not null && restorantName!=updatedRestorant.Name)
            {
                return Ok(false);
            }
            _mapper.Map(updatedRestorant,restorant);
            _context.SaveChanges();
            return Ok(true);
        }
        [HttpPost]
        [Route("Comment")]
        public IActionResult Comment([FromQuery]string restorantName,[FromBody] CreateCommentModel newComment)
        {
            var restorant = _context.Restorants.Where(r=>r.Name==restorantName).Include(r=>r.Comments).SingleOrDefault();
            var comment = _mapper.Map<Comment>(newComment);            
            comment.RestorantId=restorant.Id;
            restorant.Comments.Add(comment);
            _context.SaveChanges();
            return Ok("Comment Added.");
        }
    }
}
