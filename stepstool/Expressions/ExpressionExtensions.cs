using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Linq.Expressions
{
    public static class ExpressionExtensions
    {
        #region Call
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MethodCallExpression Call(this MethodInfo method, Expression arg0)
            => Expression.Call(method, arg0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MethodCallExpression Call(this MethodInfo method, Expression arg0, Expression arg1)
            => Expression.Call(method, arg0, arg1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MethodCallExpression Call(this MethodInfo method, Expression arg0, Expression arg1, Expression arg2)
            => Expression.Call(method, arg0, arg1, arg2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MethodCallExpression Call(this MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3)
            => Expression.Call(method, arg0, arg1, arg2, arg3);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MethodCallExpression Call(this MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4)
            => Expression.Call(method, arg0, arg1, arg2, arg3, arg4);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MethodCallExpression Call(this MethodInfo method, params Expression[] arguments)
            => Expression.Call(method, arguments);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MethodCallExpression Call(this MethodInfo method, IEnumerable<Expression> arguments)
            => Expression.Call(method, arguments);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MethodCallExpression Call(this Expression instance, MethodInfo method)
            => Expression.Call(instance, method);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MethodCallExpression Call(this Expression instance, MethodInfo method, Expression arg0)
            => Expression.Call(instance, method, arg0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MethodCallExpression Call(this Expression instance, MethodInfo method, Expression arg0, Expression arg1)
            => Expression.Call(instance, method, arg0, arg1);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MethodCallExpression Call(this Expression instance, MethodInfo method, Expression arg0, Expression arg1, Expression arg2)
            => Expression.Call(instance, method, arg0, arg1, arg2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MethodCallExpression Call(this Expression instance, MethodInfo method, params Expression[] arguments)
            => Expression.Call(instance, method, arguments);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MethodCallExpression Call(this Expression instance, MethodInfo method, IEnumerable<Expression> arguments)
            => Expression.Call(instance, method, arguments);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MethodCallExpression Call(this Expression instance, string methodName, Type[] typeArguments, params Expression[] arguments)
            => Expression.Call(instance, methodName, typeArguments, arguments);
        #endregion

        #region Convert & ConvertChecked
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UnaryExpression Convert(this Expression expression, Type type)
            => Expression.Convert(expression, type);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UnaryExpression Convert(this Expression expression, Type type, MethodInfo method)
            => Expression.Convert(expression, type, method);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UnaryExpression Convert<T>(this Expression expression)
            => Expression.Convert(expression, typeof(T));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UnaryExpression Convert<T>(this Expression expression, MethodInfo method)
            => Expression.Convert(expression, typeof(T), method);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UnaryExpression ConvertChecked(this Expression expression, Type type)
            => Expression.ConvertChecked(expression, type);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UnaryExpression ConvertChecked(this Expression expression, Type type, MethodInfo method)
            => Expression.ConvertChecked(expression, type, method);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UnaryExpression ConvertChecked<T>(this Expression expression)
            => Expression.ConvertChecked(expression, typeof(T));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UnaryExpression ConvertChecked<T>(this Expression expression, MethodInfo method)
            => Expression.ConvertChecked(expression, typeof(T), method);
        #endregion

        #region Field
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MemberExpression Field(this Expression expression, FieldInfo field)
            => Expression.Field(expression, field);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MemberExpression Field(this Expression expression, string fieldName)
            => Expression.Field(expression, fieldName);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MemberExpression Field<T>(this Expression expression, string fieldName)
            => Expression.Field(expression, typeof(T), fieldName);
        #endregion

        #region Invoke
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InvocationExpression Invoke(this Expression expression, params Expression[] arguments)
            => Expression.Invoke(expression, arguments);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InvocationExpression Invoke(this Expression expression, IEnumerable<Expression> arguments)
            => Expression.Invoke(expression, arguments);
        #endregion

        #region Lambda
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LambdaExpression Lambda(this Expression body, params ParameterExpression[] parameters)
            => Expression.Lambda(body, parameters);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LambdaExpression Lambda(this Expression body, IEnumerable<ParameterExpression> parameters)
            => Expression.Lambda(body, parameters);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LambdaExpression Lambda(this Expression body, bool tailCall, params ParameterExpression[] parameters)
            => Expression.Lambda(body, tailCall, parameters);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LambdaExpression Lambda(this Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters)
            => Expression.Lambda(body, tailCall, parameters);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LambdaExpression Lambda(this Expression body, string name, params ParameterExpression[] parameters)
            => Expression.Lambda(body, name, parameters);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LambdaExpression Lambda(this Expression body, string name, IEnumerable<ParameterExpression> parameters)
            => Expression.Lambda(body, name, parameters);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LambdaExpression Lambda(this Expression body, string name, bool tailCall, params ParameterExpression[] parameters)
            => Expression.Lambda(body, name, tailCall, parameters);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LambdaExpression Lambda(this Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters)
            => Expression.Lambda(body, name, tailCall, parameters);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LambdaExpression Lambda(this Expression body, Type delegateType, params ParameterExpression[] parameters)
            => Expression.Lambda(delegateType, body, parameters);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LambdaExpression Lambda(this Expression body, Type delegateType, IEnumerable<ParameterExpression> parameters)
            => Expression.Lambda(delegateType, body, parameters);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LambdaExpression Lambda(this Expression body, Type delegateType, bool tailCall, params ParameterExpression[] parameters)
            => Expression.Lambda(delegateType, body, tailCall, parameters);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LambdaExpression Lambda(this Expression body, Type delegateType, bool tailCall, IEnumerable<ParameterExpression> parameters)
            => Expression.Lambda(delegateType, body, tailCall, parameters);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LambdaExpression Lambda(this Expression body, Type delegateType, string name, params ParameterExpression[] parameters)
            => Expression.Lambda(delegateType, body, name, parameters);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LambdaExpression Lambda(this Expression body, Type delegateType, string name, IEnumerable<ParameterExpression> parameters)
            => Expression.Lambda(delegateType, body, name, parameters);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LambdaExpression Lambda(this Expression body, Type delegateType, string name, bool tailCall, params ParameterExpression[] parameters)
            => Expression.Lambda(delegateType, body, name, tailCall, parameters);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LambdaExpression Lambda(this Expression body, Type delegateType, string name, bool tailCall, IEnumerable<ParameterExpression> parameters)
            => Expression.Lambda(delegateType, body, name, tailCall, parameters);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Expression<T> Lambda<T>(this Expression body, params ParameterExpression[] parameters)
            where T : Delegate
            => Expression.Lambda<T>(body, parameters);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Expression<T> Lambda<T>(this Expression body, IEnumerable<ParameterExpression> parameters)
            where T : Delegate
            => Expression.Lambda<T>(body, parameters);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Expression<T> Lambda<T>(this Expression body, bool tailCall, params ParameterExpression[] parameters)
            where T : Delegate
            => Expression.Lambda<T>(body, tailCall, parameters);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Expression<T> Lambda<T>(this Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters)
            where T : Delegate
            => Expression.Lambda<T>(body, tailCall, parameters);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Expression<T> Lambda<T>(this Expression body, string name, params ParameterExpression[] parameters)
            where T : Delegate
            => Expression.Lambda<T>(body, name, parameters);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Expression<T> Lambda<T>(this Expression body, string name, IEnumerable<ParameterExpression> parameters)
            where T : Delegate
            => Expression.Lambda<T>(body, name, parameters);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Expression<T> Lambda<T>(this Expression body, string name, bool tailCall, params ParameterExpression[] parameters)
            where T : Delegate
            => Expression.Lambda<T>(body, name, tailCall, parameters);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Expression<T> Lambda<T>(this Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters)
            where T : Delegate
            => Expression.Lambda<T>(body, name, tailCall, parameters);
        #endregion

        #region Property & PropertyOrField
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MemberExpression Property(this Expression expression, MethodInfo propertyAccessor)
            => Expression.Property(expression, propertyAccessor);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MemberExpression Property(this Expression expression, PropertyInfo property)
            => Expression.Property(expression, property);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MemberExpression Property(this Expression expression, string propertyName)
            => Expression.Property(expression, propertyName);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IndexExpression Property(this Expression expression, PropertyInfo indexer, params Expression[] arguments)
            => Expression.Property(expression, indexer, arguments);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IndexExpression Property(this Expression expression, PropertyInfo indexer, IEnumerable<Expression> arguments)
            => Expression.Property(expression, indexer, arguments);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IndexExpression Property(this Expression expression, string propertyName, params Expression[] arguments)
            => Expression.Property(expression, propertyName, arguments);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MemberExpression Property(this Expression expression, Type type, string propertyName)
            => Expression.Property(expression, type, propertyName);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MemberExpression PropertyOrField(this Expression expression, string propertyOrFieldName)
            => Expression.PropertyOrField(expression, propertyOrFieldName);
        #endregion
    }
}
