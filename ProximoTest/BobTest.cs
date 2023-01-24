using System;
using System.Collections.Generic;
using Proximo;
using Xunit;

public class DateTimeOffsetTest
{
    [Theory]
    [InlineData("010120222", 5)] 
    public void InvalidTestDataResultArgumentExceptiion(string date, int days)
    {  
        var total = new BobRental();

        Assert.Throws<ArgumentOutOfRangeException>(() => total.TotalPrice(date, days));
  
    }

    [Theory]

    [InlineData("01/01/2022", 5, "$245")]
    public void ValisTimeOffsetResultDiscountAmount(string date, int days, string expected)
    {

        var total = new BobRental().TotalPrice(date, days);

        Assert.Equal(expected, total);
    }
    
}
