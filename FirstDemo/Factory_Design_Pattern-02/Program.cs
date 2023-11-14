using Factory_Design_Pattern_02;

BottleCompany bottleCompany = new PranCompany();

IBottle bottle = bottleCompany.Produce(150, "blue");  //here the object is flexible for both Pran and Acme