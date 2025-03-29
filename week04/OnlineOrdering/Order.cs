class Order
{
	private List<Product> _products = new List<Product>();
	private Customer _customer;
	public Order(Customer customer)
	{
		_customer = customer;
	}
	public void AddProduct(Product p)
	{
		_products.Add(p);
	}

	public double CalculateTotalCost()
	{
		double totalCost = 0;
		foreach (Product pItem in _products)
		{
			totalCost += pItem.CalculateTotalCost();
		}
		return totalCost;
	}
	public double CalculateTotalPrice()
	{
		int shippingCost = _customer.IsInUSA()? 5 : 35;
		return CalculateTotalCost() + shippingCost;
	}
	public void GetPackagingLabel()
	{
		foreach (Product pItem in _products)
		{
			Console.WriteLine($"{pItem.GeneratePackingLabel()}");
		}

	}
	public void GetShippingLabel()
	{
		Console.WriteLine($"{_customer.GenerateShippingLabel()}");
	}
}