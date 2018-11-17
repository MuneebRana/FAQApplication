using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FAQApplication.Models;

namespace FAQApplication.Controllers
{
    public class UserQuestionsController : ApiController
    {
        DBImplementation impl = new DBImplementation();

        //POST new question and return the whole list
        public List<UserQuestionsDomain> Post(UserQuestionsDomain question)
        {
            if (ModelState.IsValid)
            {
                bool userQuestion = impl.postQuestion(question);
                return impl.GetAllUserQuestions();
            }
            return null;
        }

        public List<UserQuestionsDomain> Get()
        {
            List<UserQuestionsDomain> list = impl.GetAllUserQuestions();
            return list;
        }
    }
}
