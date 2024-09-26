using System.Runtime.Serialization;

namespace Inventory_System_MVC.Models
{
    public class Equipment
    {
        
        public int EquipmentID { get; set; }
       
        public string Name { get; set; }
        
        public int EcCount { get; set; }

        public int Stock { get; set; }
       
        public DateTime EntryDate { get; set; }

    }
}
