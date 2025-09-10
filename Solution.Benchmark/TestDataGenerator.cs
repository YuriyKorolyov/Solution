using Bogus;
using Solution.Data.Dto;

namespace Solution.Benchmark;

public static class TestDataGenerator
{
    public static ProductComplexDto GenerateProduct()
    {
        var faker = new Faker<ProductComplexDto>()
            .RuleFor(p => p.ProductCode, f => f.IndexFaker + 1)
            .RuleFor(p => p.Title, f => f.Commerce.ProductName())
            .RuleFor(p => p.FullDescription, f => f.Commerce.ProductDescription())
            .RuleFor(p => p.ShortDesc, f => f.Commerce.ProductAdjective())
            .RuleFor(p => p.CategoryName, f => f.Commerce.Categories(1)[0])
            .RuleFor(p => p.RetailPrice, f => Math.Round(f.Finance.Amount(100, 10000), 2))
            .RuleFor(p => p.Wholesale, f => Math.Round(f.Finance.Amount(50, 9000), 2))
            .RuleFor(p => p.VendorName, f => f.Company.CompanyName())
            .RuleFor(p => p.ManufacturerName, f => f.Company.CompanyName())
            .RuleFor(p => p.LicenseDetails, f => f.Random.AlphaNumeric(16))
            .RuleFor(p => p.ColorHex, f => f.Commerce.Color())
            .RuleFor(p => p.AvailableForSale, f => f.Random.Bool())
            .RuleFor(p => p.QuantityInStock, f => f.Random.Int(0, 500))
            .RuleFor(p => p.TagsCsv, f => string.Join(",", f.Lorem.Words(5)))
            .RuleFor(p => p.IsFeatured, f => f.Random.Bool())
            .RuleFor(p => p.IsBestSeller, f => f.Random.Bool())
            .RuleFor(p => p.SupportUrl, f => f.Internet.Url())
            .RuleFor(p => p.AdditionalNotes, f => f.Lorem.Sentence())
            .RuleFor(p => p.CpuModel, f => f.Commerce.ProductAdjective() + " CPU")
            .RuleFor(p => p.RamGb, f => f.Random.Int(4, 64))
            .RuleFor(p => p.StorageGb, f => f.Random.Int(128, 2048))
            .RuleFor(p => p.OsName, f => f.PickRandom(new[] { "Windows 11", "Ubuntu 22.04", "macOS 14", "Debian 12" }))
            .RuleFor(p => p.GpuModel, f => f.Commerce.ProductAdjective() + " GPU")
            .RuleFor(p => p.ConnectivityType, f => f.PickRandom(new[] { "WiFi", "Ethernet", "Bluetooth", "4G", "5G" }))
            .RuleFor(p => p.PortsInfo, f => "USB-C, HDMI, " + f.Random.Int(1, 4) + "x USB-A")
            .RuleFor(p => p.SoftwareIncludedList, f => string.Join(", ", f.Lorem.Words(3)));

        return faker.Generate();
    }

    public static UserDto GenerateUser()
    {
        var faker = new Faker<UserDto>()
            .RuleFor(u => u.Id, f => f.IndexFaker + 1)
            .RuleFor(u => u.FirstName, f => f.Name.FirstName())
            .RuleFor(u => u.LastName, f => f.Name.LastName())
            .RuleFor(u => u.Email, f => f.Internet.Email())
            .RuleFor(u => u.Phone, f => f.Phone.PhoneNumber("+7-###-###-##-##"))
            .RuleFor(u => u.City, f => f.Address.City())
            .RuleFor(u => u.Region, f => f.Address.State())
            .RuleFor(u => u.Company, f => f.Company.CompanyName())
            .RuleFor(u => u.RegistrationDate, f => f.Date.Past(3))
            .RuleFor(u => u.IsVerified, f => f.Random.Bool())
            .RuleFor(u => u.OrderCount, f => f.Random.Int(0, 100))
            .RuleFor(u => u.AccountBalance, f => Math.Round(f.Random.Decimal(0, 100000), 2))
            .RuleFor(u => u.LastLogin, f => f.Date.Recent(30))
            .RuleFor(u => u.Role, f => f.PickRandom(new[] { "User", "Admin", "Manager", "Support" }))
            .RuleFor(u => u.Department, f => f.PickRandom(new[] { "IT", "Sales", "HR", "Marketing", "Finance" }));

        return faker.Generate();
    }

    public static List<UserDto> GenerateUsers(int count)
    {
        var users = new List<UserDto>();
        for (int i = 0; i < count; i++)
        {
            users.Add(GenerateUser());
        }
        return users;
    }

