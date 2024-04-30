[Route("api/[controller]")]
[ApiController]
public class ProdutoController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public ProdutoController(ApplicationDbContext context)
    {
        _context = context;
    }

}