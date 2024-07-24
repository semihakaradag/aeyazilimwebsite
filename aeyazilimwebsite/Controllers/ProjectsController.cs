using aeyazilimwebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace aeyazilimwebsite.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly List<Project> projects = new List<Project>
        {
            new Project { Id = 1, Title = "Antrenör Değerleme Yazılımı", Description = "Gençlik Hizmetleri ve Spor İl Müdürlükleri ve İl Temsilcilikleri için yapılmış olan Antrenör ve Sporcu Değerlendirme Yazılımıdır.", Image = "eantrenor.webp", Partner = "-", ProjectDate = new DateTime(2015, 1, 1), ProjectUrl = "http://konya.eantrenor.org" },
            new Project { Id = 2, Title = "WorkNProject", Description = "İş takip uygulaması", Image = "worknproject.webp", Partner = "Tozoğlu Mühendislik", ProjectDate = new DateTime(2019, 8, 6), ProjectUrl = "http://www.worknproject.com" },
            new Project { Id = 3, Title = "İcra Yönetim Programı", Description = "DİJİTAL İCRA YÖNETİMİ (İcra Programı) İcra Yönetim programı pratiğe yönelik olduğu için diğer icra programlarında olduğu gibi takip türlerinden değil direk föy kartını doldurarak işlem yaparsınız.", Image = "icrayonetim.webp", Partner = "-", ProjectDate = new DateTime(2006, 2, 6), ProjectUrl = "https://www.icrayonetim.com/" },
            new Project { Id = 4, Title = "İl Spor Okulları Yazılımı", Description = "Gençlik Hizmetleri İl Spor Merkezi Birimlerinin sporcuları kayıt altına aldığı, ders programlarını düzenlediği ve dönem içinde bakanlıklara vereceği raporları alabileceği online tabanlı bir yazılımdır.", Image = "ilspor.webp", Partner = "-", ProjectDate = new DateTime(2018, 1, 1), ProjectUrl = "http://www.ilspor.com" },
            new Project { Id = 5, Title = "Kasa Yönetim Programı", Description = "Avukatlar için kasa yönetimi", Image = "kasa.webp", Partner = "-", ProjectDate = new DateTime(2010, 1, 1), ProjectUrl = "http://www.kasayonetim.com" },
            new Project { Id = 6, Title = "Marka Yönetimi", Description = "Markalarınızı yönetmek için kullanmanız gereken bir uygulama", Image = "markayonetimi.webp", Partner = "Renk Patent", ProjectDate = new DateTime(2018, 1, 1), ProjectUrl = "#" },
            new Project { Id = 7, Title = "Tarım Envanter Yönetim Sistemi", Description = "Gıda Tarım Üniversitesi tarafından kullanılan tarım envanter yönetim sistemi", Image = "teys.webp", Partner = "Gıda Tarım Üniversitesi", ProjectDate = new DateTime(2019, 1, 1), ProjectUrl = "-" }
        };


        public IActionResult Details(int id)
        {
            var project = projects.FirstOrDefault(p => p.Id == id);
            if (project == null) 
            {
                return NotFound();
            }
            return View(project);
        }
        public IActionResult Projects()
        {

            if (projects == null || !projects.Any())
            {
                return View(new List<Project>());
            }

            return View(projects);
        }
    }
}
