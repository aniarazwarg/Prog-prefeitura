using System;
using System.Data;

namespace projetop2ds3
{
    internal class MysqlConnection
    {
        private string mySqlString;

        public ConnectionState State { get; internal set; }

        public MysqlConnection(string mySqlString)
        {
            this.mySqlString = mySqlString;
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }
    }
}