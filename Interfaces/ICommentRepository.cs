using API_1.Models;

namespace API_1.Repository;

public interface ICommentRepository{

  Task<List<Comment>> GetAllAsync();
}
