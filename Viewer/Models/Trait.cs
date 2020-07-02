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

        // Trait attributes
        [Required]
        [Range(-20, 20, ErrorMessage = "Stats go from 1 to 20.")]
        public int Might { get; set; }

        [Required]
        [Range(-20, 20, ErrorMessage = "Stats go from 1 to 20.")]
        public int Spryness { get; set; }

        [Required]
        [Range(-20, 20, ErrorMessage = "Stats go from 1 to 20.")]
        public int Judgement { get; set; }

        [Required]
        [Range(-20, 20, ErrorMessage = "Stats go from 1 to 20.")]
        public int Echo { get; set; }

        [Required]
        [Range(-20, 20, ErrorMessage = "Stats go from 1 to 20.")]
        public int Magnetism { get; set; }

        [Required]
        [Range(-20, 20, ErrorMessage = "Stats go from 1 to 20.")]
        public int Fortune { get; set; }
        public virtual ICollection<CharacterTrait> Characters { get; }

        //Stretch
        // public List<Delegate> Contextuals;
        public Trait()
        {
            this.Characters = new HashSet<CharacterTrait>();
        }

        public static List<Trait> GetTraits()
        {
            var apiCallTask = TraitApiHelper.GetAll();
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<Trait> traitList = JsonConvert.DeserializeObject<List<Trait>>(jsonResponse.ToString());

            return traitList;
        }

        public static Trait GetDetails(int id)
        {
            var apiCallTask = TraitApiHelper.Get(id);
            var result = apiCallTask.Result;

            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
            Trait trait = JsonConvert.DeserializeObject<Trait>(jsonResponse.ToString());
            return trait;
        }

        public static void Post(Trait trait)
        {
            string jsonTrait = JsonConvert.SerializeObject(trait);
            var apiCallTask = TraitApiHelper.Post(jsonTrait);
        }

        public static void Put(Trait trait)
        {
            string jsonTrait = JsonConvert.SerializeObject(trait);
            var apiCallTask = TraitApiHelper.Put(trait.TraitId, jsonTrait);
        }

        public static void Delete(int id)
        {
            var apiCallTask = TraitApiHelper.Delete(id);
        }
    }
}