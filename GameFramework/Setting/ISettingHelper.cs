﻿//------------------------------------------------------------
// Game Framework v3.x
// Copyright © 2013-2017 Jiang Yin. All rights reserved.
// Homepage: http://gameframework.cn/
// Feedback: mailto:jiangyin@gameframework.cn
//------------------------------------------------------------

using System;

namespace GameFramework.Setting
{
    /// <summary>
    /// 配置管理器辅助器接口。
    /// </summary>
    public interface ISettingHelper
    {
        /// <summary>
        /// 保存配置。
        /// </summary>
        void Save();

        /// <summary>
        /// 检查是否存在指定配置项。
        /// </summary>
        /// <param name="key">要检查配置项的名称。</param>
        /// <returns>指定的配置项是否存在。</returns>
        bool HasKey(string key);

        /// <summary>
        /// 移除指定配置项。
        /// </summary>
        /// <param name="key">要移除配置项的名称。</param>
        void RemoveKey(string key);

        /// <summary>
        /// 清空所有配置项。
        /// </summary>
        void RemoveAllKeys();

        /// <summary>
        /// 从指定配置项中读取布尔值。
        /// </summary>
        /// <param name="key">要获取配置项的名称。</param>
        /// <returns>读取的布尔值。</returns>
        bool GetBool(string key);

        /// <summary>
        /// 从指定配置项中读取布尔值。
        /// </summary>
        /// <param name="key">要获取配置项的名称。</param>
        /// <param name="defaultValue">当指定的配置项不存在时，返回此默认值。</param>
        /// <returns>读取的布尔值。</returns>
        bool GetBool(string key, bool defaultValue);

        /// <summary>
        /// 向指定配置项写入布尔值。
        /// </summary>
        /// <param name="key">要写入配置项的名称。</param>
        /// <param name="value">要写入的布尔值。</param>
        void SetBool(string key, bool value);

        /// <summary>
        /// 从指定配置项中读取整数值。
        /// </summary>
        /// <param name="key">要获取配置项的名称。</param>
        /// <returns>读取的整数值。</returns>
        int GetInt(string key);

        /// <summary>
        /// 从指定配置项中读取整数值。
        /// </summary>
        /// <param name="key">要获取配置项的名称。</param>
        /// <param name="defaultValue">当指定的配置项不存在时，返回此默认值。</param>
        /// <returns>读取的整数值。</returns>
        int GetInt(string key, int defaultValue);

        /// <summary>
        /// 向指定配置项写入整数值。
        /// </summary>
        /// <param name="key">要写入配置项的名称。</param>
        /// <param name="value">要写入的整数值。</param>
        void SetInt(string key, int value);

        /// <summary>
        /// 从指定配置项中读取浮点数值。
        /// </summary>
        /// <param name="key">要获取配置项的名称。</param>
        /// <returns>读取的浮点数值。</returns>
        float GetFloat(string key);

        /// <summary>
        /// 从指定配置项中读取浮点数值。
        /// </summary>
        /// <param name="key">要获取配置项的名称。</param>
        /// <param name="defaultValue">当指定的配置项不存在时，返回此默认值。</param>
        /// <returns>读取的浮点数值。</returns>
        float GetFloat(string key, float defaultValue);

        /// <summary>
        /// 向指定配置项写入浮点数值。
        /// </summary>
        /// <param name="key">要写入配置项的名称。</param>
        /// <param name="value">要写入的浮点数值。</param>
        void SetFloat(string key, float value);

        /// <summary>
        /// 从指定配置项中读取字符串值。
        /// </summary>
        /// <param name="key">要获取配置项的名称。</param>
        /// <returns>读取的字符串值。</returns>
        string GetString(string key);

        /// <summary>
        /// 从指定配置项中读取字符串值。
        /// </summary>
        /// <param name="key">要获取配置项的名称。</param>
        /// <param name="defaultValue">当指定的配置项不存在时，返回此默认值。</param>
        /// <returns>读取的字符串值。</returns>
        string GetString(string key, string defaultValue);

        /// <summary>
        /// 向指定配置项写入字符串值。
        /// </summary>
        /// <param name="key">要写入配置项的名称。</param>
        /// <param name="value">要写入的字符串值。</param>
        void SetString(string key, string value);

        /// <summary>
        /// 从指定配置项中读取对象。
        /// </summary>
        /// <typeparam name="T">要读取对象的类型。</typeparam>
        /// <param name="key">要获取配置项的名称。</param>
        /// <returns>读取的对象。</returns>
        T GetObject<T>(string key);

        /// <summary>
        /// 从指定配置项中读取对象。
        /// </summary>
        /// <param name="objectType">要读取对象的类型。</param>
        /// <param name="key">要获取配置项的名称。</param>
        /// <returns></returns>
        object GetObject(Type objectType, string key);

        /// <summary>
        /// 从指定配置项中读取对象。
        /// </summary>
        /// <typeparam name="T">要读取对象的类型。</typeparam>
        /// <param name="key">要获取配置项的名称。</param>
        /// <param name="defaultObj">当指定的配置项不存在时，返回此默认对象。</param>
        /// <returns>读取的对象。</returns>
        T GetObject<T>(string key, T defaultObj);

        /// <summary>
        /// 从指定配置项中读取对象。
        /// </summary>
        /// <param name="objectType">要读取对象的类型。</param>
        /// <param name="key">要获取配置项的名称。</param>
        /// <param name="defaultObj">当指定的配置项不存在时，返回此默认对象。</param>
        /// <returns></returns>
        object GetObject(Type objectType, string key, object defaultObj);

        /// <summary>
        /// 向指定配置项写入对象。
        /// </summary>
        /// <typeparam name="T">要写入对象的类型。</typeparam>
        /// <param name="key">要写入配置项的名称。</param>
        /// <param name="obj">要写入的对象。</param>
        void SetObject<T>(string key, T obj);

        /// <summary>
        /// 向指定配置项写入对象。
        /// </summary>
        /// <param name="key">要写入配置项的名称。</param>
        /// <param name="obj">要写入的对象。</param>
        void SetObject(string key, object obj);
    }
}
