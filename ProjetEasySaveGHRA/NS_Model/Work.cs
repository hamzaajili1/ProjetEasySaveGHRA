using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

namespace EasySave.NS_Model
{
    class Work
    {
        // --- Attributes ---
        public string name { get; set; }
        public string src { get; set; }
        public string dst { get; set; }
        public BackupType backupType { get; set; }
        public State state { get; set; }
        public string lastBackupDate { get; set; }

        // Prepare options to indent JSON Files
        private JsonSerializerOptions jsonOptions = new JsonSerializerOptions()
        {
            WriteIndented = true
        };


        // --- Constructors ---
        // Constructor used by LoadWorks()
        public Work() { }

        // Constructor used by AddWork()
        public Work(string _name, string _src, string _dst, BackupType _backupType)
        {
            this.name = _name;
            this.src = _src;
            this.dst = _dst;
            this.backupType = _backupType;
            this.state = null;
        }


        // --- Methods ----
        // Save Log 
        public void SaveLog(DateTime _startDate, string _src, string _dst, long _size, bool isError)
        {
            try
            {
                // Prepare dates
                string today = DateTime.Now.ToString("yyyy-MM-dd");
                string startTime = _startDate.ToString("yyyy-MM-dd_HH-mm-ss");
                string elapsedTime = isError ? "-1" : (DateTime.Now - _startDate).ToString();

                // Ensure the Logs directory exists
                string logsDirectoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
                if (!Directory.Exists(logsDirectoryPath))
                {
                    Directory.CreateDirectory(logsDirectoryPath);
                }

                string logFilePath = Path.Combine(logsDirectoryPath, $"{today}.json");
                List<Log> logs = new List<Log>();

                // Get Logs File Content if it Exists
                if (File.Exists(logFilePath))
                {
                    string fileContent = File.ReadAllText(logFilePath);
                    logs = JsonSerializer.Deserialize<List<Log>>(fileContent) ?? new List<Log>();
                }

                // Add Current Backuped File Log
                logs.Add(new Log(name, _src, _dst, _size.ToString(), startTime, elapsedTime));

                // Write Logs File
                File.WriteAllText(logFilePath, JsonSerializer.Serialize(logs, jsonOptions));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while saving the log: {ex.Message}");
            }
        }

    }
}