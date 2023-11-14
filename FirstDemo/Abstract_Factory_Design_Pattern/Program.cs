using Abstract_Factory_Design_Pattern;
using Abstract_Factory_Design_Pattern.BMW;

CarFactory carFactory = new BMWFactory();
IEngine engine = carFactory.CreateEngine(1000);
IHeadLight headLight = carFactory.CreateHeadLight(2);
ITire tire = carFactory.CreateTire("Black");