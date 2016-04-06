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
        public static int numVotesTanmayDharmaraj = 0;
        public static int numVotesDonaldTrump = 0;

        public override Task OnConnected()
        {
            Clients.All.upVote(new Vote() { TanmayDharmaraj = numVotesTanmayDharmaraj, DonaldTrump = numVotesDonaldTrump });
            return base.OnConnected();
        }
        public void UpVote(string myvote)
        {
            
            if(myvote == "TanmayDharmaraj")
            {
                numVotesTanmayDharmaraj++;
            }
            else if(myvote == "DonaldTrump")
            {
                numVotesDonaldTrump++;
            }
            
            Clients.All.upVote(new Vote() { TanmayDharmaraj = numVotesTanmayDharmaraj, DonaldTrump = numVotesDonaldTrump });
        }
    }
}