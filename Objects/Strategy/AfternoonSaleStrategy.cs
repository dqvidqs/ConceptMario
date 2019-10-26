namespace Objects.Strategy
{
	public class AfternoonSaleStrategy : ISaleStrategy
	{
		public int GetPrice(int price)
		{
			return price+15;
		}
	}
}
