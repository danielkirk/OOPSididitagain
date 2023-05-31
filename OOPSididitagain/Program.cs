// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var person = new Person(new DateTime(1996, 04, 24));
Console.WriteLine(person.Age);

var cookie = new IndexObject();
cookie["name"] = "Daniel";
Console.WriteLine(cookie["name"]);

var text = new Text();
text.Width = 100;
text.Copy();

var dbMigrator = new DbMigrator(new Logger());

var logger = new Logger();

var installer = new Installer(logger);

dbMigrator.Migrate();
installer.Install();

var customer = new Customer();
customer.Promote();
