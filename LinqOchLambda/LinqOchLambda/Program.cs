using System;
using System.Collections.Generic;
namespace LinqOchLambda
{
    class Program
    {

        //1. Gör en metod som returnerar en lista med spelares Hp i formatet "nuvarandeHP/maxHp"
        //2. Gör en metod som returnerar en filtrerad lista med alla spelare som har en nuvarande Hp över 0
        //3. Gör en metod som joinar ihop spelare med spelobjekt och returnerar objekt som har följande format
        //  { o.ID, p.TeamColor };
        //4. Göre en metod som returnerar en sorterad lista av spelare baserat på deras namn från A-Ö
        //5. Göre en metod som returnerar en sorterad lista av spelare baserat på deras namn från Ö-A
        public static void Main(string[] args)
        {
            List<GameObject> gameObjects = new List<GameObject>();
            gameObjects.Add(new Ship { ID = 1, X = 0, Y = 0, CurrentHP = 50, MaxHP = 100, PlayerID = 1 });
            gameObjects.Add(new Ship { ID = 2, X = 4, Y = 2, CurrentHP = 75, MaxHP = 100, PlayerID = 1 });
            gameObjects.Add(new Ship { ID = 3, X = 9, Y = 3, CurrentHP = 0, MaxHP = 100, PlayerID = 2 });
            List<Player> players = new List<Player>();
            players.Add(new Player { ID = 1, UserName = "Player 1", TeamColor = "Red" });
            players.Add(new Player { ID = 2, UserName = "Player 2", TeamColor = "Blue" });


        }

        
    }
}
