using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//In this example, we start by defining the IAuthenticationService interface with two methods: AuthenticateUser and AuthorizeUser.
//The BasicAuthenticationService class implements this interface and provides the specific implementation for these methods.
//In the BasicAuthenticationService class, the AuthenticateUser method compares the provided username and password with the stored credentials.
//It returns true if the user is authenticated and false otherwise.

//The AuthorizeUser method checks if the user with the given username has the specified role.
//It returns true if the user is authorized and false otherwise.

//In the Main method, we create an instance of the BasicAuthenticationService class and assign it to the authService variable of type IAuthenticationService.
//We then call the AuthenticateUser and AuthorizeUser methods using this interface reference.
//This implementation allows you to switch the authentication service implementation easily by creating a new class that implements
//the IAuthenticationService interface and providing the desired logic for authentication and authorization.

namespace OOP4
{
    public interface IAuthenticationService
    {
        public bool AuthenticateUser(string username,string password);
        public bool AuthorizeUser(string username,string role);
    }
    public class BasicAuthenticationService:IAuthenticationService
    {
        public string username {  get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public BasicAuthenticationService(string username, string password,string role) { 
            this.username=username;
            this.password=password;
            this.role = role;
        }
        public bool AuthenticateUser(string username,string pasword)
        {
            if(this.username ==username && this.password == password) return true;
            else  return false; 
        }
        public bool AuthorizeUser(string username ,string role)
        {
            if (this.username == username && this.role == role) return true;
            else return false;
        }

    }
}
