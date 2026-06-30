namespace C__TaskPractice.Tasks.Task9
{    public interface IStorage
    {
        void Save(string data);
        string Load(int id);
        void Delete(int id);
    }
}
