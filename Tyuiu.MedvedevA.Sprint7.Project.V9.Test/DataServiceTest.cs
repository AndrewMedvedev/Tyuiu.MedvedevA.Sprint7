using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.MedvedevA.Sprint7.Project.V9.Lib;

namespace Tyuiu.MedvedevA.Sprint7.Project.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSearchRows()
        {
            DataService ds = new DataService();

            List<string> data = new List<string> { "23", "школа", "сто двадцать три", "21", "1234" };
            DataGridView dataGrid = new DataGridView();
            dataGrid.ColumnCount = 1;
            dataGrid.RowCount = 5;
            dataGrid.Columns[0].Name = "Search";

            for(int i=0; i < data.Count(); i++)
            {
                dataGrid.Rows[i].Cells["Search"].Value = data[i];
            }
            List<DataGridViewRow> resLib = ds.GetSearchRows(dataGrid.Rows.OfType<DataGridViewRow>().ToList(),
                                                        "Search",
                                                        "23");
            List<object> res = new List<object>();
            foreach (DataGridViewRow item in resLib)
            {
                res.Add(item.Cells["Search"].Value.ToString());
            }
            CollectionAssert.AreEqual(new List<object> { "23", "1234"}, res);
        }
        [TestMethod]
        public void ValidGetSummColumn()
        {
            DataService ds = new DataService();

            List<object> data = new List<object> { "23", 20.0, 5, "сто" };

            var res = ds.GetSummColumn(data);
            Assert.AreEqual(48.0, res);
        }
        [TestMethod]
        public void ValidGetCountTargetColumn()
        {
            DataService ds = new DataService();

            List<object> data = new List<object> { "23", 20.0, 5, "сто" };

            var res = ds.GetCountTargetColumn(data, "2");
            Assert.AreEqual(2, res);
        }
        [TestMethod]
        public void ValidGetCountColumn()
        {
            DataService ds = new DataService();

            List<object> data = new List<object> { "23", 20.0, 5, "сто" };

            var res = ds.GetCountColumn(data);
            Assert.AreEqual(4, res);
        }
        [TestMethod]
        public void ValidGetAverageColumn()
        {
            DataService ds = new DataService();

            List<object> data = new List<object> { "23", 20.0, 5, "сто" };

            var res = ds.GetAverageColumn(data);
            Assert.AreEqual(16, res);
        }
        [TestMethod]
        public void ValidGetMinValueColumn()
        {
            DataService ds = new DataService();

            List<object> data = new List<object> { "23", 20.0, 5, "сто" };

            var res = ds.GetMinValueColumn(data);
            Assert.AreEqual(5.0, res);
        }
        [TestMethod]
        public void ValidGetMaxValueColumn()
        {
            DataService ds = new DataService();

            List<object> data = new List<object> { "23", 20.0, 5, "сто" };

            var res = ds.GetMaxValueColumn(data);
            Assert.AreEqual(23, res);
        }
    }
}
