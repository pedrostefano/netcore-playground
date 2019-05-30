using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    [Table("T_CONNECTOR")]
    public class TConnector : BaseEntity
    {
        public string Name { get; set; }
        public bool Status { get; set; }
        public ICollection<TDatasource> Datasources { get; set; }
    }
}
