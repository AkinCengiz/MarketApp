namespace MarketApp.WinForm;

public partial class Form1 : Form
{
	public Form1()
	{
		InitializeComponent();
	}

	private List<Product> _products;
	private List<Product> _cart;
	private void Form1_Load(object sender, EventArgs e)
	{
		_products = new List<Product>();
		_products.AddRange(
			new List<Product>()
			{
				new Product(){Id = 1, Category = "Yiyecek", Name = "Hamburger", Price = 155, Stock = 25},
				new Product(){Id = 2, Category = "Yiyecek", Name = "Tost", Price = 125, Stock = 40},
				new Product(){Id = 3, Category = "Yiyecek", Name = "Sandviç", Price = 80, Stock = 30},
				new Product(){Id = 4, Category = "Yiyecek", Name = "Salata", Price = 150, Stock = 20},
				new Product(){Id = 5, Category = "Yiyecek", Name = "Pizza", Price = 170, Stock = 15},
				new Product(){Id = 6, Category = "Yiyecek", Name = "Köfte", Price = 225, Stock = 20},
				new Product(){Id = 7, Category = "Yiyecek", Name = "Pide", Price = 150, Stock = 15},
				new Product(){Id = 8, Category = "Yiyecek", Name = "Kebap", Price = 250, Stock = 35},
				new Product(){Id = 9, Category = "Yiyecek", Name = "Çorba", Price = 50, Stock = 20},
				new Product(){Id = 10,Category = "Yiyecek", Name = "Kahvaltý", Price = 200, Stock = 20},
				new Product(){Id = 11, Category = "Ýçecek", Name = "Çay", Price = 50, Stock = 20},
				new Product(){Id = 12, Category = "Ýçecek", Name = "Kahve", Price = 50, Stock = 20},
				new Product(){Id = 13, Category = "Ýçecek", Name = "Kola", Price = 25, Stock = 50},
				new Product(){Id = 14, Category = "Ýçecek", Name = "Fanta", Price = 25, Stock = 50},
				new Product(){Id = 15, Category = "Ýçecek", Name = "Sprite", Price = 25, Stock = 50},
				new Product(){Id = 16, Category = "Ýçecek", Name = "Ayran", Price = 25, Stock = 50}
			});
		ProductListFill();
	}

	private void btnOpen_Click(object sender, EventArgs e)
	{
		_cart = new List<Product>();
	}

	private void btnBurger_Click(object sender, EventArgs e)
	{
		Product product = _products.Find(p => p.Name == "Hamburger");
		if (product.Stock == 0)
		{
			MessageBox.Show("Ýstanilen ürün stokta kalmamýþtýr...");
		}
		else
		{

			product.Stock--;
			if (_cart.FirstOrDefault(p => p.Id == product.Id) == null)
			{
				Product p = new();
				p.Id = product.Id;
				p.Category = product.Category;
				p.Name = product.Name;
				p.Price = product.Price;
				p.Stock = 1;
				_cart.Add(p);
				CardFill();
				ProductListFill();
			}
			else
			{
				Product p = _cart.FirstOrDefault(p => p.Id == product.Id);
				p.Stock++;
				ProductListFill();
				CardFill();
			}
			
			
		}
	}

	public void ProductListFill()
	{
		dgvProductList.DataSource = null;
		
		dgvProductList.DataSource = _products.ToList();
	}

	public void CardFill()
	{
		dgvShoppingCart.DataSource = null;
		dgvShoppingCart.DataSource = _cart.ToList();
	}
}
