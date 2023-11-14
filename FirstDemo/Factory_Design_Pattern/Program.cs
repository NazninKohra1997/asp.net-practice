using Factory_Design_Pattern;


CarFactory carFactory = new BMWFactory();

ICar car = carFactory.Create("Red", "X200", 5000);  //here printed BMW items and object is flexible.


CarFactory carFactory2 = new ToyotaFactory();

ICar car2 = carFactory2.Create("Blue", "X300", 4000);   //here Toyota items.

