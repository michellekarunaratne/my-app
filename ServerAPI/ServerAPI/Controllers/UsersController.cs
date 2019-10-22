using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServerAPI.Core.Domain;
using ServerAPI.Infrastucture;
using ServerAPI.Core;
using ServerAPI.Core.Interfaces;
using ServerAPI.Persistence.Repositories;

namespace ServerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {

    private IUnitOfWork _unitOfWork;
        public UsersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

    // GET: api/Users/getAllUsers
    [Route("getAllUsers"), HttpGet]
    public ActionResult<IEnumerable<User>> Get()
    {
      IEnumerable<User> users = _unitOfWork.Users.GetAll();
      return Ok(users);
    }

    //POST: api/Users/addUser
    [Route("addUser"), HttpPost]
    public void InsertUser(User user)
    {
      _unitOfWork.Users.AddUser(user);
      _unitOfWork.Save();

    }

    //GET: api/Users/findUser/{nic}
    [Route("findUser/{nic}"),HttpGet]
    public ActionResult<User> FindUser(string nic)
    {
      //System.Diagnostics.Debug.WriteLine(nic);
      //System.Diagnostics.Debug.WriteLine("Hi");
      User user=_unitOfWork.Users.FindUser(nic);
      return Ok(user);
    }

    [Route("updateUser"),HttpPut]

    public void UpdateUser(User user)
    {
      System.Diagnostics.Debug.WriteLine("Im here");
      _unitOfWork.Users.UpdateUser(user);
      _unitOfWork.Save();

    }

        // GET: api/Users/5
        //[HttpGet("{id}")]
        //public IEnumerable<User> GetUser(String id)
        //{
        //    var user = _unitOfWork.Users.Find(x=>x.nic.Equals(id));

        //    return user;
        //}

        // PUT: api/Users/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutUser(int id, User user)
        //{
        //    if (id != user.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(user).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!UserExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/Users
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        //[HttpPost]
        //public async Task<ActionResult<User>> PostUser(User user)
        //{
        //    _context.Users.Add(user);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetUser", new { id = user.Id }, user);
        //    //return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);

        //}

        // DELETE: api/Users/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<User>> DeleteUser(int id)
        //{
        //    var user = await _context.Users.FindAsync(id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Users.Remove(user);
        //    await _context.SaveChangesAsync();

        //    return user;
        //}

        //private bool UserExists(int id)
        //{
        //    return _context.Users.Any(e => e.Id == id);
        //}
    }
}
