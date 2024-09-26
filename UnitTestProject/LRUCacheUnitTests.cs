using Cache;

namespace UnitTestProject;

public class LRUCacheUnitTests
{
    [Fact]
    public void Get_One_Should_Return_One()
    {
        var cache = new LRUCache(2);

        cache.Put(1, 1);
        cache.Get(1);

        var result = cache.Get(1);

        Assert.Equal(1, result);
    }

    [Fact]
    public void Get_Two_Over_Full_Cache_Should_Return_Minus_One()
    {
        var cache = new LRUCache(2);

        cache.Put(1, 1);
        cache.Put(2, 2);
        cache.Get(1);
        cache.Put(3, 3);

        var result = cache.Get(2);

        Assert.Equal(-1, result);
    }
    [Fact]
    public void Get_One_Over_Full_Cache_Should_Return_Minus_One()
    {
        var cache = new LRUCache(2);

        cache.Put(1, 1);
        cache.Put(2, 2);
        cache.Get(1);
        cache.Put(3, 3);
        cache.Get(2);
        cache.Put(4, 4);

        var result = cache.Get(1);

        Assert.Equal(-1, result);
    }   
    
    [Fact]
    public void Get_Three_Over_Full_Cache_Should_Return_Three()
    {
        var cache = new LRUCache(2);

        cache.Put(1, 1);
        cache.Put(2, 2);
        cache.Get(1);
        cache.Put(3, 3);
        cache.Get(2);
        cache.Put(4, 4);
        cache.Get(1);
        
        var result = cache.Get(3);

        Assert.Equal(3, result);
    }

    [Fact]
    public void Get_Four_Over_Full_Cache_Should_Return_Four()
    {
        var cache = new LRUCache(2);

        cache.Put(1, 1);
        cache.Put(2, 2);
        cache.Get(1);
        cache.Put(3, 3);
        cache.Get(2);
        cache.Put(4, 4);
        cache.Get(1);
        cache.Get(3);

        var result = cache.Get(4);

        Assert.Equal(4, result);
    }

    [Fact]
    public void Get_Zero_Should_Return_Zero()
    {
        var cache = new LRUCache(2);

        cache.Put(0, 0);

        var result = cache.Get(0);

        Assert.Equal(0, result);
    }


    [Fact]
    public void Get_Zero_Over_Full_Cache_Should_Return_Minus_One()
    {
        var cache = new LRUCache(2);

        cache.Put(1, 1);
        cache.Put(2, 2);
        cache.Get(1);
        cache.Put(0,0);
        cache.Put(3, 3);
        cache.Get(2);
        cache.Put(4, 4);
        cache.Get(1);

        var result = cache.Get(0);

        Assert.Equal(-1, result);
    }
    

    [Fact]
    public void Get_Zero_Over_Full_Cache_Should_Return_Zero()
    {
        var cache = new LRUCache(2);

        cache.Put(1, 1);
        cache.Put(2, 2);
        cache.Get(1);
        cache.Put(3, 3);
        cache.Get(2);
        cache.Put(0,0);
        cache.Put(4, 4);
        cache.Get(1);

        var result = cache.Get(0);

        Assert.Equal(0, result);
    }

}