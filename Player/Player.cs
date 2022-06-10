using System;
using RpgChatCsharp.Weapons;

namespace RpgChatCsharp.PlayerS
{
    public class Player
    {
        public string Name { get; private set; }
        public string[] Dialogs { get; private set; }
        public Weapon Weapon { get; private set; }

        public Player(string name, string[] dialogs, Weapon weapon)
        {
            this.Name = name;
            this.Dialogs = dialogs;
            this.Weapon = weapon;
        }

        public void Falar()
        {
            Random r = new();
            
            Console.WriteLine($"{Name}: {Dialogs[r.Next(0, Dialogs.Length)]}");
        }
    }
}
