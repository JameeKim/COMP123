namespace COMP123.Lab15FastFood
{
    public class Supervisor : Server
    {
        public Supervisor(string name) : base(name)
        {
            duties.Add("supervising");
        }
    }
}
