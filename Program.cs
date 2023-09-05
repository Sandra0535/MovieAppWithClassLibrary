namespace MovieAppWithClassLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieController movieController = new MovieController();
            MovieController.Start();
        }
    }
}