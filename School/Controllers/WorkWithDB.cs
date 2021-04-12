using System;
using System.Web;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting.Server;

namespace School.Controllers
{
    public class WorkWithDB : Controller
    {
        //private const string connectionString = @"Data Source=ASUS-ZENBOOK;Initial Catalog=DBSchool;Integrated Security=True";
        private const string connectionString = @"Data Source=KRIGIN;Initial Catalog=DBSchool;Integrated Security=True";
        private static int id;
        private SqlConnection sqlConnection;

        public WorkWithDB()
        {
            sqlConnection = new SqlConnection(connectionString);
        }
        public int getIdForRemember(string username, string SecretWord)
        {
            sqlConnection.Open();
            SqlDataReader sqlDataReader = null;
            int id = -1;
            try
            {
                
                string switcher = "LogIn.Username";
                if (username.Contains("+375("))
                {
                    switcher = "Person.Number";
                }
                SqlCommand sqlCommand = new SqlCommand($"select LogIn.Id " +
                   $"from LogIn inner join Person " +
                   $"on LogIn.Id = Person.id " +
                   $"where {switcher} = '{username}' and Person.[Secret word] = '{SecretWord}'", sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                if(sqlDataReader.Read()) id = Convert.ToInt32(sqlDataReader["Id"]);

            }
            catch (Exception ex)
            {
                ViewBag.catchStatus = ex.Message;
            }
            finally
            {
                if (sqlDataReader != null)
                {
                    sqlDataReader.Close();
                }
                sqlConnection.Close();
            }
            return id;
        }
        public List<Person> getActualDB()
        {
            List<Person> Persons = new List<Person>();

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlDataReader sqlDataReader = null;
            SqlCommand sqlCommand = new SqlCommand("SELECT LogIn.Id, LogIn.Username, LogIn.Password, LogIn.level, Person.[E-mail],Person.Number, Person.[Secret word] FROM[LogIn], Person where LogIn.Id = Person.id", sqlConnection);

            try
            {
                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Person somePerson = new Person();
                    somePerson.id = Convert.ToInt32(sqlDataReader["Id"]);
                    somePerson.username = sqlDataReader["Username"].ToString();
                    somePerson.password = sqlDataReader["Password"].ToString();
                    somePerson.level = Convert.ToInt32(sqlDataReader["level"]);
                    somePerson.number = sqlDataReader["Number"].ToString();
                    somePerson.secretWord = sqlDataReader["Secret word"].ToString();
                    somePerson.email = sqlDataReader["E-mail"].ToString();
                    Persons.Add(somePerson);
                }
                sqlDataReader.Close();


            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ViewBag.catchStatus = ex.Message;
            }
            finally
            {
                if (sqlDataReader != null)
                {
                    sqlDataReader.Close();
                    sqlConnection.Close();
                }
            }


            return Persons;
        }
        public Person getVerifyResult(string username, string password)
        {
            sqlConnection.Open();

            SqlDataReader sqlDataReader = null;
            SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM[LogIn] where Username = \'{username}\' and Password = \'{password}\'", sqlConnection);
            Person somePerson = new Person();
            try
            {
                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    
                    somePerson.id = Convert.ToInt32(sqlDataReader["Id"]);
                    somePerson.username = sqlDataReader["Username"].ToString();
                    somePerson.password = sqlDataReader["Password"].ToString();
                    somePerson.level = Convert.ToInt32(sqlDataReader["level"]);
                }
                sqlDataReader.Close();


            }
            catch (Exception ex)
            {
                ViewBag.catchStatus = ex.Message;
            }
            finally
            {
                if (sqlDataReader != null)
                {
                    sqlDataReader.Close();
                    sqlConnection.Close();
                }
            }
            return somePerson;
        }
        public Person getFullInformation(int id)
        {
            Person somePerson = new Person();

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlDataReader sqlDataReader = null;
            SqlCommand sqlCommand = new SqlCommand("SELECT LogIn.Id, Username, Password, level, " +
                "LastName, Name, Patronymic, Sex, Birthday, Number, [E-mail], position, [Secret word] FROM [LogIn], " +
                $"Person where LogIn.Id ={id} AND LogIn.Id = Person.id", sqlConnection);

            try
            {
                sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.Read();
                somePerson.id = Convert.ToInt32(sqlDataReader["Id"]);
                somePerson.username = sqlDataReader["Username"].ToString();
                somePerson.password = sqlDataReader["Password"].ToString();
                somePerson.level = Convert.ToInt32(sqlDataReader["level"]);
                somePerson.lastName = sqlDataReader["LastName"].ToString();
                somePerson.name = sqlDataReader["Name"].ToString();
                somePerson.patronymic = sqlDataReader["Patronymic"].ToString();
                somePerson.sex = sqlDataReader["Sex"].ToString();
                somePerson.birthday = sqlDataReader["Birthday"].ToString();
                somePerson.number = sqlDataReader["Number"].ToString();
                somePerson.email = sqlDataReader["E-mail"].ToString();
                somePerson.position = sqlDataReader["position"].ToString();
                somePerson.secretWord = sqlDataReader["Secret word"].ToString();
                sqlDataReader.Close();


                sqlCommand = new SqlCommand("getFullPosition", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                // параметр для ввода имени
                SqlParameter idParam = new SqlParameter
                {
                    ParameterName = "@id",
                    Value = somePerson.id
                };
                sqlCommand.Parameters.Add(idParam);

                somePerson.fullPosition = "";
                if (somePerson.level >= 3)
                {
                    somePerson.fullPosition = sqlCommand.ExecuteScalar().ToString();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ViewBag.catchStatus = ex.Message;
            }
            finally
            {
                if (sqlDataReader != null)
                {
                    sqlDataReader.Close();

                }
                sqlConnection.Close();
            }

            return somePerson;
        }
        public bool addUser(Person somePerson)
        {
            
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("", sqlConnection);

            sqlCommand.CommandText = $"INSERT INTO LogIn (Username, Password, level) VALUES ('{somePerson.username}','{somePerson.password}', {somePerson.level})";

            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch(Exception exp)
            {
                //MessageBox.Show("Не могу вас добавить\nПричина: " + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ViewBag.catchStatus = exp.Message;
                return false;
            }
            SqlDataReader sqlDataReader = null;
            sqlCommand.CommandText = $"SELECT [Id] FROM LogIn WHERE Username='{somePerson.username}'";
            sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();
            somePerson.id =Convert.ToInt32(sqlDataReader["Id"]);
            sqlDataReader.Close();

            sqlCommand.CommandText = $"INSERT INTO Person  (Id,LastName, Name, Patronymic, Sex, Birthday, Number, [E-mail], position, [Secret word]) " +
                $"VALUES ({somePerson.id},'{somePerson.lastName}','{somePerson.name}', " +
                $"'{somePerson.patronymic}', '{somePerson.sex}'," +
                $"'{somePerson.birthday}', '{somePerson.number}'," +
                $"'{somePerson.email}', '{somePerson.position}'," +
                $"'{somePerson.secretWord}')";

            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception exp)
            {
                //MessageBox.Show("Не могу вас добавить\nПричина: " + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ViewBag.catchStatus = exp.Message;
                return false;
            }

            string sql = "";
            switch (somePerson.level)
            {
                case 1:
                    sql = $"INSERT INTO [Учащийся] (id, [Фамилия], [Имя], [Отчество], [Код класса]) " +
                        $"VALUES ({somePerson.id}, '{somePerson.lastName}', '{somePerson.name}', '{somePerson.patronymic}', 0)";
                    break;
                case 2:
                    sql = $"INSERT INTO [Родители] (id, [Фамилия], [Имя], [Отчество], [Код ребенка]) " +
                        $"VALUES ({somePerson.id}, '{somePerson.lastName}', '{somePerson.name}', '{somePerson.patronymic}', 0)";
                    break;
                case 3:
                    sql = $"INSERT INTO [Сотрудник] (id, [Фамилия], [полная должность], [стаж]) " +
                        $"VALUES ({somePerson.id}, '{somePerson.lastName}', '{somePerson.position}',0)";
                    break;
            }
            sqlCommand.CommandText = sql;

            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception exp)
            {
                //MessageBox.Show("Не могу вас добавить\nПричина: " + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ViewBag.catchStatus = exp.Message;
            }

            sqlConnection.Close();

            string text = "<h2>Вы были зарегестрированы в DB School</h2><p>Это автоматическое сообщение о регистрации вашей почты в приложении DB School</p>" +
                $"<hr><p>{somePerson.lastName} {somePerson.name}, не потеряйте свои данные для входа!</p>" +
                $"<p>Ваш логин: <i><b>{somePerson.username}</b></i></p>" +
                $"<p>Ваш пароль: <i><b>{somePerson.password}</b></i></p>" +
                $"<h4>А так же не разглашайте эти данные и лучше удалите данное сообщение</h4>";
            try
            {
                mailbot.send(somePerson.email, "Регистрация", text);
            }
            catch (Exception exp)
            {
                //MessageBox.Show("Вы зарегестрированы но я не могу вам отправить данные на E-mail\nПодробнее" + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ViewBag.catchStatus = exp.Message;
                return true;
            }
            //MessageBox.Show("Регистрация успешно завершена!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            id = somePerson.id;
            return true;
        }
        public bool updateUser(Person somePerson)
        {
            bool result = false;
            string sql = $"Update Person set LastName = '{somePerson.lastName}', Name = '{somePerson.name}', Patronymic = '{somePerson.patronymic}', " +
                $"Number = '{somePerson.number}', Birthday = '{somePerson.birthday}', [E-mail] = '{somePerson.email}', [Secret word] = '{somePerson.secretWord}' " +
                $"where id = {somePerson.id}";
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            try
            {
                sqlCommand.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ViewBag.catchStatus = ex.Message;
            }
            finally
            {
                sqlConnection.Close();
            }
            return result;
        }
        public string getClass(int id)
        {
            string Class = "";
            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();
            try
            {

                SqlDataReader sqlDataReader = null;
                SqlCommand sqlCommand = new SqlCommand("getClassName", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                // параметр для ввода имени
                SqlParameter idParam = new SqlParameter
                {
                    ParameterName = "@id",
                    Value = id
                };
                sqlCommand.Parameters.Add(idParam);

                Class = sqlCommand.ExecuteScalar().ToString();

            }
            catch
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand("getidChild", sqlConnection);
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    // параметр для ввода имени
                    SqlParameter idParam = new SqlParameter
                    {
                        ParameterName = "@idC",
                        Value = id
                    };
                    sqlCommand.Parameters.Add(idParam);

                    int newId = Convert.ToInt32(sqlCommand.ExecuteScalar().ToString());
                    sqlConnection.Close();
                    Class = getClass(newId);
                }
                catch(Exception ex)
                {
                    //MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ViewBag.catchStatus = ex.Message;

                }
                

            }

