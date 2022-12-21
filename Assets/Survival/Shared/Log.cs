using System;
using System.IO;
using UnityEngine;

namespace Survival.Shared
{
    /// <summary>
    /// 用来管理日志的组件
    /// </summary>
    public readonly struct Log
    {
        /// <summary>
        /// 日志目录
        /// </summary>
        public static readonly string LogPath = Path.Combine(Application.persistentDataPath, "Log");

        public static void Initialize()
        {
            Application.logMessageReceived += HandleUnityLog;
        }

        private static void HandleUnityLog(string condition, string stackTrace, LogType type)
        {
            WriteLine(type, condition);
        }

        public static void WriteLine(LogType type, string message)
        {
            var path = Path.Combine(LogPath, DateTime.Now.ToShortDateString().Replace('/','_'));

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            path =Path.Combine(path, "log.txt");

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine($"[{DateTime.Now.ToString("T")}][{type.ToString().PadRight(9)}]{message}");
            }
        }
    }
}