    public static List<OrderDto> GenerateOrders(int orderCount)
    {
        var faker = new Faker();

        // Пользователи
        var users = new Faker<UserDto>()
            .RuleFor(u => u.Id, f => f.IndexFaker + 1)
            .RuleFor(u => u.FirstName, f => f.Name.FirstName())
            .RuleFor(u => u.LastName, f => f.Name.LastName())
            .RuleFor(u => u.Email, f => f.Internet.Email())
            .RuleFor(u => u.Phone, f => f.Phone.PhoneNumber("+7-###-###-##-##"))
            .RuleFor(u => u.City, f => f.Address.City())
            .RuleFor(u => u.Region, f => f.Address.State())
            .RuleFor(u => u.Company, f => f.Company.CompanyName())
            .RuleFor(u => u.RegistrationDate, f => f.Date.Past(3))
            .RuleFor(u => u.IsVerified, f => f.Random.Bool())
            .RuleFor(u => u.OrderCount, f => f.Random.Int(0, 100))
            .RuleFor(u => u.AccountBalance, f => Math.Round(f.Random.Decimal(0, 100000), 2))
            .RuleFor(u => u.LastLogin, f => f.Date.Recent(30))
            .RuleFor(u => u.Role, f => f.PickRandom(new[] { "User", "Admin", "Manager", "Support" }))
            .RuleFor(u => u.Department, f => f.PickRandom(new[] { "IT", "Sales", "HR", "Marketing", "Finance" }))
            .Generate(20);

        // Клиенты
        var customers = new Faker<CustomerDto>()
            .RuleFor(c => c.Id, f => f.IndexFaker + 1)
            .RuleFor(c => c.CompanyName, f => f.Company.CompanyName())
            .RuleFor(c => c.ContactPerson, f => f.Name.FullName())
            .RuleFor(c => c.Email, f => f.Internet.Email())
            .RuleFor(c => c.Phone, f => f.Phone.PhoneNumber("+7-###-###-##-##"))
            .RuleFor(c => c.Address, f => f.Address.FullAddress())
            .RuleFor(c => c.City, f => f.Address.City())
            .RuleFor(c => c.Region, f => f.Address.State())
            .RuleFor(c => c.INN, f => f.Random.ReplaceNumbers("##########"))
            .RuleFor(c => c.KPP, f => f.Random.ReplaceNumbers("######"))
            .RuleFor(c => c.TotalSpent, f => Math.Round(f.Random.Decimal(0, 1000000), 2))
            .RuleFor(c => c.TotalOrders, f => f.Random.Int(0, 200))
            .RuleFor(c => c.VIPStatus, f => f.Random.Bool())
            .RuleFor(c => c.Industry, f => f.Commerce.Department())
            .RuleFor(c => c.RegistrationDate, f => f.Date.Past(5))
            .RuleFor(c => c.Notes, f => f.Lorem.Sentence())
            .Generate(20);

        // Продукты
        var products = new Faker<ProductDto>()
            .RuleFor(p => p.Id, f => f.IndexFaker + 1)
            .RuleFor(p => p.Name, f => f.Commerce.ProductName())
            .RuleFor(p => p.Description, f => f.Commerce.ProductDescription())
            .RuleFor(p => p.Price, f => Math.Round(f.Finance.Amount(100, 10000), 2))
            .RuleFor(p => p.Stock, f => f.Random.Int(0, 500))
            .Generate(50);

        // Заказы
        var orders = new List<OrderDto>();
        int orderId = 1;
        int orderItemId = 1;

        for (int i = 0; i < orderCount; i++)
        {
            var user = faker.PickRandom(users);
            var customer = faker.PickRandom(customers);

            int currentOrderId = orderId;

            int itemsCount = faker.Random.Int(1, 5);
            var items = new List<OrderItemDto>();

            for (int j = 0; j < itemsCount; j++)
            {
                var product = faker.PickRandom(products);
                items.Add(new OrderItemDto
                {
                    Id = orderItemId++,
                    OrderId = currentOrderId,
                    ProductId = product.Id,
                    Product = product,
                    Quantity = faker.Random.Int(1, 3),
                    UnitPrice = product.Price,
                    IsGift = faker.Random.Bool(0.1f),
                    LicenseInfo = faker.Random.AlphaNumeric(16),
                    AddedAt = faker.Date.Recent(30)
                });
            }

            decimal totalAmount = items.Sum(x => x.Total);
            decimal taxAmount = Math.Round(totalAmount * 0.2m, 2);
            decimal discount = Math.Round(totalAmount * faker.Random.Decimal(0, 0.15m), 2);

            orders.Add(new OrderDto
            {
                Id = orderId++,
                UserId = user.Id,
                User = user,
                CustomerId = customer.Id,
                Customer = customer,
                OrderDate = faker.Date.Past(1),
                DeliveryDate = faker.Date.Future(1),
                TotalAmount = totalAmount,
                TaxAmount = taxAmount,
                Discount = discount,
                Status = faker.PickRandom(new[] { "Pending", "Processing", "Shipped", "Delivered", "Cancelled" }),
                PaymentMethod = faker.PickRandom(new[] { "Card", "Cash", "Online" }),
                BillingAddress = faker.Address.FullAddress(),
                ShippingAddress = faker.Address.FullAddress(),
                Notes = faker.Lorem.Sentence(),
                Items = items
            });
        }

        return orders;
    }
}
