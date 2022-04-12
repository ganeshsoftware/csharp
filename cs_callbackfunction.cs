
private readonly object _updateStockPricesLock = new object();
private volatile bool _updatingStockPrices = false;

private void UpdateStockPrices(object state)
{
	lock(_updateStockPricesLock)
	{
		if(!_updatingStockPrices)
		{
			_updatingStockPrices = true;
			
			foreach(var stock in _stocks.Values)
			{
				if TryUpdateStockPrice(stock)
				{
					BroadcastStockPrice(stock);
				}
			}
			_updatingStockPrices = false;
		}
	}
}
