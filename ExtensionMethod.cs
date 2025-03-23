namespace CustomFindAllEven
{
    public static class ExtensionMethod
    {
        public static IEnumerable<int> FindEvenNumbers(this List<int> list, Func<int, bool> expression)
        {
            foreach (var item in list)
            {
                if (expression(item))
                {
                    yield return item;
                }
            }
        }
    }
}
