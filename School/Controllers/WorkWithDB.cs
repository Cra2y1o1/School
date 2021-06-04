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
        public string catchStatus;
        private SqlConnection sqlConnection;

        public WorkWithDB()
        {
            sqlConnection = new SqlConnection(connectionString);
        }
        public List<Person> getEmployers(string id, string name, string lname, string patr, string number, string position)
        {
            List<Person> Employers = new List<Person>();

            sqlConnection.Open();
            try
            {

                SqlDataReader sqlDataReader = null;
                SqlCommand sqlCommand = new SqlCommand("getEmployers", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                // параметр для ввода имени
                SqlParameter par1 = new SqlParameter
                {
                    ParameterName = "@id",
                    Value = id
                };
                SqlParameter par2 = new SqlParameter
                {
                    ParameterName = "@Name",
                    Value = name
                };
                SqlParameter par3 = new SqlParameter
                {
                    ParameterName = "@famil",
                    Value = lname
                };
                SqlParameter par4 = new SqlParameter
                {
                    ParameterName = "@Patronymic",
                    Value = patr
                };
                SqlParameter par5 = new SqlParameter
                {
                    ParameterName = "@number",
                    Value = number
                };
                SqlParameter par6 = new SqlParameter
                {
                    ParameterName = "@position",
                    Value = position
                };
                sqlCommand.Parameters.Add(par1);
                sqlCommand.Parameters.Add(par2);
                sqlCommand.Parameters.Add(par3);
                sqlCommand.Parameters.Add(par4);
                sqlCommand.Parameters.Add(par5);
                sqlCommand.Parameters.Add(par6);

                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Person somePerson = new Person();

                    somePerson.id = Convert.ToInt32(sqlDataReader["id"].ToString());
                    somePerson.lastName = sqlDataReader["LastName"].ToString();
                    somePerson.name = sqlDataReader["Name"].ToString();
                    somePerson.patronymic = sqlDataReader["Patronymic"].ToString();
                    somePerson.sex = sqlDataReader["Sex"].ToString();
                    somePerson.birthday = sqlDataReader["Birthday"].ToString();
                    somePerson.number = sqlDataReader["Number"].ToString();
                    somePerson.email = sqlDataReader["E-mail"].ToString();
                    somePerson.fullPosition = sqlDataReader["полная должность"].ToString();
                    somePerson.level = Convert.ToInt32(sqlDataReader["level"].ToString());
                    Employers.Add(somePerson);
                }
                sqlDataReader.Close();

            }
            catch (Exception ex)
            {
                this.catchStatus = ex.Message;
            }
            sqlConnection.Close();

            return Employers;
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
                this.catchStatus = ex.Message;
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
                this.catchStatus = ex.Message;
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
                this.catchStatus = ex.Message;
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
                "LastName, Name, Patronymic, Sex, Birthday, Number, [E-mail], position, [Secret word], avatar FROM [LogIn], " +
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
                somePerson.level = Convert.ToInt32(sqlDataReader["level"].ToString());
                somePerson.avatar = sqlDataReader["avatar"].ToString();
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
                this.catchStatus = ex.Message;
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
            switch (somePerson.position)
            {
                case "Учащийся":
                    somePerson.level = 1;
                    break;
                case "Родитель":
                    somePerson.level = 2;
                    break;
                case "Сотрудник":
                    somePerson.level = 3;
                    break;
            }


            sqlCommand.CommandText = $"INSERT INTO LogIn (Username, Password, level) VALUES ('{somePerson.username}','{somePerson.password}', {somePerson.level})";

            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch(Exception exp)
            {
                //MessageBox.Show("Не могу вас добавить\nПричина: " + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.catchStatus = exp.Message;
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
                this.catchStatus = exp.Message;
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
                this.catchStatus = exp.Message;
                return false;
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
                this.catchStatus = exp.Message;
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
                $"Number = '{somePerson.number}', Birthday = '{somePerson.birthday}', [E-mail] = '{somePerson.email}', [Secret word] = '{somePerson.secretWord}', " +
                $"avatar = '{somePerson.avatar}' " +
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
                this.catchStatus = ex.Message;
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
                    this.catchStatus = ex.Message;

                }
                

            }

            return Class;
        }
        public Classes getClassobj(int id)
        {
            sqlConnection.Open();
            Classes classes = new Classes();
            try
            {

                SqlDataReader sqlDataReader = null;
                SqlCommand sqlCommand = new SqlCommand($"select * from Классы where [Код класса] = {id}", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;


                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    classes.idClass = Convert.ToInt32(sqlDataReader["Код класса"].ToString());
                    classes.Name = sqlDataReader["Название"].ToString();
                }
                sqlDataReader.Close();

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.catchStatus = ex.Message;

            }
            finally
            {
                sqlConnection.Close();
            }
            return classes;
        }
        public List<Classes> getClassses()
        {
            sqlConnection.Open();
            List<Classes> classes = new List<Classes>();
            try
            {
                
                SqlDataReader sqlDataReader = null;
                SqlCommand sqlCommand = new SqlCommand("getClasses", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
               

                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Classes someClass = new Classes();
                    someClass.idClass = Convert.ToInt32(sqlDataReader["Код класса"].ToString());
                    someClass.Name = sqlDataReader["Название"].ToString();
                    classes.Add(someClass);
                }
                sqlDataReader.Close();

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.catchStatus = ex.Message;

            }
            finally
            {
                sqlConnection.Close();
            }
            return classes;
        }
        public void updateClass(string idStduer, string idclass)
        {
            sqlConnection.Open();
            try
            {

                SqlDataReader sqlDataReader = null;
                SqlCommand sqlCommand = new SqlCommand("updateClass", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter par1 = new SqlParameter
                {
                    ParameterName = "@id",
                    Value = idStduer
                };
                SqlParameter par2 = new SqlParameter
                {
                    ParameterName = "@idClass",
                    Value = idclass
                };
                sqlCommand.Parameters.Add(par1);
                sqlCommand.Parameters.Add(par2);
                sqlCommand.ExecuteReader();


            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.catchStatus = ex.Message;

            }
            finally
            {
                sqlConnection.Close();
            }
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
                this.catchStatus = e.Message;
            }
			sqlConnection.Close();

		}
        public bool UpdateParentChild(int idParent, int idChild)
        {
            bool res = true;
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

                int i = sqlCommand.ExecuteNonQuery();
                if(i == 0)
                {
                    res = false;
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.catchStatus = ex.Message;
                res = false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return res;
        }
        public bool addMark(int idPeople, int idObject, int idTeacher, int mark, string date = "GETDATE()")
        {
            bool status = true;
            sqlConnection.Open();
            try
            {
                string sql = $"Insert into Журнал Values({idPeople}, {idObject}, {idTeacher}, {mark}, {date})";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ViewBag.catchStatus = ex.Message;
                status = false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return status;
        }
        public string getIdBySQL(string sql)
        {
            string id = "-1";
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            try
            {
                id = sqlCommand.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.catchStatus = ex.Message;
            }
            finally
            {
                sqlConnection.Close();
            }
            return id;
        }
        public bool addTimeTable(int idDay, int idRing, int idClass, int idScObj, int idTeacher, int idClassRoom)
        {
            bool status = true;
            
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("addToTimeTable", sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            
            try
            {
                SqlParameter par1 = new SqlParameter
                {
                    ParameterName = "@idDay",
                    Value = idDay
                };
                SqlParameter par2 = new SqlParameter
                {
                    ParameterName = "@idRing",
                    Value = idRing
                };
                SqlParameter par3 = new SqlParameter
                {
                    ParameterName = "@idClass",
                    Value = idClass
                };
                SqlParameter par4 = new SqlParameter
                {
                    ParameterName = "@idScObj",
                    Value = idScObj
                };
                SqlParameter par5 = new SqlParameter
                {
                    ParameterName = "@idTeacher",
                    Value = idTeacher
                };
                SqlParameter par6 = new SqlParameter
                {
                    ParameterName = "@idClassRoom",
                    Value = idClassRoom
                };
                sqlCommand.Parameters.Add(par1);
                sqlCommand.Parameters.Add(par2);
                sqlCommand.Parameters.Add(par3);
                sqlCommand.Parameters.Add(par4);
                sqlCommand.Parameters.Add(par5);
                sqlCommand.Parameters.Add(par6);

                sqlCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.catchStatus = ex.Message;
                status = false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return status;
        }
        public bool updateTimeTable(int id, int idDay, int idRing, int idClass, int idScObj, int idTeacher, int idClassRoom)
        {
            bool status = true;

            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("updateTimeTable", sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                SqlParameter par1 = new SqlParameter
                {
                    ParameterName = "@idDay",
                    Value = idDay
                };
                SqlParameter par2 = new SqlParameter
                {
                    ParameterName = "@idRing",
                    Value = idRing
                };
                SqlParameter par3 = new SqlParameter
                {
                    ParameterName = "@idClass",
                    Value = idClass
                };
                SqlParameter par4 = new SqlParameter
                {
                    ParameterName = "@idScObj",
                    Value = idScObj
                };
                SqlParameter par5 = new SqlParameter
                {
                    ParameterName = "@idTeacher",
                    Value = idTeacher
                };
                SqlParameter par6 = new SqlParameter
                {
                    ParameterName = "@idClassRoom",
                    Value = idClassRoom
                };
                SqlParameter par7 = new SqlParameter
                {
                    ParameterName = "@id",
                    Value = id
                };

                sqlCommand.Parameters.Add(par1);
                sqlCommand.Parameters.Add(par2);
                sqlCommand.Parameters.Add(par3);
                sqlCommand.Parameters.Add(par4);
                sqlCommand.Parameters.Add(par5);
                sqlCommand.Parameters.Add(par6);
                sqlCommand.Parameters.Add(par7);


                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.catchStatus = ex.Message;
                status = false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return status;
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
                this.catchStatus = ex.Message;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        public List<Person> getParents()
        {
            List<Person> parents = new List<Person>();

            sqlConnection.Open();

            SqlDataReader sqlDataReader = null;
            SqlCommand sqlCommand = new SqlCommand("SELECT [LastName],[Name],[Patronymic],[Sex],[Birthday],[Number],[E-mail], Учащийся.Имя, Учащийся.Фамилия, Учащийся.Отчество, Person.id, Классы.Название, Родители.[Код Ребенка] " +
                "from Родители inner join Person on Родители.id = Person.id   inner join Учащийся on Родители.[Код Ребенка] = Учащийся.id inner join Классы on Классы.[Код класса] = Учащийся.[Код класса] ", sqlConnection);

            try
            {
                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Person somePerson = new Person();

                    somePerson.id = Convert.ToInt32(sqlDataReader["id"].ToString());
                    somePerson.lastName = sqlDataReader["LastName"].ToString();
                    somePerson.name = sqlDataReader["Name"].ToString();
                    somePerson.patronymic = sqlDataReader["Patronymic"].ToString();
                    somePerson.sex = sqlDataReader["Sex"].ToString();
                    somePerson.birthday = sqlDataReader["Birthday"].ToString();
                    somePerson.number = sqlDataReader["Number"].ToString();
                    somePerson.email = sqlDataReader["E-mail"].ToString();
                    somePerson.child.id = Convert.ToInt32(sqlDataReader["Код Ребенка"].ToString());
                    somePerson.child.lastName = sqlDataReader["Фамилия"].ToString();
                    somePerson.child.name = sqlDataReader["Имя"].ToString();
                    somePerson.child.patronymic = sqlDataReader["Отчество"].ToString();
                    somePerson.child.ScClass = sqlDataReader["Название"].ToString();
                    parents.Add(somePerson);
                }
                sqlDataReader.Close();


            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.catchStatus = ex.Message;
            }
            finally
            {
                if (sqlDataReader != null)
                {
                    sqlDataReader.Close();
                    sqlConnection.Close();
                }
            }


            return parents;
        }
        public List<Person> getParents(string LastName, string FirstName, string Patronymic)
        {
            List<Person> parents = new List<Person>();

            sqlConnection.Open();

            LastName = LastName.Equals("") ? "%" : LastName;
            FirstName = FirstName.Equals("") ? "%" : FirstName;
            Patronymic = Patronymic.Equals("") ? "%" : Patronymic;

            SqlDataReader sqlDataReader = null;
            SqlCommand sqlCommand = new SqlCommand("SELECT [LastName],[Name],[Patronymic],[Sex],[Birthday],[Number],[E-mail], Учащийся.Имя, Учащийся.Фамилия, Учащийся.Отчество, Person.id, Классы.Название, Родители.[Код Ребенка] " +
                "from Родители inner join Person on Родители.id = Person.id   inner join Учащийся on Родители.[Код Ребенка] = Учащийся.id inner join Классы on Классы.[Код класса] = Учащийся.[Код класса] " +
                $"where Родители.Фамилия like '{LastName}' and Родители.Имя like '{FirstName}' and Родители.Отчество like '{Patronymic}' ", sqlConnection);

            try
            {
                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Person somePerson = new Person();

                    somePerson.id = Convert.ToInt32(sqlDataReader["id"].ToString());
                    somePerson.lastName = sqlDataReader["LastName"].ToString();
                    somePerson.name = sqlDataReader["Name"].ToString();
                    somePerson.patronymic = sqlDataReader["Patronymic"].ToString();
                    somePerson.sex = sqlDataReader["Sex"].ToString();
                    somePerson.birthday = sqlDataReader["Birthday"].ToString();
                    somePerson.number = sqlDataReader["Number"].ToString();
                    somePerson.email = sqlDataReader["E-mail"].ToString();
                    somePerson.child.id = Convert.ToInt32(sqlDataReader["Код Ребенка"].ToString());
                    somePerson.child.lastName = sqlDataReader["Фамилия"].ToString();
                    somePerson.child.name = sqlDataReader["Имя"].ToString();
                    somePerson.child.patronymic = sqlDataReader["Отчество"].ToString();
                    somePerson.child.ScClass = sqlDataReader["Название"].ToString();
                    parents.Add(somePerson);
                }
                sqlDataReader.Close();


            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.catchStatus = ex.Message;
            }
            finally
            {
                if (sqlDataReader != null)
                {
                    sqlDataReader.Close();
                    sqlConnection.Close();
                }
            }


            return parents;
        }
        public List<Person> getParents(string LastName, string idParent, string LastNameChild, string idChild)
        {
            List<Person> parents = new List<Person>();

            sqlConnection.Open();
            try
            {
                
                SqlDataReader sqlDataReader = null;
                SqlCommand sqlCommand = new SqlCommand("getExparents", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                // параметр для ввода имени
                SqlParameter parentLName = new SqlParameter
                {
                    ParameterName = "@parentLName",
                    Value = LastName
                };
                SqlParameter idParenParam = new SqlParameter
                {
                    ParameterName = "@idParent",
                    Value = idParent
                };
                SqlParameter LastNameChildParam = new SqlParameter
                {
                    ParameterName = "@childLN",
                    Value = LastNameChild
                };
                SqlParameter idchildParam = new SqlParameter
                {
                    ParameterName = "@idChild",
                    Value = idChild
                };
                sqlCommand.Parameters.Add(parentLName);
                sqlCommand.Parameters.Add(idParenParam);
                sqlCommand.Parameters.Add(LastNameChildParam);
                sqlCommand.Parameters.Add(idchildParam);

                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Person somePerson = new Person();

                    somePerson.id = Convert.ToInt32(sqlDataReader["id"].ToString());
                    somePerson.lastName = sqlDataReader["LastName"].ToString();
                    somePerson.name = sqlDataReader["Name"].ToString();
                    somePerson.patronymic = sqlDataReader["Patronymic"].ToString();
                    somePerson.sex = sqlDataReader["Sex"].ToString();
                    somePerson.birthday = sqlDataReader["Birthday"].ToString();
                    somePerson.number = sqlDataReader["Number"].ToString();
                    somePerson.email = sqlDataReader["E-mail"].ToString();
                    somePerson.child.id = Convert.ToInt32(sqlDataReader["Код Ребенка"].ToString());
                    somePerson.child.lastName = sqlDataReader["Фамилия"].ToString();
                    somePerson.child.name = sqlDataReader["Имя"].ToString();
                    somePerson.child.patronymic = sqlDataReader["Отчество"].ToString();
                    somePerson.child.ScClass = sqlDataReader["Название"].ToString();
                    parents.Add(somePerson);
                }
                sqlDataReader.Close();

            }
            catch(Exception ex)
            {
                this.catchStatus = ex.Message;
            }
            finally
            {
                sqlConnection.Close();

            }

            return parents;
        }
        public List<Person> getStudiers()
        {
            List<Person> Studiers = new List<Person>();

            sqlConnection.Open();

            SqlDataReader sqlDataReader = null;
            SqlCommand sqlCommand = new SqlCommand("SELECT [LastName],[Name],[Patronymic],[Sex],[Birthday],[Number],[E-mail], Учащийся.id, Классы.Название " +
                "from Учащийся inner join Person on Учащийся.id = Person.id " +
                $"inner join Классы on Классы.[Код класса] = Учащийся.[Код класса] ", sqlConnection);

            try
            {
                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Person somePerson = new Person();

                    somePerson.id = Convert.ToInt32(sqlDataReader["id"].ToString());
                    somePerson.lastName = sqlDataReader["LastName"].ToString();
                    somePerson.name = sqlDataReader["Name"].ToString();
                    somePerson.patronymic = sqlDataReader["Patronymic"].ToString();
                    somePerson.sex = sqlDataReader["Sex"].ToString();
                    somePerson.birthday = sqlDataReader["Birthday"].ToString();
                    somePerson.number = sqlDataReader["Number"].ToString();
                    somePerson.email = sqlDataReader["E-mail"].ToString();
                    somePerson.child.ScClass = sqlDataReader["Название"].ToString();
                    Studiers.Add(somePerson);
                }
                sqlDataReader.Close();


            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.catchStatus = ex.Message;
            }
            finally
            {
                if (sqlDataReader != null)
                {
                    sqlDataReader.Close();
                    
                }
                sqlConnection.Close();
            }


            return Studiers;
        }
        public List<Person> getStudiers(string LastName, string FirstName, string Patronymic, string phone, string ClassName)
        {
            List<Person> Studiers = new List<Person>();

            sqlConnection.Open();
            try
            {

                SqlDataReader sqlDataReader = null;
                SqlCommand sqlCommand = new SqlCommand("getStudiersPar", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                // параметр для ввода имени
                SqlParameter LName = new SqlParameter
                {
                    ParameterName = "@lname",
                    Value = LastName
                };
                SqlParameter name = new SqlParameter
                {
                    ParameterName = "@name",
                    Value = FirstName
                };
                SqlParameter patronymic = new SqlParameter
                {
                    ParameterName = "@patronymic",
                    Value = Patronymic
                };
                SqlParameter phonep = new SqlParameter
                {
                    ParameterName = "@phone",
                    Value = phone
                };
                SqlParameter className = new SqlParameter
                {
                    ParameterName = "@className",
                    Value = ClassName
                };
                sqlCommand.Parameters.Add(LName);
                sqlCommand.Parameters.Add(name);
                sqlCommand.Parameters.Add(patronymic);
                sqlCommand.Parameters.Add(phonep);
                sqlCommand.Parameters.Add(className);

                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Person somePerson = new Person();

                    somePerson.id = Convert.ToInt32(sqlDataReader["id"].ToString());
                    somePerson.lastName = sqlDataReader["LastName"].ToString();
                    somePerson.name = sqlDataReader["Name"].ToString();
                    somePerson.patronymic = sqlDataReader["Patronymic"].ToString();
                    somePerson.sex = sqlDataReader["Sex"].ToString();
                    somePerson.birthday = sqlDataReader["Birthday"].ToString();
                    somePerson.number = sqlDataReader["Number"].ToString();
                    somePerson.email = sqlDataReader["E-mail"].ToString();
                    somePerson.child.ScClass = sqlDataReader["Название"].ToString();
                    Studiers.Add(somePerson);
                }
                sqlDataReader.Close();

            }
            catch (Exception ex)
            {
                this.catchStatus = ex.Message;
            }

            sqlConnection.Close();
            return Studiers;
        }
        public bool deleteFromJournal(string idMark, string idStudier, string idSchoolObj, string idTeach, string mark)
        {

            sqlConnection.Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("deteleFromJournal", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                // параметр для ввода имени
                SqlParameter par1 = new SqlParameter
                {
                    ParameterName = "@idMark",
                    Value = idMark
                };
                SqlParameter par2 = new SqlParameter
                {
                    ParameterName = "@idStudier",
                    Value = idStudier
                };
                SqlParameter par3 = new SqlParameter
                {
                    ParameterName = "@idSchoolObj",
                    Value = idSchoolObj
                };
                SqlParameter par4 = new SqlParameter
                {
                    ParameterName = "@idTeach",
                    Value = idTeach
                };
                SqlParameter par5 = new SqlParameter
                {
                    ParameterName = "@mark",
                    Value = mark
                };
                sqlCommand.Parameters.Add(par1);
                sqlCommand.Parameters.Add(par2);
                sqlCommand.Parameters.Add(par3);
                sqlCommand.Parameters.Add(par4);
                sqlCommand.Parameters.Add(par5);

                sqlCommand.ExecuteReader();



            }
            catch (Exception ex)
            {
                this.catchStatus = ex.Message;
                return false;
            }
            finally
            {
                sqlConnection.Close();
                
            }
            return true;
        }
        public bool deleteFromStudier(string idStudier, string idClass)
        {

            sqlConnection.Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("deleteStudier", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                // параметр для ввода имени
               
                SqlParameter par1 = new SqlParameter
                {
                    ParameterName = "@idStudier",
                    Value = idStudier
                };
                SqlParameter par2 = new SqlParameter
                {
                    ParameterName = "@idSchoolClass",
                    Value = idClass
                };
                sqlCommand.Parameters.Add(par1);
                sqlCommand.Parameters.Add(par2);

                sqlCommand.ExecuteReader();



            }
            catch (Exception ex)
            {
                this.catchStatus = ex.Message;
                return false;
            }
            finally
            {
                sqlConnection.Close();

            }
            return true;
        }
        public bool deleteFromParents(string id)
        {

            sqlConnection.Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("deleteParents", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                // параметр для ввода имени

                SqlParameter par1 = new SqlParameter
                {
                    ParameterName = "@id",
                    Value = id
                };
                sqlCommand.Parameters.Add(par1);

                sqlCommand.ExecuteReader();



            }
            catch (Exception ex)
            {
                this.catchStatus = ex.Message;
                return false;
            }
            finally
            {
                sqlConnection.Close();

            }
            return true;
        }
        public bool deleteFromPerson(string id)
        {

            sqlConnection.Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("deletePerson", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                // параметр для ввода имени

                SqlParameter par1 = new SqlParameter
                {
                    ParameterName = "@id",
                    Value = id
                };
                sqlCommand.Parameters.Add(par1);

                sqlCommand.ExecuteReader();



            }
            catch (Exception ex)
            {
                this.catchStatus = ex.Message;
                return false;
            }
            finally
            {
                sqlConnection.Close();

            }
            return true;
        }
        public bool deleteFromLogIn(string id)
        {

            sqlConnection.Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("deleteLogIn", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                // параметр для ввода имени

                SqlParameter par1 = new SqlParameter
                {
                    ParameterName = "@id",
                    Value = id
                };
                sqlCommand.Parameters.Add(par1);

                sqlCommand.ExecuteReader();



            }
            catch (Exception ex)
            {
                this.catchStatus = ex.Message;
                return false;
            }
            finally
            {
                sqlConnection.Close();

            }
            return true;
        }
        public bool deleteFromTimeTable(string idTT, string idDay, string idClass, string idScObj, string idTeach, string idCabinet)
        {

            sqlConnection.Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("deleteFromTimeTable", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                // параметр для ввода имени

                SqlParameter par1 = new SqlParameter
                {
                    ParameterName = "@idTT",
                    Value = idTT
                };
                SqlParameter par2 = new SqlParameter
                {
                    ParameterName = "@idDay",
                    Value = idDay
                };
                SqlParameter par3 = new SqlParameter
                {
                    ParameterName = "@idSchoolObj",
                    Value = idScObj
                };
                SqlParameter par4 = new SqlParameter
                {
                    ParameterName = "@idTeach",
                    Value = idTeach
                };
                SqlParameter par5 = new SqlParameter
                {
                    ParameterName = "@idCabinet",
                    Value = idCabinet
                };
                SqlParameter par6 = new SqlParameter
                {
                    ParameterName = "@idClass",
                    Value = idClass
                };
                sqlCommand.Parameters.Add(par1);
                sqlCommand.Parameters.Add(par2);
                sqlCommand.Parameters.Add(par3);
                sqlCommand.Parameters.Add(par4);
                sqlCommand.Parameters.Add(par5);
                sqlCommand.Parameters.Add(par6);
                sqlCommand.ExecuteReader();



            }
            catch (Exception ex)
            {
                this.catchStatus = ex.Message;
                return false;
            }
            finally
            {
                sqlConnection.Close();

            }
            return true;
        }
        public bool deleteFromKurators(string idTeach, string idClass)
        {

            sqlConnection.Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("deleteFromKurators", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                // параметр для ввода имени

                SqlParameter par1 = new SqlParameter
                {
                    ParameterName = "@idTeach",
                    Value = idTeach
                };
                SqlParameter par2 = new SqlParameter
                {
                    ParameterName = "@idClass",
                    Value = idClass
                };
                sqlCommand.Parameters.Add(par1);
                sqlCommand.Parameters.Add(par2);

                sqlCommand.ExecuteReader();



            }
            catch (Exception ex)
            {
                this.catchStatus = ex.Message;
                return false;
            }
            finally
            {
                sqlConnection.Close();

            }
            return true;
        }
        public bool deleteFromEmployer(string id)
        {

            sqlConnection.Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("deleteFromEmployer", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                // параметр для ввода имени

                SqlParameter par1 = new SqlParameter
                {
                    ParameterName = "@idEmployer",
                    Value = id
                };
                sqlCommand.Parameters.Add(par1);

                sqlCommand.ExecuteReader();



            }
            catch (Exception ex)
            {
                this.catchStatus = ex.Message;
                return false;
            }
            finally
            {
                sqlConnection.Close();

            }
            return true;
        }
        public bool deletePerson(int id)
        {
            Person p = new Person();
            p = getFullInformation(id);
            switch (p.position)
            {
                case "Учащийся":
                    {
                        if (!deleteFromJournal("%", id.ToString(), "%", "%", "%"))
                        {
                            return false;
                        }
                        List<Person> parents = getParents("%", "%", "%", id.ToString());
                        foreach(Person parent in parents)
                        {
                            UpdateParentChild(parent.id, 0);
                        }
                        if (!deleteFromStudier(id.ToString(), "%")) return false;
                        if (!deleteFromPerson(id.ToString())) return false;
                        if (!deleteFromLogIn(id.ToString())) return false;
                        break;
                    }
                case "Родитель":
                    {
                        if (!deleteFromParents(id.ToString())) return false;
                        if (!deleteFromPerson(id.ToString())) return false;
                        if (!deleteFromLogIn(id.ToString())) return false;
                        break;
                    }
                case "Сотрудник":
                    {
                        if (!deleteFromJournal("%", "%", "%", id.ToString(), "%")) return false;
                        if (!deleteFromTimeTable("%", "%", "%", "%", id.ToString(), "%")) return false;
                        if (!deleteFromKurators(id.ToString(), "%")) return false;
                        if (!deleteFromEmployer(id.ToString())) return false;
                        if (!deleteFromPerson(id.ToString())) return false;
                        if (!deleteFromLogIn(id.ToString())) return false;
                        break;
                    }
                default: return false;
            }
            
            

            return true;
        }
        public List<Position> GetPositions()
        {
            List<Position> positions = new List<Position>();


            sqlConnection.Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT *  FROM [Должности]", sqlConnection);

                SqlDataReader sqlDataReader=sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Position somePosition = new Position();

                    somePosition.id = Convert.ToInt32(sqlDataReader["id"].ToString());
                   somePosition.name = sqlDataReader["наименование"].ToString();
                    somePosition.level = Convert.ToInt32(sqlDataReader["уровень"].ToString());
                    positions.Add(somePosition);
                }
                sqlDataReader.Close();

            }
            catch (Exception ex)
            {
                this.catchStatus = ex.Message;
            }
            finally
            {
                sqlConnection.Close();

            }

            return positions;
        }
        public bool updateLevel(string id, string level)
        {
            sqlConnection.Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("updateLevel", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                // параметр для ввода имени

                SqlParameter par1 = new SqlParameter
                {
                    ParameterName = "@id",
                    Value = id
                };
                SqlParameter par2 = new SqlParameter
                {
                    ParameterName = "@level",
                    Value = level
                };
                sqlCommand.Parameters.Add(par1);
                sqlCommand.Parameters.Add(par2);

                sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                this.catchStatus = ex.Message;
                sqlConnection.Close();
                return false;
            }
            finally
            {
                sqlConnection.Close();

            }
            return true;
        }
        public bool updatePosition(string id, string fullPostition, string idPosition)
        {

            sqlConnection.Open();
            try
            {
                SqlCommand sqlCommand = new SqlCommand("UpdateFullPosition", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                // параметр для ввода имени

                SqlParameter par1 = new SqlParameter
                {
                    ParameterName = "@id",
                    Value = id
                };
                SqlParameter par2 = new SqlParameter
                {
                    ParameterName = "@fullPosition",
                    Value = fullPostition
                };
                SqlParameter par3 = new SqlParameter
                {
                    ParameterName = "@idDefPosition",
                    Value = idPosition
                };
                sqlCommand.Parameters.Add(par1);
                sqlCommand.Parameters.Add(par2);
                sqlCommand.Parameters.Add(par3);

                sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                this.catchStatus = ex.Message;
                sqlConnection.Close();
                return false;
            }
            finally
            {
                sqlConnection.Close();

            }
            return true;
        }
        public List<TimeTablemodel> GetTimeTables(string day, string ScClass, string ScObj, string classroom, string teacher, string ring)
        {
            List<TimeTablemodel> timeTables = new List<TimeTablemodel>();
            sqlConnection.Open();
            try
            {
                SqlDataReader sqlDataReader = null;
                SqlCommand sqlCommand = new SqlCommand("getTimeTable", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                // параметр для ввода имени
                SqlParameter  par1 = new SqlParameter
                {
                    ParameterName = "@day",
                    Value = day
                };
                SqlParameter par2 = new SqlParameter
                {
                    ParameterName = "@class",
                    Value  = ScClass
                };
                SqlParameter par3 = new SqlParameter
                {
                    ParameterName = "@object",
                    Value = ScObj
                };
                SqlParameter par4 = new SqlParameter
                {
                    ParameterName = "@cabinet",
                    Value = classroom
                };
                SqlParameter par5 = new SqlParameter
                {
                    ParameterName = "@teacher",
                    Value = teacher
                };
                SqlParameter par6 = new SqlParameter
                {
                    ParameterName = "@numberRing",
                    Value = ring
                };
                sqlCommand.Parameters.Add(par1);
                sqlCommand.Parameters.Add(par2);
                sqlCommand.Parameters.Add(par3);
                sqlCommand.Parameters.Add(par4);
                sqlCommand.Parameters.Add(par5);
                sqlCommand.Parameters.Add(par6);

                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    TimeTablemodel timeTable = new TimeTablemodel();


                    timeTable.id = Convert.ToInt32(sqlDataReader["Код расписания"].ToString());
                    timeTable.Day = sqlDataReader["День"].ToString();
                    timeTable.ScClass = sqlDataReader["Класс"].ToString();
                    timeTable.ScObj = sqlDataReader["Предмет"].ToString();
                    timeTable.ClassRoom = sqlDataReader["Кабинет"].ToString();
                    timeTable.LastNameTeacher = sqlDataReader["Учитель"].ToString();
                    timeTable.numb = sqlDataReader["Номер урока"].ToString();
                    timeTable.start = sqlDataReader["начало"].ToString();
                    timeTable.end = sqlDataReader["конец"].ToString();
                    timeTables.Add(timeTable);
                }
                sqlDataReader.Close();

            }
            catch (Exception ex)
            {
                this.catchStatus = ex.Message;
            }
            sqlConnection.Close();
            return timeTables;
        }
        public List<ScObj> GetScObjs()
        {
            List<ScObj> scObjs = new List<ScObj>();
            sqlConnection.Open();
            try
            {
                SqlDataReader sqlDataReader = null;
                SqlCommand sqlCommand = new SqlCommand("getScObjects", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
               

                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    ScObj scObj = new ScObj();
                    scObj.id = Convert.ToInt32(sqlDataReader["Код предмета"].ToString());
                    scObj.name = sqlDataReader["название предмета"].ToString();
                    scObj.start = Convert.ToInt32(sqlDataReader["От"].ToString());
                    scObj.end = Convert.ToInt32(sqlDataReader["До"].ToString());
                    scObjs.Add(scObj);
                }
                sqlDataReader.Close();

            }
            catch (Exception ex)
            {
                this.catchStatus = ex.Message;
            }
            sqlConnection.Close();
            return scObjs;
        }
        public ScObj GetScObj(int id)
        {
            ScObj scObj = new ScObj();
            sqlConnection.Open();
            try
            {
                SqlDataReader sqlDataReader = null;
                SqlCommand sqlCommand = new SqlCommand($"select * from Предметы where [Код предмета] = {id}", sqlConnection);


                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    scObj.id = Convert.ToInt32(sqlDataReader["Код предмета"].ToString());
                    scObj.name = sqlDataReader["название предмета"].ToString();
                    scObj.start = Convert.ToInt32(sqlDataReader["От"].ToString());
                    scObj.end = Convert.ToInt32(sqlDataReader["До"].ToString());
                }
                sqlDataReader.Close();

            }
            catch (Exception ex)
            {
                this.catchStatus = ex.Message;
            }
            sqlConnection.Close();
            return scObj;
        }
        public List<ClassRoom> GetClassRooms()
        {
            List<ClassRoom> classRooms = new List<ClassRoom>();
            sqlConnection.Open();
            try
            {
                SqlDataReader sqlDataReader = null;
                SqlCommand sqlCommand = new SqlCommand("getClassRooms", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    ClassRoom classRoom = new ClassRoom();
                    classRoom.id = Convert.ToInt32(sqlDataReader["Код кабинета"].ToString());
                    classRoom.number = Convert.ToInt32(sqlDataReader["Номер"].ToString());
                    classRoom.floor = Convert.ToInt32(sqlDataReader["Этаж"].ToString());
                    classRooms.Add(classRoom);
                }
                sqlDataReader.Close();

            }
            catch (Exception ex)
            {
                this.catchStatus = ex.Message;
            }
            sqlConnection.Close();
            return classRooms;
        }

        public List<Ring> GetRings()
        {
            List<Ring> rings = new List<Ring>();
            sqlConnection.Open();
            try
            {
                SqlDataReader sqlDataReader = null;
                SqlCommand sqlCommand = new SqlCommand("getRings", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Ring ring = new Ring();
                    ring.id = Convert.ToInt32(sqlDataReader["Код звонка"].ToString());
                    ring.number = Convert.ToInt32(sqlDataReader["Номер урока"].ToString());
                    ring.start = sqlDataReader["начало"].ToString();
                    ring.end = sqlDataReader["конец"].ToString();
                    rings.Add(ring);
                }
                sqlDataReader.Close();
            }
            catch (Exception ex)
            {
                this.catchStatus = ex.Message;
            }
            sqlConnection.Close();
            return rings;
        }
        public List<Mark> GetMarks(string idClass, string idScObj, string dateMark, string Studier, string Teacher)
        {
            List<Mark> marks = new List<Mark>();
            sqlConnection.Open();
            try
            {
                SqlDataReader sqlDataReader = null;
                SqlCommand sqlCommand = new SqlCommand("getMark", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter par1 = new SqlParameter
                {
                    ParameterName = "@idClass",
                    Value = idClass
                };
                SqlParameter par2 = new SqlParameter
                {
                    ParameterName = "@idScObj",
                    Value = idScObj
                };
                SqlParameter par3 = new SqlParameter
                {
                    ParameterName = "@Date",
                    Value = dateMark
                };
                SqlParameter par4 = new SqlParameter
                {
                    ParameterName = "@LnameStudier",
                    Value = Studier
                };
                SqlParameter par5 = new SqlParameter
                {
                    ParameterName = "@LnameTeacher",
                    Value = Teacher
                };
                sqlCommand.Parameters.Add(par1);
                sqlCommand.Parameters.Add(par2);
                sqlCommand.Parameters.Add(par3);
                sqlCommand.Parameters.Add(par4);
                sqlCommand.Parameters.Add(par5);


                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Mark mark = new Mark();
                    mark.id = Convert.ToInt32(sqlDataReader["Код оценки"].ToString());
                    mark.dateTime = Convert.ToDateTime(sqlDataReader["дата оценки"].ToString());
                    mark.scObj.id = Convert.ToInt32(sqlDataReader["Код предмета"].ToString());
                    mark.mark = Convert.ToInt32(sqlDataReader["Оценка"].ToString());
                    mark.Studier.id = Convert.ToInt32(sqlDataReader["Ученик"].ToString());
                    mark.Teacher.id = Convert.ToInt32(sqlDataReader["id преподаватель"].ToString());
                    mark.ScClass.idClass = Convert.ToInt32(sqlDataReader["Код класса"].ToString());

                    marks.Add(mark);
                }
                sqlDataReader.Close();
            }
            catch (Exception ex)
            {
                this.catchStatus = ex.Message;
            }
            sqlConnection.Close();

            List<Mark> marksRes = new List<Mark>();
            foreach(var m in marks)
            {
                m.Studier = getFullInformation(m.Studier.id);
                m.Teacher = getFullInformation(m.Teacher.id);
                m.scObj = GetScObj(m.scObj.id);
                m.ScClass = getClassobj(m.ScClass.idClass);
                marksRes.Add(m);
            }
            return marksRes;
        }
       
    }
}
