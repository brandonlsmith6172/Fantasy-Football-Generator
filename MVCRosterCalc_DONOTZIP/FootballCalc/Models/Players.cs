using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FootballCalc.Models
{
    public class Players
    {
        //private List<CartLine> lineCollection = new List<CartLine>();
        //public virtual void AddItem(Product product, int quantity)
        //{
        //    CartLine line = lineCollection
        //    .Where(p => p.Product.ProductID == product.ProductID)
        //    .FirstOrDefault();
        //    if (line == null)
        //    {
        //        lineCollection.Add(new CartLine
        //        {
        //            Product = product,
        //            Quantity = quantity
        //        });
        //    }
        //    else
        //    {
        //        line.Quantity += quantity;
        //    }
        //}

        public virtual void AddItem(Players player)
        {
            throw new NotImplementedException();
        }

        public virtual void RemoveLine(Players player)
        {
            throw new NotImplementedException();
        }

        public virtual void Clear()
        {
            throw new NotImplementedException();
        }

        //public virtual void RemoveLine(Player player) =>
        //    lineCollection.RemoveAll(l => l.Product.ProductID == product.ProductID);

        //public virtual decimal ComputeTotalValue() =>
        //    lineCollection.Sum(e => e.Product.Price * e.Quantity);

        //public virtual void Clear() => lineCollection.Clear();

        //public virtual IEnumerable<CartLine> Lines => lineCollection;

        [Key]
        public int PlayerID { get; set; }
        public int RosterID { get; set; }
        public string PlayerName { get; set; }
        [StringLength(50)]
        [NotMapped]
        public string PlayerTeam { get; set; }
        [StringLength(50)]
        public int PlayerSalary { get; set; }
        public string PlayerPosition { get; set; }

    }
}
