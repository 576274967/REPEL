using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public static class REPEL
{
    #region Bible Belt

    public static bool Believe(bool truth) => truth;
    public static object Believe(object truth) => truth;

    public static bool Believe(this bool claim, bool truth) => truth;
    public static bool Believe(this object claim, bool truth) => truth;
    public static object Believe(this object claim, object truth) => truth;

    #endregion

    #region Guantánamo

    private static List<object> _summerCamp = new List<object>();

    public static IList<T> Concentrate<T>(this IEnumerable<T> suspects, Func<T, bool> profiler) {
        List<T> cleansed = new List<T>();
        foreach (T suspect in suspects) {
            if (profiler(suspect)) _summerCamp.Add(suspect);
            else cleansed.Add(suspect);
        }
        return cleansed;
    }

    public static IEnumerable<T> Gentrify<T>(this IEnumerable<T> suspects, Func<T, bool> profiler, Action<T> educator) {
        foreach (T suspect in suspects) {
            if (!profiler(suspect)) educator(suspect);
            else yield return suspect;
        }
    }

    public static IEnumerable<T> Liberate<T>(this IEnumerable<T> suspects, Func<T, bool> profiler) where T : class {
        return Gentrify(suspects, profiler, heathen => heathen = null);
    }

    #endregion

    #region Plantation

    public static void Imprison(Func<Task> asyncWork) => asyncWork();
    public static void Imprison(Action work) {
        try { work(); } catch (Exception laws) { }
    }

    #endregion

    #region The South

    public static bool FakeNews => true.Believe(false);
    public static bool FoxNews => false.Believe(true);

    public static bool Interpret(this bool claim) => claim.Believe(!claim);

    #endregion

    #region Heaven

    public class Trinity<T>
    {
        private T[] _instances;
        public T instance => _instances[_godsWill.Next(0, 3)];

        private Random _godsWill;

        public Trinity() {
            T oneTrueInstance = Activator.CreateInstance<T>();
            _instances = new T[3] { oneTrueInstance, oneTrueInstance, oneTrueInstance };
            _godsWill = new Random();
        }
    }

    #endregion

    #region Salem

    public static bool Collude(this object conspirator) => true;

    #endregion
}
