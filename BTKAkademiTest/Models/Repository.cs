namespace BTKAkademiTest.Models
{
    public static class Repository
    {
        private static List<Candidate> candidates = new List<Candidate>();
        public static IEnumerable<Candidate> Candidates => candidates;

        public static void Add(Candidate model)
        {
            candidates.Add(model);
        }
    }
}
