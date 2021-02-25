using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using ByPassTheMovieAPI.VO;
using Microsoft.AspNetCore.Authorization;


namespace ByPassTheMovieAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/"), Authorize]
    public class TopRatedController : Controller
    {

        public IEnumerable<NameFilmVO> Get()
        {
            var topRatedCliente = new RestClient("https://api.themoviedb.org/3/movie/top_rated?api_key=791bf1768d1e08c597a8365d2203431d");
            var request = new RestRequest(Method.GET);
            IRestResponse response = topRatedCliente.Execute<ResultTopRated>(request);
            ResultTopRated result = JsonConvert.DeserializeObject<ResultTopRated>(response.Content);
            var topRatedResponse = result.results.ToList();

            List<NameFilmVO> resultNameFilmVO = new List<NameFilmVO>();

            foreach(TopRatedResponse tRR in topRatedResponse)
            {
                string titleinvert = new string (tRR.Title.Reverse().ToArray());
                titleinvert = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(titleinvert.ToLower());
                string titleOrig = new string(tRR.Title);
  
                resultNameFilmVO.Add(new NameFilmVO { Title = titleOrig, TitleIvers = titleinvert });
            }

            return resultNameFilmVO;
        }
    }
}

