using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FsToDoApi.Models;

namespace FsToDoApi.Controllers
{
  [Route("[controller]")] 
  [ApiController]
  public class ToDosController : ControllerBase
  {
    private readonly FsToDoApiContext _db;

    public ToDosController(FsToDoApiContext db)
    {
      _db = db;
    }

    // // GET /todos
    // [HttpGet]
    // public async Task<ActionResult<IEnumerable<Message>>> Get()
    // {
    //   return await _db.Messages.ToListAsync();
    // }

    // WITH SEARCH QUERY SUPPORT
    // GET: /ToDos
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ToDo>>> Get(string title)
    {
      IQueryable<ToDo> query = _db.ToDos.AsQueryable();

      if (title != null)
      {
        query = query.Where(entry => entry.Title == title);
      }

      return await query.ToListAsync();
    }

    // GET: /todos/5
    [HttpGet("{id}")]
    public async Task<ActionResult<ToDo>> GetToDo(int id)
    {
      ToDo todo = await _db.ToDos.FindAsync(id);

      if (todo == null)
      {
        return NotFound();
      }

      return todo;
    }



    // POST /todos
    [HttpPost]
    public async Task<ActionResult<ToDo>> Post(ToDo todo)
    {
      _db.ToDos.Add(todo);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetToDo), new { id = todo.ToDoId }, todo);
    }

    // PUT: /todos/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, ToDo todo)
    {
      if (id != todo.ToDoId)
      {
        return BadRequest();
      }

      _db.ToDos.Update(todo);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ToDoExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    // DELETE: /ToDos/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteToDo(int id)
    {
      ToDo todo = await _db.ToDos.FindAsync(id);
      if (todo == null)
      {
        return NotFound();
      }

      _db.ToDos.Remove(todo);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    // method for finding if message exist

     private bool ToDoExists(int id)
    {
      return _db.ToDos.Any(e => e.ToDoId == id);
    }


  }
}


// .NET Automatically Converts C# into JSON 
// It's a Best Practice to Use Async Controller Actions
 
// Never include an Id property when making a POST request, 
// as that value should always be set by our database.

// PUT requires a body with the entire updated object (including the ObjectId)