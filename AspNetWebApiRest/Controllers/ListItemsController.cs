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
        public IEnumerable<string> Get()
        {
            return new string[] { "1", "2", "3" };
        }

        public string Get(int id)
        {
            string s;
            switch (id)
            {
                case 1:
                    s = "1";
                    break;
                case 2:
                    s = "2";
                    break;
                case 3:
                    s = "3";
                    break;
                case 4:
                    s = "4";
                    break;
                default:
                    s = "0";
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