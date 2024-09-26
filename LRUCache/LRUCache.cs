namespace Cache;

public class LRUCache(int capacity)
{
    private readonly int capacity = capacity;

    private readonly Dictionary<int, int> data = [];

    private readonly List<int> history = [];

    public int Get(int key)
    {
        bool exists = data.TryGetValue(key, out int value);

        if (!exists)
            return -1;

        RefreshHistory(key);

        return value;
    }

    public void Put(int key, int value)
    {
        if (data.Count >= capacity)
        {
            var lru = history.First();

            Evict(lru);
        }

        data[key] = value;

        RefreshHistory(key);
    }

    private void RefreshHistory(int key)
    {
        if (history.Exists(x => x == key))
            history.RemoveAll(x => x == key);

        history.Add(key);
    }

    private void Evict(int lru)
    {
        data.Remove(lru);
        history.Remove(lru);
    }
}
