using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;
using System.Text;
using WebApplication1.Models;

/// <summary>
/// DBServices is a class created by me to provides some DataBase Services
/// </summary>
public class DBservices
{
    public SqlDataAdapter da;
    public DataTable dt;
    public DBservices()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public SqlConnection connect(String conString)
    {

        // read the connection string from the configuration file
        string pStr = WebConfigurationManager.ConnectionStrings[conString].ConnectionString;
        SqlConnection con = new SqlConnection(pStr);
        con.Open();
        return con;
    }


    private SqlCommand CreateCommand(String CommandSTR, SqlConnection con)
    {

        SqlCommand cmd = new SqlCommand(); // create the command object

        cmd.Connection = con;              // assign the connection to the command object

        cmd.CommandText = CommandSTR;      // can be Select, Insert, Update, Delete 

        cmd.CommandTimeout = 10;           // Time to wait for the execution' The default is 30 seconds

        cmd.CommandType = System.Data.CommandType.Text; // the type of the command, can also be stored procedure

        return cmd;
    }
    public int insert(Patient p)
    {

        SqlConnection con;
        SqlCommand cmd;

        try
        {
            con = connect("dietDBConnectionString"); // create the connection
        }
        catch (Exception ex)
        {
            // write to log
            throw (ex);
        }

        String pStr = BuildInsertPatientCommand(p);      // helper method to build the insert string

        cmd = CreateCommand(pStr, con);             // create the command

        try
        {

            /*int numPatient = Convert.ToInt32(cmd.ExecuteScalar());*/ // execute the command

            int numEffected = cmd.ExecuteNonQuery(); // execute the command

            return numEffected;
        }
        catch (Exception ex)
        {
            return 0;
            // write to log
            throw (ex);
        }

        finally
        {
            if (con != null)
            {
                // close the db connection
                con.Close();
            }
        }

    }

    private String BuildInsertPatientCommand(Patient p)
    {
        String command;

        StringBuilder sb = new StringBuilder();
        // use a string builder to create the dynamic string
        sb.AppendFormat("Values('{0}', '{1}' ,'{2}', '{3}', {4}, '{5}', '{6}','{7}',{8}, {9}, '{10}', {11},{12},'{13}','{14}','{15}' )", p.Id, p.FirstName, p.LastName, p.DateOfBirth.ToString(), p.Age.ToString(), p.ContactName, p.ContactPhone, p.ContactRelation, p.Height.ToString(), p.Weight.ToString(), p.Diseases, p.IdTexture.ToString(), p.NumSensitivity.ToString(), p.Classification, p.Image, p.Comments);
        String prefix = "INSERT INTO Patients (idPatient, firstNamePatient, lastNamePatient, dateOfBirthPatient, age, nameEmergencyContact, phoneEmergencyContact, relationContact, height, weight, diseases, idTexture, numSensitivity, classificationPatient, image, additionalComments) OUTPUT INSERTED.numPatient ";
        command = prefix + sb.ToString();

        return command;
    }

}

