using ef_dbfirst_tutorial;
using ef_dbfirst_tutorial.Models;
using Microsoft.EntityFrameworkCore;


var _context = new SalesDbContext();

var orders = await _context.Orders.ToListAsync();
orders.ForEach(x => Console.WriteLine(x.Description));

//var CustCtrl = new CustomersController();

//var success = await CustCtrl.DeleteAsync(37);

//Console.WriteLine(success ? "yep" : "nah");

//var bootcamp = await CustCtrl.GetByIdAsync(37);

//bootcamp.Sales = 5000;

// var success = await CustCtrl.UpdateAsync(bootcamp); 

//Console.WriteLine(success ? "good~!" : "Nope you failed");

//var cust = new Customer()
//{
//    Id = 0,
//    Name = "Bootcamp",
//    City = "Mason",
//    State = "OH",
//    Sales = 0,
//    Active = true
//};

//var success = await CustCtrl.InsertAsync(cust);


//var cust = await CustCtrl.GetByIdAsync(1);
//Console.WriteLine(cust.Name);
//foreach(var c in await CustCtrl.GetAllAsync())
//{
//    Console.WriteLine(c.Name);
//}



//var dbc = new SalesDbContext();

//var customer = await GetById(1);
//var customers = await GetAll();
//foreach(var c in customers)
//{
//    Console.WriteLine(c.Name);

//}


//async Task<Customer> GetById(int id)
//{
//    return await dbc.Customers.FindAsync(id);
//}

//async Task<List<Customer>> GetAll()
//{
//    return await dbc.Customers.ToListAsync();
//}
//var orderWithCustomers = from o in dbc.Orders
//                         join c in dbc.Customers
//                            on o.CustomerId equals c.Id
//                            orderby c.Id descending
//                         select new
//                         {
//                             Id = o.Id,
//                             Desc = o.Description,
//                             Customer = c.Name
//                         };
//foreach(var oc in orderWithCustomers)
//{
//    Console.WriteLine($"{oc.Id,2} | {oc.Desc,-30} | {oc.Customer,-30}");
//}

//var orders = from o in dbc.Orders
//             select o; 

//foreach(var order in orders)
//{
//    Console.WriteLine(order.Description);
//}

//var customers = dbc.Customers.
//    Where(x => x.City == "Cincinnati")
//    .OrderByDescending(x => x.Sales)
//    .ToList();

//foreach(var c in customers)
//{
//    Console.WriteLine(c.Name);
//}
