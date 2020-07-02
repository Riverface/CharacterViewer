using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Viewer.Models
{
    public class Character
    {
        public int CharacterId { get; set; }

        public string Faction { get; set; }

        public string Bio { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1, 20, ErrorMessage = "Stats go from 1 to 20.")]
        public int Might { get; set; }

        [Required]
        [Range(1, 20, ErrorMessage = "Stats go from 1 to 20.")]
        public int Spryness { get; set; }

        [Required]
        [Range(1, 20, ErrorMessage = "Stats go from 1 to 20.")]
        public int Judgement { get; set; }

        [Required]
        [Range(1, 20, ErrorMessage = "Stats go from 1 to 20.")]
        public int Echo { get; set; }

        [Required]
        [Range(1, 20, ErrorMessage = "Stats go from 1 to 20.")]
        public int Magnetism { get; set; }

        [Required]
        [Range(1, 20, ErrorMessage = "Stats go from 1 to 20.")]
        public int Fortune { get; set; }

        [Required]

        [Range(1, 20)]
        public int Level { get; set; }
        public int experience { get; set; }

        public virtual ICollection<CharacterTrait> Traits { get; }
        
        public Character()
        {
            this.Traits = new HashSet<CharacterTrait>();
        }

        public static List<Character> GetCharacters()
        {
            var apiCallTask = CharacterApiHelper.GetAll();
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<Character> characterList = JsonConvert.DeserializeObject<List<Character>>(jsonResponse.ToString());

            return characterList;
        }

        public static Character GetDetails(int id)
        {
            var apiCallTask = CharacterApiHelper.Get(id);
            var result = apiCallTask.Result;

            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
            Character character = JsonConvert.DeserializeObject<Character>(jsonResponse.ToString());
            return character;
        }

        public static void Post(Character character)
        {
            string jsonCharacter = JsonConvert.SerializeObject(character);
            var apiCallTask = CharacterApiHelper.Post(jsonCharacter);
        }

        public static void Put(Character character)
        {
            string jsonCharacter = JsonConvert.SerializeObject(character);
            var apiCallTask = CharacterApiHelper.Put(character.CharacterId, jsonCharacter);
        }

        public static void Delete(int id)
        {
            var apiCallTask = CharacterApiHelper.Delete(id);
        }
    }
}