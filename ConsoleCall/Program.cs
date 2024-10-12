using ConsoleCall.Menu;
using ConsoleCall.Methods;
using CreationalPatterns.AbstractFactory;
using CreationalPatterns.AbstractFactory.Factories;
using CreationalPatterns.FactoryMethod.Factories;
using System.Diagnostics;
using System.Runtime.CompilerServices;

MenuItem mainMenu = new("Главное меню");
MenuItem creationalPatternsMenu = new("Порождающие паттерны");
MenuItem patternsMenu1 = new("Структурные паттерны");
MenuItem PatternsMenu2 = new("Поведенческие паттерны");

CreationalPatterns(creationalPatternsMenu);

mainMenu.AddMenuItemChild(creationalPatternsMenu);
mainMenu.AddMenuItemChild(patternsMenu1);
mainMenu.AddMenuItemChild(PatternsMenu2);

ConsoleMenu consoleMenu = new(mainMenu);

while(true) consoleMenu.Start();

void CreationalPatterns(MenuItem main)
{
    main.AddMenuItemChild(new("Фабричный метод", action: () => 
                                                {
                                                    new FactoryMethod().Factory(new EmailNotificationFactory("Hello Email"));
                                                    new FactoryMethod().Factory(new SmsNotificationFactory("Hello SMS"));
                                                }));
    main.AddMenuItemChild(new("Абстрактная фабрика", action: () => 
                                                {
                                                    new AbstractFactory().Factory(new HashFactory()); 
                                                    new AbstractFactory().Factory(new PlusFactory()); 
                                                }));
    main.AddMenuItemChild(new("Строитель", action: () => 
                                                {
                                                    new Builder().Factory();
                                                }));
    main.AddMenuItemChild(new("Прототип", action: () => { Console.WriteLine("Прототип"); }));
    main.AddMenuItemChild(new("Одиночка", action: () => { Console.WriteLine("Одиночка"); }));
}