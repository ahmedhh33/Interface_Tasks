namespace InterfaceTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("%%%%%%%%%%%%%%% Task 1 %%%%%%%%%%%%");
            IVechile car = new Car();
            car.Start();
            car.Accelerate(120, 60);
            car.Break();

            IVechile motercycle = new Motorcycle();
            motercycle.Start();
            motercycle.Accelerate(120, 80);
            motercycle.Break();

            Console.WriteLine("%%%%%%%%%%%%%%% Task 2 %%%%%%%%%%%%");

            IBanlkAcount savinaccount = new SavingAccount(3456.67);
            Console.WriteLine($" You have in saving account {savinaccount.GetBalance()} OMR");
            savinaccount.Deposit(3360);
            savinaccount.Withdraw(4565);

            Console.WriteLine("#########");

            IBanlkAcount checkingaccount = new CheckingAccount(1230);
            Console.WriteLine($" You have in saving account {checkingaccount.GetBalance()} OMR");
            checkingaccount.Deposit(300);
            checkingaccount.Withdraw(3023);

            Console.WriteLine("%%%%%%%%%%%%%%% Task 3 %%%%%%%%%%%%");

            IPlayable music = new MusicPlayer();
            music.Play();
            music.Pause();
            music.Stop();
            Console.WriteLine("######");
            IPlayable video = new VideoPlayer();
            video.Play();
            video.Pause();
            video.Stop();

            Console.WriteLine("%%%%%%%%%%%%%%% Task 4 %%%%%%%%%%%%");



        }
    }
}