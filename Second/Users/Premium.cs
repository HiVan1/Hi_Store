using Gaming.Games;

namespace Gaming.Users{
    public class Premium : User{
        public Premium(string userName) : base(userName){}

        public override void WinGame(Game game){
            Rating += game.Coins * 2;
            history.Add(game);
        }

        public override void LoseGame(Game game){
            Rating -= game.Coins;
            history.Add(game);
        }

        public override string outputName(){
            return "Pre. " +userName;
        }
    }
}