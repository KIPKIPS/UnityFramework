using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

//框架主要扩展方法
public static class KExtension {
    /// <summary>
    /// 获取特性
    /// </summary>
    /// <param name="obj"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T GetAttribute<T>(this object obj) where T:Attribute{
        return obj.GetType().GetCustomAttribute<T>();
    }
    /// <summary>
    /// 获取特性
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="type">特性所在的类型</param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T GetAttribute<T>(this object obj,Type type) where T:Attribute{
        return type.GetCustomAttribute<T>();
    }
}