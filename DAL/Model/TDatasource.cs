using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model
{
    [Table("T_DATASOURCE")]
    public class TDatasource : BaseEntity
    {
        public string Name { get; set; }
        public bool Status { get; set; }
        public long ConnectorId { get; set; }
        public TConnector Connector { get; set; }
    }
}
