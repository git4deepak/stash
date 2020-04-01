using System;
using System.Diagnostics;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Test LRU");
        Test1();            
        Test2();
        Test3();
    }

    static void Test1()
    {
        var lruObj = new LRUCache(2);
        lruObj.Put(1, 1);
        lruObj.Put(2, 2);
        Debug.Assert(lruObj.Get(1) == 1);
        lruObj.Put(3,3);
        Debug.Assert(lruObj.Get(2) == -1);
        lruObj.Put(4,4);
        Debug.Assert(lruObj.Get(1) == -1);
        Debug.Assert(lruObj.Get(3) == 3);
        Debug.Assert(lruObj.Get(4) == 4);
    }
    static void Test2()
    {
        /*
        ["LRUCache","put","get","put","get","get"]
        [[1],[2,1],[2],[3,2],[2],[3]]
        */
        var lruObj = new LRUCache(1);
        lruObj.Put(1, 1);
        Debug.Assert(lruObj.Get(1) == 1);
        lruObj.Put(2, 2);
        Debug.Assert(lruObj.Get(1) == -1);
        Debug.Assert(lruObj.Get(2) == 2);
    }

    static void Test3()
    {
        /*
        ["LRUCache","put","put","get","put","put","get"]
        [[2],[2,1],[2,2],[2],[1,1],[4,1],[2]]
        */
        var lruObj = new LRUCache(2);
        lruObj.Put(2, 1);
        lruObj.Put(2, 2);
        Debug.Assert(lruObj.Get(2) == 2);
        lruObj.Put(1, 1);
        lruObj.Put(4, 1);
        Debug.Assert(lruObj.Get(2) == -1);
    }
}
