using System;
using FootballCalc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Infrastructure;

namespace FootballCalc.Models
{
    public class SessionPlayer : Players
    {
        public static Players GetPlayers(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
            .HttpContext.Session;
            SessionPlayer players = session?.GetJson<SessionPlayer>("Players")
            ?? new SessionPlayer();
            players.Session = session;
            return players;
        }
        [JsonIgnore]
        public ISession Session { get; set; }
        public override void AddItem(Players players)
        {
            base.AddItem(players);
            Session.SetJson("Players", this);
        }
        public override void RemoveLine(Players players)
        {
            base.RemoveLine(players);
            Session.SetJson("Cart", this);
        }
        public override void Clear()
        {
            base.Clear();
            Session.Remove("Players");
        }
    }
}