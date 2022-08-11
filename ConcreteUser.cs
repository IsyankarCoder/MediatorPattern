public class ConcreteUser : User
{

    public ConcreteUser(IFacebookGroupMediatorInterface mediator,string name)
    :base(mediator,name)
    {

    }
    public override void Recieve(string message)
    {
        Console.WriteLine(this.name+" : Received Message : "+ message);
    }

    public override void Send(string message)
    {
       
        Console.WriteLine(this.name + ": Sending Message= " + message+"\n");
        this.mediator?.SendMessage(message,this);
    }
}