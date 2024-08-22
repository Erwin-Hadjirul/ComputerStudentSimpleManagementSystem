using ComputerStudent_SimpleManagementSystem.Models;
using System.Data.SqlClient;

namespace ComputerStudent_SimpleManagementSystem.Services;

public class CSSMSService
{
    private static CSSMSService? _instance = null;
    private readonly SqlConnection _connection;

    private CSSMSService()
    {
        _connection = new SqlConnection(
            "Data Source=TECH-WANNABE;" +
            "Initial Catalog=CSSMS_DB;" +
            "Integrated Security=True;");

        // Uncomment this (very important!)
        //RootData(_connection);
    }

    public static CSSMSService GetInstance()
    {
        if (_instance == null) _instance = new CSSMSService();

        return _instance;
    }

    public IEnumerable<BSCS>? Read_BSCSs()
    {
        List<BSCS>? BSCSs = new List<BSCS>();

        try
        {
            _connection.Open();

            string query = @"
                            SELECT * FROM [dbo].[BSCS];
                        ";

            SqlCommand comm = new SqlCommand(query, _connection);
            SqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                BSCSs.Add(new BSCS
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    Age = Convert.ToInt32(reader["Age"]),
                    YearLvl = Convert.ToInt32(reader["YearLvl"]),
                    Specialization = reader["Specialization"].ToString()
                });
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("There is something wrong with the database!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            _connection.Close();
        }

        return BSCSs;
    }

    public IEnumerable<BSIT>? Read_BSITs()
    {
        List<BSIT>? BSITs = new List<BSIT>();

        try
        {
            _connection.Open();

            string query = @"
                            SELECT * FROM [dbo].[BSIT];
                        ";

            SqlCommand comm = new SqlCommand(query, _connection);
            SqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                BSITs.Add(new BSIT
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    Age = Convert.ToInt32(reader["Age"]),
                    YearLvl = Convert.ToInt32(reader["YearLvl"]),
                    Specialization = reader["Specialization"].ToString()
                });
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("There is something wrong with the database!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            _connection.Close();
        }

        return BSITs;
    }

    public BSCS? Read_BSCS(int id)
    {
        BSCS? bscs = null;

        try
        {
            _connection.Open();

            string query = $@"
                            SELECT * FROM [dbo].[BSCS] WHERE id = {id};
                        ";

            SqlCommand comm = new SqlCommand(query, _connection);
            SqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                bscs = new BSCS
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    Age = Convert.ToInt32(reader["Age"]),
                    YearLvl = Convert.ToInt32(reader["YearLvl"]),
                    Specialization = reader["Specialization"].ToString()
                };
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("There is something wrong with the database!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            _connection.Close();
        }

        return bscs;
    }

    public BSIT? Read_BSIT(int id)
    {
        BSIT? bsit = null;

        try
        {
            _connection.Open();

            string query = $@"
                            SELECT * FROM [dbo].[BSIT] WHERE id = {id};
                        ";

            SqlCommand comm = new SqlCommand(query, _connection);
            SqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                bsit = new BSIT
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    Age = Convert.ToInt32(reader["Age"]),
                    YearLvl = Convert.ToInt32(reader["YearLvl"]),
                    Specialization = reader["Specialization"].ToString()
                };
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("There is something wrong with the database!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            _connection.Close();
        }

        return bsit;
    }

    public BSCS Write_BSCS(BSCS bscs)
    {
        try
        {
            _connection.Open();

            string query = $@"
                        INSERT INTO [dbo].[BSCS] (
                            [Name],
                            [Age],
                            [YearLvl],
                            [Specialization]
                        )
                        VALUES (
                            '{bscs.Name}',
                            {bscs.Age},
                            {bscs.YearLvl},
                            '{bscs.Specialization}'
                        );
                    ";

            SqlCommand comm = new SqlCommand(query, _connection);
            comm.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            MessageBox.Show("There is something wrong with the database!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            _connection.Close();
        }

        return bscs;
    }

    public BSIT Write_BSIT(BSIT bsit)
    {
        try
        {
            _connection.Open();

            string query = $@"
                        INSERT INTO [dbo].[BSIT] (
                            [Name],
                            [Age],
                            [YearLvl],
                            [Specialization]
                        )
                        VALUES (
                            '{bsit.Name}',
                            {bsit.Age},
                            {bsit.YearLvl},
                            '{bsit.Specialization}'
                        );
                    ";

            SqlCommand comm = new SqlCommand(query, _connection);
            comm.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            MessageBox.Show("There is something wrong with the database!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            _connection.Close();
        }

        return bsit;
    }

    // Method for initializing DB Data
    private void RootData(SqlConnection conn)
    {
        List<BSCS>? BSCSs = new List<BSCS>
        {
            new BSCS { Id = 1, Name = "Erwin", Age = 24, YearLvl = 4, Specialization = "Computer Programmer" },
            new BSCS { Id = 2, Name = "Abdilhakim", Age = 23, YearLvl = 4, Specialization = "Computer Hacking" },
            new BSCS { Id = 3, Name = "Ajiver", Age = 24, YearLvl = 4, Specialization = "Web Frontend" }
        };

        List<BSIT>? BSITs = new List<BSIT>
        {
            new BSIT { Id = 1, Name = "Adjikir", Age = 23, YearLvl = 4, Specialization = "Computer Programmer" },
            new BSIT { Id = 2, Name = "Solohom", Age = 23, YearLvl = 4, Specialization = "Computer Hacking" },
            new BSIT { Id = 3, Name = "Ridzkir", Age = 24, YearLvl = 4, Specialization = "IT Stuff" },
            new BSIT { Id = 4, Name = "Erwin", Age = 26, YearLvl = 4, Specialization = "Selling Computer" }
        };

        try
        {
            conn.Open();

            // Create tables
            string query = @"
                                CREATE TABLE BSCS (
                                    Id int PRIMARY KEY IDENTITY(1, 1) NOT NULL,
                                    Name varchar(50) NOT NULL,
                                    Age int NOT NULL,
                                    YearLvl int NOT NULL,
                                    Specialization varchar(25) NOT NULL
                                );

                                CREATE TABLE BSIT (
                                    Id int PRIMARY KEY IDENTITY(1, 1) NOT NULL,
                                    Name varchar(50) NOT NULL,
                                    Age int NOT NULL,
                                    YearLvl int NOT NULL,
                                    Specialization varchar(25) NOT NULL
                                );
                            ";

            SqlCommand comm = new SqlCommand(query, conn);
            comm.ExecuteNonQuery();

            // CREATE ROOT DATA
            for (int i = 0; i < BSCSs.Count; i++)
            {
                query = $@"
                            INSERT INTO [dbo].[BSCS] (
                                [Name],
                                [Age],
                                [YearLvl],
                                [Specialization]
                            )
                            VALUES (
                                '{BSCSs[i].Name}',
                                {BSCSs[i].Age},
                                {BSCSs[i].YearLvl},
                                '{BSCSs[i].Specialization}'
                            );
                        ";

                comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();
            }

            for (int i = 0; i < BSITs.Count; i++)
            {
                query = $@"
                            INSERT INTO [dbo].[BSIT] (
                                [Name],
                                [Age],
                                [YearLvl],
                                [Specialization]
                            )
                            VALUES (
                                '{BSITs[i].Name}',
                                {BSITs[i].Age},
                                {BSITs[i].YearLvl},
                                '{BSITs[i].Specialization}'
                            );
                        ";

                comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("There is something wrong with the database!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            conn.Close();
        }
    }
}
