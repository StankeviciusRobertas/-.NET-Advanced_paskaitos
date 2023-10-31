namespace Advanced._14.AsyncProgramming
{
    public class Kitchen
    {
        public async Task<IEnumerable<Meal>> PrepareAsyncImitacija(IEnumerable<Meal> orders)
        {
            var patiekalai = new List<Meal>();
            foreach (var o in orders)
            {
                var patiekalas = await o.Prepare();
                patiekalai.Add(patiekalas);
            }
            return patiekalai;
        }

        public async Task<IEnumerable<Meal>> Prepare(IEnumerable<Meal> orders)
        {
            return await Task.WhenAll(orders.Select(o => o.Prepare()));
        }
    }
}