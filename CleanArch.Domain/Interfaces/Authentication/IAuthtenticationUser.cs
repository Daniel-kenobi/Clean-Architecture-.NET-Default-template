namespace CleanArch.Domain.Interfaces.Authentication
{
    public interface IAuthtenticationUser
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
