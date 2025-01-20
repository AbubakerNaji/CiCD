List<Customer> customers = new List<Customer>{
    new Customer{Id=1, FirstName="John", LastName="Doe", ODLimit=1000},
    new Customer{Id=2, FirstName="Jane", LastName="Doe", ODLimit=2000},
    new Customer{Id=3, FirstName="Jack", LastName="Doe", ODLimit=3000},
    new Customer{Id=4, FirstName="Jill", LastName="Doe", ODLimit=4000},
    new Customer{Id=5, FirstName="Joe", LastName="Doe", ODLimit=5000},
    
};
foreach (var customer in customers)
{
    Console.WriteLine($"Id: {customer.Id}, Name: {customer.FirstName}, {customer.LastName}, OD Limit: {customer.ODLimit}"); 
}

