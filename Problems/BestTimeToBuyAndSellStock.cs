namespace Problems;

public class BestTimeToBuyAndSellStock
{

    public int MaxProfit(int[] prices)
    {
        var maxProfit = 0;
        var lowerPrice = prices[0];

        foreach (var price in prices)
        {
            if(lowerPrice > price)
                lowerPrice = price;

            if(maxProfit < price - lowerPrice)
                maxProfit = price - lowerPrice;
        }
        
        return maxProfit;
    }

}
