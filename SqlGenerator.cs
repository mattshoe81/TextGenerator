namespace TextGenerator
{
    class SqlGenerator
    {
        public enum SqlAction
        {
            UPDATE,
            INSERT,
            QUERY,
            DELETE
        }

        public string Text { get; set; }
        public SqlAction Action { get; set; }

        public SqlGenerator()
        {
        }

    }
}
