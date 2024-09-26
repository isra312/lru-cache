
# LRUCache

This is an implementation of a Least Recently Used (LRU) Cache in C#. An LRU Cache evicts the least recently used item when it reaches its capacity limit, making it suitable for scenarios where memory usage is constrained. The cache supports `Get` and `Put` operations.

## Methods

### `LRUCache(int capacity)`
Initialize the LRU cache with a positive size capacity.

- **Parameters:**
  - `capacity` (int): The maximum number of items that can be stored in the cache.

### `int Get(int key)`
Retrieve the value associated with the given key if it exists in the cache. Otherwise, it returns `-1`.

- **Parameters:**
  - `key` (int): The key to look up in the cache.
- **Returns:**
  - `int`: The value associated with the key, or `-1` if the key is not found in the cache.

### `void Put(int key, int value)`
Add or update the value of the given key in the cache. If the key already exists, its value will be updated, and it will be marked as recently used. If adding the key-value pair causes the number of keys to exceed the cache capacity, the least recently used key will be evicted.

- **Parameters:**
  - `key` (int): The key to add or update in the cache.
  - `value` (int): The value associated with the key.

## Example Usage

```csharp
LRUCache cache = new LRUCache(2);
cache.Put(1, 1); // cache is {1=1}
cache.Put(2, 2); // cache is {1=1, 2=2}
cache.Get(1);    // return 1
cache.Put(3, 3); // LRU key was 2, evicts key 2, cache is {1=1, 3=3}
cache.Get(2);    // returns -1 (not found)
cache.Put(4, 4); // LRU key was 1, evicts key 1, cache is {4=4, 3=3}
cache.Get(1);    // return -1 (not found)
cache.Get(3);    // return 3
cache.Get(4);    // return 4
```
