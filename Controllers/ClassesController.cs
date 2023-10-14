using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PFSAPI.ViewModels;
using PFSAPI.Models;
using PFSAPI.ViewModels;
using System.Security.Claims;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PFSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassesController : ControllerBase
    {
        private readonly PFSDBContext _context;

        public ClassesController(PFSDBContext context)
        {
            _context = context;
        }
        // GET: api/<ClassesController>
        [HttpGet]
        public async Task<List<ClassVM>> Get()
        {
            return await _context.Class.Include(s => s.Session)
                .Select(x => new ClassVM
                {
                    ClassId = x.ClassId,
                    ClassName = x.ClassName,
                    SessionId = x.SessionId,
                    Description = x.Description,
                    SessionName = x.Session.SessionName
                })
                .ToListAsync();
        }

        // GET api/<ClassesController>/5
        [HttpGet("{id}")]
        public async Task<ClassVM> Get(int id)
        {
            return await _context.Class.Include(s => s.Session)
                .Select(x => new ClassVM
                {
                    ClassId = x.ClassId,
                    ClassName = x.ClassName,
                    SessionId = x.SessionId,
                    Description = x.Description,
                    SessionName = x.Session.SessionName
                }).Where(x => x.ClassId == id).FirstOrDefaultAsync();
        }

        // POST api/<ClassesController>
        [HttpPost]
        public async Task<String> Post(ClassVM classVM)
        {
            if (ModelState.IsValid)
            {
                var classModel = new Class();
                classModel.ClassName = classVM.ClassName;
                classModel.SessionId = classVM.SessionId;
                classModel.Description = classVM.Description;

                _context.Add(classModel);
                await _context.SaveChangesAsync();
                return "Success";
            }
            else
            {
                return "Model is Invalid";
            }

        }

        // PUT api/<ClassesController>/5
        [HttpPut("{id}")]
        public async Task<String> Put(ClassVM classVM)
        {
            if (ModelState.IsValid)
            {
                var classModel = _context.Class.Find(classVM.ClassId);
                if (classModel != null)
                {
                    classModel.ClassName = classVM.ClassName;
                    classModel.SessionId = classVM.SessionId;
                    classModel.Description = classVM.Description;

                    _context.Update(classModel);
                    await _context.SaveChangesAsync();
                    return "Success";
                }
                else {
                    return "\"Model is Invalid";
                }
            }
            else
            {
                return "Model is Invalid";
            }
        }

        // DELETE api/<ClassesController>/5
        [HttpDelete("{id}")]
        public async Task<String> Delete(int id)
        {
            var classModel = _context.Class.Find(id);
            if (classModel != null)
            {
                _context.Remove(classModel);
                await _context.SaveChangesAsync();
                return "Success" ;
            }
            else {
                return "Model is Invalid";
            }
        }
    }
}
