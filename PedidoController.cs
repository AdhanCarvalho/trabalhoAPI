[Route("api/[controller]")]
[ApiController]
public class PedidoController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public PedidoController(ApplicationDbContext context)
    {
        _context = context;
    }
           
}