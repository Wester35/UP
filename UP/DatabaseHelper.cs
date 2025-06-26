using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace UP
{
    // Класс для работы с базой данных SQLite
    public static class DatabaseHelper
    {
        // Имя файла базы данных
        private static readonly string DbFile = "results.db";

        // Строка подключения к базе данных
        private static readonly string ConnectionString = $"Data Source={DbFile};Version=3;";

        // Метод инициализации базы данных: создание файла и таблицы, если не существует
        public static void InitializeDatabase()
        {
            if (!File.Exists(DbFile))
            {
                SQLiteConnection.CreateFile(DbFile); // создаём файл базы
                using (var conn = new SQLiteConnection(ConnectionString))
                {
                    conn.Open();

                    // SQL-запрос на создание таблицы результатов
                    string createTable = @"
                        CREATE TABLE Results (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            X0 REAL,
                            Y0 REAL,
                            R REAL,
                            C REAL,
                            Direction TEXT,
                            N INTEGER,
                            FormulaResult REAL,
                            MonteCarloResult REAL,
                            Date TEXT
                        );";

                    using (var cmd = new SQLiteCommand(createTable, conn))
                    {
                        cmd.ExecuteNonQuery(); // выполняем команду создания таблицы
                    }
                }
            }
        }

        // Метод для добавления новой записи в таблицу
        public static void AddResult(double x0, double y0, double r, double c, string direction, int n, double formula, double monteCarlo)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand(@"
                    INSERT INTO Results (X0, Y0, R, C, Direction, N, FormulaResult, MonteCarloResult, Date)
                    VALUES (@x0, @y0, @r, @c, @direction, @n, @formula, @monte, @date);", conn);

                // Добавляем параметры для предотвращения SQL-инъекций
                cmd.Parameters.AddWithValue("@x0", x0);
                cmd.Parameters.AddWithValue("@y0", y0);
                cmd.Parameters.AddWithValue("@r", r);
                cmd.Parameters.AddWithValue("@c", c);
                cmd.Parameters.AddWithValue("@direction", direction);
                cmd.Parameters.AddWithValue("@n", n);
                cmd.Parameters.AddWithValue("@formula", formula);
                cmd.Parameters.AddWithValue("@monte", monteCarlo);
                cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                cmd.ExecuteNonQuery(); // выполняем добавление
            }
        }

        // Получить все записи в виде DataTable (для отображения в таблице)
        public static DataTable GetAllResults()
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var dt = new DataTable();
                var cmd = new SQLiteCommand("SELECT * FROM Results ORDER BY Id DESC;", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader); // загружаем данные в таблицу
                }
                return dt;
            }
        }

        // Обновить значения формулы и Монте-Карло по ID записи
        public static void UpdateResult(int id, double formula, double monte)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand(@"
                    UPDATE Results 
                    SET FormulaResult = @formula, MonteCarloResult = @monte 
                    WHERE Id = @id;", conn);

                cmd.Parameters.AddWithValue("@formula", formula);
                cmd.Parameters.AddWithValue("@monte", monte);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }

        // Удалить запись по ID
        public static void DeleteResult(int id)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("DELETE FROM Results WHERE Id = @id;", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        // Удалить все записи из таблицы
        public static void DeleteAllResult()
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SQLiteCommand("DELETE FROM Results;", conn);
                cmd.ExecuteNonQuery();
            }
        }

        // Получить одну запись по ID (в виде DataRow)
        public static DataRow GetResultById(int id)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                var dt = new DataTable();
                var cmd = new SQLiteCommand("SELECT * FROM Results WHERE Id = @id;", conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }

                // Если найдена хотя бы одна строка — вернуть её, иначе null
                return dt.Rows.Count > 0 ? dt.Rows[0] : null;
            }
        }

        // Получить все записи с расчетом разницы для анализа (гистограмма)
        public static List<ResultEntry> GetAllResultsForAnalys()
        {
            var results = new List<ResultEntry>();

            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = "SELECT id, FormulaResult, MonteCarloResult FROM Results;";
                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var entry = new ResultEntry
                        {
                            Id = reader.GetInt32(0),
                            Formula = reader.GetDouble(1),
                            MonteCarlo = reader.GetDouble(2)
                        };
                        results.Add(entry);
                    }
                }
            }

            return results;
        }
    }
}
