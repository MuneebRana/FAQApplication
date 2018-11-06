using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;
using FAQApplication.Models;

namespace FAQApplication.Controllers
{
    public class FAQController : ApiController
    {
        DBImplementation impl = new DBImplementation();

        //GET all FAQ questions and answers
        public List<FAQDomain> Get()
        {
            List<FAQDomain> faqList = impl.GetAllFAQQuestions();
            return faqList;
        }

     /*   public List<FAQDomain> Get(int id)
        {
            List<FAQDomain> answerList = impl.GetFAQAnswers();
            return answerList;
        }*/

    }
}
