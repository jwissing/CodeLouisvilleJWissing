using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WissingCodeLouisvilleProject1.Models;

namespace WissingCodeLouisvilleProject1.DAL
{
    public class InterviewInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<InterviewContext>
    {
        protected override void Seed(InterviewContext context)
        {
            var interviews = new List<Interview>
            {
                new Interview {InterviewerFirstName="Bob",InterviewerLastName="Buckner",IntervieweeFirstName="Terry",IntervieweeLastName="Jones",Location="Louisville, KY",EventName="Small Trade Show",Date=DateTime.Parse("03/24/2016"),Duration=150,Notes="Terry talks about new product" },
                new Interview {InterviewerFirstName="Tom",InterviewerLastName="McDonald",IntervieweeFirstName="Jon",IntervieweeLastName="Jacob",Location="Nashville, TN",EventName="Medium Trade Show",Date=DateTime.Parse("01/13/2016"),Duration=139,Notes="Jon introduces new system" },
                new Interview {InterviewerFirstName="Lisa",InterviewerLastName="Finch",IntervieweeFirstName="Mario",IntervieweeLastName="Pribble",Location="Indianapolis, IN",EventName="Big Trade Show",Date=DateTime.Parse("09/02/2015"),Duration=114,Notes="Mario gives product demo" },
                new Interview {InterviewerFirstName="Sarah",InterviewerLastName="Buckner",IntervieweeFirstName="Randy",IntervieweeLastName="Scott",Location="Cincinnati, OH",EventName="Press Event",Date=DateTime.Parse("02/09/2016"),Duration=298,Notes="Randy debuts new concept design" },
                new Interview {InterviewerFirstName="Bob",InterviewerLastName="Buckner",IntervieweeFirstName="James",IntervieweeLastName="Goss",Location="Louisville, KY",EventName="Small Trade Show",Date=DateTime.Parse("03/22/2016"),Duration=120,Notes="James talks about next year" },
                
            };

            interviews.ForEach(s => context.Interviews.Add(s));
            context.SaveChanges();
            
        }
    }
}