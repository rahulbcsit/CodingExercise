using System;
using System.Collections.Generic;
using Proximo;
using Xunit;

public class SortDateTest
{
    [Fact] 
    public void ListInputReturnCustomSortResult()
    {
        var input = new List<string> { "aa", "abc", "aabc" };
        var ret = SortList.CustomSort(input);
        Assert.Equal("aa", ret[0]);
        Assert.Equal("abc", ret[ret.Count - 1]);
    }

   
}
