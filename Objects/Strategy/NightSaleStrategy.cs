namespace Objects.Strategy
{
	public class NightSaleStrategy : ISaleStrategy
	{
		public int GetPrice(int price)
		{
			return price-15;
		}
	}
}
