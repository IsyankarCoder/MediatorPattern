public abstract class User{
    protected string? name;
    protected IFacebookGroupMediatorInterface? mediator;

    public User(IFacebookGroupMediatorInterface mediator, string name){
        this.mediator=mediator;
        this.name=name;
    }

    public abstract void Send(string message);
    public abstract void Recieve(string message);
}