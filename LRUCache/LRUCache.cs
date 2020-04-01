using System.Collections.Generic;
public class LRUCache {    
    struct Data {
        public int Key;
        public int Val;
        public Data(int k, int val)
        {
            Key = k;
            Val = val;
        }
    }
    private Dictionary<int, LinkedListNode<Data>> map;
    private LinkedList<Data> dList;
    private readonly int capacity;
    private int size;
    
    public LRUCache(int capacity) {
        this.capacity = capacity;
        size = 0;
        map = new Dictionary<int, LinkedListNode<Data>>();
        dList = new LinkedList<Data>();
    }
    
    public int Get(int key) {
        if(!map.ContainsKey(key))
            return -1;
        var n = map[key];
        dList.Remove(n);
        dList.AddFirst(n);
        return n.Value.Val;
    }
    public void Put(int key, int val) {
        
        if(map.ContainsKey(key))
        {
            var m = map[key];
            m.Value = new Data(key, val);
            dList.Remove(m);
            dList.AddFirst(m);
            return;
        }
        // else
        if(size < capacity)
        {
            ++size;
        }
        else
        {
            // evict tail node
            map.Remove(dList.Last.Value.Key);
            dList.RemoveLast();
        }

        // make new node the new head
        var n = dList.AddFirst(new Data(key, val));        
        map.Add(key, n);        
    }
}