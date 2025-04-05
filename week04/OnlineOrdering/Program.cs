using System;

class Program
{
	static void Main(string[] args)
	{
		List<Order> orders = CreateOrders();
		DisplayOrderInformation(orders);
	}

	private static void DisplayOrderInformation(List<Order> orders)
	{
		foreach (Order orderItem in orders)
		{
			Console.WriteLine("Package Label");
			orderItem.GetPackagingLabel();
			Console.WriteLine("\nCost and Price Imformation");
			Console.WriteLine($"Total Cost: {orderItem.CalculateTotalCost()}");
			Console.WriteLine($"Total Price: {orderItem.CalculateTotalPrice()}");
			Console.WriteLine("\nShipping Information");
			orderItem.GetShippingLabel();
			Console.WriteLine("\n");
		}
	}

	private static List<Order> CreateOrders()
	{
		Address add1 = new Address("123 Main St", "Phoenix", "AZ", "United States");
		Address add2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

		Customer c1 = new Customer("John Doe", add1);
		Customer c2 = new Customer("Jane Smith", add2);

		Order order1 = new Order(c1);
		order1.AddProduct(new Product("Laptop", "LPT123", 999.99, 1));
		order1.AddProduct(new Product("Wireless Mouse", "MSE456", 29.99, 2));

		Order order2 = new Order(c2);
		order2.AddProduct(new Product("Smartphone", "SMP789", 799.49, 1));
		order2.AddProduct(new Product("Headphones", "HPD321", 199.99, 1));

		List<Order> orders = new List<Order>();
		orders.Add(order1);
		orders.Add(order2);
		return orders;
	}
}