using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Delivery.Data.EF.Entity.DeliveryOrder
{
    /// <summary>
    /// класс описывает таблицу курьеров
    /// пока только имя курьера
    /// </summary>
    public class Courier
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourierId { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public List<Order> Order { get; set; }
    }
}
