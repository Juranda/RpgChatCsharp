using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RpgChatCsharp.Core
{
    public static class GlobalChat
    {
        public static List<PlayerS.Player> players = new();

        private static Random r = new();

        private static Action randomChatLine = () => { 
            players[r.Next(players.Count)].Falar();
        };

        public static Task InitGlobalChat(int maxDelay)
        {
            Console.Clear();

            do {
                System.Threading.Thread.Sleep(maxDelay * 1000);

                randomChatLine.Invoke();
            } 
            while (true);
        }
    }
}
