namespace WEB.Context
{
    public class Role
    {
        public int Id { get; set; }
        public string Rol { get; set; }
        public List<User> Users{ get; set; }

        public override string ToString()
        {
            return Rol;
        }
    }
}
