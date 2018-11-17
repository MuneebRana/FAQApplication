﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FAQApplication.Models
{
    public class DBInit : DropCreateDatabaseAlways<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            var question1 = new FAQ
            {
                Id = 1,
                Question = "What do I do if I cannot buy a movie?",
                Answer = "Send message to one of the admins at admin@cinemacity.com",
            };
            context.FAQ.Add(question1);

            var question2 = new FAQ
            {
                Id = 2,
                Question = "Are movies one time purchase only?",
                Answer = "Yes. Once you buy a movie, you do not need to buy it again.",
            };
            context.FAQ.Add(question2);

            var question3 = new FAQ
            {
                Id = 3,
                Question = "I have bought a movie but I cannot access it",
                Answer = "Try deleting cache of your browser and if that does not work, message an admin at admin@cinemacity.com",
            };
            context.FAQ.Add(question3);

            var question4 = new FAQ
            {
                Id = 4,
                Question = "Can I rewatch movies I have bought?",
                Answer = "Once you buy a movie you can watch them as many times as you wish",
            };
            context.FAQ.Add(question4);
            var question5 = new FAQ
            {
                Id = 5,
                Question = "How often does CinemaCity update your movie library?",
                Answer = "We update it once a month, usually 2 weeks into the month",
            };
            context.FAQ.Add(question5);
            var question6 = new FAQ
            {
                Id = 6,
                Question = "Will CinemaCity add series?",
                Answer = "We are currently working on it. The series option should be available relatively soon!",
            };
            context.FAQ.Add(question6);
            var question7 = new FAQ
            {
                Id = 7,
                Question = "Why do you think we should choose CinemaCity compared to for example Netflix or HBO?",
                Answer = "We are surely cheaper and have a lot more variety!",
            };
            context.FAQ.Add(question7);

            var userquestion1 = new UserQuestions
            {
                Id = 1,
                Question = "Why do you guys not have Venom added to the store?",
                Rating = 150
            };
            context.UserQuestions.Add(userquestion1);

            var userquestion2 = new UserQuestions
            {
                Id = 2,
                Question = "Will you guys have 4k functionality?",
                Rating = 75
            };
            context.UserQuestions.Add(userquestion2);

            var userquestion3 = new UserQuestions
            {
                Id = 3,
                Question = "Why is CinemaCity website so bad? Everything is so buggy",
                Rating = -300
            };
            context.UserQuestions.Add(userquestion3);

            var userquestion4 = new UserQuestions
            {
                Id = 1,
                Question = "Can I donate to CinemaCity in some way? You guys are really doing a good job here",
                Rating = 30
            };
            context.UserQuestions.Add(userquestion4);
            base.Seed(context);
        }
    }
}