using System;
using WebModels;
using System.Reflection;
using System.Collections.Generic;

namespace WebDal
{
    public class BaseDal
    {
        public static string GetUser(User user)
        {

            Type t = user.GetType();
            PropertyInfo[] infos = t.GetProperties();
            List<string> list = new List<string>();

            for (int i = 0; i < infos.Length; i++)
            {
                if (infos[i].GetValue(user,null) != null&& infos[i].GetValue(user, null).ToString()!= "0")
                {
                    string temp = $"{infos[i].Name}='{infos[i].GetValue(user,null)}'";
                    list.Add(temp);
                }
            }
            string sql =$"select * from {t.Name} where 1=1 and {string.Join(" and ", list)}" ;

            return sql;
        }
        public static string InsertUser(User user)
        {
            Type t= user.GetType();
            PropertyInfo[] infos = t.GetProperties();
            List<string> listname = new List<string>();
            List<string> listvalue = new List<string>();
            for (int i = 0; i < infos.Length; i++)
            {
                if (infos[i].Name != "id")
                {
                    string temp = $"{infos[i].Name}";
                    listname.Add(temp);

                    string tempvalue = $"'{infos[i].GetValue(user, null)}'";
                    listvalue.Add(tempvalue);
                }                    
            }

            string sql = $"insert into {t.Name}({string.Join(",", listname)}) values ({string.Join(",", listvalue)})";
            return sql;
        }
        public static string UpdateUser(User user)
        {

            Type t = user.GetType();
            PropertyInfo[] infos = t.GetProperties();
            List<string> list = new List<string>();

            for (int i = 0; i < infos.Length; i++)
            {
                if (infos[i].GetValue(user, null) != null && infos[i].Name != "id")
                {
                    string temp = $"{infos[i].Name}='{infos[i].GetValue(user, null)}'";
                    list.Add(temp);
                }
            }
            string sql =$"update {t.Name} set {string.Join(",", list)} where id={infos[0].GetValue(user, null)}" ;


            return sql;
        }

    }
}
