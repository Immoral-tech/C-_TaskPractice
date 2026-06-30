namespace C__TaskPractice.Tasks.Task9
{
    public class CloudStorage : IStorage
    {
        private Dictionary<int, string> _data = new Dictionary<int, string>();
        private int _nextId = 1;
        private string _bucketName;

        public CloudStorage(string bucketName)
        {
            _bucketName = bucketName;
            Console.WriteLine($"Облако создано: {_bucketName}");
        }

        public void Save(string data)
        {
            _data[_nextId] = data;
            Console.WriteLine($"Данные сохранены в облаке ID: {_nextId}");
            _nextId++;
        }

        public string Load(int id)
        {
            if (_data.ContainsKey(id))
            {
                Console.WriteLine($"Загрузка из облака ID: {id}");
                return _data[id];
            }
            return "Данные не найдены";
        }

        public void Delete(int id)
        {
            if (_data.ContainsKey(id))
            {
                _data.Remove(id);
                Console.WriteLine($"Удалено из облака ID: {id}");
            }
        }
    }
}
