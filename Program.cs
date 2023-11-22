using PatronFacade.Entity;
using PatronFacade.Facade;
using PatronFacade.Subsystem;

ContactSystem subsystem = new ContactSystem();
ContactFacade facade = new ContactFacade(subsystem);
Console.WriteLine(facade.create().ToString());
