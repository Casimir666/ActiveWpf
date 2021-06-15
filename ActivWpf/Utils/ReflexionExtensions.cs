using System.Reflection;
using System.Threading.Tasks;

namespace ActivWpf.Utils
{
    static class ReflexionExtensions
    {
        public static TResult GetPrivateField<TObject, TResult>(this object obj, string fieldName)
            where TObject : class
            where TResult : class
        {
            var memberInfo = typeof(TObject).GetField(fieldName, BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.Instance);
            return memberInfo?.GetValue(obj) as TResult;
        }

        public static Task<T> InvokePrivateAsync<T>(this object obj, string methodName, params object[] parameters)
        {
            var method = obj.GetType().GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.Instance);
            return method?.Invoke(obj, parameters) as Task<T>;
        }
    }
}
