using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace SPZ7.Model
{
    public class Database
    {
        private MySqlConnection connection = new MySqlConnection();
        public Database()
        {
            connection.ConnectionString = "server=localhost;port=3306;username=root;database=spz7;SSL Mode=None";
            connection.Open();
        }
        public void AddStudent(string lastname, string firstname, string gropname)
        {
            Random random = new Random();
            int id = random.Next(0, 10000);
            MySqlCommand command = new MySqlCommand("INSERT INTO students VALUES(\'" + id + "\', \'" + lastname + "\', \'" + firstname + "\', (SELECT id_group FROM groups " +
                                                                                "WHERE groups.group_name = \'" + gropname + "\'))", connection);
            command.ExecuteNonQuery();
          
        }
        public void AddGroup(string groupname)
        {
            Random random = new Random();
            int id = random.Next(0, 10000);
            MySqlCommand command = new MySqlCommand("INSERT INTO groups(`id_group`, `group_name`) " +
               "VALUES(\'" + id + "\', \'" + groupname + "\');", connection);
            command.ExecuteNonQuery();
        }
        public List<List<string>> GetStudents()
        {
            MySqlCommand command = new MySqlCommand("SELECT s.id_student, s.last_name, s.first_name, g.group_name " +
                "FROM students s INNER JOIN groups g ON s.id_group = g.id_group", connection);
            MySqlDataReader reader = command.ExecuteReader();
            List<List<string>> result = new List<List<string>>();
            while (reader.Read())
            {
                result.Add(new List<string> { reader.GetString("id_student"), reader.GetString("last_name"),
                    reader.GetString("first_name"), reader.GetString("group_name")});
            }
            reader.Close();
            return result;
        }
        public List<List<string>> GetGroups()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM groups", connection);
            MySqlDataReader reader = command.ExecuteReader();
            List<List<string>> result = new List<List<string>>();
            while (reader.Read())
            {
                result.Add(new List<string> { reader.GetString("id_group"), reader.GetString("group_name") });
            }
            reader.Close();
            return result;
        }
        public List<string> GetOneStudent(string id)
        {
            MySqlCommand command = new MySqlCommand("SELECT a.id_student, a.last_name, a.first_name, b.group_name " +
                "FROM students a INNER JOIN groups b ON a.id_group = b.id_group " +
                "WHERE a.id_student = \'" + id + "\'", connection);
            MySqlDataReader reader = command.ExecuteReader();
            List<string> result = new List<string>();
            while (reader.Read())
            {
                result.Add(reader.GetString("id_student"));
                result.Add(reader.GetString("last_name"));
                result.Add(reader.GetString("first_name"));
                result.Add(reader.GetString("group_name"));
            }
            reader.Close();
            return result;
        }
        public void UpdateStudentName(string name, string id)
        {
            MySqlCommand command = new MySqlCommand("UPDATE students SET first_name = \'" + name + "\'" +
                " WHERE id_student = \'" + id + "\'", connection);
            command.ExecuteNonQuery();
        }
        public void UpdateStudentLastName(string lastname, string id)
        {
            MySqlCommand command = new MySqlCommand("UPDATE students SET last_name = \'" + lastname + "\'" +
                " WHERE id_student = \'" + id + "\'", connection);
            command.ExecuteNonQuery();
        }
        public void UpdateStudentGroup(string groupName, string id)
        {
            string idGroup = null;
            MySqlCommand command = new MySqlCommand("SELECT id_group FROM groups WHERE group_name = \'" + groupName + "\'", connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                idGroup = reader.GetString("id_group");
            }
            reader.Close();
            command = new MySqlCommand("UPDATE students SET id_group = \'" + idGroup + "\'" +
                " WHERE id_student = \'" + id + "\'", connection);
            command.ExecuteNonQuery();
        }
        public void UpdateGroupName(string groupName, string id)
        {
            MySqlCommand command = new MySqlCommand("UPDATE groups SET group_name = \'" + groupName + "\'" +
                " WHERE id_group = \'" + id + "\'", connection);
            command.ExecuteNonQuery();
        }
        public void DeleteStudent(string id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM students WHERE id_student = \'" + id + "\'", connection);
            command.ExecuteNonQuery();
        }
        public void DeleteGroup(string id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM students WHERE id_group = " + id, connection);
            command.ExecuteNonQuery();
            command = new MySqlCommand("DELETE FROM groups WHERE id_group = " + id, connection);
            command.ExecuteNonQuery();
        }
        public string GetGroupName(string id)
        {
            MySqlCommand command = new MySqlCommand("SELECT group_name FROM groups WHERE id_group  = \'" + id + "\'", connection);
            MySqlDataReader reader = command.ExecuteReader();
            string result = null;
            while (reader.Read())
            {
                result = reader.GetString("group_name");
            }
            reader.Close();
            return result;
        }
        public string GetGroupId(string groupName)
        {
            MySqlCommand command = new MySqlCommand("SELECT id_group FROM groups WHERE group_name = \'" + groupName + "\'", connection);
            MySqlDataReader reader = command.ExecuteReader();
            string result = null;
            while (reader.Read())
            {
                result = reader.GetString("id_group");
            }
            reader.Close();
            return result;
        }

        public void Close()
        {
            connection.Close();
        }
    }
}
