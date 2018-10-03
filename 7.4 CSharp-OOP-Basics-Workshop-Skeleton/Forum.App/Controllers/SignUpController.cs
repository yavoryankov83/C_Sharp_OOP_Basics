namespace Forum.App.Controllers
{
	using Forum.App;
	using Forum.App.Controllers.Contracts;
    using Forum.App.Services;
    using Forum.App.UserInterface;
    using Forum.App.UserInterface.Contracts;
    using System;

    public class SignUpController : IController, IReadUserInfoController
	{
        private enum Command
        {
            ReadUsername, ReadPassword, SignUp, Back
        }
        public enum SignUpStatus
        {
            Success, DetailsError, UsernameTakenError
        }
		private const string DETAILS_ERROR = "Invalid Username or Password!";
		private const string USERNAME_TAKEN_ERROR = "Username already in use!";

        public string Username { get; private set; }
        private string Password { get; set; }
        private string ErrorMesage { get; set; }

        public MenuState ExecuteCommand(int index)
        {
            switch ((Command)index)
            {
                case Command.ReadUsername:
                    this.ReadUsername();
                    return MenuState.SignedUp;

                case Command.ReadPassword:
                    this.ReadPassword();
                    return MenuState.SignedUp;

                case Command.SignUp:
                    var signedUp = UserService.TrySignUpUser(Username, Password);

                    switch (signedUp)
                    {
                        case SignUpStatus.Success:
                            return MenuState.SuccessfulLogIn;

                        case SignUpStatus.DetailsError:
                            ErrorMesage = DETAILS_ERROR;
                            return MenuState.SignUpError;

                        case SignUpStatus.UsernameTakenError:
                            ErrorMesage = USERNAME_TAKEN_ERROR;
                            return MenuState.SignUpError;
                    }
                    return MenuState.SignUpError;

                case Command.Back:
                    this.ResetSignUp();
                    return MenuState.Back;
                default:
                    throw new InvalidOperationException();
            }
        }

        public IView GetView(string userName)
        {
             return new SignUpView(this.ErrorMesage);
        }

        public void ReadPassword()
        {
            this.Password = ForumViewEngine.ReadRow();
            ForumViewEngine.HideCursor();
        }

        public void ReadUsername()
        {
            this.Username = ForumViewEngine.ReadRow();
            ForumViewEngine.HideCursor();
        }

        private void ResetSignUp()
        {
            this.ErrorMesage = string.Empty;
            this.Username = string.Empty;
            this.Password = string.Empty;
        }
    }
}
