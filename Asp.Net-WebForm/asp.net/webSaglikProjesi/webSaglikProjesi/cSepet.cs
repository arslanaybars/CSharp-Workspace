using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace webSaglikProjesi
{
    public class cSepet                 // 13.11 *************************
    {
        public DataTable YeniSepet()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("sepetID");
            dt.Columns["sepetID"].DataType = typeof(int);
            dt.Columns["sepetID"].AutoIncrement = true;
            dt.Columns["sepetID"].AutoIncrementSeed = 1;
            dt.Columns["sepetID"].AutoIncrementStep = 1;

            dt.Columns.Add("urunID");
            dt.Columns["urunID"].DataType = typeof(int);

            //dt.Columns.Add("urunKodu");
            //dt.Columns["urunKodu"].DataType = typeof(string);

            dt.Columns.Add("urunAd");
            dt.Columns["urunAd"].DataType = typeof(string);


            dt.Columns.Add("adet");
            dt.Columns["adet"].DataType = typeof(int);
            dt.Columns["adet"].DefaultValue = 1;

            dt.Columns.Add("fiyat");
            dt.Columns["fiyat"].DataType = typeof(decimal);
            dt.Columns["fiyat"].DefaultValue = 0;

            dt.Columns.Add("tutar");
            dt.Columns["tutar"].DataType = typeof(decimal);
            dt.Columns["tutar"].DefaultValue = 0;

            return dt;
        }
    }
}