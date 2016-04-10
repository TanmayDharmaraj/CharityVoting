using CharityVoting.Models;
using Microsoft.AspNet.SignalR;
using Newtonsoft.Json;
using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace CharityVoting.Hubs
{
    public class VotingHub : Hub
    {
        public static int numVotesVote1 = 0;
        public static int numVotesVote2 = 0;
        public static int numVotesVote3 = 0;

        public override Task OnConnected()
        {
            Clients.All.upVote(new Vote() { Vote1 = numVotesVote1, Vote2 = numVotesVote2, Vote3 = numVotesVote3 });
            return base.OnConnected();
        }
        public void UpVote(string myvote)
        {
            switch (myvote)
            {
                case "Vote1":
                    numVotesVote1++;
                    break;
                case "Vote2":
                    numVotesVote2++;
                    break;
                case "Vote3":
                    numVotesVote3++;
                    break;
            }
            Clients.All.upVote(new Vote() { Vote1 = numVotesVote1, Vote2 = numVotesVote2, Vote3 = numVotesVote3 });
        }
    }
}