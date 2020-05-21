using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using Newtonsoft.Json;

namespace FootballCalc.Models
{
    public class Players
    {
        //private List<PlayerInfo> lineCollection = new List<PlayerInfo>();
        //public virtual void AddItem(Players players)
        //{
        //    PlayerInfo line = lineCollection
        //    .Where(p => p.PlayerID == players)
        //    .FirstOrDefault();
        //    if (line == null)
        //    {
        //        lineCollection.Add(new PlayerInfo
        //        {
        //            PlayerID = players,
        //        });
        //    }
        //    else
        //    {
        //        line.Quantity += quantity;
        //    }
        //}

        //public virtual void AddItem(Players player)
        //{
        //    throw new NotImplementedException();
        //}

        //public virtual void RemoveLine(Players player)
        //{
        //    throw new NotImplementedException();
        //}

        //public virtual void Clear()
        //{
        //    throw new NotImplementedException();
        //}

        //public virtual void RemoveLine(Players player) =>
        //    lineCollection.RemoveAll(l => l.Product.ProductID == product.ProductID);

        //public virtual decimal ComputeTotalValue() =>
        //    lineCollection.Sum(e => e.Product.Price * e.Quantity);

        //public virtual void Clear() => lineCollection.Clear();

        //public virtual IEnumerable<Players> Lines => lineCollection;

        [Key]
        public int PlayerID { get; set; }
        public string PlayerName { get; set; }
        [StringLength(50)]
        [NotMapped]
        public string PlayerTeam { get; set; }
        [StringLength(50)]
        public int PlayerSalary { get; set; }
        public int PlayerPosition { get; set; }

    }
}
