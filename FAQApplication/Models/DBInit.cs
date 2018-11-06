using System;
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
                Id = 4,
                Question = "Can I rewatch movies I have bought?",
                Answer = "Once you buy a movie you can watch them as many times as you wish",
            };
            context.FAQ.Add(question5);

            var question6 = new FAQ
            {
                Id = 4,
                Question = "Can I rewatch movies I have bought?",
                Answer = "Once you buy a movie you can watch them as many times as you wish",
            };
            context.FAQ.Add(question6);

            base.Seed(context);
        }
    }
}