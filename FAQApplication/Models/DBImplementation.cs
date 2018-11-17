using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FAQApplication.Models;

namespace FAQApplication.Models
{
    public class DBImplementation
    {
        public List<FAQDomain> GetAllFAQQuestions()
        {
            DatabaseContext db = new DatabaseContext();
            try
            {
                List<FAQDomain> allFAQs = db.FAQ.Select(k => new FAQDomain()
                {
                    Id = k.Id,
                    Question = k.Question,
                    Answer = k.Answer
                }).ToList();
                return allFAQs;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                return null;
            }
        }

        public List<UserQuestionsDomain> GetAllUserQuestions()
        {
            DatabaseContext db = new DatabaseContext();
            try
            {
                List<UserQuestionsDomain> allUserQuestions = db.UserQuestions.Select(k => new UserQuestionsDomain()
                {
                    Id = k.Id,
                    Question = k.Question,
                    Rating = k.Rating
                }).OrderByDescending(o => o.Rating).ToList();
                return allUserQuestions;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                return null;
            }
        }

        public bool postQuestion(UserQuestionsDomain question)
        {
            var newQuestion = new UserQuestions()
            {
                Id = question.Id,
                Question = question.Question,
                Rating = question.Rating
            };
            DatabaseContext db = new DatabaseContext();
                try
                {
                    db.UserQuestions.Add(newQuestion);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
        }

        public bool changeRating(int id, int rating)
        {
            DatabaseContext db = new DatabaseContext();
            UserQuestions changedQuestion = db.UserQuestions.Find(id);
            try
            {
                changedQuestion.Rating  = rating;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}