namespace MarketApp.WinForm;

partial class Form1
{
	/// <summary>
	///  Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	///  Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	/// <summary>
	///  Required method for Designer support - do not modify
	///  the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		btnBurger = new Button();
		btnTost = new Button();
		btnSandwich = new Button();
		btnSalat = new Button();
		btnPizza = new Button();
		btnMeatball = new Button();
		btnPita = new Button();
		btnKebab = new Button();
		groupBox1 = new GroupBox();
		btnSoup = new Button();
		btnAyran = new Button();
		btnBreakfast = new Button();
		btnSprite = new Button();
		btnTea = new Button();
		btnFanta = new Button();
		btnCoffee = new Button();
		btnCola = new Button();
		groupBox2 = new GroupBox();
		btnCash = new Button();
		btnOpen = new Button();
		btnCreditCard = new Button();
		groupBox3 = new GroupBox();
		dgvShoppingCart = new DataGridView();
		gbxProductList = new GroupBox();
		dgvProductList = new DataGridView();
		groupBox1.SuspendLayout();
		groupBox2.SuspendLayout();
		groupBox3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)dgvShoppingCart).BeginInit();
		gbxProductList.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
		SuspendLayout();
		// 
		// btnBurger
		// 
		btnBurger.Location = new Point(6, 28);
		btnBurger.Name = "btnBurger";
		btnBurger.Size = new Size(99, 85);
		btnBurger.TabIndex = 0;
		btnBurger.Text = "Hamburger";
		btnBurger.UseVisualStyleBackColor = true;
		btnBurger.Click += btnBurger_Click;
		// 
		// btnTost
		// 
		btnTost.Location = new Point(111, 28);
		btnTost.Name = "btnTost";
		btnTost.Size = new Size(99, 85);
		btnTost.TabIndex = 1;
		btnTost.Text = "Tost";
		btnTost.UseVisualStyleBackColor = true;
		// 
		// btnSandwich
		// 
		btnSandwich.Location = new Point(216, 28);
		btnSandwich.Name = "btnSandwich";
		btnSandwich.Size = new Size(99, 85);
		btnSandwich.TabIndex = 2;
		btnSandwich.Text = "Sandviç";
		btnSandwich.UseVisualStyleBackColor = true;
		// 
		// btnSalat
		// 
		btnSalat.Location = new Point(321, 28);
		btnSalat.Name = "btnSalat";
		btnSalat.Size = new Size(99, 85);
		btnSalat.TabIndex = 3;
		btnSalat.Text = "Salata";
		btnSalat.UseVisualStyleBackColor = true;
		// 
		// btnPizza
		// 
		btnPizza.Location = new Point(6, 119);
		btnPizza.Name = "btnPizza";
		btnPizza.Size = new Size(99, 85);
		btnPizza.TabIndex = 4;
		btnPizza.Text = "Pizza";
		btnPizza.UseVisualStyleBackColor = true;
		// 
		// btnMeatball
		// 
		btnMeatball.Location = new Point(111, 119);
		btnMeatball.Name = "btnMeatball";
		btnMeatball.Size = new Size(99, 85);
		btnMeatball.TabIndex = 5;
		btnMeatball.Text = "Köfte";
		btnMeatball.UseVisualStyleBackColor = true;
		// 
		// btnPita
		// 
		btnPita.Location = new Point(216, 119);
		btnPita.Name = "btnPita";
		btnPita.Size = new Size(99, 85);
		btnPita.TabIndex = 6;
		btnPita.Text = "Pide";
		btnPita.UseVisualStyleBackColor = true;
		// 
		// btnKebab
		// 
		btnKebab.Location = new Point(321, 119);
		btnKebab.Name = "btnKebab";
		btnKebab.Size = new Size(99, 85);
		btnKebab.TabIndex = 7;
		btnKebab.Text = "Kebap";
		btnKebab.UseVisualStyleBackColor = true;
		// 
		// groupBox1
		// 
		groupBox1.Controls.Add(btnSoup);
		groupBox1.Controls.Add(btnAyran);
		groupBox1.Controls.Add(btnBreakfast);
		groupBox1.Controls.Add(btnSprite);
		groupBox1.Controls.Add(btnTea);
		groupBox1.Controls.Add(btnFanta);
		groupBox1.Controls.Add(btnCoffee);
		groupBox1.Controls.Add(btnCola);
		groupBox1.Controls.Add(btnBurger);
		groupBox1.Controls.Add(btnKebab);
		groupBox1.Controls.Add(btnTost);
		groupBox1.Controls.Add(btnPita);
		groupBox1.Controls.Add(btnSandwich);
		groupBox1.Controls.Add(btnMeatball);
		groupBox1.Controls.Add(btnSalat);
		groupBox1.Controls.Add(btnPizza);
		groupBox1.Location = new Point(12, 12);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new Size(433, 402);
		groupBox1.TabIndex = 8;
		groupBox1.TabStop = false;
		groupBox1.Text = "Ürün Satış Paneli";
		// 
		// btnSoup
		// 
		btnSoup.Location = new Point(6, 210);
		btnSoup.Name = "btnSoup";
		btnSoup.Size = new Size(99, 85);
		btnSoup.TabIndex = 8;
		btnSoup.Text = "Çorba";
		btnSoup.UseVisualStyleBackColor = true;
		// 
		// btnAyran
		// 
		btnAyran.Location = new Point(321, 301);
		btnAyran.Name = "btnAyran";
		btnAyran.Size = new Size(99, 85);
		btnAyran.TabIndex = 15;
		btnAyran.Text = "Ayran";
		btnAyran.UseVisualStyleBackColor = true;
		// 
		// btnBreakfast
		// 
		btnBreakfast.Location = new Point(111, 210);
		btnBreakfast.Name = "btnBreakfast";
		btnBreakfast.Size = new Size(99, 85);
		btnBreakfast.TabIndex = 9;
		btnBreakfast.Text = "Kahvaltı";
		btnBreakfast.UseVisualStyleBackColor = true;
		// 
		// btnSprite
		// 
		btnSprite.Location = new Point(216, 301);
		btnSprite.Name = "btnSprite";
		btnSprite.Size = new Size(99, 85);
		btnSprite.TabIndex = 14;
		btnSprite.Text = "Sprite";
		btnSprite.UseVisualStyleBackColor = true;
		// 
		// btnTea
		// 
		btnTea.Location = new Point(216, 210);
		btnTea.Name = "btnTea";
		btnTea.Size = new Size(99, 85);
		btnTea.TabIndex = 10;
		btnTea.Text = "Çay";
		btnTea.UseVisualStyleBackColor = true;
		// 
		// btnFanta
		// 
		btnFanta.Location = new Point(111, 301);
		btnFanta.Name = "btnFanta";
		btnFanta.Size = new Size(99, 85);
		btnFanta.TabIndex = 13;
		btnFanta.Text = "Fanta";
		btnFanta.UseVisualStyleBackColor = true;
		// 
		// btnCoffee
		// 
		btnCoffee.Location = new Point(321, 210);
		btnCoffee.Name = "btnCoffee";
		btnCoffee.Size = new Size(99, 85);
		btnCoffee.TabIndex = 11;
		btnCoffee.Text = "Kahve";
		btnCoffee.UseVisualStyleBackColor = true;
		// 
		// btnCola
		// 
		btnCola.Location = new Point(6, 301);
		btnCola.Name = "btnCola";
		btnCola.Size = new Size(99, 85);
		btnCola.TabIndex = 12;
		btnCola.Text = "Kola";
		btnCola.UseVisualStyleBackColor = true;
		// 
		// groupBox2
		// 
		groupBox2.Controls.Add(btnCash);
		groupBox2.Controls.Add(btnOpen);
		groupBox2.Controls.Add(btnCreditCard);
		groupBox2.Location = new Point(12, 420);
		groupBox2.Name = "groupBox2";
		groupBox2.Size = new Size(433, 161);
		groupBox2.TabIndex = 9;
		groupBox2.TabStop = false;
		groupBox2.Text = "Ödeme Şekli";
		// 
		// btnCash
		// 
		btnCash.Location = new Point(269, 28);
		btnCash.Name = "btnCash";
		btnCash.Size = new Size(151, 127);
		btnCash.TabIndex = 2;
		btnCash.Text = "Nakit";
		btnCash.UseVisualStyleBackColor = true;
		// 
		// btnOpen
		// 
		btnOpen.Location = new Point(6, 28);
		btnOpen.Name = "btnOpen";
		btnOpen.Size = new Size(99, 127);
		btnOpen.TabIndex = 11;
		btnOpen.Text = "Kasa Aç";
		btnOpen.UseVisualStyleBackColor = true;
		btnOpen.Click += btnOpen_Click;
		// 
		// btnCreditCard
		// 
		btnCreditCard.Location = new Point(111, 28);
		btnCreditCard.Name = "btnCreditCard";
		btnCreditCard.Size = new Size(151, 127);
		btnCreditCard.TabIndex = 1;
		btnCreditCard.Text = "Kredi Kartı";
		btnCreditCard.UseVisualStyleBackColor = true;
		// 
		// groupBox3
		// 
		groupBox3.Controls.Add(dgvShoppingCart);
		groupBox3.Location = new Point(455, 313);
		groupBox3.Name = "groupBox3";
		groupBox3.Size = new Size(735, 268);
		groupBox3.TabIndex = 10;
		groupBox3.TabStop = false;
		groupBox3.Text = "Alışveriş Sepeti";
		// 
		// dgvShoppingCart
		// 
		dgvShoppingCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dgvShoppingCart.Dock = DockStyle.Fill;
		dgvShoppingCart.Location = new Point(3, 25);
		dgvShoppingCart.Name = "dgvShoppingCart";
		dgvShoppingCart.Size = new Size(729, 240);
		dgvShoppingCart.TabIndex = 0;
		// 
		// gbxProductList
		// 
		gbxProductList.Controls.Add(dgvProductList);
		gbxProductList.Location = new Point(452, 12);
		gbxProductList.Name = "gbxProductList";
		gbxProductList.Size = new Size(735, 295);
		gbxProductList.TabIndex = 12;
		gbxProductList.TabStop = false;
		gbxProductList.Text = "Ürün Stok Durum Paneli";
		// 
		// dgvProductList
		// 
		dgvProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dgvProductList.Dock = DockStyle.Fill;
		dgvProductList.EnableHeadersVisualStyles = false;
		dgvProductList.Location = new Point(3, 25);
		dgvProductList.Name = "dgvProductList";
		dgvProductList.Size = new Size(729, 267);
		dgvProductList.TabIndex = 0;
		// 
		// Form1
		// 
		AutoScaleDimensions = new SizeF(9F, 21F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1202, 630);
		Controls.Add(gbxProductList);
		Controls.Add(groupBox3);
		Controls.Add(groupBox2);
		Controls.Add(groupBox1);
		Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
		Margin = new Padding(4);
		Name = "Form1";
		Text = "Market Plus";
		Load += Form1_Load;
		groupBox1.ResumeLayout(false);
		groupBox2.ResumeLayout(false);
		groupBox3.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)dgvShoppingCart).EndInit();
		gbxProductList.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
		ResumeLayout(false);
	}

	#endregion

	private Button btnBurger;
	private Button btnTost;
	private Button btnSandwich;
	private Button btnSalat;
	private Button btnPizza;
	private Button btnMeatball;
	private Button btnPita;
	private Button btnKebab;
	private GroupBox groupBox1;
	private Button btnSoup;
	private Button btnAyran;
	private Button btnBreakfast;
	private Button btnSprite;
	private Button btnTea;
	private Button btnFanta;
	private Button btnCoffee;
	private Button btnCola;
	private GroupBox groupBox2;
	private Button btnCash;
	private Button btnCreditCard;
	private GroupBox groupBox3;
	private DataGridView dgvShoppingCart;
	private Button btnOpen;
	private GroupBox gbxProductList;
	private DataGridView dgvProductList;
}
