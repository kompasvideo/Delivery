using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Delivery.Data.EF.Entity.DeliveryOrder
{
    /// <summary>
    /// Описывает таблицу грузополучателя, грузоотправителя
    /// пока только город
    /// </summary>
    public class Client
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientId { get; set; }
        /// <summary>
        /// город грузополучателя, грузоотправителя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// связь с таблицей Order
        /// </summary>
        [JsonIgnore]
        public List<Order> Order { get; set; }
        /// <summary>
        /// связь с таблицей Order
        /// </summary>
        [JsonIgnore]
        public List<Order> Order2 { get; set; }
    }
}