            return Class;
        }
        public void UpdatePassword(int id, string password)
        {
			sqlConnection.Open();

			SqlCommand sqlCommand = new SqlCommand("", sqlConnection);

			sqlCommand.CommandText = $"UPDATE LogIn SET Password = '{password}' WHERE id = {id}";
			try
			{
				sqlCommand.ExecuteNonQuery();
			}
			catch (Exception e)
            {
                //MessageBox.Show(e.Message, e.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ViewBag.catchStatus = e.Message;
            }
			sqlConnection.Close();

		}
        public int UpdateParentChild(int idParent, int idChild)
        {
            int res = 0;
            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();
            try
            {

                SqlDataReader sqlDataReader = null;
                SqlCommand sqlCommand = new SqlCommand("updateParentChild", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                // параметр для ввода имени
                SqlParameter idP = new SqlParameter
                {
                    ParameterName = "@idP",
                    Value = idParent
                };
                sqlCommand.Parameters.Add(idP);
                SqlParameter idC = new SqlParameter
                {
                    ParameterName = "@idC",
                    Value = idChild
                };
                sqlCommand.Parameters.Add(idC);

                res = sqlCommand.ExecuteNonQuery();
                

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ViewBag.catchStatus = ex.Message;
            }
            finally
            {
                sqlConnection.Close();
            }
            return res;
        }
        public void addMark(int idPeople, int idObject, int idTeacher, int mark)
        {
            sqlConnection.Open();
            try
            {
                string sql = $"Insert into Журнал Values({idPeople}, {idObject}, {idTeacher}, {mark}, GETDATE())";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ViewBag.catchStatus = ex.Message;
            }
            finally
            {
                sqlConnection.Close();
            }

        }
        public int getIdBySQL(string sql)
        {
            int id = -1;
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            try
            {
                id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ViewBag.catchStatus = ex.Message;
            }
            finally
            {
                sqlConnection.Close();
            }
            return id;
        }
        public void addTimeTable(int day, int classOfSchool, int Object, int cabinet, int teacher)
        {
            string sql = $"Insert into Расписание Values({day}, {classOfSchool}, {Object}, {teacher}, {cabinet})";
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ViewBag.catchStatus = ex.Message;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        public void updateTimeTable(int id, int day, int classOfSchool, int Object, int cabinet, int teacher )
        {
            string sql = $"Update Расписание set [Код дня] = {day}, [Код класса] = {classOfSchool}, [код предмета] = {Object}, [Код учителя] = {teacher}, [Код кабинета] = {cabinet} " +
                $"where [Код расписания] = {id}";
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ViewBag.catchStatus = ex.Message;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        public void deleteFromTimeTable(int id)
        {
            string sql = $"DELETE FROM Расписание WHERE [Код расписания] = {id}";
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ViewBag.catchStatus = ex.Message;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
