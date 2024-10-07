using Microsoft.AspNetCore.Mvc;

namespace ElsoAPI.Controllers
{
    public class NapVicceController : ControllerBase
    {
        [HttpGet]
        [Route("[controller]")]
        public string Get()
        {
            string[] viccek = { "Miért nem játszik a számítógép a fociban? Mert fél a hálótól!", "Miért nem lehet a tengerbe dobni a számítógépet? Mert elárasztja az internetet!", "Miért nem tud a számítógép biciklizni? Mert fél a leállástól!", "Mit mond a számítógép, amikor megfájdul a feje? 'Túl sok a RAM!'", "Miért nem lehet a számítógépet megenni? Mert tele van bitekkel!", "Miért szeretik a számítógépek a zenét? Mert jók a hangkártyájuk!", "Mi választja el az embereket és az álatokat? A mediterrán óceán!" };

            return viccek[(int)DateTime.Now.DayOfWeek - 1];
        }
    }
}
