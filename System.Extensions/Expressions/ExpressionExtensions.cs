using System.Collections.Generic;
using System.Reflection;

namespace System.Linq.Expressions
{
    public static class ExpressionExtensions
    {
        #region Convert & ConvertChecked
        public static UnaryExpression Convert(this Expression expression, Type type)
            => Expression.Convert(expression, type);

        public static UnaryExpression Convert(this Expression expression, Type type, MethodInfo method)
            => Expression.Convert(expression, type, method);

        public static UnaryExpression Convert<T>(this Expression expression)
            => Expression.Convert(expression, typeof(T));

        public static UnaryExpression Convert<T>(this Expression expression, MethodInfo method)
            => Expression.Convert(expression, typeof(T), method);

        public static UnaryExpression ConvertChecked(this Expression expression, Type type)
            => Expression.ConvertChecked(expression, type);

        public static UnaryExpression ConvertChecked(this Expression expression, Type type, MethodInfo method)
            => Expression.ConvertChecked(expression, type, method);

        public static UnaryExpression ConvertChecked<T>(this Expression expression)
            => Expression.ConvertChecked(expression, typeof(T));

        public static UnaryExpression ConvertChecked<T>(this Expression expression, MethodInfo method)
            => Expression.ConvertChecked(expression, typeof(T), method);
        #endregion

        #region Lambda
        public static LambdaExpression Lambda(this Expression body, params ParameterExpression[] parameters)
            => Expression.Lambda(body, parameters);

        public static LambdaExpression Lambda(this Expression body, IEnumerable<ParameterExpression> parameters)
            => Expression.Lambda(body, parameters);

        public static LambdaExpression Lambda(this Expression body, bool tailCall, params ParameterExpression[] parameters)
            => Expression.Lambda(body, tailCall, parameters);

        public static LambdaExpression Lambda(this Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters)
            => Expression.Lambda(body, tailCall, parameters);

        public static LambdaExpression Lambda(this Expression body, string name, params ParameterExpression[] parameters)
            => Expression.Lambda(body, name, parameters);

        public static LambdaExpression Lambda(this Expression body, string name, IEnumerable<ParameterExpression> parameters)
            => Expression.Lambda(body, name, parameters);

        public static LambdaExpression Lambda(this Expression body, string name, bool tailCall, params ParameterExpression[] parameters)
            => Expression.Lambda(body, name, tailCall, parameters);

        public static LambdaExpression Lambda(this Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters)
            => Expression.Lambda(body, name, tailCall, parameters);

        public static LambdaExpression Lambda(this Expression body, Type delegateType, params ParameterExpression[] parameters)
            => Expression.Lambda(delegateType, body, parameters);

        public static LambdaExpression Lambda(this Expression body, Type delegateType, IEnumerable<ParameterExpression> parameters)
            => Expression.Lambda(delegateType, body, parameters);

        public static LambdaExpression Lambda(this Expression body, Type delegateType, bool tailCall, params ParameterExpression[] parameters)
            => Expression.Lambda(delegateType, body, tailCall, parameters);

        public static LambdaExpression Lambda(this Expression body, Type delegateType, bool tailCall, IEnumerable<ParameterExpression> parameters)
            => Expression.Lambda(delegateType, body, tailCall, parameters);

        public static LambdaExpression Lambda(this Expression body, Type delegateType, string name, params ParameterExpression[] parameters)
            => Expression.Lambda(delegateType, body, name, parameters);

        public static LambdaExpression Lambda(this Expression body, Type delegateType, string name, IEnumerable<ParameterExpression> parameters)
            => Expression.Lambda(delegateType, body, name, parameters);

        public static LambdaExpression Lambda(this Expression body, Type delegateType, string name, bool tailCall, params ParameterExpression[] parameters)
            => Expression.Lambda(delegateType, body, name, tailCall, parameters);

        public static LambdaExpression Lambda(this Expression body, Type delegateType, string name, bool tailCall, IEnumerable<ParameterExpression> parameters)
            => Expression.Lambda(delegateType, body, name, tailCall, parameters);

        public static Expression<T> Lambda<T>(this Expression body, params ParameterExpression[] parameters)
            where T : Delegate
            => Expression.Lambda<T>(body, parameters);

        public static Expression<T> Lambda<T>(this Expression body, IEnumerable<ParameterExpression> parameters)
            where T : Delegate
            => Expression.Lambda<T>(body, parameters);

        public static Expression<T> Lambda<T>(this Expression body, bool tailCall, params ParameterExpression[] parameters)
            where T : Delegate
            => Expression.Lambda<T>(body, tailCall, parameters);

        public static Expression<T> Lambda<T>(this Expression body, bool tailCall, IEnumerable<ParameterExpression> parameters)
            where T : Delegate
            => Expression.Lambda<T>(body, tailCall, parameters);

        public static Expression<T> Lambda<T>(this Expression body, string name, params ParameterExpression[] parameters)
            where T : Delegate
            => Expression.Lambda<T>(body, name, parameters);

        public static Expression<T> Lambda<T>(this Expression body, string name, IEnumerable<ParameterExpression> parameters)
            where T : Delegate
            => Expression.Lambda<T>(body, name, parameters);

        public static Expression<T> Lambda<T>(this Expression body, string name, bool tailCall, params ParameterExpression[] parameters)
            where T : Delegate
            => Expression.Lambda<T>(body, name, tailCall, parameters);

        public static Expression<T> Lambda<T>(this Expression body, string name, bool tailCall, IEnumerable<ParameterExpression> parameters)
            where T : Delegate
            => Expression.Lambda<T>(body, name, tailCall, parameters);
        #endregion

        #region Property & PropertyOrField
        public static MemberExpression Property(this Expression expression, MethodInfo propertyAccessor)
            => Expression.Property(expression, propertyAccessor);

        public static MemberExpression Property(this Expression expression, PropertyInfo property)
            => Expression.Property(expression, property);

        public static MemberExpression Property(this Expression expression, string propertyName)
            => Expression.Property(expression, propertyName);

        public static IndexExpression Property(this Expression expression, PropertyInfo indexer, params Expression[] arguments)
            => Expression.Property(expression, indexer, arguments);

        public static IndexExpression Property(this Expression expression, PropertyInfo indexer, IEnumerable<Expression> arguments)
            => Expression.Property(expression, indexer, arguments);

        public static IndexExpression Property(this Expression expression, string propertyName, params Expression[] arguments)
            => Expression.Property(expression, propertyName, arguments);

        public static MemberExpression Property(this Expression expression, Type type, string propertyName)
            => Expression.Property(expression, type, propertyName);

        public static MemberExpression PropertyOrField(this Expression expression, string propertyOrFieldName)
            => Expression.PropertyOrField(expression, propertyOrFieldName);
        #endregion
    }
}
