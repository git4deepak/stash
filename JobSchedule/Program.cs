using System.Collections.Generic;
using System.Linq;

int JobScheduling(int[] startTime, int[] endTime, int[] profit) {
    int items = startTime.Length;
    int [] dp = new int[items];
    var maxStartTime = startTime.ToList().Aggregate(0, (a, x) => (x > a) ? x : a);
    var jobsStartAt = new Dictionary<int, List<Tuple<int, int>>>();
    for(int i=0; i<items; ++i)
    {
        var st = startTime[i];
        if(jobsStartAt[st] == null) jobsStartAt[st] = new List<Tuple<int, int>>();
        jobsStartAt[st].Add(Tuple.Create(endTime[i], profit[i]));
    }
    
    foreach (var st in jobsStartAt.Keys)
    {
        
    }
}

int[] startTime = {1,2,3,3};
int[] endTime = {3,4,5,6};
int[] profit = {50,10,40,70};

Console.WriteLine("Profit: {0}", JobScheduling(startTime, endTime, profit));
