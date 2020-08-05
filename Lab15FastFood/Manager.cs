namespace COMP123.Lab15FastFood
{
    public class Manager : Supervisor
    {
        public Manager(string name) : base(name)
        {
            duties.Add("management");
        }
    }
}
