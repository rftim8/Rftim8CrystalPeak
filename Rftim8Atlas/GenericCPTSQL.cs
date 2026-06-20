using Microsoft.Data.SqlClient;
using Rftim8Atlas.Models.CP;
using System.Data;

namespace Rftim8Atlas
{
    public class GenericCPTSQL
    {
        public GenericCPTSQL(CPModel cPModel,
            bool insertOne = false,
            bool updateOne = false,
            bool getOne = false,
            bool getAll = false,
            bool deleteOne = false
            )
        {
            if (insertOne)
                InsertCP(cPModel);

            if (updateOne)
            {
                CPModel? cPModel1 = ReadOneCP(3);
                cPModel1!.Description = "tester";
                UpdateCP(cPModel1);
            }

            if (getOne)
            {
                CPModel cPModel1 = ReadOneCP(2)!;
                Console.WriteLine(cPModel1.Algorithms);
            }

            if (getAll)
                ReadAllCPs();

            if (deleteOne)
                DeleteCP(2);
        }

        public GenericCPTSQL()
        {
        }

        private static void InsertCP(CPModel cPModel)
        {
            using SqlConnection sqlConn = new(GenericURLs.mssqlDb);
            using SqlCommand cmd = new("sp_InsertCP", sqlConn);
            cmd.CommandType = CommandType.StoredProcedure;

            // Input parameters
            cmd.Parameters.AddWithValue("@competition", cPModel.Competition);
            cmd.Parameters.AddWithValue("@timestamp", cPModel.Timestamp);
            cmd.Parameters.AddWithValue("@rank", cPModel.Rank);
            cmd.Parameters.AddWithValue("@rating", cPModel.Rating);
            cmd.Parameters.AddWithValue("@problem", cPModel.Problem);
            cmd.Parameters.AddWithValue("@description", cPModel.Description);
            cmd.Parameters.AddWithValue("@solution", cPModel.Solution);
            cmd.Parameters.AddWithValue("@input", cPModel.Input);
            cmd.Parameters.AddWithValue("@output", cPModel.Output);
            cmd.Parameters.AddWithValue("@difficulty", cPModel.Difficulty);
            cmd.Parameters.AddWithValue("@testStatus", cPModel.TestStatus);
            cmd.Parameters.AddWithValue("@runtime", cPModel.Runtime);
            cmd.Parameters.AddWithValue("@memory", cPModel.Memory);
            cmd.Parameters.AddWithValue("@algorithms", cPModel.Algorithms!);
            cmd.Parameters.AddWithValue("@filePath", cPModel.FilePath);

            // Return value
            SqlParameter returnValue = new()
            {
                Direction = ParameterDirection.ReturnValue
            };
            cmd.Parameters.Add(returnValue);

            sqlConn.Open();
            cmd.ExecuteNonQuery();

            int result = (int)returnValue.Value;
            Console.WriteLine("Return Value = " + result);
        }

        private static CPModel? ReadOneCP(long id)
        {
            using SqlConnection sqlConn = new(GenericURLs.mssqlDb);
            using SqlCommand cmd = new("sp_GetOneCP", sqlConn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);

            sqlConn.Open();
            using SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new CPModel
                {
                    Id = (long)reader["Id"],
                    Competition = reader["Competition"] as string,
                    Timestamp = (DateTime)reader["Timestamp"],
                    Rank = (int)reader["Rank"],
                    Rating = (int)reader["Rating"],
                    Problem = reader["Problem"] as string,
                    Description = reader["Description"] as string,
                    Solution = reader["Solution"] as string,
                    Input = reader["Input"] as string,
                    Output = reader["Output"] as string,
                    Difficulty = (int)reader["Difficulty"],
                    TestStatus = (bool)reader["TestStatus"],
                    Runtime = (double)reader["Runtime"],
                    Memory = (double)reader["Memory"],
                    Algorithms = reader["Algorithms"] as string,
                    FilePath = reader["FilePath"] as string
                };
            }
            return null; // not found
        }

        private static void ReadAllCPs()
        {
            using SqlConnection sqlConn = new(GenericURLs.mssqlDb);
            using SqlDataAdapter sqlDataAdapter = new("sp_GetAllCPs", sqlConn);
            sqlConn.Open();
            DataSet dataSet = new();
            sqlDataAdapter.Fill(dataSet);

            // Print DataTable as a table to the console
            if (dataSet.Tables.Count > 0)
            {
                DataTable table = dataSet.Tables[0];
                // Print column headers
                for (int col = 0; col < table.Columns.Count; col++)
                {
                    Console.Write($"{table.Columns[col].ColumnName}\t");
                }
                Console.WriteLine();

                // Print rows
                foreach (DataRow row in table.Rows)
                {
                    for (int col = 0; col < table.Columns.Count; col++)
                    {
                        Console.Write($"{row[col]}\t");
                    }
                    Console.WriteLine();
                }
            }
        }

        private static void UpdateCP(CPModel cPModel)
        {
            using SqlConnection sqlConn = new(GenericURLs.mssqlDb);
            using SqlCommand cmd = new("sp_UpdateCP", sqlConn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", cPModel.Id);
            cmd.Parameters.AddWithValue("@competition", cPModel.Competition);
            cmd.Parameters.AddWithValue("@timestamp", cPModel.Timestamp);
            cmd.Parameters.AddWithValue("@rank", cPModel.Rank);
            cmd.Parameters.AddWithValue("@rating", cPModel.Rating);
            cmd.Parameters.AddWithValue("@problem", cPModel.Problem);
            cmd.Parameters.AddWithValue("@description", cPModel.Description);
            cmd.Parameters.AddWithValue("@solution", cPModel.Solution);
            cmd.Parameters.AddWithValue("@input", cPModel.Input);
            cmd.Parameters.AddWithValue("@output", cPModel.Output);
            cmd.Parameters.AddWithValue("@difficulty", cPModel.Difficulty);
            cmd.Parameters.AddWithValue("@testStatus", cPModel.TestStatus);
            cmd.Parameters.AddWithValue("@runtime", cPModel.Runtime);
            cmd.Parameters.AddWithValue("@memory", cPModel.Memory);
            cmd.Parameters.AddWithValue("@algorithms", cPModel.Algorithms);
            cmd.Parameters.AddWithValue("@filePath", cPModel.FilePath);

            sqlConn.Open();
            int rows = cmd.ExecuteNonQuery();
            Console.WriteLine($"{rows} row(s) updated.");
        }

        private static void DeleteCP(int id)
        {
            using SqlConnection sqlConn = new(GenericURLs.mssqlDb);
            using SqlCommand cmd = new("sp_DeleteOneCP", sqlConn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);

            sqlConn.Open();
            int rows = cmd.ExecuteNonQuery();
            Console.WriteLine($"{rows} row(s) deleted.");
        }
    }
}