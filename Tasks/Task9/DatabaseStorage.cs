namespace C__TaskPractice.Tasks.Task9
{
    public class DatabaseStorage : IStorage
    {
        private Dictionary<int, string> _data = new Dictionary<int, string>();
        private int _nextId = 1;

        public void Save(string data)
        {
            _data[_nextId] = data;
            Console.WriteLine($"Данные сохранены в БД с ID: {_nextId}");
            _nextId++;
        }

        public string Load(int id)
        {
            if (_data.ContainsKey(id))
            {
                Console.WriteLine($"Загрузка из БД ID: {id}");
                return _data[id];
            }
            return "Данные не найдены";
        }

        public void Delete(int id)
        {
            if (_data.ContainsKey(id))
            {
                _data.Remove(id);
                Console.WriteLine($"Удалено из БД ID: {id}");
            }
        }
    }
}
