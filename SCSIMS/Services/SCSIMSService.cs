using ComputerStudent_SimpleManagementSystem.Models;
using System.Data.SqlClient;
using System.Configuration;

namespace ComputerStudent_SimpleManagementSystem.Services;

public class SCSIMSService
{
    // This class' only instance for the entire program
    private static SCSIMSService? _instance = null;
    // Connection to the DB
    private readonly SqlConnection _connection;

    // Private constructor to disable this
    // class to have multiple instances
    private SCSIMSService()
    {
        // Adding DB connection string to the connection
        _connection = new SqlConnection(
            ConfigurationManager.ConnectionStrings["SCSIMS_DB"].ConnectionString);

        // Calling root data to prepare the DB
        // Add 2nd and 3rd parameters to prepare the DB and its root data
        RootData(_connection);
    }

    // The only way to get the instance of this class
    public static SCSIMSService GetInstance()
    {
        if (_instance == null) _instance = new SCSIMSService();

        return _instance;
    }

    // Getting All BSCS' Data
    public IEnumerable<BSCS>? Read_BSCSs()
    {
        // Where we stored all of the BSCS' data
        List<BSCS>? BSCSs = new List<BSCS>();

        try
        {
            // Reading data from DB
            _connection.Open();

            string query = @"
                            SELECT * FROM [dbo].[BSCS];
                        ";

            SqlCommand comm = new SqlCommand(query, _connection);
            SqlDataReader reader = comm.ExecuteReader();

            // Converting all data gathered from DB
            // to our model class and stored it in a
            // list
            while (reader.Read())
            {
                BSCSs.Add(new BSCS
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString() ?? string.Empty,
                    Age = Convert.ToInt32(reader["Age"]),
                    YearLvl = Convert.ToInt32(reader["YearLvl"]),
                    Specialization = reader["Specialization"].ToString() ?? string.Empty
                });
            }
        }
        catch (Exception)
        {
            MessageBox.Show("There is something wrong with the database.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            _connection.Close();
        }

        return BSCSs;
    }

    // Getting All BSIT's Data
    public IEnumerable<BSIT>? Read_BSITs()
    {
        // Where we stored all of the BSIT's data
        List<BSIT>? BSITs = new List<BSIT>();

        try
        {
            // Reading data from DB
            _connection.Open();

            string query = @"
                            SELECT * FROM [dbo].[BSIT];
                        ";

            SqlCommand comm = new SqlCommand(query, _connection);
            SqlDataReader reader = comm.ExecuteReader();

            // Converting all data gathered from DB
            // to our model class and stored it in a
            // list
            while (reader.Read())
            {
                BSITs.Add(new BSIT
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString() ?? string.Empty,
                    Age = Convert.ToInt32(reader["Age"]),
                    YearLvl = Convert.ToInt32(reader["YearLvl"]),
                    Specialization = reader["Specialization"].ToString() ?? string.Empty
                });
            }
        }
        catch (Exception)
        {
            MessageBox.Show("There is something wrong with the database.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            _connection.Close();
        }

        return BSITs;
    }

    // Getting specific BSCS' data
    public BSCS? Read_BSCS(int id)
    {
        // Where we store the data
        BSCS? bscs = null;

        try
        {
            // Reading data from DB
            _connection.Open();

            string query = $@"
                            SELECT * FROM [dbo].[BSCS] WHERE id = {id};
                        ";

            SqlCommand comm = new SqlCommand(query, _connection);
            SqlDataReader reader = comm.ExecuteReader();

            // Converting the data gathered from DB
            // to our model class and stored it
            while (reader.Read())
            {
                bscs = new BSCS
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString() ?? string.Empty,
                    Age = Convert.ToInt32(reader["Age"]),
                    YearLvl = Convert.ToInt32(reader["YearLvl"]),
                    Specialization = reader["Specialization"].ToString() ?? string.Empty
                };
            }
        }
        catch (Exception)
        {
            MessageBox.Show("There is something wrong with the database.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            _connection.Close();
        }

        return bscs;
    }

    // Getting specific BSIT's data
    public BSIT? Read_BSIT(int id)
    {
        // Where we store the data
        BSIT? bsit = null;

        try
        {
            // Reading data from DB
            _connection.Open();

            string query = $@"
                            SELECT * FROM [dbo].[BSIT] WHERE id = {id};
                        ";

            SqlCommand comm = new SqlCommand(query, _connection);
            SqlDataReader reader = comm.ExecuteReader();

            // Converting the data gathered from DB
            // to our model class and stored it
            while (reader.Read())
            {
                bsit = new BSIT
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString() ?? string.Empty,
                    Age = Convert.ToInt32(reader["Age"]),
                    YearLvl = Convert.ToInt32(reader["YearLvl"]),
                    Specialization = reader["Specialization"].ToString() ?? string.Empty
                };
            }
        }
        catch (Exception)
        {
            MessageBox.Show("There is something wrong with the database.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            _connection.Close();
        }

        return bsit;
    }

    // Writing data to the DB
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
        catch (Exception)
        {
            MessageBox.Show("There is something wrong with the database.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            _connection.Close();
        }

        return bscs;
    }

    // Writing data to the DB
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
        catch (Exception)
        {
            MessageBox.Show("There is something wrong with the database.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            _connection.Close();
        }

        return bsit;
    }

    // Method for initializing DB Data
    private void RootData(SqlConnection conn, bool createDBTable = false, bool addRootData = false)
    {
        string query = string.Empty;
        SqlCommand? comm = null;

        try
        {
            conn.Open();

            if (createDBTable)
            {
                // Create tables
                query = @"
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

                comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();
            }

            if (addRootData)
            {
                // Root data
                List<BSCS>? BSCSs = new List<BSCS>
                {
                    new BSCS { Id = 1, Name = "Erwin", Age = 24, YearLvl = 4, Specialization = "Computer Programming" },
                    new BSCS { Id = 2, Name = "Abdilhakim", Age = 23, YearLvl = 4, Specialization = "Computer Hacking" },
                    new BSCS { Id = 3, Name = "Ajiver", Age = 24, YearLvl = 4, Specialization = "Frontend Development" },
                    new BSCS { Id = 3, Name = "Benjoung", Age = 23, YearLvl = 3, Specialization = "Backend Development" }
                };

                List<BSIT>? BSITs = new List<BSIT>
                {
                    new BSIT { Id = 1, Name = "Adjikir", Age = 23, YearLvl = 4, Specialization = "Computer Programming" },
                    new BSIT { Id = 2, Name = "Solohom", Age = 23, YearLvl = 4, Specialization = "Computer Hacking" },
                    new BSIT { Id = 3, Name = "Ridzkir", Age = 24, YearLvl = 4, Specialization = "Networking" },
                    new BSIT { Id = 4, Name = "Erwin", Age = 26, YearLvl = 4, Specialization = "Computer Selling" }
                };

                // Add root data to the DB
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
        }
        catch (Exception)
        {
            MessageBox.Show("There is something wrong with the database.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            conn.Close();
        }
    }
}
