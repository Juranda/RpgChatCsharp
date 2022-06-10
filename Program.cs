using System;
using System.IO;
using RpgChatCsharp.PlayerS;
using RpgChatCsharp.Core;

namespace RpgChatCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            GlobalChat.players.AddRange(PlayerGenerator.GenerateRandomPlayers(10));

            GlobalChat.InitGlobalChat(3);
        }
    }
}
