using System;

namespace projetop2ds3
{
    internal class MYSqlCommand
    {
        private string sql;
        private MysqlConnection conn;

        public MYSqlCommand(string sql, MysqlConnection conn)
        {
            this.sql = sql;
            this.conn = conn;
        }

        internal void BeginExecuteNonQuery()
        {
            throw new NotImplementedException();
        }
    }
}