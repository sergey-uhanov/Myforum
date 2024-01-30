using Myforum.Model;

namespace Myforum.Services
{
    public class TopicService
    {

        // Создание экземпляра ApplicationDbContext, который предоставляет доступ к базе данных.
        private readonly ApplicationDbContext _context = default!;

        // Конструктор класса TopicService, принимающий в качестве параметра экземпляр ApplicationDbContext.
        public TopicService(ApplicationDbContext context)
        {
            _context = context; // Присваивание переданного экземпляра ApplicationDbContext в поле _context.
        }

        // Метод для получения списка всех пицц из базы данных.
        public IList<Topic> GetTopics()
        {
            // Проверка, что коллекция Topics не является null.
            if (_context.Topics != null)
            {
                // Возвращение списка всех пицц, преобразованного в List.
                return _context.Topics.ToList();
            }
            // В случае, если коллекция Topics равна null, возвращается пустой список.
            return new List<Topic>();
        }
       
    }
}
