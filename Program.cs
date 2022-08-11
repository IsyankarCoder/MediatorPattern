IFacebookGroupMediatorInterface facebookGroupMediator =new ConcreteFacebookGroupMediator();

User Ram = new ConcreteUser(facebookGroupMediator,"Ram");
User Dave = new ConcreteUser(facebookGroupMediator,"Dave");
User Smith = new ConcreteUser(facebookGroupMediator,"Smith");
User Sam = new ConcreteUser(facebookGroupMediator,"Sam");
User Pam = new ConcreteUser(facebookGroupMediator,"Pam");
User Rajesh = new ConcreteUser(facebookGroupMediator,"Rajesh");
User Anurag = new ConcreteUser(facebookGroupMediator,"Anurag");
User John = new ConcreteUser(facebookGroupMediator,"John");

facebookGroupMediator.RegisterUser(Ram);
facebookGroupMediator.RegisterUser(Dave);
facebookGroupMediator.RegisterUser(Smith);
facebookGroupMediator.RegisterUser(Sam);
facebookGroupMediator.RegisterUser(Pam);
facebookGroupMediator.RegisterUser(Rajesh);
facebookGroupMediator.RegisterUser(Anurag);
 facebookGroupMediator.RegisterUser(John);

 Dave.Send("volkan genç - is a dandik diveloper");

 Console.WriteLine();

 Rajesh.Send("volkan tolkan da kim yaww");

 Console.Read();