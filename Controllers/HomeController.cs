using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Musa, Kc Rose", ID = "21-1605", StudentAge = "20" },
            new StudentInfoModel { Name = "Musa, Bianca Mae", ID = "21-1606", StudentAge = "19" },
            new StudentInfoModel { Name = "Musa, Jaybe", ID = "21-1607", StudentAge = "17" },
            new StudentInfoModel { Name = "Musa, Myra Aliman", ID = "21-1608", StudentAge = "49" },
            new StudentInfoModel { Name = "Musa, Nasser Tanangao", ID = "21-1609", StudentAge = "50" }
            
        };

        return View(studentInfoArray);
    }
}
