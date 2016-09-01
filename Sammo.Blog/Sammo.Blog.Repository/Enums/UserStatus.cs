namespace Sammo.Blog.Repository.Enums
{
    public enum UserInvokeResult
    {
        Success,
        UserNameExists,
        EmailExists
    }

    public enum UserLoginInvokeResult
    {
        Success,
        UserOrEmailNotFound,
        PasswordIncorrect
    }
}
