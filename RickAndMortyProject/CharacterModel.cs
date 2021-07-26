using System;
using System.Collections.Generic;
using System.Text;

namespace RickAndMortyProject
{
    class CharacterModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

        public CharacterModel(string id, string name, string status)
        {
            Id = id;
            Name = name;
            Status = status;
        }
    }
}
