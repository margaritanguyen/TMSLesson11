using System.Linq;

namespace TMSLesson11
{
    public static class GenericAggregateClass<T> where T : struct
    {
        public static T Max(T a, T b, T c)
        {
            T[] array = {a, b, c};
            return array.Max();
        }
    }
}
