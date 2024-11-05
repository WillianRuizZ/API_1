using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_1.Repository;
using Microsoft.AspNetCore.Mvc;

namespace API_1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CommentController : ControllerBase
{
 private readonly ICommentRepository _commentRepo;
    public CommentController(ICommentRepository commentRepo)
    {
        _commentRepo = commentRepo;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var comments = await _commentRepo.GetAllAsync();
        return Ok(comments);
    }
}

