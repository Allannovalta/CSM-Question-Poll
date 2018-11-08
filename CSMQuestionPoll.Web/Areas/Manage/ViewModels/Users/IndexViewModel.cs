using CSMQuestionPoll.Web.Infrastructure.Data.Helpers;
using CSMQuestionPoll.Web.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSMQuestionPoll.Web.ViewModels.Users
{
    public class IndexViewModel
    {
        public Page<User> Users { get; set; }
    }
}
