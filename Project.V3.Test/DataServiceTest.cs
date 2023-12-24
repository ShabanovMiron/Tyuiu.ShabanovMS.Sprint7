﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Project.V3.Lib;
using System.IO;
namespace Project.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint7\InPutDataFileProjectV3.cvs";

            //string[,] waitMatrix = new string  {
                //{ Румянцев Е.М.; Преподаватель; Алгебра и геометрия; 205; Экзамен},
                //{ Воронина В.М.; Доцент; Программирование; 705; Экзамен},
                //{ Галкин С.Б.; Преподаватель; Английский язык; 506; Зачет}, 
                //{ Михайлов М.Д.; Преподаватель; Информатика; 710; Экзамен},
                //{ Мельников М.Р.; Доцент; Алгоритмы и структуры данных; 815; Экзамен},
                //{ Воронина В.М.; Преподаватель; Физкультура; 103; Зачет},
                //{ Одинцов А.Е.; Профессор; Проектирование информационных систем; 820; Экзамен},
                //{ Самойлова П.Р.; Старший преподаватель; Математический анализ; 308; Экзамен},
                //{ Смирнов Н.П.; Преподаватель; Основы российской государственности; 405; Зачет},
                //{ Семенова Н.Д.; Доцент; Объектно-ориентированное программирование; 704; Экзамен}};
            string[,] resMatrix = ds.GetMatrix(path);
            //CollectionAssert.AreEqual(resMatrix, waitMatrix);
        }
    
    }
}
