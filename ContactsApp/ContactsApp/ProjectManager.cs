using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ContactsApp
{
    public class ProjectManager
    {
        /// <summary>
        /// Хранит путь до файла сохранения
        /// </summary>
        // ApplicationData - путь к пользовательской директории
        private static readonly string _pathToFile = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ContactsApp\\ContactsApp.txt";

        /// <summary>
        /// Сохраняет объект проекта в файл
        /// </summary>
        /// <param name="data"></param>
        /// <param name="filename"></param>
      
        public static void SaveToFile(Contact data, string filename)
        {
            File.WriteAllText(_pathToFile, JsonConvert.SerializeObject(data));
        }


        /// <summary>
        /// Загружает объект проекта из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        //public static Project LoadFromFile(string filename)
        //{
        //    Project project;
        //    string data;

        //    try
        //    {
        //        data = File.ReadAllText(_pathToFile);
        //    }

        //    catch (DirectoryNotFoundException e)
        //    {
        //        throw e;
        //    }

        //    catch (FileNotFoundException e)
        //    {
        //        throw e;
        //    }

        //    project = JsonConvert.DeserializeObject<Project>(data);

        //    return project;
        //    //никаких полей
        //    //метод SaveToFile
        //    //метод LoadFromFile
        //}

        public static Contact LoadFromFile(string filename)
        {
            Contact contact;
            string data;

            try
            {
                data = File.ReadAllText(_pathToFile);
            }
            //нет папки
            catch (DirectoryNotFoundException e)
            {
                throw e;
            }
            //нет файла
            catch (FileNotFoundException e)
            {
                throw e;
            }
            //считывание
            contact = JsonConvert.DeserializeObject<Contact>(data);
            
            return contact;
            //никаких полей
            //метод SaveToFile
            //метод LoadFromFile
        }
    }
}
