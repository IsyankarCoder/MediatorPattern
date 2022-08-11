public class ConcreteFacebookGroupMediator : IFacebookGroupMediatorInterface
{
    private List<User> usersList = new List<User>();

    public void RegisterUser(User user){
        usersList.Add(user);
    }

    public void SendMessage(string msg, User user)
    {
        foreach(var u in usersList){
            if(u!=user){
                u.Recieve(msg);
            }
        }
    }
}