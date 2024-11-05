
using API_1.Data;
using API_1.Models;
using Microsoft.EntityFrameworkCore;

namespace API_1.Repository;

public class CommentRepository:ICommentRepository
{
    private readonly ApplicationDBContext _context;

    public CommentRepository( ApplicationDBContext context)
    {
        _context = context;
    }

    public async Task<List<Comment>> GetAllAsync()
    {
        return await _context.Comments.ToListAsync();
    }
}

