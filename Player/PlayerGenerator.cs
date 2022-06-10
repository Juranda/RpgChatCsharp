using System;
using System.IO;
using System.Collections.Generic;

namespace RpgChatCsharp.PlayerS
{
    public static class PlayerGenerator
    {
        public static List<Player> GenerateRandomPlayers(int quantity)
        {
            Random r = new();
            List<Player> players = new();

            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            string[] names = File.ReadAllLines(projectDirectory + @"\Database\Names.txt");
            string[] dialogues = File.ReadAllLines(projectDirectory + @"\Database\Dialogues.txt");

            for (int i = 0; i < quantity - 1; i++)
            {
                var name = names[r.Next(names.Length)];

                Player player = new Player(name, dialogues, null);
                players.Add(player);
            }

            return players;
        }
    }
}
