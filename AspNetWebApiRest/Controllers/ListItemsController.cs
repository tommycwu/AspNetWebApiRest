using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AspNetWebApiRest.Models;

namespace AspNetWebApiRest.Controllers
{
    [Authorize]
    public class ListItemsController : ApiController
    {
        private static List<CustomListItem> _listItems { get; set; } = new List<CustomListItem>();

        //GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "1", "2", "3", "4" };
        //}

        public string Get(string id)
        {
            string s;
            switch (id)
            {
                case "111-22-3333":
                    s = "ssn:111-22-3333, mrn:101, beneficiary:none, prescription:tylenol";
                    break;
                case "555-66-7777":
                    s = "ssn:555-66-7777, mrn:102, beneficiary:spouse, prescription:asprin";
                    break;
                case "888-99-0000":
                    s = "ssn:888-99-0000, mrn:103, beneficiary:children, prescription:ibuprofen:";
                    break;
                case "123-45-6789":
                    s = "ssn:123-45-6789, mrn:104, beneficiary:parents, prescription:none";
                    break;
                default:
                    s = "medical record not found";
                    break;
            }
            return s;
        }

        //POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        //PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        //DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}