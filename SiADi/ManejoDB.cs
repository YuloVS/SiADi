using System;
using SiADi.Modelo;

namespace SiADi
{
    public class ManejoDB
    {
        public void backup()
        {
            using (var db = new SiADiDB())
            {
                //string query = "BACKUP DATABASE SiADi TO DISK = 'D:SiADi"+DateTime.Today.ToString("yy-MM-dd")+".bak'";
                string query = "BACKUP DATABASE SiADi TO DISK = 'D:SiADi.bak'";
                db.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, query);
            }
        }
        
        public void restore()
        {
            using (var db = new SiADiDB())
            {
                db.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, "RESTORE DATABASE SiADi TO DISK = 'D:SiADi.bak'");
            }
        }
    }
}