using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Data.Models
{
    public class Person
    {
        public int id { set; get; }
        public int level { set; get; } 
        public string lastName { set; get; }
        public string name { set; get; }
        public string patronymic { set; get; }
        public string sex { set; get; }
        public string birthday { set; get; }
        public string number { set; get; }
        public string email { set; get; }
        public string position { set; get; }
        public string secretWord { set; get; }
        public string username { set; get; }
        public string password { set; get; }
        public string fullPosition { set; get; }
        public string avatar { set; get; }
        public Child child { set; get; }
        public Position defPosition { set; get; }
        public Person()
        {
            id = 0;
            level = 0;
            lastName = "";
            name = "";
            patronymic = "";
            sex = "";
            birthday = "";
            number = "";
            email = "";
            position = "";
            secretWord = "";
            username = "";
            password = "";
            avatar = "";
            child = new Child();
            defPosition = new Position();
        }
        #region Seters
        public void setId(int id)
        {
            this.id = id;
        }
        public void setLevel(int level)
        {
            this.level = level;
        }
        public void setlastName(string lastName)
        {
            this.lastName = lastName;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setPatronymic(string patronymic)
        {
            this.patronymic = patronymic;
        }
        public void setSex(string sex)
        {
            this.sex = sex;
        }
        public void setBithday(string birthday)
        {
            this.birthday = birthday;
        }
        public void setNumber(string number)
        {
            this.number = number;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public void setPosition(string position)
        {
            this.position = position;
        }
        public void setSecretWord(string secretWord)
        {
            this.secretWord = secretWord;
        }
        public void setUsername(string username)
        {
            this.username = username;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        #endregion

        #region getters
        public int getId()
        {
            return id;
        }
        public int getLevel()
        {
            return level;
        }
        public string getLastName()
        {
            return lastName;
        }
        public string getName()
        {
            return name;
        }
        public string getPatronymic()
        {
            return patronymic;
        }
        public string getSex()
        {
            return sex;
        }
        public string getBithday()
        {
            return birthday;
        }
        public string getNumber()
        {
            return number;
        }
        public string getEmail()
        {
            return email;
        }
        public string getPosition()
        {
            return position;
        }
        public string getSecretWord()
        {
            return secretWord;
        }
        public string getUsername()
        {
            return username;
        }
        public string getPassword()
        {
            return password;
        }
        #endregion
    }
}