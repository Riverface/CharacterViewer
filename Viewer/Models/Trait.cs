using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using RestSharp;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Viewer.Models
{
    public class Trait
    {
        public int TraitId { get; set; }
        [Required]
        public string Name { get; set; }

        // Character attributes
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
        public ICollection<CharacterTrait> Characters { get; set; }

        //Stretch
        // public List<Delegate> Contextuals;

        public static List<Character> GetCharacters()
        {
            var apiCallTask = ApiHelper.GetAll();
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<Character> characterList = JsonConvert.DeserializeObject<List<Character>>(jsonResponse.ToString());

            return characterList;
        }

        public static Character GetDetails(int id)
        {
            var apiCallTask = ApiHelper.Get(id);
            var result = apiCallTask.Result;

            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
            Character character = JsonConvert.DeserializeObject<Character>(jsonResponse.ToString());
            return character;
        }

        public static void Post(Character character)
        {
            string jsonCharacter = JsonConvert.SerializeObject(character);
            var apiCallTask = ApiHelper.Post(jsonCharacter);
        }

        public static void Put(Character character)
        {
            string jsonCharacter = JsonConvert.SerializeObject(character);
            var apiCallTask = ApiHelper.Put(character.CharacterId, jsonCharacter);
        }

        public static void Delete(int id)
        {
            var apiCallTask = ApiHelper.Delete(id);
        }
    }
}