using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameFramework
{
    /// <summary>
    /// 封装一个方法，该方法不具有参数并且不返回值。
    /// </summary>
    public delegate void GameFrameworkAction();

    /// <summary>
    /// 封装一个方法，该方法只有一个参数并且不返回值。
    /// </summary>
    /// <typeparam name="T">此委托封装的方法的参数类型。</typeparam>
    /// <param name="obj">此委托封装的方法的参数。</param>
    public delegate void GameFrameworkAction<in T>(T obj);

    /// <summary>
    /// 封装一个方法，该方法具有两个参数并且不返回值。
    /// </summary>
    /// <typeparam name="T1">此委托封装的方法的第一个参数的类型。</typeparam>
    /// <typeparam name="T2">此委托封装的方法的第二个参数的类型。</typeparam>
    /// <param name="arg1">此委托封装的方法的第一个参数。</param>
    /// <param name="arg2">此委托封装的方法的第二个参数。</param>
    public delegate void GameFrameworkAction<in T1, in T2>(T1 arg1, T2 arg2);

    /// <summary>
    /// 封装一个方法，该方法具有三个参数并且不返回值。
    /// </summary>
    /// <typeparam name="T1">此委托封装的方法的第一个参数的类型。</typeparam>
    /// <typeparam name="T2">此委托封装的方法的第二个参数的类型。</typeparam>
    /// <typeparam name="T3">此委托封装的方法的第三个参数的类型。</typeparam>
    /// <param name="arg1">此委托封装的方法的第一个参数。</param>
    /// <param name="arg2">此委托封装的方法的第二个参数。</param>
    /// <param name="arg3">此委托封装的方法的第三个参数。</param>
    public delegate void GameFrameworkAction<in T1, in T2, in T3>(T1 arg1, T2 arg2, T3 arg3);

    /// <summary>
    /// 封装一个方法，该方法具有四个参数并且不返回值。
    /// </summary>
    /// <typeparam name="T1">此委托封装的方法的第一个参数的类型。</typeparam>
    /// <typeparam name="T2">此委托封装的方法的第二个参数的类型。</typeparam>
    /// <typeparam name="T3">此委托封装的方法的第三个参数的类型。</typeparam>
    /// <typeparam name="T4">此委托封装的方法的第四个参数的类型。</typeparam>
    /// <param name="arg1">此委托封装的方法的第一个参数。</param>
    /// <param name="arg2">此委托封装的方法的第二个参数。</param>
    /// <param name="arg3">此委托封装的方法的第三个参数。</param>
    /// <param name="arg4">此委托封装的方法的第四个参数。</param>
    public delegate void GameFrameworkAction<in T1, in T2, in T3, in T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4);

    /// <summary>
    /// 封装一个方法，该方法具有五个参数并且不返回值。
    /// </summary>
    /// <typeparam name="T1">此委托封装的方法的第一个参数的类型。</typeparam>
    /// <typeparam name="T2">此委托封装的方法的第二个参数的类型。</typeparam>
    /// <typeparam name="T3">此委托封装的方法的第三个参数的类型。</typeparam>
    /// <typeparam name="T4">此委托封装的方法的第四个参数的类型。</typeparam>
    /// <typeparam name="T5">此委托封装的方法的第五个参数的类型。</typeparam>
    /// <param name="arg1">此委托封装的方法的第一个参数。</param>
    /// <param name="arg2">此委托封装的方法的第二个参数。</param>
    /// <param name="arg3">此委托封装的方法的第三个参数。</param>
    /// <param name="arg4">此委托封装的方法的第四个参数。</param>
    /// <param name="arg5">此委托封装的方法的第五个参数。</param>
    public delegate void GameFrameworkAction<in T1, in T2, in T3, in T4, in T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);

    /// <summary>
    /// 封装一个方法，该方法具有六个参数并且不返回值。
    /// </summary>
    /// <typeparam name="T1">此委托封装的方法的第一个参数的类型。</typeparam>
    /// <typeparam name="T2">此委托封装的方法的第二个参数的类型。</typeparam>
    /// <typeparam name="T3">此委托封装的方法的第三个参数的类型。</typeparam>
    /// <typeparam name="T4">此委托封装的方法的第四个参数的类型。</typeparam>
    /// <typeparam name="T5">此委托封装的方法的第五个参数的类型。</typeparam>
    /// <typeparam name="T6">此委托封装的方法的第六个参数的类型。</typeparam>
    /// <param name="arg1">此委托封装的方法的第一个参数。</param>
    /// <param name="arg2">此委托封装的方法的第二个参数。</param>
    /// <param name="arg3">此委托封装的方法的第三个参数。</param>
    /// <param name="arg4">此委托封装的方法的第四个参数。</param>
    /// <param name="arg5">此委托封装的方法的第五个参数。</param>
    /// <param name="arg6">此委托封装的方法的第六个参数。</param>
    public delegate void GameFrameworkAction<in T1, in T2, in T3, in T4, in T5, in T6>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);

    /// <summary>
    /// 封装一个方法，该方法具有七个参数并且不返回值。
    /// </summary>
    /// <typeparam name="T1">此委托封装的方法的第一个参数的类型。</typeparam>
    /// <typeparam name="T2">此委托封装的方法的第二个参数的类型。</typeparam>
    /// <typeparam name="T3">此委托封装的方法的第三个参数的类型。</typeparam>
    /// <typeparam name="T4">此委托封装的方法的第四个参数的类型。</typeparam>
    /// <typeparam name="T5">此委托封装的方法的第五个参数的类型。</typeparam>
    /// <typeparam name="T6">此委托封装的方法的第六个参数的类型。</typeparam>
    /// <typeparam name="T7">此委托封装的方法的第七个参数的类型。</typeparam>
    /// <param name="arg1">此委托封装的方法的第一个参数。</param>
    /// <param name="arg2">此委托封装的方法的第二个参数。</param>
    /// <param name="arg3">此委托封装的方法的第三个参数。</param>
    /// <param name="arg4">此委托封装的方法的第四个参数。</param>
    /// <param name="arg5">此委托封装的方法的第五个参数。</param>
    /// <param name="arg6">此委托封装的方法的第六个参数。</param>
    /// <param name="arg7">此委托封装的方法的第七个参数。</param>
    public delegate void GameFrameworkAction<in T1, in T2, in T3, in T4, in T5, in T6, in T7>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);

    /// <summary>
    /// 封装一个方法，该方法具有八个参数并且不返回值。
    /// </summary>
    /// <typeparam name="T1">此委托封装的方法的第一个参数的类型。</typeparam>
    /// <typeparam name="T2">此委托封装的方法的第二个参数的类型。</typeparam>
    /// <typeparam name="T3">此委托封装的方法的第三个参数的类型。</typeparam>
    /// <typeparam name="T4">此委托封装的方法的第四个参数的类型。</typeparam>
    /// <typeparam name="T5">此委托封装的方法的第五个参数的类型。</typeparam>
    /// <typeparam name="T6">此委托封装的方法的第六个参数的类型。</typeparam>
    /// <typeparam name="T7">此委托封装的方法的第七个参数的类型。</typeparam>
    /// <typeparam name="T8">此委托封装的方法的第八个参数的类型。</typeparam>
    /// <param name="arg1">此委托封装的方法的第一个参数。</param>
    /// <param name="arg2">此委托封装的方法的第二个参数。</param>
    /// <param name="arg3">此委托封装的方法的第三个参数。</param>
    /// <param name="arg4">此委托封装的方法的第四个参数。</param>
    /// <param name="arg5">此委托封装的方法的第五个参数。</param>
    /// <param name="arg6">此委托封装的方法的第六个参数。</param>
    /// <param name="arg7">此委托封装的方法的第七个参数。</param>
    /// <param name="arg8">此委托封装的方法的第八个参数。</param>
    public delegate void GameFrameworkAction<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);
}
